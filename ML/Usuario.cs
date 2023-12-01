using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Data.SqlTypes;
using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;

namespace ML
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        [Required]
        [StringLength(10)]
        [Display(Name ="Nombre de Usaurio")]
        public string UserName { get; set; }

        [Required]
        [StringLength(20)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Apellido Paterno")]
        public string ApellidoPaterno { get; set; }

        [Required]
        [StringLength (50)]
        [Display(Name = "Apellido Materno")]
        public string ApellidoMaterno { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        public string Password { get; set; }

        [MinLength(1)]
        public string Sexo { get; set; }

        [Required]
        [Phone]
        [MinLength(10)]
        [MaxLength(12)]
        public string Telefono { get; set; }

        [Phone]
        [MinLength(10)]
        [MaxLength(12)]
        public string Celular { get; set; }
        
        [Required]
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public string CURP { get; set; }
        public string Imagen { get; set; }

        public bool Status { get; set; }
        public ML.Roll Rol { get; set; }

        public ML.Direccion Direccion { get; set; }
        public List<object> Usuarios { get; set; }


        //public void MuestraTabla(int IDUsuario, string Nombre, string ApellidoPaterno, string ApellidoMaterno, string FechaNacimineto, string Profesion, float Promedio)
        //{
        //    int ProductID = IDUsuario;
        //    string ProducNombre = Nombre;
        //    string ProductPaterno = ApellidoPaterno;
        //    string ProductMaterno = ApellidoMaterno;
        //    string ProductFecha = FechaNacimiento.ToString();
        //    string ProductPrefe = Profesion;
        //    float ProductProm = Promedio;

        //}
    }
}
