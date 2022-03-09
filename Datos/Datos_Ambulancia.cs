using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class Datos_Ambulancia
    {
        Conexion con = new Conexion();

        //INSERTA REGISTROS DE AMBULANCIAS
        public String InsertarAmbulancia(Ambulancia a)
        {
            string msj = "";
            SqlConnection c1 = con.abrir_conexion();
            try
            {
                if (a != null)
                {
                    //comando
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = c1;
                    comando.CommandText = "sp_insertar_ambulancia";
                    comando.CommandType = CommandType.StoredProcedure;

                    SqlParameter param_placa = new SqlParameter();
                    param_placa.ParameterName = "@placa";
                    param_placa.SqlDbType = SqlDbType.VarChar;
                    param_placa.Value = a.Placa;
                    comando.Parameters.Add(param_placa);

                    SqlParameter param_modelo = new SqlParameter();
                    param_modelo.ParameterName = "@modelo";
                    param_modelo.SqlDbType = SqlDbType.VarChar;
                    param_modelo.Value = a.Modelo;
                    comando.Parameters.Add(param_modelo);

                    SqlParameter param_tipo_ambulancia = new SqlParameter();
                    param_tipo_ambulancia.ParameterName = "@tipo_ambulancia";
                    param_tipo_ambulancia.SqlDbType = SqlDbType.Int;
                    param_tipo_ambulancia.Value = a.Tipo_ambulancia;
                    comando.Parameters.Add(param_tipo_ambulancia);

                    SqlParameter param_capacity = new SqlParameter();
                    param_capacity.ParameterName = "@capacidad";
                    param_capacity.SqlDbType = SqlDbType.Int;
                    param_capacity.Value = a.Capacidad;
                    comando.Parameters.Add(param_capacity);

                    SqlParameter param_observacion = new SqlParameter();
                    param_observacion.ParameterName = "@observacion";
                    param_observacion.SqlDbType = SqlDbType.VarChar;
                    param_observacion.Value = a.Observacion;
                    comando.Parameters.Add(param_observacion);
                    comando.ExecuteNonQuery();
                    msj =  "Los datos se insertaron exitosamente";
                }    
            }
            catch (Exception ex)
            {
                con.cerrar_conexion(c1);
                msj = "Error al insertar en la base de datos " + ex.Message;
            }
            return msj;
        }

        // CONSULTA LOS TIPO DE AMBULANCIA DE LA BD Y DEVUELVE EN DATATABLE
        public DataTable ConsultarTipo()
        {
            DataTable DtResultado = new DataTable("TIPO_AMBULANCIA");
            SqlConnection c1 = con.abrir_conexion();
            try
            {
                string sentencia = "Select * from TIPO_AMBULANCIA where ID_ESTADO = 1";
                SqlCommand comando = new SqlCommand(sentencia, c1);
                SqlDataAdapter SqlDat = new SqlDataAdapter(comando);
                SqlDat.Fill(DtResultado);
                DataRow nuevaFila = DtResultado.NewRow();

                nuevaFila["ID_TIPO_AMBULANCIA"] = 0;
                nuevaFila["NOMBRE_TIPO_AMBULANCIA"] = "--Seleccione--";

                DtResultado.Rows.InsertAt(nuevaFila, 0);
            }
            catch (Exception ex)
            {
                DtResultado = null;
                Console.WriteLine("Error al consultar en el tipo de ambulancia " + ex.Message);
            }
            return DtResultado;
        }

        // CONSULTA SI PLACA INGRESADA ESTÁ REGISTRADA EN LA BD
        public bool ConsultarPlaca(string placa)
        {
            bool flag = true;
            SqlConnection c1 = con.abrir_conexion();
            try
            {
                //comando
                SqlDataReader dr = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = c1;
                comando.CommandText = "sp_consultar_placa";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter param_placa = new SqlParameter();
                param_placa.ParameterName = "@placa";
                param_placa.SqlDbType = SqlDbType.VarChar;
                param_placa.Value = placa;
                comando.Parameters.Add(param_placa);
                dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }

            }
            catch (Exception ex)
            {
                con.cerrar_conexion(c1);
                Console.WriteLine("Error al consultar en la placa " + ex.Message);
                flag = false;
            }
            return flag;
        }

        // CONSULTA LAS AMBULANCIAS REGISTRADAS EN LA BD SEGÚN EL FILTRO SELECCIONADO POR EL USUARIO
        public DataTable ConsultarAmbulancias(string dato, int tipo_ambulancia, int disponibilidad, int buscarOb, int buscarOp)
        {
            DataTable dt = new DataTable();
            SqlConnection c1 = con.abrir_conexion();
            try
            {
                using (SqlCommand comando = new SqlCommand("sp_consultar_ambulancias", c1))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new SqlParameter("@opcionA", buscarOb));
                    comando.Parameters.Add(new SqlParameter("@opcionB", buscarOp));
                    comando.Parameters.Add(new SqlParameter("@dato", dato));
                    comando.Parameters.Add(new SqlParameter("@tipo_ambulancia", tipo_ambulancia));
                    comando.Parameters.Add(new SqlParameter("@disponibilidad", disponibilidad));
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                dt = null;
                Console.WriteLine("Error al consultar las ambulancias " + ex.Message);
            }
            
            return dt;
        }

        // CONSULTA TODAS LAS AMBULANCIAS REGISTRADAS EN LA BD
        public DataTable ListarAmbulancias()
        {
            DataTable dt = new DataTable();
            SqlConnection c1 = con.abrir_conexion();
            try
            {
                using (SqlCommand comando = new SqlCommand("sp_listar_ambulancias", c1))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                dt = null;
                Console.WriteLine("Error al listar las ambulancias " + ex.Message);
            }

            return dt;
        }

        // CONSULTA TODAS LAS AMBULANCIAS REGISTRADAS EN LA BD QUE ESTÉN DISPONIBLES PARA ASIGNARLAS LUEGO
        public object ListarAmbulanciasDisponibles()
        {
            DataTable dt = new DataTable();
            SqlConnection c1 = con.abrir_conexion();
            try
            {
                using (SqlCommand comando = new SqlCommand("sp_listar_ambulancias_disponibles", c1))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                dt = null;
                Console.WriteLine("Error al listar las ambulancias " + ex.Message);
            }

            return dt;
        }
    }
}
