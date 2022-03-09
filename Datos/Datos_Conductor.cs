using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos {
    public class Datos_Conductor {

        /*----------------------Frm_Conductor_Editar-------------------------------------*/
        public string insertarDatosConductor (Conductor conductor) {
            Conexion conexion = null;
            SqlConnection sql_conexion = null;
            SqlCommand sql_comando = null;
            string mensaje = "";
            string query = "sp_insertar_conductor";  // Stored Procedure name
            try {
                conexion = new Conexion ();
                sql_conexion = conexion.abrir_conexion ();              // Opens conexion to sql server
                sql_comando = new SqlCommand (query, sql_conexion);     // Creatin SqlCommand object
                sql_comando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                if (conductor != null) {
                    // Adding values to paramerters to SqlCommand below
                    sql_comando.Parameters.AddWithValue ("@cedula", conductor.Cedula);
                    sql_comando.Parameters.AddWithValue ("@nombre_1", conductor.Nombre_1);
                    sql_comando.Parameters.AddWithValue ("@nombre_2", conductor.Nombre_2);
                    sql_comando.Parameters.AddWithValue ("@apellido_1", conductor.Apellido_1);
                    sql_comando.Parameters.AddWithValue ("@apellido_2", conductor.Apellido_2);
                    sql_comando.Parameters.AddWithValue ("@sexo", conductor.Sexo);
                    sql_comando.Parameters.AddWithValue ("@fecha_nac", conductor.Fecha_nac);
                    sql_comando.Parameters.AddWithValue ("@telefono", conductor.Telefono);
                    sql_comando.Parameters.AddWithValue ("@fecha_contrato", conductor.Fecha_contrato);
                    mensaje = Convert.ToString (sql_comando.ExecuteNonQuery ());
                    if (mensaje == "-1") {
                        mensaje = "¡CÉDULA YA EXISTE!";
                    } else {
                        mensaje = "DATOS GUARDADOS CORRECTAMENTE.";
                    }
                }
            } catch (Exception ex) {
                mensaje = "OCURRIO UN ERROR. \n" + ex.Message;
            } finally {
                conexion.cerrar_conexion (sql_conexion);
            }
            return mensaje;
        }





        /*---------------------- Billy -------------------------------------*/

        public object ListarConductoresDisponibles () {
            Conexion conexion = null;
            SqlConnection sql_conexion = null;
            SqlCommand sql_comando = null;
            SqlDataAdapter sql_data_adapter = null;
            DataTable data_table = null;
            try {
                conexion = new Conexion ();
                sql_conexion = conexion.abrir_conexion ();
                data_table = new DataTable ();
                using (sql_comando = new SqlCommand ("sp_listar_conductores_disponibles", sql_conexion)) {
                    sql_comando.CommandType = CommandType.StoredProcedure;
                    sql_data_adapter = new SqlDataAdapter (sql_comando);
                    sql_data_adapter.Fill (data_table);
                }
            } catch (Exception ex) {
                data_table = null;
                Console.WriteLine ("Error al listar los conductores " + ex.Message);
            }
            return data_table;
        }

    }
}
