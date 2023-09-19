﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Area
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DLEF.JGarciaProgramacionNCapasEntities contex = new DLEF.JGarciaProgramacionNCapasEntities())
                {
                    var query = contex.AreaGetAll().ToList();

                    if(query != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var registro in query)
                        {
                            ML.Area area = new ML.Area();

                            area.IdArea = registro.IdArea;
                            area.Nombre = registro.Nombre;


                            result.Objects.Add(area);
                        }
                        result.Correct = true;
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
