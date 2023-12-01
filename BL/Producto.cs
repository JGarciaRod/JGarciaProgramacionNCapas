using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Producto
    {
        public static ML.Result Add(ML.Producto producto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DLEF.JGarciaProgramacionNCapasEntities context = new DLEF.JGarciaProgramacionNCapasEntities())
                {
                    int rowAffected = context.ProductosAdd(
                        producto.Nombre,
                        producto.PrecioUnitario,
                        producto.stock,
                        producto.proveedor.IdProveedor,
                        producto.departamento.IdDepartamento,
                        producto.Descripcion,
                        producto.Imagen
                        );
                    if ( rowAffected > 0 )
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMassage = "Error al imgresar el producto";
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMassage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result Update(ML.Producto producto)
        {
            ML.Result result = new ML.Result ();

            try
            {
                using(DLEF.JGarciaProgramacionNCapasEntities context = new DLEF.JGarciaProgramacionNCapasEntities())
                {
                    int rowAffected = context.ProductoUpdate(
                        producto.IdProducto,
                        producto.Nombre,
                        producto.PrecioUnitario,
                        producto.stock,
                        producto.proveedor.IdProveedor,
                        producto.departamento.IdDepartamento,
                        producto.Descripcion,
                        producto.Imagen
                        );
                    if( rowAffected > 0 )
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMassage="Error al actualizar";
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMassage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result Dell(int IdProducto)
        {
            ML.Result result= new ML.Result ();
            try
            {
                using (DLEF.JGarciaProgramacionNCapasEntities context =  new DLEF.JGarciaProgramacionNCapasEntities())
                {
                    int rowsAffected = context.ProductoDell( IdProducto );
                    if(rowsAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }

                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMassage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result ();
            try
            {
                using (DLEF.JGarciaProgramacionNCapasEntities context = new DLEF.JGarciaProgramacionNCapasEntities())
                {
                    var query = context.ProductoGetAll().ToList();

                    if( query != null)
                    {
                        result.Objects = new List<object>();

                        foreach ( var registro in query)
                        {
                            ML.Producto producto1 = new ML.Producto();
                             
                            producto1.IdProducto = registro.IdProducto;
                            producto1.Nombre = registro.NombreProducto;
                            producto1.PrecioUnitario = registro.PrecioUnitario;
                            producto1.stock = registro.stock;

                            producto1.departamento = new ML.Departamento();
                            producto1.departamento.IdDepartamento = registro.IdDepartamento;
                            producto1.departamento.Nombre = registro.NombreDepartamento;

                            producto1.Descripcion = registro.Descripcion;
                            producto1.Imagen = registro.Imagen;
                            
                            producto1.proveedor = new ML.Proveedor();
                            producto1.proveedor.IdProveedor = registro.IdProveedor;
                            producto1.proveedor.Nombre = registro.NombreProveedor;
                            producto1.proveedor.Telefono = registro.Telefono;

                            result.Objects.Add(producto1);
                        }
                        result.Correct = true;
                    }
                        
                }
            }
            catch(Exception e)
            {
                result.Correct = false;
                result.ErrorMassage = e.Message;
                result.Ex = e;
            }
            return result;
        }

        public static ML.Result GetById(int IdProducto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.JGarciaProgramacionNCapasEntities context = new DLEF.JGarciaProgramacionNCapasEntities())
                {
                    var query = context.ProductosGetById(IdProducto).SingleOrDefault();

                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        ML.Producto producto = new ML.Producto();
                        producto.IdProducto = query.IdProducto;
                        producto.Nombre = query.NombreProducto;
                        producto.PrecioUnitario = query.PrecioUnitario;
                        producto.stock = query.stock;

                        producto.departamento = new ML.Departamento();
                        producto.departamento.IdDepartamento = query.IdDepartamento;
                        producto.departamento.Nombre = query.NombreDepartamento;

                        producto.Descripcion = query.Descripcion;
                        producto.Imagen = query.Imagen;
                        
                        producto.proveedor = new ML.Proveedor();
                        producto.proveedor.IdProveedor = query.IdProveedor;
                        producto.proveedor.Nombre = query.NombreProveedor;
                        producto.proveedor.Telefono = query.Telefono;

                        result.Object = producto;

                        result.Correct = true;
                    }
                }
            }
            catch(Exception e)
            {
                result.Correct =false;
                result.ErrorMassage = e.Message;
                result.Ex = e;
            }
            return result;
        }

        public static ML.Result ProductoGetByIdArea(int IdArea)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.JGarciaProgramacionNCapasEntities context = new DLEF.JGarciaProgramacionNCapasEntities())
                {
                    var query = context.AreaGetById(IdArea).ToList();

                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        foreach (var registro in query)
                        {
                            ML.Producto producto = new ML.Producto();
                            producto.IdProducto = registro.IdProducto;
                            producto.Nombre = registro.NombreProducto;
                            producto.PrecioUnitario = registro.PrecioUnitario;
                            producto.stock = registro.stock;
                            producto.Descripcion = registro.Descripcion;
                            producto.Imagen = registro.Imagen;

                            producto.proveedor = new ML.Proveedor();
                            producto.proveedor.IdProveedor = registro.IdProveedor;

                            producto.departamento = new ML.Departamento();
                            producto.departamento.IdDepartamento = registro.IdDepartamento;
                            producto.departamento.Nombre = registro.NombreDepartamento;

                            producto.departamento.Area = new ML.Area();
                            producto.departamento.Area.IdArea = registro.IdArea;
                            producto.departamento.Area.Nombre = registro.NombreArea;

                            result.Objects.Add(producto);
                        }
                        result.Correct = true;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMassage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
    }
}
