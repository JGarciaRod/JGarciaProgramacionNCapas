using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SLWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IDepartamentoServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IDepartamentoServices
    {
        [OperationContract]
        SLWCF.Result Add(ML.Departamento departamento);

        [OperationContract]
        SLWCF.Result Delete(ML.Departamento departamento);

        [OperationContract]
        SLWCF.Result Update(ML.Departamento departamento);

        [OperationContract]
        [ServiceKnownType(typeof(ML.Departamento))]
        SLWCF.Result GetAll(ML.Departamento departamento);

        [OperationContract]
        [ServiceKnownType(typeof(ML.Departamento))]
        SLWCF.Result GetById(ML.Departamento departamento);
    }
}
