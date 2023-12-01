using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SLWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "OperacionesService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione OperacionesService.svc o OperacionesService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class OperacionesService : IOperacionesService
    {
        public int Divicion(int a, int b)
        {
            return a / b;
        }

        public int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        public int Resta(int a, int b)
        {
            return a - b;
        }

        public int Suma(int a, int b)
        {
            return a + b;
        }
    }
}
