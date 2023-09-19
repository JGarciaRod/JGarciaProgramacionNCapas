using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace PL_MVC.Controllers
{
    public class CargaMasivaController : Controller
    {
        // GET: CargaMasiva
        public ActionResult Cargar()
        {
            ML.Result result = new ML.Result();
            result.Objects = new List<object>();
            return View(result);
        }

        [HttpPost]
        public ActionResult Cargar(ML.Result result)
        {
            HttpPostedFileBase file = Request.Files["Excel"];

            if (Session["pathExcel"] == null)
            {


                if (file != null)
                {
                    string extencionArchivo = Path.GetExtension(file.FileName).ToLower(); //obtenemos la extencion del archivo
                    string extencionValida = ConfigurationManager.AppSettings["TipoExcel"]; //traemos las extencion permitida

                    if (extencionArchivo == extencionValida) //comparamos que si sea valido
                    {
                        string filePath = Server.MapPath("~/CargaMasiva/") + Path.GetFileNameWithoutExtension(file.FileName) + '-' + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx";
                        //creamos una copia la cual guardamos en la carpeta de CargaMasiva
                        if (!System.IO.File.Exists(filePath)) //comprobamos la existencia del archivo
                        {
                            file.SaveAs(filePath);

                            string connectionString = ConfigurationManager.ConnectionStrings["OleDbConnection"] + filePath; //leemos el archivo
                            ML.Result resultUsuarios = BL.Usuario.LeerExcel(connectionString);

                            if (resultUsuarios.Correct)
                            {
                                ML.Result resultValidacion = BL.Usuario.ValidarExcel(resultUsuarios.Objects);
                                if (resultValidacion.Objects.Count == 0)
                                {
                                    resultValidacion.Correct = true;
                                    Session["pathExcel"] = filePath;
                                }

                                return View(resultValidacion);
                            }
                            else
                            {
                                ViewBag.Message = "El Excel no contiene registros";
                            }
                        }
                    }
                    else
                    {
                        ViewBag.Message = "Favor de seleccionar un archivo .xlsx, Verifique su archivo";
                    }
                }
                else
                {
                    ViewBag.Message = "No selecciono ningun archivo, Selecione uno correctamente";
                }


                return View(result);

            }
            else
            {
                string filepath = Session["pathExcel"].ToString();// recupera la info de la session 

                if (filepath != null)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["OleDbConnection"] + filepath;
                    ML.Result resultUsuarios = BL.Usuario.LeerExcel(connectionString);

                    if (resultUsuarios.Correct)
                    {
                        ML.Result resultErrores = new ML.Result();
                        resultErrores.Objects = new List<object>();
                        foreach (ML.Usuario usuario in resultUsuarios.Objects)
                        {
                            ML.Result result1 = BL.Usuario.AddEF(usuario);
                            if (!result1.Correct)
                            {
                                
                                string error = "ocurrio un error al incertar el usuario " + usuario.Nombre + " " + result1.Ex.InnerException.Message 
                                    + " " + DateTime.Now.ToString("yyyyMMddHHmmss");
                                resultErrores.Objects.Add(error);
                            }
                            Session["pathExcel"] = null;
                        }
                        if(resultErrores.Objects.Count > 0)
                        {
                            string pathTxt = Server.MapPath(@"~\Files\logErrores.txt");
                            using (StreamWriter writer = new StreamWriter(pathTxt))
                            {
                                foreach (string line in resultErrores.Objects)
                                {
                                    writer.WriteLine(line);
                                }
                            }
                        }

                    }
                }
                else
                {

                }
            }
            return View(result);
        }
    }
}