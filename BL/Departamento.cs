using DLEF;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Departamento
    {

        public static ML.Result DepartamentoAdd(ML.Departamento departamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DLEF.JGarciaProgramacionNCapasEntities context = new DLEF.JGarciaProgramacionNCapasEntities())
                {
                    //ObjectParameter filasAfectadas = new ObjectParameter("FilasAfectadas",typeof(int));

                    int rowAffected = context.DepartamentoAdd(
                        departamento.Nombre,
                        departamento.Area.IdArea
                        );

                    if (rowAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMassage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }


        public static ML.Result DepartamentoUpdate(ML.Departamento departamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DLEF.JGarciaProgramacionNCapasEntities context = new DLEF.JGarciaProgramacionNCapasEntities())
                { 

                    int rowAffected = context.DepartamentoUpdate(
                        departamento.IdDepartamento,
                        departamento.Nombre
                        );

                    if (rowAffected > 0)
                    {
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


        public static ML.Result DepartamentoDell(int IdDepartamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DLEF.JGarciaProgramacionNCapasEntities context = new JGarciaProgramacionNCapasEntities())
                {
                    ObjectParameter filasAfectadas = new ObjectParameter("FilasAfectadas", typeof(int));

                    int rowAffected = context.DepartamentoDell(
                        IdDepartamento
                        );
                    if (rowAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else { result.Correct = false; }
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMassage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result DepartamentoGetAll(ML.Departamento departamento)
        {
            ML.Result result = new ML.Result();
            
            try
            {
                using(DLEF.JGarciaProgramacionNCapasEntities context = new JGarciaProgramacionNCapasEntities())
                {   
                    var rowAffected = context.DepartamentoGetAll(
                        departamento.Area.IdArea, 
                        departamento.Nombre
                        ).ToList();

                    if(rowAffected != null)
                    {
                        result.Objects = new List<object>();

                        foreach(var registro in rowAffected)
                        {
                            ML.Departamento depa = new ML.Departamento();

                            depa.IdDepartamento = registro.IdDepartamento;
                            depa.Nombre = registro.NombreDepartamento;
                            
                            depa.Area = new ML.Area();
                            depa.Area.IdArea = registro.IdArea;
                            depa.Area.Nombre = registro.NombreArea;

                            result.Objects.Add(depa);
                        }
                        result.Correct = true;
                    }
                }
            }
            catch( Exception ex) 
            { 
                result.Correct = false;
                result.ErrorMassage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result DepartamentoGetById(int IdDepartamento)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DLEF.JGarciaProgramacionNCapasEntities context = new JGarciaProgramacionNCapasEntities())
                {
                 
                    var rowAffected = context.DepartamentoGetById(IdDepartamento).SingleOrDefault();

                    result.Objects = new List<object>();

                    if(rowAffected != null)
                    {
                        ML.Departamento depa1 = new ML.Departamento();
                        depa1.IdDepartamento = rowAffected.IdDepartamento;
                        depa1.Nombre = rowAffected.NombreDepartamento;
                        
                        depa1.Area = new ML.Area();
                        depa1.Area.IdArea = rowAffected.IdArea;
                        depa1.Area.Nombre = rowAffected.NombreArea;

                        result.Object = depa1;

                        result.Correct = true;
                    }

                }
            }
            catch( Exception ex )
            {
                result.Correct = false;
                result.ErrorMassage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }


        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DLEF.JGarciaProgramacionNCapasEntities context = new DLEF.JGarciaProgramacionNCapasEntities())
                {
                    var query = context.DepartamentoGetAlldpl().ToList();

                    if (query != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var registro in query)
                        {
                            ML.Departamento departamento = new ML.Departamento();

                            departamento.IdDepartamento = registro.IdDepartamento;
                            departamento.Nombre = registro.Nombre;


                            result.Objects.Add(departamento);
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
