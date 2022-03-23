using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class Datos_Cliente
    {
        //NOTA: Esta clase es creada para realizar solamente las operaciones de base de datos, como insertar,
        //consultar, eliminar, editar, etc.

        Conexion con = new Conexion();

        //metodo para insertar la informacion pasado desde la capa de control a la base de datos
        public string insertarDatosCliente(Cliente cliente)
        {
            Conexion conexion = null;
            SqlConnection sql_conexion = null;
            SqlCommand sql_comando = null;
            string mensaje = "";
            string procedimeinto = "sp_insertar_cliente";  // Stored Procedure name
            try
            {
                conexion = new Conexion();
                sql_conexion = conexion.abrir_conexion();              // Opens conexion to sql server
                sql_comando = new SqlCommand(procedimeinto, sql_conexion);     // Creatin SqlCommand object
                sql_comando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                if (cliente != null)
                {
                    // Adding values to paramerters to SqlCommand below
                    sql_comando.Parameters.AddWithValue("@cedula", cliente.Cedula);
                    sql_comando.Parameters.AddWithValue("@nombre_1", cliente.Nombre_1);
                    sql_comando.Parameters.AddWithValue("@nombre_2", cliente.Nombre_2);
                    sql_comando.Parameters.AddWithValue("@apellido_1", cliente.Apellido_1);
                    sql_comando.Parameters.AddWithValue("@apellido_2", cliente.Apellido_2);
                    sql_comando.Parameters.AddWithValue("@sexo", cliente.Sexo);
                    sql_comando.Parameters.AddWithValue("@fecha_nac", cliente.Fecha_nac);
                    sql_comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
                    sql_comando.Parameters.AddWithValue("@nombre_usuario", cliente.Usuario.Nombre_usuario);
                    sql_comando.Parameters.AddWithValue("@correo", cliente.Usuario.Correo);
                    sql_comando.Parameters.AddWithValue("@contrasenia", cliente.Usuario.Contrasenia);
                    sql_comando.Parameters.AddWithValue("@id_hospital", cliente.Id_hospital);
                    mensaje = Convert.ToString(sql_comando.ExecuteNonQuery());
                    if (mensaje == "-1")
                    {
                        // ¡Error el numero de cedula o usuario ya existen! \n DATOS NO GUARDADOS
                        // Este numero de cedula ya esta registrado
                        //Este nombre de usuario ya existe
                        //Registro exitoso
                        mensaje = "¡Error el numero de cedula o usuario ya existen! \n DATOS NO GUARDADOS";
                    }
                    else
                    {
                        mensaje = "DATOS GUARDADOS CORRECTAMENTE.";
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "OCURRIO UN ERROR. \n" + ex.Message;
            }
            finally
            {
                conexion.cerrar_conexion(sql_conexion);
            }
            return mensaje;
        }

        //metodo para listar todos los clientes
        public DataTable ListarClientes()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlconn = con.abrir_conexion();
            try
            {
                using (SqlCommand comando = new SqlCommand("sp_listar_clientes", sqlconn))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                dt = null;
                Console.WriteLine("Error al listar los clientes" + ex.Message);
            }
            finally
            {
                con.cerrar_conexion(sqlconn);
            }

            return dt;
        }

        // metodo de consulta de cliente por los filtros 
        public DataTable ConsultarClientes(string dato, int estado, int hospital, int buscarOb, int buscarOp)
        {
            DataTable dt = new DataTable();
            SqlConnection c1 = con.abrir_conexion();
            try
            {
                using (SqlCommand comando = new SqlCommand("sp_consultar_clientes", c1))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new SqlParameter("@opcionA", buscarOb));
                    comando.Parameters.Add(new SqlParameter("@opcionB", buscarOp));
                    comando.Parameters.Add(new SqlParameter("@dato", dato));
                    comando.Parameters.Add(new SqlParameter("@estado", estado));
                    comando.Parameters.Add(new SqlParameter("@hospital", hospital));
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                dt = null;
                Console.WriteLine("Error al consultar los Clientes " + ex.Message);
            }
            finally
            {
                con.cerrar_conexion(c1);
            }

            return dt;
        }


        public string eliminarcliente(int idcliente)
        {
            Conexion conexion = null;
            SqlConnection sql_conexion = null;
            SqlCommand sql_comando = null;
            string mensaje = "";
            string procedimeinto = "sp_eliminar_clientes";  // Stored Procedure name
            try
            {
                conexion = new Conexion();
                sql_conexion = conexion.abrir_conexion();              // Opens conexion to sql server
                sql_comando = new SqlCommand(procedimeinto, sql_conexion);     // Creatin SqlCommand object
                sql_comando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                    // Adding values to paramerters to SqlCommand below
                sql_comando.Parameters.AddWithValue("@idcliente", idcliente);
                   
                    int cant = sql_comando.ExecuteNonQuery();
                    if (cant != 0)
                    {
                        mensaje = "El cliente se ha eliminado con exito";
                    }
                    else
                    {
                        mensaje = "Error al eliminar, intentalo mas tarde";
                    }
                    conexion.cerrar_conexion(sql_conexion);
            }
            catch (Exception ex)
            {
                mensaje = "OCURRIO UN ERROR. \n" + ex.Message;
                conexion.cerrar_conexion(sql_conexion);
            }
            finally
            {
                conexion.cerrar_conexion(sql_conexion);
            }
            return mensaje;
        }

        // metodo de busca de cliente por ID 
        public DataTable buscarClienteID(int idcliente)
        {
            DataTable dt = new DataTable();
            SqlConnection c1 = con.abrir_conexion();
            try
            {
                using (SqlCommand comando = new SqlCommand("sp_cliente_buscarDatosPorId", c1))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new SqlParameter("@idcliente", idcliente));
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                dt = null;
                Console.WriteLine("Error al consultar el Clientes " + ex.Message);
            }
            finally
            {
                con.cerrar_conexion(c1);
            }
            return dt;
        }

    }
}
