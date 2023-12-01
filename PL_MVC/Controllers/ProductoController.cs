using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class ProductoController : Controller
    {
        [HttpGet]// GET: Producto
        public ActionResult GetAll()
        {
            ML.Producto producto = new ML.Producto();
            producto.Productos = new List<object>();
            ML.Result resultSubCategoria = new ML.Result();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

                var responseTask = client.GetAsync($"Producto");
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    ML.Result resultArea = BL.Area.GetAll();

                    var readTask = result.Content.ReadAsAsync<ML.Result>();
                    readTask.Wait();

                    foreach (var resultItem in readTask.Result.Objects)
                    {
                        ML.Producto resultItemList = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Producto>(resultItem.ToString());
                        producto.Productos.Add(resultItemList);
                    }
                }
            }
            ////WCF
            //ServiceReferenceProducto.ProductoServicioClient productoWCF = new ServiceReferenceProducto.ProductoServicioClient();
            //var result = productoWCF.GetAll();
            ////WCF

            ////ML.Result result = BL.Producto.GetAll();

            //if (result.Correct)
            //{
            //    producto.Productos = result.Objects.ToList();
            //}
            //else
            //{
            //    ViewBag.Message = result.ErrorMassage;
            //}
            return View(producto);
        }

        [HttpPost]
        public ActionResult GetAll(ML.Producto producto)
        {

            ML.Result resultSubCategoria = new ML.Result();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

                var responseTask = client.GetAsync($"Producto");
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    ML.Result resultArea = BL.Area.GetAll();

                    var readTask = result.Content.ReadAsAsync<ML.Result>();
                    readTask.Wait();

                    foreach (var resultItem in readTask.Result.Objects)
                    {
                        ML.Producto resultItemList = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Producto>(resultItem.ToString());
                        producto.Productos.Add(resultItemList);
                    }
                }
            }
            //ServiceReferenceProducto.ProductoServicioClient productoWCF = new ServiceReferenceProducto.ProductoServicioClient();
            //var result = productoWCF.GetAll();

            ////ML.Result result = BL.Producto.GetAll();

            //producto = new ML.Producto();
            //producto.Productos = result.Objects.ToList();
            return View(producto);
        }

        [HttpGet]
        public ActionResult Add(int? IdProducto)
        {
            ML.Producto producto = new ML.Producto();
            producto.IdProducto = IdProducto.Value; //asignamos al modelo el id que traia

            producto.Productos = new List<object>();
            producto.departamento = new ML.Departamento();
            producto.proveedor = new ML.Proveedor();

            ML.Result resultDepa = BL.Departamento.GetAll();
            ML.Result resultProv = BL.Proveedor.GetAll();

            if (producto.IdProducto != 0) //update
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);
                    var responseTask = client.GetAsync("Producto/GetBy?id=" + IdProducto);
                    responseTask.Wait();

                    var resultServicio = responseTask.Result;
                    if (resultServicio.IsSuccessStatusCode)
                    {

                        var readTask = resultServicio.Content.ReadAsAsync<ML.Result>();
                        readTask.Wait();

                        ML.Producto resultItemList = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Producto>(readTask.Result.Object.ToString());
                        producto = resultItemList;

                    }
                    producto.departamento.Departamentos = resultDepa.Objects;
                    producto.proveedor.Proveedores = resultProv.Objects;
                }
            }
            else
            {
                producto.departamento.Departamentos = resultDepa.Objects;
                producto.proveedor.Proveedores = resultProv.Objects;
            }

            //if (IdProducto != 0) //update
            //{
            //    //WCF
            //    ServiceReferenceProducto.ProductoServicioClient productoWCF = new ServiceReferenceProducto.ProductoServicioClient();
            //    var result = productoWCF.GetById(producto);
            //    //WCF
            //    //ML.Result result = BL.Producto.GetById(IdProducto.Value);

            //    if (result.Correct)
            //    {
            //        producto = (ML.Producto)result.Object;
            //        producto.departamento.Departamentos = resultDepa.Objects;
            //        producto.proveedor.Proveedores = resultProv.Objects;
            //    }
            //}
            //else //add
            //{
            //    producto.departamento.Departamentos = resultDepa.Objects;
            //    producto.proveedor.Proveedores = resultProv.Objects;
            //}
            return View(producto);
        }

        [HttpPost]
        public ActionResult Add(ML.Producto producto)
        {
            HttpPostedFileBase file = Request.Files["Imagen"];
            if (file.ContentLength > 0)
            {
                producto.Imagen = ConvertirBase64(file);
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

                if (producto.IdProducto == 0) //add
                {
                    var postTask = client.PostAsJsonAsync<ML.Producto>("Producto", producto);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        ViewBag.Mensaje = "Se ha insertado correctamente";
                    }
                    else
                    {
                        ViewBag.Error = result.ToString();
                    }
                }
                else //update
                {
                    var postTask = client.PutAsJsonAsync<ML.Producto>("Producto?idProducto=" + producto.IdProducto, producto);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        ViewBag.Mensaje = "Se Actualizo el Producto";
                    }
                    else
                    {
                        ViewBag.Error = result.ToString();
                    }
                }
            }
                //producto.Productos = new List<object>();

                //if (producto.IdProducto == 0) //add
                //{
                //    //WCF
                //    ServiceReferenceProducto.ProductoServicioClient productoWCF = new ServiceReferenceProducto.ProductoServicioClient();
                //    var result = productoWCF.Add(producto);
                //    //WCF
                //    //ML.Result result = BL.Producto.Add(producto);

                //    if (result.Correct)
                //    {
                //        ViewBag.Mensaje = "Se incerto correctamente";
                //    }
                //    else
                //    {
                //        ViewBag.Error = result.ErrorMassage;
                //    }
                //}
                //else //update
                //{
                //    //WCF
                //    ServiceReferenceProducto.ProductoServicioClient productoWCF = new ServiceReferenceProducto.ProductoServicioClient();
                //    var result = productoWCF.Update(producto);
                //    //WCF
                //    //ML.Result result = BL.Producto.Update(producto);

                //    if (result.Correct)
                //    {
                //        ViewBag.Mensaje = "Se actualizo correctamente";
                //    }
                //    else
                //    {
                //        ViewBag.Error = result.ErrorMassage;
                //    }
                //}
                return PartialView("Modal");
        }

        public ActionResult Dell(int IdProducto) 
        {
            ML.Producto producto = new ML.Producto();
            producto.IdProducto = IdProducto;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

                var postTask = client.DeleteAsync("Producto?idProducto=" + producto.IdProducto);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    ViewBag.Mensaje = "Se elimino el Producto";
                }
                else
                {
                    ViewBag.Error = result.ToString();
                }
            }
                //WCF
                //ServiceReferenceProducto.ProductoServicioClient productoWCF = new ServiceReferenceProducto.ProductoServicioClient();
                //var result = productoWCF.Delete(producto);
                ////WCF
                ////ML.Result result = BL.Producto.Dell(IdProducto);

                //if (result.Correct)
                //{
                //    ViewBag.Mensaje = "Se elimino el producto";
                //}
                //else
                //{
                //    ViewBag.Error = result.ErrorMassage;
                //}
                return PartialView("Modal");
        }



        public string ConvertirBase64(HttpPostedFileBase foto)
        {
            System.IO.BinaryReader reader = new System.IO.BinaryReader(foto.InputStream);
            byte[] data = reader.ReadBytes((int)foto.ContentLength);
            string imagen = Convert.ToBase64String(data);
            return imagen;
        }

    }
}