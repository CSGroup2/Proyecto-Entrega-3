
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class Datos_Peticion
    {
        Conexion con = new Conexion();  //Objeto conexion para conectar la BD

        //consulta la cedula del usuario en la base de datos
        public string consultarCedula(int v)
        {
            string ced = "";
            SqlConnection conexion = con.abrir_conexion();
            try 
            {
                SqlCommand cmd = new SqlCommand("SELECT P.CEDULA FROM PERSONA P, CLIENTE C WHERE (P.ID_PERSONA=C.ID_PERSONA AND C.ID_ESTADO=1) AND C.ID_CLIENTE=@ID;", conexion);
                cmd.Parameters.AddWithValue("@ID", v);
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.Read())
                {
                    ced = registro["CEDULA"].ToString();
                }
            } catch (Exception ex)
            {
                con.cerrar_conexion(conexion);
            }
            finally
            {
                con.cerrar_conexion(conexion);
            }
            return ced;
        }

        //inserta la peticion en la base de datos
        public string insetarPeticion(Peticion peticion)
        {
            string msj = "";
            SqlConnection conexion = con.abrir_conexion();
            try
            {
                if (peticion != null)
                {
                    //comando
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conexion;
                    comando.CommandText = "sp_insertar_peticion";
                    comando.CommandType = CommandType.StoredProcedure;

                    SqlParameter param_cliente = new SqlParameter();
                    param_cliente.ParameterName = "@id_cliente";
                    param_cliente.SqlDbType = SqlDbType.Int;
                    param_cliente.Value = peticion.Cliente.Id_cliente;
                    comando.Parameters.Add(param_cliente);

                    SqlParameter param_id_tipo_ambulancia = new SqlParameter();
                    param_id_tipo_ambulancia.ParameterName = "@id_tipo_ambulancia";
                    param_id_tipo_ambulancia.SqlDbType = SqlDbType.Int;
                    param_id_tipo_ambulancia.Value = peticion.Id_tipo_ambulancia;
                    comando.Parameters.Add(param_id_tipo_ambulancia);

                    SqlParameter param_n_ambulancias = new SqlParameter();
                    param_n_ambulancias.ParameterName = "@n_ambulancias";
                    param_n_ambulancias.SqlDbType = SqlDbType.Int;
                    param_n_ambulancias.Value = peticion.N_ambulancia;
                    comando.Parameters.Add(param_n_ambulancias);

                    SqlParameter param_punto_origen = new SqlParameter();
                    param_punto_origen.ParameterName = "@punto_origen";
                    param_punto_origen.SqlDbType = SqlDbType.VarChar;
                    param_punto_origen.Value = peticion.Punto_origen;
                    comando.Parameters.Add(param_punto_origen);

                    SqlParameter param_punto_destino = new SqlParameter();
                    param_punto_destino.ParameterName = "@punto_destino";
                    param_punto_destino.SqlDbType = SqlDbType.VarChar;
                    param_punto_destino.Value = peticion.Punto_destino;
                    comando.Parameters.Add(param_punto_destino);

                    SqlParameter param_condicion = new SqlParameter();
                    param_condicion.ParameterName = "@condicion";
                    param_condicion.SqlDbType = SqlDbType.VarChar;
                    param_condicion.Value = peticion.Condicion;
                    comando.Parameters.Add(param_condicion);

                    comando.ExecuteNonQuery();
                    msj = "1";
                }
            }
            catch (Exception ex) 
            {
                con.cerrar_conexion(conexion);
                msj = "OCURRIO UN ERROR " + ex.Message;
            }
            return msj;
        }

        // consulta las penticiones en progreso de la base de datos
        public object listarPeticionesPendientes()
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = con.abrir_conexion();
            try
            {
                using (SqlCommand comando = new SqlCommand("sp_listar_peticiones_progreso", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                dt = null;
                Console.WriteLine("Error al listar las peticiones " + ex.Message);
            }
            return dt;
        }

        public object listarPeticionesPendientesUsuario(int idCliente)
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = con.abrir_conexion();
            try
            {
                using (SqlCommand comando = new SqlCommand("sp_listar_peticiones_pend_usuario", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlParameter param_id = new SqlParameter();
                    param_id.ParameterName = "@idC";
                    param_id.SqlDbType = SqlDbType.Int;
                    param_id.Value = idCliente;
                    comando.Parameters.Add(param_id);
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                dt = null;
                Console.WriteLine("Error al listar las peticiones " + ex.Message);
            }
            return dt;
        }

        public Peticion ConsultarPeticionXId(int idPet)
        {
            Peticion p = new Peticion();
            Cliente c = new Cliente();
            SqlConnection conexion = con.abrir_conexion();
            try
            {
                //comando
                SqlDataReader dr = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "sp_consultar_peticion_x_id";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter param_id = new SqlParameter();
                param_id.ParameterName = "@idP";
                param_id.SqlDbType = SqlDbType.Int;
                param_id.Value = idPet;
                comando.Parameters.Add(param_id);
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    c = new Cliente();
                    c.Cedula = dr["Cedula"].ToString();
                    c.Nombre_1 = dr["Nombre"].ToString();
                    c.Apellido_1 = dr["Apellido"].ToString();
                    
                    p = new Peticion();
                    p.Cliente = c;
                    p.Id_tipo_ambulancia = Convert.ToInt32(dr["Tipo_Ambulancia"]);
                    p.N_ambulancia = Convert.ToInt32(dr["Cant_Ambulancias"]);
                    p.Punto_origen = dr["Punto_Origen"].ToString();
                    p.Punto_destino = dr["Punto_Destino"].ToString();
                }
            }
            catch (Exception ex)
            {
                con.cerrar_conexion(conexion);
                Console.WriteLine("Error al consultar en la placa " + ex.Message);
            }
            return p;
        }

        public string editarPeticion(int idPet, int cant, int id_TA, string punto_Origen, string punto_Destino)
        {
            string msj = "";
            SqlConnection conexion = con.abrir_conexion();
            try
            {
                //comando
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "sp_editar_peticion";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter param_id = new SqlParameter();
                param_id.ParameterName = "@idP";
                param_id.SqlDbType = SqlDbType.Int;
                param_id.Value = idPet;
                comando.Parameters.Add(param_id);

                SqlParameter param_id_tipo_ambulancia = new SqlParameter();
                param_id_tipo_ambulancia.ParameterName = "@id_tipo_ambulancia";
                param_id_tipo_ambulancia.SqlDbType = SqlDbType.Int;
                param_id_tipo_ambulancia.Value = id_TA;
                comando.Parameters.Add(param_id_tipo_ambulancia);

                SqlParameter param_n_ambulancias = new SqlParameter();
                param_n_ambulancias.ParameterName = "@n_ambulancias";
                param_n_ambulancias.SqlDbType = SqlDbType.Int;
                param_n_ambulancias.Value = cant;
                comando.Parameters.Add(param_n_ambulancias);

                SqlParameter param_punto_origen = new SqlParameter();
                param_punto_origen.ParameterName = "@punto_origen";
                param_punto_origen.SqlDbType = SqlDbType.VarChar;
                param_punto_origen.Value = punto_Origen;
                comando.Parameters.Add(param_punto_origen);

                SqlParameter param_punto_destino = new SqlParameter();
                param_punto_destino.ParameterName = "@punto_destino";
                param_punto_destino.SqlDbType = SqlDbType.VarChar;
                param_punto_destino.Value = punto_Destino;
                comando.Parameters.Add(param_punto_destino);

                comando.ExecuteNonQuery();
                msj = "1";
            }
            catch (Exception ex)
            {
                con.cerrar_conexion(conexion);
                msj = "OCURRIO UN ERROR " + ex.Message;
            }
            return msj;
        }

        public object listarPeticionesXDestino(string destino, int idCliente)
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = con.abrir_conexion();
            try
            {
                using (SqlCommand comando = new SqlCommand("sp_listar_peticiones_destino", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    SqlParameter param_destino = new SqlParameter();
                    param_destino.ParameterName = "@destino";
                    param_destino.SqlDbType = SqlDbType.VarChar;
                    param_destino.Value = destino;
                    comando.Parameters.Add(param_destino);

                    SqlParameter param_id = new SqlParameter();
                    param_id.ParameterName = "@idC";
                    param_id.SqlDbType = SqlDbType.Int;
                    param_id.Value = idCliente;
                    comando.Parameters.Add(param_id);

                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                dt = null;
                con.cerrar_conexion(conexion);
                Console.WriteLine("Error al listar las peticiones " + ex.Message);
            }
            return dt;
        }
    }
}
