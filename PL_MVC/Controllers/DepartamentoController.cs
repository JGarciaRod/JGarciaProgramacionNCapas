using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.ServiceModel.PeerResolvers;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class DepartamentoController : Controller
    {
        // GET: Departamento
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Departamento departamento = new ML.Departamento();
            departamento.Departamentos = new List<object>();
            departamento.Area = new ML.Area();
            departamento.Nombre = "";
            departamento.Area.IdArea = 0;

            ML.Result resultSubCategoria = new ML.Result();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

                var responseTask = client.GetAsync($"Departamento?idArea=&Nombre=");
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    ML.Result resultArea = BL.Area.GetAll();

                    var readTask = result.Content.ReadAsAsync<ML.Result>();
                    readTask.Wait();
                    departamento.Area.Areas = resultArea.Objects;

                    foreach (var resultItem in readTask.Result.Objects)
                    {
                        ML.Departamento resultItemList = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Departamento>(resultItem.ToString());
                        departamento.Departamentos.Add(resultItemList);
                    }
                }
            }
            return View(departamento);
            //ML.Departamento departamento = new ML.Departamento();
            //departamento.Area = new ML.Area();
            //departamento.Nombre = "";
            //departamento.Area.IdArea = 0;

            //wcf
            //ServiceReferenceDepartamento.DepartamentoServicesClient departamentowcf = new ServiceReferenceDepartamento.DepartamentoServicesClient();
            //var result = departamentowcf.GetAll(departamento);
            //wcf


            //con modelo
            //ML.Result result = BL.Departamento.DepartamentoGetAll(departamento);

            //ML.Result resultArea = BL.Area.GetAll();

            //if (result.Correct)
            //{
            //    departamento.Departamentos = result.Objects.ToList();
            //    departamento.Area.Areas = resultArea.Objects;
            //}
            //else
            //{
            //    ViewBag.Massage = result.ErrorMassage;
            //}
            //return View(departamento);
        }

        [HttpPost]
        public ActionResult GetAll(ML.Departamento departamento)
        {
            if (departamento.Nombre == null)
            {
                departamento.Nombre = "";
            }
            //no igualamos el id ese ya viene como entero = 0

            ML.Result resultSubCategoria = new ML.Result();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

                var responseTask = client.GetAsync($"Departamento?idArea=" + departamento.Area.IdArea + "&Nombre=" + departamento.Nombre);
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    ML.Result resultArea = BL.Area.GetAll();

                    var readTask = result.Content.ReadAsAsync<ML.Result>();
                    readTask.Wait();
                    departamento.Area.Areas = resultArea.Objects;

                    foreach (var resultItem in readTask.Result.Objects)
                    {
                        ML.Departamento resultItemList = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Departamento>(resultItem.ToString());
                        departamento.Departamentos.Add(resultItemList);
                    }
                }
            }

            //WCF
            //ServiceReferenceDepartamento.DepartamentoServicesClient departamentoWCF = new ServiceReferenceDepartamento.DepartamentoServicesClient();
            //var result = departamentoWCF.GetAll(departamento);
            ////WCF

            ////ML.Result result = BL.Departamento.DepartamentoGetAll(departamento);

            //ML.Result resultArea = BL.Area.GetAll();

            //departamento = new ML.Departamento();
            //departamento.Area = new ML.Area();
            //departamento.Departamentos = result.Objects.ToList();
            //departamento.Area.Areas = resultArea.Objects;
            return View(departamento);
        }


        [HttpGet]  //mostrar 
        public ActionResult Add(int? IdDepartamento)
        {
            ML.Departamento departamento = new ML.Departamento();
            departamento.IdDepartamento = IdDepartamento.Value; //asignamos al modelo de departamento el id ingresado
            departamento.Departamentos = new List<object>();

            departamento.Area = new ML.Area();
            ML.Result resultArea = BL.Area.GetAll();

            if(departamento.IdDepartamento != 0) //update
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);
                    var responseTask = client.GetAsync("Departamento?idDepartamento=" + IdDepartamento);
                    responseTask.Wait();

                    var resultServicio = responseTask.Result;
                    if (resultServicio.IsSuccessStatusCode)
                    {

                        var readTask = resultServicio.Content.ReadAsAsync<ML.Result>();
                        readTask.Wait();

                        ML.Departamento resultItemList = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Departamento>(readTask.Result.Object.ToString());
                        departamento = resultItemList;
                        
                    }
                    departamento.Area.Areas = resultArea.Objects;
                }
            }
            else
            {
                departamento.Area.Areas = resultArea.Objects;
            }


            //if (departamento.IdDepartamento != 0) //update
            //{
            //    //WCF
            //    ServiceReferenceDepartamento.DepartamentoServicesClient departamentoWCF = new ServiceReferenceDepartamento.DepartamentoServicesClient();
            //    var result = departamentoWCF.GetById(departamento);
            //    //WCF
            //    //ML.Result result = BL.Departamento.DepartamentoGetById(IdDepartamento.Value);

            //    if (result.Correct)
            //    {
            //        departamento = (ML.Departamento)result.Object;
            //        departamento.Area.Areas = resultArea.Objects;
            //    }
            //}
            //else //add
            //{
            //    departamento.Area.Areas = resultArea.Objects;
            //}
            return View(departamento);
        }

        [HttpPost]

        public ActionResult Add(ML.Departamento departamento)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

                if (departamento.IdDepartamento == 0) //add
                {
                    var postTask = client.PostAsJsonAsync<ML.Departamento>("Departamento" , departamento);
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
                    var postTask = client.PutAsJsonAsync<ML.Departamento>("Departamento?idDepartamento=" + departamento.IdDepartamento, departamento);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        ViewBag.Mensaje = "Se Actualizo el Departamento";
                    }
                    else
                    {
                        ViewBag.Error = result.ToString();
                    }
                }

                return PartialView("modal");
            }

            //if(departamento.IdDepartamento == 0) //add
            //{
            //    //WCF       
            //    ServiceReferenceDepartamento.DepartamentoServicesClient departamentoWCF = new ServiceReferenceDepartamento.DepartamentoServicesClient();
            //    var result = departamentoWCF.Add(departamento);
            //    //WCF
            //    //ML.Result result = BL.Departamento.DepartamentoAdd(departamento);
            //    if(result.Correct)
            //    {
            //        ViewBag.Mensaje = "Se ha insertado correctamente";
            //    }
            //    else
            //    {
            //        ViewBag.Error = result.ErrorMassage;
            //    }
            //}
            //else //update 
            //{
            //    //WCF
            //    ServiceReferenceDepartamento.DepartamentoServicesClient departamentoWCF = new ServiceReferenceDepartamento.DepartamentoServicesClient();
            //    var result = departamentoWCF.Update(departamento);
            //    //WCF
            //    //ML.Result result = BL.Departamento.DepartamentoUpdate(departamento);
            //    if (result.Correct)
            //    {
            //        ViewBag.Mensaje = "Se ha actualizado correctamente";
            //    }
            //    else
            //    {
            //        ViewBag.Error = result.ErrorMassage;
            //    }
            //}
            //return PartialView("modal");
        }


        public ActionResult Delete(int IdDepartamento)
        {
            ML.Departamento departamento = new ML.Departamento(); //se crea el modelo donde solo le asignamos el id
            departamento.IdDepartamento = IdDepartamento;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

                var postTask = client.DeleteAsync("Departamento?idDepartamento=" + departamento.IdDepartamento );
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    ViewBag.Mensaje = "Se elimino el Departamento";
                }
                else
                {
                    ViewBag.Error = result.ToString();
                }
            }
                //ML.Departamento departamento = new ML.Departamento(); //se crea el modelo donde solo le asignamos el id
                //departamento.IdDepartamento = IdDepartamento;
                ////WCF
                //ServiceReferenceDepartamento.DepartamentoServicesClient departamentoWCF = new ServiceReferenceDepartamento.DepartamentoServicesClient();
                //var result = departamentoWCF.Delete(departamento);
                ////WCF
                ////ML.Result result = BL.Departamento.DepartamentoDell(IdDepartamento);

                //if (result.Correct)
                //{
                //    ViewBag.Mensaje = "Se elimino el Area";
                //}
                //else
                //{
                //    ViewBag.Error = result.ErrorMassage;
                //}
                return PartialView("modal");
        }

    }
}