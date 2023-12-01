using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SLWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ProductoServicio" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ProductoServicio.svc o ProductoServicio.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ProductoServicio : IProductoServicio
    {
        public SLWCF.Result Add(ML.Producto producto)
        {
            ML.Result result = BL.Producto.Add(producto);

            return new SLWCF.Result
            {
                Correct = result.Correct,
                ErrorMassage = result.ErrorMassage,
                Ex = result.Ex,
                Object = result.Object,
                Objects = result.Objects,
            };
        }

        public SLWCF.Result Delete(ML.Producto producto)
        {
            ML.Result result = BL.Producto.Dell(producto.IdProducto);

            return new SLWCF.Result
            {
                Correct = result.Correct,
                ErrorMassage = result.ErrorMassage,
                Ex = result.Ex,
                Object = result.Object,
                Objects = result.Objects,
            };
        }

        public SLWCF.Result Update(ML.Producto producto)
        {
            ML.Result result = BL.Producto.Update(producto);

            return new SLWCF.Result
            {
                Correct = result.Correct,
                ErrorMassage = result.ErrorMassage,
                Ex = result.Ex,
                Object = result.Object,
                Objects = result.Objects,
            };
        }

        public Result GetAll()
        {
            ML.Result result = BL.Producto.GetAll();

            return new Result 
            {
                Correct = result.Correct,
                ErrorMassage = result.ErrorMassage,
                Ex = result.Ex,
                Object = result.Object,
                Objects = result.Objects,
            };
        }

        public Result GetById(ML.Producto producto)
        {
            ML.Result result = BL.Producto.GetById(producto.IdProducto);
            return new Result
            {
                Correct = result.Correct,
                ErrorMassage = result.ErrorMassage,
                Ex = result.Ex,
                Object = result.Object,
                Objects = result.Objects,
            };
        }
    }
}
