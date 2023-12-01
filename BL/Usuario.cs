using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Configuration;
using ML;
using System.Collections.ObjectModel;
using System.Runtime.Remoting.Messaging;
using Microsoft.SqlServer.Server;
using System.Runtime.InteropServices.ComTypes;
using DLEF;
using System.Runtime.Remoting.Contexts;
using Microsoft.Win32;
using System.Data.Entity.Core.Objects;
using System.Data.OleDb;
using System.Reflection.Emit;

namespace BL
{
    public class Usuario
    {
        // sql client
        //public static ML.Result Add(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "INSERT INTO Usuario VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @FechaNacimiento, @Profesion, @Promedio)";

        //            SqlCommand cmd = new SqlCommand(query, context);

        //            SqlParameter[] collection = new SqlParameter[6];

        //            collection[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
        //            collection[0].Value = usuario.Nombre;
        //            collection[1] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
        //            collection[1].Value = usuario.ApellidoPaterno;
        //            collection[2] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
        //            collection[2].Value = usuario.ApellidoMaterno;
        //            collection[3] = new SqlParameter("@FechaNacimiento", SqlDbType.Date);
        //            collection[3].Value = usuario.FechaNacimiento;
        //            collection[4] = new SqlParameter("@Profesion", SqlDbType.VarChar);
        //            collection[4].Value = usuario.Profesion;
        //            collection[5] = new SqlParameter("@Promedio", SqlDbType.Float);
        //            collection[5].Value = usuario.Promedio;

        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();

        //            int filasAfectadas = cmd.ExecuteNonQuery();

        //            if (filasAfectadas > 0)
        //            {
        //                result.Correct = true;

        //            }
        //            else
        //            {
        //                result.Correct = false;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMassage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}

        //public static ML.Result Dell(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "DELETE FROM [dbo].[Usuario] WHERE IdUsuario = @IdUsuario";

        //            SqlCommand cmd = new SqlCommand(query, conn);

        //            SqlParameter[] collection = new SqlParameter[1];

        //            collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
        //            collection[0].Value = usuario.IdUsuario;

        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();

        //            int filasAfectadas = cmd.ExecuteNonQuery();

        //            if (filasAfectadas > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMassage = "Error al eliminar";
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMassage = ex.Message;
        //        result.Ex = ex;

        //    }
        //    return result;
        //}

        //public static ML.Result Update(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "UPDATE [dbo].[Usuario] set [Nombre] = @Nombre, [ApellidoPaterno] = @ApellidoPaterno, [ApellidoMaterno] = @ApellidoMaterno, [FechaNacimiento] = @FechaNacimiento,  [Profesion] = @Profesion, [Promedio] = @Promedio WHERE IdUsuario = @IdUsuario ";
        //            SqlCommand cmd = new SqlCommand();

        //            cmd.Connection = context;
        //            cmd.CommandText = query;

        //            SqlParameter[] collection = new SqlParameter[7];

        //            collection[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
        //            collection[0].Value = usuario.Nombre;
        //            collection[1] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
        //            collection[1].Value = usuario.ApellidoPaterno;
        //            collection[2] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
        //            collection[2].Value = usuario.ApellidoMaterno;
        //            collection[3] = new SqlParameter("@FechaNacimiento", SqlDbType.Date);
        //            collection[3].Value = usuario.FechaNacimiento;
        //            collection[4] = new SqlParameter("@Profesion", SqlDbType.VarChar);
        //            collection[4].Value = usuario.Profesion;
        //            collection[5] = new SqlParameter("@Promedio", SqlDbType.Float);
        //            collection[5].Value = usuario.Promedio;

        //            collection[6] = new SqlParameter("@IdUsuario", SqlDbType.Int);
        //            collection[6].Value = usuario.Promedio;

        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();

        //            int rowaffected = cmd.ExecuteNonQuery();

        //            if (rowaffected > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMassage = "Error al actualizar";
        //            }
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        result.Correct = false;
        //        result.ErrorMassage = e.Message;
        //        result.Ex = e;
        //    }
        //    return result;
        //}

        //public static ML.Result GetAll()
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "SELECT [IdUsuario] ,[Nombre] ,[ApellidoPaterno] ,[ApellidoMaterno] ,[FechaNacimiento] ,[Profesion] ,[Promedio] FROM [dbo].[Usuario]";

        //            SqlCommand cmd = new SqlCommand(query, context);

        //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        //            DataTable tableUsuarios = new DataTable();

