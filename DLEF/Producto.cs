//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DLEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int stock { get; set; }
        public Nullable<int> IdProveedor { get; set; }
        public Nullable<int> IdDepartamento { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
    
        public virtual Departamento Departamento { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}
