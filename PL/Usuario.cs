using ML;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Usuario
    {
        public static void Add()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingresa el UserName del nuevo usuario");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Ingresa el nombre del nuevo usuario");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el apellido del nuevo usuario");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingresa el apellido materno del nuevo usuario");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingresa el Email del nuevo usuario");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Ingresa el password del nuevo usuario");
            usuario.Password = Console.ReadLine();

            Console.WriteLine("Ingresa el sexo del nuevo usuario");
            usuario.Sexo = Console.ReadLine();

            Console.WriteLine("Ingresa el telefono del nuevo usuario");
            usuario.Telefono = Console.ReadLine();

            Console.WriteLine("Ingresa el celular del nuevo usuario");
            usuario.Celular = Console.ReadLine();

            Console.WriteLine("Ingresa la fecha de nacimiento del nuevo usuario (M/DD/AAAA)");
            usuario.FechaNacimiento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el CURP del nuevo usuario");
            usuario.CURP = Console.ReadLine();

            Console.WriteLine("Ingrese el rol del nuevo usuario");
            usuario.Rol = new ML.Roll();
            usuario.Rol.idRol = int.Parse(Console.ReadLine());

            ML.Result result = BL.Usuario.AddEF(usuario);

            if (result.Correct)
            {
                Console.WriteLine("Se agrego el Usuario correctamnete");
            }
            else
            {
                Console.WriteLine("Error en el nuevo usuario " + result.ErrorMassage);
            }
        }


        //public static void delate()
        //{
        //    ML.Usuario usuario = new ML.Usuario();

        //    Console.WriteLine("Ingrese el ID del que desea eliminar: ");
        //    usuario.IdUsuario = int.Parse(Console.ReadLine());

        //    ML.Result result = BL.Usuario.DellEF(usuario);
        //    if (result.Correct)
        //    {
        //        Console.WriteLine("Se elimino el Usuario correctamnete");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Error al eliminar el usuario " + result.ErrorMassage);
        //    }
        //}

        public static void Update()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingresa el UserName del nuevo usuario");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Ingresa el nombre del nuevo usuario");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el apellido del nuevo usuario");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingresa el apellido materno del nuevo usuario");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingresa el Email del nuevo usuario");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Ingresa el password del nuevo usuario");
            usuario.Password = Console.ReadLine();

            Console.WriteLine("Ingresa el sexo del nuevo usuario");
            usuario.Sexo = Console.ReadLine();

            Console.WriteLine("Ingresa el telefono del nuevo usuario");
            usuario.Telefono = Console.ReadLine();

            Console.WriteLine("Ingresa el celular del nuevo usuario");
            usuario.Celular = Console.ReadLine();

            Console.WriteLine("Ingresa la fecha de nacimiento del nuevo usuario (M/DD/AAAA)");
            usuario.FechaNacimiento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el CURP del nuevo usuario");
            usuario.CURP = Console.ReadLine();

            Console.WriteLine("Ingrese el rol del nuevo usuario");
            usuario.Rol = new ML.Roll();
            usuario.Rol.idRol = int.Parse(Console.ReadLine());


            Console.WriteLine("Ingresa el ID del usuario a afectar: ");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            ML.Result result = BL.Usuario.UpdateEF(usuario);
            if (result.Correct)
            {
                Console.WriteLine("El usuario se actualizo correctamente");
            }
            else
            {
                Console.WriteLine("Error el usuario no se actualizo " + result.ErrorMassage);
            }

        }

        public static void CargaMasiva()
        {
            //carga masiva crear txt 
            string file = @"C:\Users\digis\Documents\JairGarcia\JGarciaProgramacionNCapas\PL_MVC\Files\CargaMasiva.txt";

            if (File.Exists(file))
            {
                StreamReader streamReader = new StreamReader(file);
                
                string line = streamReader.ReadLine(); //saltar headers

                while ( (line = streamReader.ReadLine()) != null)
                {
                    string[] row = line.Split('|');
                    ML.Usuario usuario = new ML.Usuario();
                    usuario.UserName = row[0];
                    usuario.Nombre = row[1];
                    usuario.ApellidoPaterno = row[2];
                    usuario.ApellidoMaterno = row[3];
                    usuario.Email = row[4];
                    usuario.Password = row[5];
                    usuario.Sexo = row[6];
                    usuario.Telefono = row[7];
                    usuario.Celular = row[8];
                    usuario.FechaNacimiento = DateTime.Parse(row[9]);
                    usuario.CURP = row[10];
                    usuario.Rol.idRol = int.Parse(row[11]);
                    usuario.Direccion.Calle= row[12];
                    usuario.Direccion.NumeroExterior = row[13];
                    usuario.Direccion.NumeroInterior = row[14];
                    usuario.Direccion.Colonia.IdColonia = int.Parse(row[15]);

                    BL.Usuario.AddEF(usuario);
                }
            }
        }

        //public static void GetAll()
        //{
        //    ML.Usuario usuario1 = new ML.Usuario();

        //    ML.Result result = BL.Usuario.GetAllEF();
        //    if (result.Correct)
        //    {
        //        foreach (ML.Usuario objeto in result.Objects) //se usa el ML usuario porque fue donde guardamos nuestros datos, ademas de que guardamos en la lista  
        //        {
        //            Console.WriteLine("ID: " + objeto.IdUsuario);
        //            Console.WriteLine("UserName: " + objeto.UserName);
        //            Console.WriteLine("Nombre: " + objeto.Nombre);
        //            Console.WriteLine("Apellido Paterno: " + objeto.ApellidoPaterno);
        //            Console.WriteLine("Apellido Materno: " + objeto.ApellidoMaterno);
        //            Console.WriteLine("Email: " + objeto.Email);
        //            Console.WriteLine("Password: " + objeto.Password);
        //            Console.WriteLine("Sexo: " + objeto.Sexo);
        //            Console.WriteLine("Telefono: " + objeto.Telefono);
        //            Console.WriteLine("Celular: " + objeto.Celular);
        //            Console.WriteLine("Fecha de Nacimiento: " + objeto.FechaNacimiento);
        //            Console.WriteLine("CURP: " + objeto.CURP);
        //            Console.WriteLine("IdRol: " + objeto.Rol.idRol);
        //            Console.WriteLine("Nombre Rol: " + objeto.Rol.Nombre);
        //            Console.WriteLine("--------------------------------------");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("vacia");
        //    }
        //}

        //public static void GetById()
        //{
        //    ML.Usuario usuario = new ML.Usuario();

        //    Console.WriteLine("Ingrese el ID del que desea consultar: ");
        //    usuario.IdUsuario = int.Parse(Console.ReadLine());

        //    ML.Result result = BL.Usuario.GetByIdEF(usuario);

        //    if (result.Correct)
        //    {
        //        //unboxing vaciamos el objeto
        //        usuario = (ML.Usuario)result.Object; //como solo es 1 usamos OBJECT 
        //        Console.WriteLine("ID: " + usuario.IdUsuario);
        //        Console.WriteLine("UserName: " + usuario.UserName);
        //        Console.WriteLine("Nombre: " + usuario.Nombre);
        //        Console.WriteLine("Apellido Paterno: " + usuario.ApellidoPaterno);
        //        Console.WriteLine("Apellido Materno: " + usuario.ApellidoMaterno);
        //        Console.WriteLine("Email: " + usuario.Email);
        //        Console.WriteLine("Password: " + usuario.Password);
        //        Console.WriteLine("Sexo: " + usuario.Sexo);
        //        Console.WriteLine("Telefono: " + usuario.Telefono);
        //        Console.WriteLine("Celular: " + usuario.Celular);
        //        Console.WriteLine("Fecha de Nacimiento: " + usuario.FechaNacimiento);
        //        Console.WriteLine("CURP: " + usuario.CURP);
        //        Console.WriteLine("IdRol: " + usuario.Rol.idRol);
        //        Console.WriteLine("Nombre Rol: " + usuario.Rol.Nombre);
        //        Console.WriteLine("--------------------------------------");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No se econtro el ID del usuario");
        //    }
        //}

        //public static void Cosulta()
        //{
        //    ML.Usuario usuario = new ML.Usuario();

        //    Console.WriteLine("Ingrese EL ID del que desea consultar: ");
        //    usuario.IdUsuario = int.Parse(Console.ReadLine());

        //    string resultado = BL.Usuario.Consulta(usuario);
        //    Console.WriteLine(resultado);
        //}


        
    }
}
