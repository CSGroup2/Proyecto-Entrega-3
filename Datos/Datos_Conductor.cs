using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos {
    public class Datos_Conductor {
        /*----------------------Frm_Conductor_Registrar-------------------------------------*/
        public string insertarDatosConductor (Conductor conductor) {
            // insert new "condutor" data into the database
            Conexion conexion = null;
            SqlConnection sql_conexion = null;
            SqlCommand sql_comando = null;
            string mensaje = "";
            string query = null;
            try {
                conexion = new Conexion ();
                sql_conexion = conexion.abrir_conexion ();              // Opens conexion to sql server
                query = "sp_conductor_insertarDatos";                        // Stored Procedure name
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

        /*----------------------Frm_Conductor_Consultar-------------------------------------*/

        public object listarDatosConductor () {
            // Extract all "conductor" data from database
            DataTable dataTable_resultado = null;
            Conexion conexion = null;
            SqlConnection sql_conexion = null;
            SqlCommand sql_comando = null;
            SqlDataAdapter sql_adaptador = null;
            string query = null;
            try {
                conexion = new Conexion ();
                sql_conexion = conexion.abrir_conexion ();              // Opens conexion to sql server
                query = "sp_conductor_listarDatos";                        // Stored Procedure name
                sql_comando = new SqlCommand (query, sql_conexion);     // Creatin SqlCommand object
                sql_comando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                sql_adaptador = new SqlDataAdapter (sql_comando);
                dataTable_resultado = new DataTable ();
                using (sql_comando) {
                    sql_adaptador.Fill (dataTable_resultado);
                }
            } catch (Exception ex) {
                dataTable_resultado = null;
                Console.WriteLine ("Error al listar los datos de los conductores " + ex.Message);
            } finally {
                conexion.cerrar_conexion (sql_conexion);
            }
            return dataTable_resultado;
        }


        public object listarDatosDisponibilidad () {
            // Extract all "disponibilidad" data from database
            Conexion conexion = null;
            SqlConnection sql_conexion = null;
            SqlCommand sql_comando = null;
            SqlDataAdapter sql_adaptador = null;
            DataTable dataTable_resultado = null;
            string query = null;
            try {
                conexion = new Conexion ();
                sql_conexion = conexion.abrir_conexion ();          // Opens conexion to sql server
                query = "SELECT * FROM DISPONIBILIDAD";             // SQL sentece
                sql_comando = new SqlCommand (query, sql_conexion); // Creatin SqlCommand object
                dataTable_resultado = new DataTable ("DISPONIBILIDAD");
                sql_adaptador = new SqlDataAdapter (sql_comando);
                sql_adaptador.Fill (dataTable_resultado);
            } catch (Exception ex) {
                dataTable_resultado = null;
                Console.WriteLine ("Error al consultar en el tipo de ambulancia " + ex.Message);
            } finally {
                conexion.cerrar_conexion (sql_conexion);
            }
            return dataTable_resultado;
        }

        public string actualizarDatosConductor (Conductor conductor) {
            // insert new "condutor" data into the database
            Conexion conexion = null;
            SqlConnection sql_conexion = null;
            SqlCommand sql_comando = null;
            string mensaje = "";
            string query = null;
            try {
                conexion = new Conexion ();
                sql_conexion = conexion.abrir_conexion ();              // Opens conexion to sql server
                query = "sp_conductor_actualizarDatos";                        // Stored Procedure name
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

        public DataTable buscarDatosConductor (string cedula_nombre, string disponibilidad) {
            // Extract all "conductor" data from database
            DataTable dataTable_resultado = null;
            Conexion conexion = null;
            SqlConnection sql_conexion = null;
            SqlCommand sql_comando = null;
            SqlDataAdapter sql_adaptador = null;
            string query = null;
            try {
                conexion = new Conexion ();
                sql_conexion = conexion.abrir_conexion ();              // Opens conexion to sql server
                query = "sp_buscar_conductores";                        // Stored Procedure name
                sql_comando = new SqlCommand (query, sql_conexion);     // Creatin SqlCommand object
                sql_comando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                sql_adaptador = new SqlDataAdapter (sql_comando);
                dataTable_resultado = new DataTable ();
                
                using (sql_comando) {
                    // Adding values to paramerters for SqlCommand below
                    // Use DBNull.Value make stored procedure parameters have defaults of NULL
                    if (cedula_nombre != null) {
                        sql_comando.Parameters.Add (new SqlParameter ("@cedula_nombre", cedula_nombre));
                    }else {
                        sql_comando.Parameters.Add (new SqlParameter ("@cedula_nombre", DBNull.Value));
                    }
                    if (disponibilidad != null) {
                        sql_comando.Parameters.Add (new SqlParameter ("@disponibilidad", disponibilidad));
                    } else {
                        sql_comando.Parameters.Add (new SqlParameter ("@disponibilidad", DBNull.Value));
                    }
                    sql_adaptador.Fill (dataTable_resultado);
                }
            } catch (Exception ex) {
                dataTable_resultado = null;
                Console.WriteLine ("¡ERROR! al listar los datos de los conductores " + ex.Message);
            } finally {
                conexion.cerrar_conexion (sql_conexion);
            }
            return dataTable_resultado;
        }

        /*----------------------Frm_Conductor_Editar-------------------------------------*/

        public Conductor buscarDatosConductorEditar (int idConductor) {
            // Extract all "conductor" data from database
            Conductor conductor_resultado = null;
            Conexion conexion = null;
            SqlConnection sql_conexion = null;
            SqlCommand sql_comando = null;
            SqlDataReader sql_lector = null;
            string query = null;
            try {
                conexion = new Conexion ();
                sql_conexion = conexion.abrir_conexion ();              // Opens conexion to sql server
                query = "sp_conductor_buscarDatosPor_Id";               // Stored Procedure name
                sql_comando = new SqlCommand (query, sql_conexion);     // Creatin SqlCommand object
                sql_comando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                sql_comando.Parameters.Add (new SqlParameter ("@dato_idConductor", idConductor));
                sql_lector = sql_comando.ExecuteReader ();
                while (sql_lector.Read()) {
                    conductor_resultado = new Conductor ();
                    conductor_resultado.Id_conductor = Convert.ToInt32(sql_lector["ID"]);
                    conductor_resultado.Cedula = sql_lector["CEDULA"].ToString ();
                    conductor_resultado.Estado = sql_lector["ESTADO"].ToString ();
                    conductor_resultado.Nombre_1 = sql_lector["NOMBRE1"].ToString ();
                    conductor_resultado.Nombre_2 = sql_lector["NOMBRE2"].ToString ();
                    conductor_resultado.Apellido_1 = sql_lector["APELLIDO1"].ToString ();
                    conductor_resultado.Apellido_2 = sql_lector["APELLIDO2"].ToString ();
                    conductor_resultado.Diponibilidad = sql_lector["DISPONIBILIDAD"].ToString ();
                    conductor_resultado.Telefono = sql_lector["TELEFONO"].ToString ();
                    conductor_resultado.Sexo = sql_lector["SEXO"].ToString ();
                    conductor_resultado.Fecha_nac = DateTime.Parse(sql_lector["FECHA_NACIMIENTO"].ToString());
                    conductor_resultado.Fecha_contrato = DateTime.Parse (sql_lector["FECHA_CONTRATO"].ToString());
                }

            } catch (Exception ex) {
                conductor_resultado = null;
                Console.WriteLine ("¡ERROR! al buscar datos de conductore por ID." + ex.Message);
            } finally {
                conexion.cerrar_conexion (sql_conexion);
            }
            return conductor_resultado;
        }
        /**/

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
