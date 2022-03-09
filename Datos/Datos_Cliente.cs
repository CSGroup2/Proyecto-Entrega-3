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


        // Metodo para poder cargar todos los hospitales disponibles de la base de datos
        public DataTable ConsultarHospitales()
        {
            // Se definen las variables necesarias para la conexion y ejecucion de comandos. 
            DataTable DtResultado = new DataTable("HOSPITAL");
            SqlConnection sqlconn = con.abrir_conexion();
            SqlCommand sql_comando = null;
            try
            {
                string procedimeinto = "sp_consultar_hospitales"; //Se define que procedimiento ejecutar
                sql_comando = new SqlCommand(procedimeinto, sqlconn);     // Creatin SqlCommand object
                sql_comando.CommandType = CommandType.StoredProcedure; //Se especifico que el comando es de tipo procedimiento
                SqlDataAdapter SqlDat = new SqlDataAdapter(sql_comando);
                SqlDat.Fill(DtResultado);  //empiezo a recoger los datos
                DataRow nuevaFila = DtResultado.NewRow();

                // creo la opcion por defecto
                nuevaFila["ID_HOSPITAL"] = 0;
                nuevaFila["NOMBRE_HOSPITAL"] = "--Seleccione--";
                //inserto la opcion por defecto
                DtResultado.Rows.InsertAt(nuevaFila, 0);
            }
            catch (Exception ex)
            {
                DtResultado = null;
                Console.WriteLine("Error al consultar los hospitales " + ex.Message);
            }
            finally
            {
                con.cerrar_conexion(sqlconn);
            }
            return DtResultado;
        }

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
    }
}
