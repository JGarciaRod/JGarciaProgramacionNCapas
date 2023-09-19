using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Estado
    {
        public static ML.Result GetByIdPais(int idPais)
        {

            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.JGarciaProgramacionNCapasEntities context = new DLEF.JGarciaProgramacionNCapasEntities())
                {
                    var query = context.EstadoGetByIdPais(idPais).ToList();

                    if (query != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var registro in query)
                        {
                            ML.Estado estado = new ML.Estado();
                            estado.IdEstado = registro.IdEstado;
                            estado.Nombre = registro.Nombre;
                            result.Objects.Add(estado);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
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
