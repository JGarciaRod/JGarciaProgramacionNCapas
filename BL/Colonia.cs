using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Colonia
    {
        public static ML.Result GetByIdMunicipio(int idMunicipio)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.JGarciaProgramacionNCapasEntities context = new DLEF.JGarciaProgramacionNCapasEntities())
                {
                    var query = context.ColoniaGetByMunicipio(idMunicipio).ToList();

                    if (query != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var registro in query)
                        {
                            ML.Colonia colonia = new ML.Colonia();
                            colonia.IdColonia = registro.IdColonia;
                            colonia.Nombre = registro.Nombre;
                            result.Objects.Add(colonia);
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