        //            adapter.Fill(tableUsuarios);

        //            if (tableUsuarios.Rows.Count > 0)
        //            {
        //                result.Objects = new List<object>();

        //                foreach (DataRow row in tableUsuarios.Rows)
        //                {
        //                    ML.Usuario usuario = new ML.Usuario();

        //                    usuario.IdUsuario = int.Parse(row[0].ToString()); //0
        //                    usuario.Nombre = row[1].ToString();                 //1
        //                    usuario.ApellidoPaterno = row[2].ToString();        //2
        //                    usuario.ApellidoMaterno = row[3].ToString();        //3
        //                    usuario.FechaNacimiento = DateTime.Parse(row[4].ToString());//4
        //                    usuario.Profesion = row[5].ToString();                      //5
        //                    usuario.Promedio = float.Parse(row[6].ToString());          //6

        //                    result.Objects.Add(usuario); //aqui guardamos los datos en el ML para despues usarlos
        //                }

        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        result.Correct = false;
        //        result.ErrorMassage = e.Message;
        //        result.Ex = e;
        //    }
        //    return result;

        //}

        //public static ML.Result GetById(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection conect = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "SELECT [Nombre], [ApellidoPaterno], [ApellidoMaterno], [FechaNacimiento], [Profesion], [Promedio] FROM [dbo].[Usuario] WHERE [IdUsuario] = @IdUsuario";

        //            SqlCommand cmd = new SqlCommand(query, conect);

        //            //aqui ingresa el dato en este caso el Id
        //            SqlParameter[] param = new SqlParameter[1];

        //            param[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
        //            param[0].Value = usuario.IdUsuario; //El id se resube y se guarda dentro del parametro

        //            cmd.Parameters.AddRange(param);
        //            cmd.Connection.Open();

        //            SqlDataAdapter adapter = new SqlDataAdapter(cmd); //recibimos los datos de la BD 

        //            DataTable tablaUsuario = new DataTable(); //creamos la tabla para guardarlos

        //            adapter.Fill(tablaUsuario); //llenamos la tabla


        //            if (tablaUsuario.Rows.Count > 0) //SI {en caso de haber filas afectas > 0 }
        //            {
        //                DataRow row = tablaUsuario.Rows[0];

        //                ML.Usuario usuario1 = new ML.Usuario();

        //                usuario1.Nombre = row[0].ToString();
        //                usuario1.ApellidoPaterno = row[1].ToString();
        //                usuario1.ApellidoMaterno = row[2].ToString();
        //                usuario1.FechaNacimiento = DateTime.Parse(row[3].ToString());
        //                usuario1.Profesion = row[4].ToString();
        //                usuario1.Promedio = float.Parse(row[5].ToString());

        //                //boxing guardamos las variables en el objeto
        //                result.Object = usuario1;

        //                result.Correct = true;

        //            }
        //            else
        //            {
        //                result.Correct = false;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMassage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}

        //los metodos con SPROCEDEUS

        //public static ML.Result AddSP(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "[dbo].[UsuarioAdd]";

        //            SqlCommand cmd = new SqlCommand(query, context);

        //            cmd.CommandType = CommandType.StoredProcedure;

        //            SqlParameter[] collection = new SqlParameter[7];

        //            collection[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
        //            collection[0].Value = usuario.Nombre;

        //            collection[1] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
        //            collection[1].Value = usuario.ApellidoPaterno;

        //            collection[2] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
        //            collection[2].Value = usuario.ApellidoMaterno;

        //            collection[3] = new SqlParameter("@FechaNacimiento", SqlDbType.Date);
        //            collection[3].Value = usuario.FechaNacimiento;

        //            collection[4] = new SqlParameter("@Profesion", SqlDbType.VarChar);
        //            collection[4].Value = usuario.Profesion;

        //            collection[5] = new SqlParameter("@Promedio", SqlDbType.Float);
        //            collection[5].Value = usuario.Promedio;

        //            collection[6] = new SqlParameter("@idRol", SqlDbType.Int);
        //            collection[6].Value = usuario.Rol.idRol;

        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();

        //            int filasAfectadas = cmd.ExecuteNonQuery();

        //            if (filasAfectadas > 0)
        //            {
        //                result.Correct = true;

        //            }
        //            else
        //            {
        //                result.Correct = false;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMassage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}

        //public static ML.Result DellSP(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "[dbo].[UsuarioDell]";

        //            SqlCommand cmd = new SqlCommand(query, conn);

