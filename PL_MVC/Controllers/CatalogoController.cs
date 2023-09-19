using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class CatalogoController : Controller
    {
        // GET: Catalogo
        [HttpGet]
        public ActionResult Catalogo()
        {
            ML.Area area = new ML.Area();

            ML.Result result = BL.Area.GetAll();

            if (result.Correct)
            {
                area.Areas = result.Objects;
            }
            else
            {
                ViewBag.Massage = result.ErrorMassage;
            }

            return View(area);
        }

        [HttpGet]
        public ActionResult GetProductos(int? IdArea)
        {
            ML.Producto producto = new ML.Producto();

            ML.Result result = BL.Producto.ProductoGetByIdArea(IdArea.Value);
            if (result.Correct)
            {
                producto.Productos = result.Objects;
            }
            else
            {
                ViewBag.Massage = result.ErrorMassage;
            }

            return View(producto);
        }
    }
}