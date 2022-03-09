using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos {
    public class Datos_Secretaria {


        /*----------------------Frm_Secretaria_Editar-------------------------------------*/
        public string insertarDatosSecretaria (Secretaria secretaria) {
            Conexion conexion = null;
            SqlConnection sql_conexion = null;
            SqlCommand sql_comando = null;
            string mensaje = "";
            string query = "sp_insertar_secretaria";  // Stored Procedure name
            try {
                conexion = new Conexion ();
                sql_conexion = conexion.abrir_conexion ();              // Opens conexion to sql server
                sql_comando = new SqlCommand (query, sql_conexion);     // Creatin SqlCommand object
                sql_comando.CommandType = CommandType.StoredProcedure;  // Declaring command type as stored Procedure
                if (secretaria != null) {
                    // Adding values to paramerters to SqlCommand below
                    sql_comando.Parameters.AddWithValue ("@cedula", secretaria.Cedula);
                    sql_comando.Parameters.AddWithValue ("@nombre_1", secretaria.Nombre_1);
                    sql_comando.Parameters.AddWithValue ("@nombre_2", secretaria.Nombre_2);
                    sql_comando.Parameters.AddWithValue ("@apellido_1", secretaria.Apellido_1);
                    sql_comando.Parameters.AddWithValue ("@apellido_2", secretaria.Apellido_2);
                    sql_comando.Parameters.AddWithValue ("@sexo", secretaria.Sexo);
                    sql_comando.Parameters.AddWithValue ("@fecha_nac", secretaria.Fecha_nac);
                    sql_comando.Parameters.AddWithValue ("@telefono", secretaria.Telefono);
                    sql_comando.Parameters.AddWithValue ("@nombre_usuario", secretaria.Usuario.Nombre_usuario);
                    sql_comando.Parameters.AddWithValue ("@correo", secretaria.Usuario.Correo);
                    sql_comando.Parameters.AddWithValue ("@contrasenia", secretaria.Usuario.Contrasenia);
                    sql_comando.Parameters.AddWithValue ("@fecha_contrato", secretaria.Fecha_contrato);
                    mensaje = Convert.ToString (sql_comando.ExecuteNonQuery ());
                    if (mensaje == "-1") {
                        mensaje = "¡DATOS NO GUARDADOS!";
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


    }
}
