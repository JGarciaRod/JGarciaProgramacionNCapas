using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SLWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IProductoServicio" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IProductoServicio
    {
        [OperationContract]
        SLWCF.Result Add(ML.Producto producto);

        [OperationContract]
        SLWCF.Result Delete(ML.Producto producto);

        [OperationContract]
        SLWCF.Result Update (ML.Producto producto);

        [OperationContract]
        [ServiceKnownType(typeof(ML.Producto))]
        SLWCF.Result GetAll();

        [OperationContract]
        [ServiceKnownType(typeof(ML.Producto))]
        SLWCF.Result GetById(ML.Producto producto);
    }
}
