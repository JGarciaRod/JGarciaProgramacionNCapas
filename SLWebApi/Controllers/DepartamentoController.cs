using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SLWebApi.Controllers
{
    [RoutePrefix("api/Departamento")] 
    public class DepartamentoController : ApiController
    {
        [Route("")]
        [HttpPost]
        public IHttpActionResult Add(ML.Departamento departamento) //si entra
        {
            ML.Result result = BL.Departamento.DepartamentoAdd(departamento);

            if (result.Correct)
            {
                return Content(HttpStatusCode.OK,result);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }
        }

        [Route("{idDepartamento?}")] 
        [HttpDelete]
        public IHttpActionResult Delete(int idDepartamento) //ya entra
        {
            ML.Result result = BL.Departamento.DepartamentoDell(idDepartamento);
           

            if (result.Correct)
            {
                return Content(HttpStatusCode.OK,result);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }
        }

        [Route("{idDepartamento?}")] 
        [HttpPut]
        public IHttpActionResult Update(int idDepartamento, [FromBody] ML.Departamento departamento) //si entra
        {
            departamento.IdDepartamento = idDepartamento;
            ML.Result result = BL.Departamento.DepartamentoUpdate(departamento);

            if(result.Correct)
            {
                return Content(HttpStatusCode.OK,result);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest , result);
            }
        }

        [Route("{idArea?}/{Nombre?}")]
        [HttpGet]
        public IHttpActionResult GetAll(int? idArea, string Nombre) //ya entra
        {
            if (idArea == null) idArea = 0;
            if (Nombre == null) Nombre = "";

            ML.Departamento departamento = new ML.Departamento();
            departamento.Area = new ML.Area();
            departamento.Area.IdArea = idArea.Value;
            departamento.Nombre = Nombre;

            ML.Result result = BL.Departamento.DepartamentoGetAll(departamento);

            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }
        }


        [Route("{idDepartamento?}")]
        [HttpGet]
        public IHttpActionResult GetById(int idDepartamento)  //si entra
        {
            ML.Result result = BL.Departamento.DepartamentoGetById(idDepartamento);

            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content (HttpStatusCode.BadRequest, result);
            }
        }


    }
}