        //            cmd.CommandType = CommandType.StoredProcedure;

        //            SqlParameter[] collection = new SqlParameter[1];

        //            collection[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
        //            collection[0].Value = usuario.IdUsuario;

        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();

        //            int filasAfectadas = cmd.ExecuteNonQuery();

        //            if (filasAfectadas > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMassage = "Error al eliminar";
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMassage = ex.Message;
        //        result.Ex = ex;

        //    }
        //    return result;
        //}

        //public static ML.Result UpdateSP(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "UsuarioUpdate";

        //            SqlCommand cmd = new SqlCommand();

        //            cmd.CommandType = CommandType.StoredProcedure;

        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Connection = context;
        //            cmd.CommandText = query;

        //            SqlParameter[] collection = new SqlParameter[8];

        //            collection[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
        //            collection[0].Value = usuario.Nombre;
        //            collection[1] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
        //            collection[1].Value = usuario.ApellidoPaterno;
        //            collection[2] = new SqlParameter("@ApellidoMaterno", SqlDbType.VarChar);
        //            collection[2].Value = usuario.ApellidoMaterno;
        //            collection[3] = new SqlParameter("@FechaNacimiento", SqlDbType.Date);
        //            collection[3].Value = usuario.FechaNacimiento;
        //            collection[4] = new SqlParameter("@Profesion", SqlDbType.VarChar);
        //            collection[4].Value = usuario.Profesion;
        //            collection[5] = new SqlParameter("@Promedio", SqlDbType.Float);
        //            collection[5].Value = usuario.Promedio;
        //            collection[6] = new SqlParameter("@idRol", SqlDbType.Int);
        //            collection[6].Value = usuario.Rol.idRol;

        //            collection[7] = new SqlParameter("@IdUsuario", SqlDbType.Int);
        //            collection[7].Value = usuario.Promedio;

        //            cmd.Parameters.AddRange(collection);
        //            cmd.Connection.Open();

        //            int rowaffected = cmd.ExecuteNonQuery();

        //            if (rowaffected > 0)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMassage = "Error al actualizar";
        //            }
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        result.Correct = false;
        //        result.ErrorMassage = e.Message;
        //        result.Ex = e;
        //    }
        //    return result;
        //}

        //public static ML.Result GetAllSP()
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "UsuarioGetAll";

        //            SqlCommand cmd = new SqlCommand(query, context);

        //            cmd.CommandType = CommandType.StoredProcedure;

        //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        //            DataTable tableUsuarios = new DataTable();

        //            adapter.Fill(tableUsuarios);

        //            if (tableUsuarios.Rows.Count > 0)
        //            {
        //                result.Objects = new List<object>();

        //                foreach (DataRow row in tableUsuarios.Rows)
        //                {
        //                    ML.Usuario usuario = new ML.Usuario();

        //                    usuario.IdUsuario = int.Parse(row[0].ToString()); //0
        //                    usuario.Nombre = row[1].ToString();                 //1
        //                    usuario.ApellidoPaterno = row[2].ToString();        //2
        //                    usuario.ApellidoMaterno = row[3].ToString();        //3
        //                    usuario.FechaNacimiento = DateTime.Parse(row[4].ToString());//4
        //                    usuario.Profesion = row[5].ToString();                      //5
        //                    usuario.Promedio = float.Parse(row[6].ToString());          //6

        //                    usuario.Rol = new Roll(); //instanciamos (creamos el valor para llenarlo en la linea de abajo
        //                    usuario.Rol.idRol = int.Parse(row[7].ToString());

        //                    result.Objects.Add(usuario); //aqui guardamos los datos en el ML para despues usarlos
        //                }

        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        result.Correct = false;
        //        result.ErrorMassage = e.Message;
        //        result.Ex = e;
        //    }
        //    return result;

        //}

        //public static ML.Result GetByIdSP(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (SqlConnection conect = new SqlConnection(DL.Conexion.GetConnectionString()))
        //        {
        //            string query = "UsuarioGetById";

        //            SqlCommand cmd = new SqlCommand(query, conect);

        //            cmd.CommandType = CommandType.StoredProcedure;

        //            //aqui ingresa el dato en este caso el Id
        //            SqlParameter[] param = new SqlParameter[1];

        //            param[0] = new SqlParameter("@IdUsuario", SqlDbType.Int);
        //            param[0].Value = usuario.IdUsuario; //El id se resube y se guarda dentro del parametro

        //            cmd.Parameters.AddRange(param);
        //            cmd.Connection.Open();

