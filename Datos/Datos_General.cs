using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos {
    public class Datos_General {

        public DataTable listarDatosDisponibilidad () {
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

    }
}
