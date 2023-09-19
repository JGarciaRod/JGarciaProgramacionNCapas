using ML;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PL_MVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        [HttpGet]
        public ActionResult GetALL()
        {
            ML.Usuario usuario = new ML.Usuario();
            usuario.Nombre = "";
            usuario.ApellidoPaterno = "";
            ML.Result result = BL.Usuario.GetAllEF(usuario);
            
            if (result.Correct)
            {
                usuario.Usuarios = result.Objects;
            }
            else
            {
                ViewBag.Massage = result.ErrorMassage;
            }

            return View(usuario);
        }

        [HttpPost]
        public ActionResult GetALL(ML.Usuario usuario)
        {
            if (usuario.Nombre == null)
            {
                usuario.Nombre = "";
            }
            if (usuario.ApellidoPaterno == null)
            {
                usuario.ApellidoPaterno = "";
            }

            ML.Result result = BL.Usuario.GetAllEF(usuario);
            usuario = new ML.Usuario();
            usuario.Usuarios = result.Objects;
            return View(usuario);
        }


        [HttpGet] //mostrar
        public ActionResult Add(int? IdUsuario)
        {
            ML.Usuario usuario = new ML.Usuario();
            usuario.Rol = new ML.Roll();
            usuario.Direccion = new ML.Direccion();
            usuario.Direccion.Colonia = new ML.Colonia();
            usuario.Direccion.Colonia.Municipio = new ML.Municipio();
            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
            usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();

            ML.Result resultRol = BL.Rol.GetAll();
            ML.Result resultPais = BL.Pais.GetAll();

            if (IdUsuario != 0) //update
            {
                ML.Result result = BL.Usuario.GetByIdEF(IdUsuario.Value);

                if (result.Correct)
                {
                    usuario = (ML.Usuario)result.Object;
                    usuario.Rol.Roles = resultRol.Objects;

                    usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPais.Objects;
                    usuario.Direccion.Colonia.Municipio.Estado.Estados = BL.Estado.GetByIdPais(usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais).Objects;
                    usuario.Direccion.Colonia.Municipio.Municipios = BL.Municipio.GetByIdEstado(usuario.Direccion.Colonia.Municipio.Estado.IdEstado).Objects;
                    usuario.Direccion.Colonia.Colonias = BL.Colonia.GetByIdMunicipio(usuario.Direccion.Colonia.Municipio.IdMunicipio).Objects;


                }
            }
            else //add
            {
                usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPais.Objects;
                usuario.Rol.Roles = resultRol.Objects;
            }

            return View(usuario);
        }

        [HttpPost]
        public ActionResult Add(ML.Usuario usuario)
        {

            if (ModelState.IsValid)
            {
                HttpPostedFileBase file = Request.Files["Imagen"];
                if (file.ContentLength > 0)
                {
                    usuario.Imagen = ConvertirBase64(file);
                }

                if (usuario.IdUsuario == 0) //add
                {
                    ML.Result result = BL.Usuario.AddEF(usuario);
                    if (result.Correct)
                    {
                        ViewBag.Mensaje = "Se ha incertado correctamente";

                    }
                    else
                    {
                        ViewBag.Error = result.ErrorMassage;

                    }
                }
                else //UPDATE   
                {
                    ML.Result result = BL.Usuario.UpdateEF(usuario);
                    if (result.Correct)
                    {
                        ViewBag.Mensaje = "Se ha actualizado correctamente";

                    }
                    else
                    {
                        ViewBag.Error = result.ErrorMassage;

                    }
                }
                return PartialView("modal");
            }
            else
            {
                ML.Result resultRol = BL.Rol.GetAll();
                ML.Result resultPais = BL.Pais.GetAll();

                usuario.Rol.Roles = resultRol.Objects;
                usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPais.Objects;
                usuario.Direccion.Colonia.Municipio.Estado.Estados = BL.Estado.GetByIdPais(usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais).Objects;
                usuario.Direccion.Colonia.Municipio.Municipios = BL.Municipio.GetByIdEstado(usuario.Direccion.Colonia.Municipio.Estado.IdEstado).Objects;
                usuario.Direccion.Colonia.Colonias = BL.Colonia.GetByIdMunicipio(usuario.Direccion.Colonia.Municipio.IdMunicipio).Objects;

                return View(usuario);
            }

        }

        [HttpGet]
        public ActionResult Delete(int IdUsuario)
        {
            ML.Result result = BL.Usuario.DellEF(IdUsuario);
            if (result.Correct)
            {
                ViewBag.Mensaje = "Usuario eliminado";
            }
            else
            {
                ViewBag.Error = result.ErrorMassage;
            }
            return PartialView("modal");

        }


        public JsonResult EstadoGetByIdPais(int IdPais)
        {
            ML.Result result = BL.Estado.GetByIdPais(IdPais);
            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }

        public JsonResult MunicipioGetByIdEstado(int IdEstado)
        {
            ML.Result result = BL.Municipio.GetByIdEstado(IdEstado);
            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ColoniaGetByIdMunicipio(int IdMunicipio)
        {
            ML.Result result = BL.Colonia.GetByIdMunicipio(IdMunicipio);
            return Json(result.Objects, JsonRequestBehavior.AllowGet);
        }

        public string ConvertirBase64(HttpPostedFileBase foto)
        {
            System.IO.BinaryReader reader = new System.IO.BinaryReader(foto.InputStream);
            byte[] data = reader.ReadBytes((int)foto.ContentLength);
            string imagen = Convert.ToBase64String(data);
            return imagen;
        }

        public JsonResult ChangeStatus(int IdUsuario, bool Status)
        {
            ML.Result result = BL.Usuario.ChangeStatus(IdUsuario, Status);
            return Json(null);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return PartialView(null);
        }

        [HttpPost]

        public ActionResult Login(string Email,string password)
        {
            ML.Usuario usuario = new ML.Usuario();
            
            ML.Result result = BL.Usuario.GetByEmail(Email);

            if (result.Correct)
            {
                usuario = (ML.Usuario)result.Object;
                if(password == usuario.Password)
                {
                    ViewBag.Login = true;
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    ViewBag.Login = false;
                    ViewBag.Mensaje = "Hubo un error";
                    return PartialView("modal");
                }
            }
            else
            {
                ViewBag.Login = false;
                ViewBag.Mensaje = "Hubo un error";
                return PartialView("modal");
            }
            //return PartialView(null);
        }
    }
}