        //            SqlDataAdapter adapter = new SqlDataAdapter(cmd); //recibimos los datos de la BD 

        //            DataTable tablaUsuario = new DataTable(); //creamos la tabla para guardarlos

        //            adapter.Fill(tablaUsuario); //llenamos la tabla


        //            if (tablaUsuario.Rows.Count > 0) //SI {en caso de haber filas afectas > 0 }
        //            {
        //                DataRow row = tablaUsuario.Rows[0];

        //                ML.Usuario usuario1 = new ML.Usuario();

        //                usuario1.Nombre = row[0].ToString();
        //                usuario1.ApellidoPaterno = row[1].ToString();
        //                usuario1.ApellidoMaterno = row[2].ToString();
        //                usuario1.FechaNacimiento = DateTime.Parse(row[3].ToString());
        //                usuario1.Profesion = row[4].ToString();
        //                usuario1.Promedio = float.Parse(row[5].ToString());

        //                usuario1.Rol = new Roll(); //instanciamos para que podamos traer el valor
        //                usuario1.Rol.idRol = int.Parse(row[6].ToString());

        //                //boxing guardamos las variables en el objeto
        //                result.Object = usuario1;

        //                result.Correct = true;

        //            }
        //            else
        //            {
        //                result.Correct = false;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMassage = ex.Message;
        //        result.Ex = ex;
        //    }
        //    return result;
        //}

        //los metodos con EF (Entitty Framework)

