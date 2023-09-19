using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Bienvenido----");
            Console.WriteLine("1)Agregar usuario");
            Console.WriteLine("2)Eliminar usuario");
            Console.WriteLine("3)Alterar usuario");
            Console.WriteLine("4)Ver toda la tabla");
            Console.WriteLine("5)Consulta por ID");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    PL.Usuario.Add();
                    Console.ReadKey();
                    break;

                case 2:
                    PL.Usuario.delate();
                    Console.ReadKey();
                    break;
                case 3:
                    PL.Usuario.Update();
                    Console.ReadKey();
                    break;
                case 4:
                    PL.Usuario.GetAll();
                    Console.ReadKey();
                    break;
                case 5:
                    PL.Usuario.GetById();
                    Console.ReadKey();
                    break;
            }

        }
    }
}
