using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace SLWebApi.Controllers
{
    [RoutePrefix("api/Producto")]
    public class ProductoController : ApiController
    {
        [Route("")]
        [HttpPost]
        public IHttpActionResult Add(ML.Producto producto) //si entra
        {
            ML.Result result = BL.Producto.Add(producto);

            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }
        }

        [Route("{idProducto?}")]
        [HttpDelete]
        public IHttpActionResult Delete(int idProducto) //si entra
        {
            ML.Result result = BL.Producto.Dell(idProducto);

            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }
        }

        [Route("{idProducto?}")]
        [HttpPut]
        public IHttpActionResult Update(int idProducto, [FromBody] ML.Producto producto) //si entra
        {
            producto.IdProducto = idProducto;
            ML.Result result = BL.Producto.Update(producto);

            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }
        }


        [Route("")]
        [HttpGet]
        public IHttpActionResult GetAll() //si entra
        {
            ML.Result result = BL.Producto.GetAll();
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }
        }


        [Route("GetBy/{id?}")]
        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            ML.Result result = BL.Producto.GetById(id);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }
        }
    }
}
