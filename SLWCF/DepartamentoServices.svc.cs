using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SLWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "DepartamentoServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione DepartamentoServices.svc o DepartamentoServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class DepartamentoServices : IDepartamentoServices
    {
        public SLWCF.Result Add(ML.Departamento departamento)
        {
            ML.Result result = BL.Departamento.DepartamentoAdd(departamento);

            return new SLWCF.Result
            {
                ErrorMassage = result.ErrorMassage,
                Correct = result.Correct,
                Objects = result.Objects,
                Object = result.Object,
                Ex = result.Ex,
            };
        }

        public SLWCF.Result Delete(ML.Departamento departamento)
        {
            ML.Result result = BL.Departamento.DepartamentoDell(departamento.IdDepartamento);

            return new SLWCF.Result
            {
                ErrorMassage = result.ErrorMassage,
                Correct = result.Correct,
                Objects = result.Objects,
                Object = result.Object,
                Ex = result.Ex,
            };
        }

        public SLWCF.Result Update(ML.Departamento departamento)
        {
            ML.Result result = BL.Departamento.DepartamentoUpdate(departamento);

            return new SLWCF.Result
            {
                ErrorMassage = result.ErrorMassage,
                Correct = result.Correct,
                Objects = result.Objects,
                Object = result.Object,
                Ex = result.Ex,
            };
        }

        public Result GetAll(ML.Departamento departamento)
        {
            ML.Result result = BL.Departamento.DepartamentoGetAll(departamento);

            return new Result
            {
                Correct = result.Correct,
                Objects = result.Objects,
                Object = result.Object,
                ErrorMassage = result.ErrorMassage,
                Ex = result.Ex,
            };
        }

        public Result GetById(ML.Departamento departamento)
        {
            ML.Result result = BL.Departamento.DepartamentoGetById(departamento.IdDepartamento);

            return new Result
            {
                Correct = result.Correct,
                Objects = result.Objects,
                Object = result.Object,
                ErrorMassage = result.ErrorMassage,
                Ex = result.Ex,
            };
        }

    }
}
