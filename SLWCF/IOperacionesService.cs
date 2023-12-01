using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SLWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IOperacionesService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]//que la interface es parte de un servicio WCF
    public interface IOperacionesService
    {
        [OperationContract] //el metodo es parte del servicio WCF
        int Suma(int a, int b);

        [OperationContract]
        int Resta(int a, int b);

        [OperationContract]
        int Multiplicacion (int a, int b);

        [OperationContract]
        int Divicion(int a, int b);

    }
}
