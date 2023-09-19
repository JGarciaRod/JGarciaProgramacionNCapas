using System;
using System.Collections.Generic;
using System.Linq;
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

            ML.Result result = BL.Producto.GetAll();


            if (result.Correct)
            {
                producto.Productos = result.Objects;
            }
            else
            {
                ViewBag.Message = result.ErrorMassage;
            }
            return View(producto);
        }

        [HttpPost]
        public ActionResult GetAll(ML.Producto producto)
        {
            ML.Result result = BL.Producto.GetAll();
            producto = new ML.Producto();
            producto.Productos = result.Objects;
            return View(producto);
        }

        [HttpGet]
        public ActionResult Add(int? IdProducto)
        {
            ML.Producto producto = new ML.Producto();
            producto.departamento = new ML.Departamento();
            producto.proveedor = new ML.Proveedor();

            ML.Result resultDepa = BL.Departamento.GetAll();
            ML.Result resultProv = BL.Proveedor.GetAll();

            if (IdProducto != 0) //update
            {
                ML.Result result = BL.Producto.GetById(IdProducto.Value);

                if (result.Correct)
                {
                    producto = (ML.Producto)result.Object;
                    producto.departamento.Departamentos = resultDepa.Objects;
                    producto.proveedor.Proveedores = resultProv.Objects;
                }
            }
            else //add
            {
                producto.departamento.Departamentos = resultDepa.Objects;
                producto.proveedor.Proveedores = resultProv.Objects;
            }
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

            if (producto.IdProducto == 0) //add
            {
                ML.Result result = BL.Producto.Add(producto);
                
                if (result.Correct)
                {
                    ViewBag.Mensaje = "Se incerto correctamente";
                }
                else
                {
                    ViewBag.Error = result.ErrorMassage;
                }
            }
            else //update
            {
                ML.Result result = BL.Producto.Update(producto);
                
                if (result.Correct)
                {
                    ViewBag.Mensaje = "Se actualizo correctamente";
                }
                else
                {
                    ViewBag.Error = result.ErrorMassage;
                }
            }
            return PartialView("Modal");
        }

        public ActionResult Dell(int IdProducto) 
        {
            ML.Result result = BL.Producto.Dell(IdProducto);

            if (result.Correct)
            {
                ViewBag.Mensaje = "Se elimino el producto";
            }
            else
            {
                ViewBag.Error = result.ErrorMassage;
            }
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