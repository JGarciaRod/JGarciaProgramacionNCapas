using System;
using System.Collections.Generic;
using System.Linq;
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
            departamento.Area = new ML.Area();
            departamento.Nombre = "";
            departamento.Area.IdArea = 0;
            ML.Result result = BL.Departamento.DepartamentoGetAll(departamento);
            ML.Result resultArea = BL.Area.GetAll();

            if (result.Correct)
            {
                departamento.Departamentos = result.Objects;
                departamento.Area.Areas = resultArea.Objects;
            }
            else
            {
                ViewBag.Massage = result.ErrorMassage;
            }
            return View(departamento);
        }
        [HttpPost]
        public ActionResult GetAll(ML.Departamento departamento)
        {
            if (departamento.Nombre == null)
            {
                 departamento.Nombre = "";
            }
            
            
            ML.Result result = BL.Departamento.DepartamentoGetAll(departamento);
            ML.Result resultArea = BL.Area.GetAll();
            
            departamento = new ML.Departamento();
            departamento.Area = new ML.Area();
            departamento.Departamentos = result.Objects;
            departamento.Area.Areas= resultArea.Objects;
            return View(departamento);
        }


        [HttpGet]  //mostrar 
        public ActionResult Add(int? IdDepartamento) 
        {
            ML.Departamento departamento = new ML.Departamento();
            departamento.Area = new ML.Area();

            ML.Result resultArea = BL.Area.GetAll();
            
            if (IdDepartamento != 0) //update
            {
                ML.Result result = BL.Departamento.DepartamentoGetById(IdDepartamento.Value);

                if (result.Correct)
                {
                    departamento = (ML.Departamento)result.Object;
                    departamento.Area.Areas = resultArea.Objects;
                }
            }
            else //add
            {
                departamento.Area.Areas = resultArea.Objects;
            }
            return View(departamento);
        }

        [HttpPost]

        public ActionResult Add(ML.Departamento departamento) 
        {
            if(departamento.IdDepartamento == 0) //add
            {
                ML.Result result = BL.Departamento.DepartamentoAdd(departamento);
                if(result.Correct)
                {
                    ViewBag.Mensaje = "Se ha insertado correctamente";
                }
                else
                {
                    ViewBag.Error = result.ErrorMassage;
                }
            }
            else //update 
            {
                ML.Result result = BL.Departamento.DepartamentoUpdate(departamento);
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


        public ActionResult Delete(int IdDepartamento)
        {
            ML.Result result = BL.Departamento.DepartamentoDell(IdDepartamento);
            if (result.Correct) 
            {
                ViewBag.Mensaje="Se elimino el Area";
            }
            else
            {
                ViewBag.Error = result.ErrorMassage;
            }
            return PartialView("modal");
        }

    }
}