        public static ML.Result AddEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.JGarciaProgramacionNCapasEntities context = new DLEF.JGarciaProgramacionNCapasEntities())
                {
                    ObjectParameter filasfectadas = new ObjectParameter("FilasAfectadas", typeof(int));

                    int rowAffected = context.UsuarioAdd(
                        usuario.UserName,
                        usuario.Nombre, 
                        usuario.ApellidoPaterno, 
                        usuario.ApellidoMaterno,
                        usuario.Email,
                        usuario.Password,
                        usuario.Sexo,
                        usuario.Telefono,
                        usuario.Celular,
                        usuario.FechaNacimiento,
                        usuario.CURP,
                        usuario.Rol.idRol,
                        usuario.Direccion.Calle,
                        usuario.Direccion.NumeroInterior,
                        usuario.Direccion.NumeroExterior,
                        usuario.Direccion.Colonia.IdColonia,
                        usuario.Imagen,
                        filasfectadas
                        );

                    if (rowAffected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMassage = "Error al ingresar el usuario";
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

        public static ML.Result UpdateEF(ML.Usuario usuario)
        {
            ML.Result result = new Result();
            try
            {
                using (DLEF.JGarciaProgramacionNCapasEntities context = new DLEF.JGarciaProgramacionNCapasEntities())
                {
                    ObjectParameter filasAfectadas = new ObjectParameter("FilasAfectadas",typeof(int));
                    int rowAffected = context.UsuarioUpdate(
                        usuario.IdUsuario,
                        usuario.UserName,
                        usuario.Nombre,
                        usuario.ApellidoPaterno,
                        usuario.ApellidoMaterno,
                        usuario.Email,
                        usuario.Password,
                        usuario.Sexo,
                        usuario.Telefono,
                        usuario.Celular,
                        usuario.FechaNacimiento,
                        usuario.CURP,
                        usuario.Rol.idRol,
                        usuario.Direccion.Calle,
                        usuario.Direccion.NumeroInterior,
                        usuario.Direccion.NumeroExterior,
                        usuario.Direccion.Colonia.IdColonia,
                        usuario.Imagen,
                        filasAfectadas
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

        public static ML.Result  DellEF(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.JGarciaProgramacionNCapasEntities context = new DLEF.JGarciaProgramacionNCapasEntities())
                {
                    ObjectParameter filasAfectadas = new ObjectParameter("FilasAfectadas",typeof(int));
                    var query = context.UsuarioDell(IdUsuario,filasAfectadas);
                    if(query > 0)
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

        public static  ML.Result GetAllEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DLEF.JGarciaProgramacionNCapasEntities context = new DLEF.JGarciaProgramacionNCapasEntities())
                {
                    var query = context.UsuarioGetAll(usuario.Nombre,usuario.ApellidoPaterno).ToList();

                    if(query != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var registro in query)
                        {
                            ML.Usuario usuario1 = new ML.Usuario();
                            
                            usuario1.IdUsuario = registro.IdUsuario;
                            usuario1.UserName = registro.UserName;
                            usuario1.Nombre = registro.Nombre;
                            usuario1.ApellidoPaterno = registro.ApellidoPaterno;
                            usuario1.ApellidoMaterno = registro.ApellidoMaterno;
                            usuario1.Email = registro.Email;
                            usuario1.Password = registro.Password;
                            usuario1.Sexo = registro.Sexo;
                            usuario1.Telefono = registro.Telefono;
                            usuario1.Celular = registro.Celular;
                            usuario1.FechaNacimiento = registro.FechaNacimineto.Value;
                            usuario1.CURP = registro.CURP;
                            usuario1.Imagen = registro.Imagen;
                            usuario1.Status = registro.Status;
                            
                            usuario1.Rol = new Roll();
                            usuario1.Rol.idRol = (int)registro.idRol;
                            usuario1.Rol.Nombre = registro.NombreRol;
                            //direccion
                            usuario1.Direccion = new ML.Direccion();
                            usuario1.Direccion.IdDireccion = (int)registro.IdDireccion;
                            usuario1.Direccion.Calle = registro.Calle;
                            usuario1.Direccion.NumeroInterior = registro.NumeroInterior;
                            usuario1.Direccion.NumeroExterior = registro.NumeroExterior;
                            //colonia
                            usuario1.Direccion.Colonia = new ML.Colonia();
                            usuario1.Direccion.Colonia.IdColonia = (int)registro.IdColonia;
                            usuario1.Direccion.Colonia.Nombre = registro.NombreColonia;
                            //codigo postal no usamos
                            //municipio
                            usuario1.Direccion.Colonia.Municipio = new ML.Municipio();
                            usuario1.Direccion.Colonia.Municipio.IdMunicipio = (int)registro.IdMunicipio;
                            usuario1.Direccion.Colonia.Municipio.Nombre = registro.NombreMunicipio;
                            //Estado
                            usuario1.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                            usuario1.Direccion.Colonia.Municipio.Estado.IdEstado = (int)registro.IdEstado;
                            usuario1.Direccion.Colonia.Municipio.Estado.Nombre = registro.NombreEstado;
                            //Pais
                            usuario1.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
                            usuario1.Direccion.Colonia.Municipio.Estado.Pais.IdPais = (int)registro.IdPais;
                            usuario1.Direccion.Colonia.Municipio.Estado.Pais.Nombre = registro.NombrePais;

                            result.Objects.Add(usuario1);
                        }
                        result.Correct = true;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct=false;
                result.ErrorMassage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result GetByIdEF(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DLEF.JGarciaProgramacionNCapasEntities context = new DLEF.JGarciaProgramacionNCapasEntities())
                {
                    var query = context.UsuarioGetById(IdUsuario).SingleOrDefault();

                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        ML.Usuario usuario2 = new ML.Usuario();
                        usuario2.IdUsuario = query.IdUsuario;
                        usuario2.UserName = query.UserName;
                        usuario2.Nombre = query.Nombre;
                        usuario2.ApellidoPaterno = query.ApellidoPaterno;
                        usuario2.ApellidoMaterno = query.ApellidoMaterno;
                        usuario2.Email = query.Email;
                        usuario2.Password = query.Password;
                        usuario2.Sexo = query.Sexo;
                        usuario2.Telefono = query.Telefono;
                        usuario2.Celular = query.Celular;
                        usuario2.FechaNacimiento= query.FechaNacimineto.Value;
                        usuario2.CURP = query.CURP;
                        usuario2.Imagen = query.Imagen;
                        usuario2.Status = query.Status;
                        //rol
                        usuario2.Rol = new Roll();
                        usuario2.Rol.idRol = Convert.ToInt16(query.idRol);
                        usuario2.Rol.Nombre = query.NombreRol;
                        //direccion
                        usuario2.Direccion = new ML.Direccion();
                        usuario2.Direccion.IdDireccion = Convert.ToInt16(query.IdDireccion);
                        usuario2.Direccion.Calle = query.Calle;
                        usuario2.Direccion.NumeroInterior = query.NumeroInterior;
                        usuario2.Direccion.NumeroExterior = query.NumeroExterior;
                        //colonia
                        usuario2.Direccion.Colonia = new ML.Colonia();
                        usuario2.Direccion.Colonia.IdColonia = Convert.ToInt16(query.IdColonia);
                        usuario2.Direccion.Colonia.Nombre = query.NombreColonia;
                        //municipio
                        usuario2.Direccion.Colonia.Municipio = new ML.Municipio();
                        usuario2.Direccion.Colonia.Municipio.IdMunicipio = Convert.ToInt16(query.IdMunicipio);
                        usuario2.Direccion.Colonia.Municipio.Nombre = query.NombreMunicipio;
                        //Estado
                        usuario2.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                        usuario2.Direccion.Colonia.Municipio.Estado.IdEstado = Convert.ToInt16(query.IdEstado);
                        usuario2.Direccion.Colonia.Municipio.Estado.Nombre = query.NombreEstado;
                        //pais
                        usuario2.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
                        usuario2.Direccion.Colonia.Municipio.Estado.Pais.IdPais = Convert.ToInt16(query.IdPais);
                        usuario2.Direccion.Colonia.Municipio.Estado.Pais.Nombre = query.NombrePais;



                        result.Object = usuario2;

                        result.Correct=true;
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

        public static ML.Result ChangeStatus(int IdUsuario, bool Status)
        {
            ML.Result result= new ML.Result();
            try
            {
                using(DLEF.JGarciaProgramacionNCapasEntities context = new DLEF.JGarciaProgramacionNCapasEntities())
                {
                    var rowAffectad = context.UsuarioChangeStatus(IdUsuario, Status);
                    if(rowAffectad> 0)
                    {
                        result.Correct =true;
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

        public static ML.Result GetByEmail(string Email)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DLEF.JGarciaProgramacionNCapasEntities contex = new DLEF.JGarciaProgramacionNCapasEntities())
                {
                    var query = contex.GetByEmail(Email).FirstOrDefault();

                    if(query != null)
                    {
                        ML.Usuario usuario3 = new ML.Usuario();
                        usuario3.Email = query.Email;
                        usuario3.Password = query.Password;
                        
                        result.Object = usuario3;

                        result.Correct = true;
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct=false;
                result.ErrorMassage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result LeerExcel(string connectionString) 
        {
            ML.Result result = new ML.Result();
            try
            {
                using (OleDbConnection context = new OleDbConnection(connectionString))
                {
                    string query = "SELECT * FROM [Sheet1$]";
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.CommandText = query;
                        cmd.Connection = context;

                        OleDbDataAdapter da = new OleDbDataAdapter();
                        da.SelectCommand = cmd;

                        DataTable tablaUsuario = new DataTable();

                        da.Fill(tablaUsuario);

                        if(tablaUsuario.Rows.Count > 0 )
                        {
                            result.Objects = new List<object>();

                            foreach(DataRow row in tablaUsuario.Rows)
                            {
                                ML.Usuario usuario = new ML.Usuario();
                                usuario.UserName = row[0].ToString();
                                usuario.Nombre = row[1].ToString();
                                usuario.ApellidoPaterno = row[2].ToString();
                                usuario.ApellidoMaterno = row[3].ToString();
                                usuario.Email = row[4].ToString();
                                usuario.Password = row[5].ToString();
                                usuario.Sexo = row[6].ToString();
                                usuario.Telefono = row[7].ToString();
                                usuario.Celular = row[8].ToString();
                                usuario.FechaNacimiento= DateTime.Parse(row[9].ToString());
                                usuario.CURP = row[10].ToString();

                                usuario.Rol = new Roll();
                                usuario.Rol.idRol = Convert.ToInt16(row[11].ToString());

                                usuario.Direccion = new ML.Direccion();
                                usuario.Direccion.Calle = row[12].ToString();
                                usuario.Direccion.NumeroExterior = row[13].ToString();
                                usuario.Direccion.NumeroInterior = row[14].ToString();

                                usuario.Direccion.Colonia = new ML.Colonia();
                                usuario.Direccion.Colonia.IdColonia = Convert.ToInt16(row[15].ToString());

                                result.Objects.Add(usuario);
                            }
                            result.Correct = true;
                        }

                        result.Object = tablaUsuario;

                        if(tablaUsuario.Rows.Count > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                            result.ErrorMassage = "No existen registros en el excel";
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct=false;
                result.ErrorMassage=ex.Message;
            }
            return result;
        }


        public static ML.Result ValidarExcel(List<object> usuarios)
        {
            ML.Result result = new ML.Result();
            try
            {
                result.Objects = new List<object>(); //almaceba los registros incompletos
                int i = 1; //guarda las filas afectadas
                foreach (ML.Usuario usuario in usuarios)
                {
                    ML.ErrorExcel error = new ML.ErrorExcel();
                    error.IdRegistro = i++;
                    if(usuario.UserName == "")
                    {
                        error.Mensaje += "Ingrese el UserName";
                    }
                    if(usuario.Nombre == "")
                    {
                        error.Mensaje += "Ingrese el Nombre";
                    }
                    if(usuario.ApellidoPaterno == "")
                    {
                        error.Mensaje += "Ingrese el Apellido Paterno";
                    }
                    if(usuario.ApellidoMaterno == "")
                    {
                        error.Mensaje += "Ingrese el Apellido Materno";
                    }
                    if(usuario.Email == "")
                    {
                        error.Mensaje += "Ingrese el Email";
                    }
                    if(usuario.Password == "")
                    {
                        error.Mensaje += "Ingrese el Password";
                    }
                    if(usuario.Sexo == "")
                    {
                        error.Mensaje += "Ingrese el Sexo";
                    }
                    if(usuario.Telefono == "")
                    {
                        error.Mensaje += "Ingrese el Telefono";
                    }
                    if(usuario.Celular == "")
                    {
                        error.Mensaje += "Ingrese el Celular";
                    }
                    if(usuario.FechaNacimiento == null)
                    {
                        error.Mensaje += "Ingrese la Fecha de Nacimiento";
                    }
                    if(usuario.CURP == "")
                    {
                        error.Mensaje += "Ingrese el CURP";
                    }
                    if(usuario.Rol.idRol == 0)
                    {
                        error.Mensaje += "Ingrese el Id del Rol";
                    }
                    if(usuario.Direccion.Calle == "")
                    {
                        error.Mensaje += "Ingrese la Calle";
                    }
                    if(usuario.Direccion.NumeroInterior == "")
                    {
                        error.Mensaje += "Ingrese el Nimero Interior";
                    }
                    if(usuario.Direccion.NumeroExterior == "")
                    {
                        error.Mensaje += "Ingrese el Numero Exterior";
                    }
                    if(usuario.Direccion.Colonia.IdColonia == 0)
                    {
                        error.Mensaje += "Ingrese el Id de la Colonia";
                    }

                    if(error.Mensaje != null)
                    {
                        result.Objects.Add(error);
                    }
                }
                result.Correct = true;
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMassage = ex.Message;
            }

            return result;
        }

        //LINQ

        public static ML.Result AddLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.JGarciaProgramacionNCapasEntities context = new DLEF.JGarciaProgramacionNCapasEntities())
                {
                    DLEF.Usuario usuario1 = new DLEF.Usuario();

                    usuario1.UserName = usuario.UserName;
                    usuario1.Nombre = usuario.Nombre;
                    usuario1.ApellidoPaterno = usuario.ApellidoPaterno;
                    usuario1.ApellidoMaterno = usuario.ApellidoMaterno;
                    usuario1.Email = usuario.Email;
                    usuario1.Password = usuario.Password;
                    usuario1.Sexo = usuario.Sexo;
                    usuario1.Telefono = usuario.Telefono;
                    usuario1.Celular = usuario.Celular;
                    usuario1.FechaNacimineto = usuario.FechaNacimiento;
                    usuario1.CURP = usuario.CURP;
                    usuario1.IdRol = usuario.Rol.idRol;

                    context.Usuarios.Add(usuario1);
                    int rowsAffected = context.SaveChanges();

                    if (rowsAffected > 0 )
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct= false;
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

        public static ML.Result DellLINQ( ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.JGarciaProgramacionNCapasEntities context = new DLEF.JGarciaProgramacionNCapasEntities())
                {
                    var query = (from a in context.Usuarios
                                 where a.IdUsuario == usuario.IdUsuario
                                 select a).First();
                    context.Usuarios.Remove(query);
                    context.SaveChanges();
                }
                result.Correct = true;
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMassage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result UpdateLINQ (ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.JGarciaProgramacionNCapasEntities context = new DLEF.JGarciaProgramacionNCapasEntities())
                {
                    var query = (from a in context.Usuarios
                                 where a.IdUsuario == usuario.IdUsuario
                                 select a).SingleOrDefault();
                    if(query != null)
                    {
                        query.UserName = usuario.UserName;
                        query.Nombre = usuario.Nombre;
                        query.ApellidoPaterno = usuario.ApellidoPaterno;
                        query.ApellidoPaterno = usuario.ApellidoPaterno;
                        query.Email = usuario.Email;
                        query.Password = usuario.Password;
                        query.Sexo = usuario.Sexo;
                        query.Telefono = usuario.Telefono;
                        query.Celular = usuario.Celular;
                        query.FechaNacimineto = usuario.FechaNacimiento;
                        query.CURP = usuario.CURP;
                        
                        query.IdRol = usuario.Rol.idRol;

                        context.SaveChanges();

                        result.Correct = true;
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

        public static ML.Result GetAllLINQ()
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DLEF.JGarciaProgramacionNCapasEntities context = new DLEF.JGarciaProgramacionNCapasEntities())
                {
                    var query = ( from Users in context.Usuarios
                                  join Rol in context.Rols on Users.IdRol equals Rol.idRol
                                  select new{
                                      IdUsuario = Users.IdUsuario,
                                      UserName = Users.UserName,
                                      Nombre = Users.Nombre, 
                                      ApellidoPaterno = Users.ApellidoPaterno,
                                      ApellidoMaterno = Users.ApellidoMaterno,
                                      Email = Users.Email,
                                      Password = Users.Password,
                                      Sexo = Users.Sexo,
                                      Telefono = Users.Telefono,
                                      Celular = Users.Celular,
                                      FechaNacimiento = Users.FechaNacimineto,
                                      CURP = Users.CURP,
                                      IdRol = Users.IdRol,
                                      NombreRol = Rol.Nombre,
                                  });
                    
                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var registro in query)
                        {
                            ML.Usuario usuario1 = new ML.Usuario();

                            usuario1.IdUsuario = registro.IdUsuario;
                            usuario1.UserName = registro.UserName;
                            usuario1.Nombre = registro.Nombre;
                            usuario1.ApellidoPaterno = registro.ApellidoPaterno;
                            usuario1.ApellidoMaterno = registro.ApellidoMaterno;
                            usuario1.Email = registro.Email;
                            usuario1.Password = registro.Password;
                            usuario1.Sexo = registro.Sexo;
                            usuario1.Telefono = registro.Telefono;
                            usuario1.Celular = registro.Celular;
                            usuario1.FechaNacimiento = registro.FechaNacimiento.Value;
                            usuario1.CURP = registro.CURP;
                            usuario1.Rol = new Roll();
                            usuario1.Rol.idRol = (int)registro.IdRol;
                            usuario1.Rol.Nombre = registro.NombreRol;

                            result.Objects.Add(usuario1);
                        }
                        result.Correct = true;
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct =false;
                result.ErrorMassage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result GetByIdLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DLEF.JGarciaProgramacionNCapasEntities context = new DLEF.JGarciaProgramacionNCapasEntities())
                {
                    var query = (from Users in context.Usuarios
                                 join Rol in context.Rols on Users.IdRol equals Rol.idRol
                                 join idUsuario in context.Usuarios on Users.IdUsuario equals idUsuario.IdUsuario
                                 where Users.IdUsuario == usuario.IdUsuario
                                 select new
                                 {
                                     IdUsuario = Users.IdUsuario,
                                     UserName = Users.UserName,
                                     Nombre = Users.Nombre,
                                     ApellidoPaterno = Users.ApellidoPaterno,
                                     ApellidoMaterno = Users.ApellidoMaterno,
                                     Email = Users.Email,
                                     Password = Users.Password,
                                     Sexo = Users.Sexo,
                                     Telefono = Users.Telefono,
                                     Celular = Users.Celular,
                                     FechaNacimiento = Users.FechaNacimineto,
                                     CURP = Users.CURP,
                                     IdRol = Users.IdRol,
                                     NombreRol = Rol.Nombre,
                                 }).SingleOrDefault();
                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        
                        ML.Usuario usuario2 = new ML.Usuario();

                        usuario2.UserName = query.UserName;
                        usuario2.Nombre = query.Nombre;
                        usuario2.ApellidoPaterno = query.ApellidoPaterno;
                        usuario2.ApellidoMaterno = query.ApellidoMaterno;
                        usuario2.Email = query.Email;
                        usuario2.Password = query.Password;
                        usuario2.Sexo = query.Sexo;
                        usuario2.Telefono = query.Telefono;
                        usuario2.Celular = query.Celular;
                        usuario2.FechaNacimiento = query.FechaNacimiento.Value;
                        usuario2.CURP = query.CURP;
                        usuario2.Rol = new Roll();
                        usuario.Rol = new Roll();
                        usuario2.Rol.idRol = Convert.ToInt16(query.IdRol);
                        usuario2.Rol.Nombre = query.NombreRol;

                        result.Object = usuario2;

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
