
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
    }
}
