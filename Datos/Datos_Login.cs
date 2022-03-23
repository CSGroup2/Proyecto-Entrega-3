using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos {
    public class Datos_Login {

        Conexion conn = new Conexion ();

        public Usuario_Cache LoginUser (String usuario, String contraseña) {
            bool var = false;
            SqlConnection sql_conexion = conn.abrir_conexion ();
            Usuario_Cache usuarioCache = new Usuario_Cache ();

            string procedimeinto = "sp_login";
            try
            {
                SqlCommand sql_comando = new SqlCommand(procedimeinto, sql_conexion);     // Creatin SqlCommand object
                sql_comando.CommandType = CommandType.StoredProcedure;
                sql_comando.Parameters.AddWithValue("@nombre_usuario", usuario);
                sql_comando.Parameters.AddWithValue("@contrasenia", contraseña);
                SqlDataReader registros = sql_comando.ExecuteReader();
                if (registros.HasRows)
                {
                    while (registros.Read())
                    {

                        usuarioCache.Id_tipo = Int16.Parse(registros["id_tipo"].ToString());
                        usuarioCache.Tipo = registros["tipo"].ToString();
                        usuarioCache.Nombres = registros["nombre"].ToString();
                        usuarioCache.Apellidos = registros["apellido"].ToString();
                    }
                    //var = true;
                }
                else
                {
                    //var = false;
                    usuarioCache = null;
                }
                conn.cerrar_conexion(sql_conexion);
            }
            catch
            {
                conn.cerrar_conexion(sql_conexion);
                usuarioCache = null;
            }
            finally
            {
                conn.cerrar_conexion(sql_conexion);
            }
            return usuarioCache;
        }

        public string RecuperarPassword (string userrequesting) {
            SqlConnection c1 = conn.abrir_conexion ();
            string sentencia = "select * from USUARIO where nombre_usuario=@usuario or correo=@correo";
            SqlCommand comando = new SqlCommand (sentencia, c1); //Para ejecutar 
            comando.Parameters.AddWithValue ("@usuario", userrequesting);
            comando.Parameters.AddWithValue ("@correo", userrequesting);
            SqlDataReader registros = comando.ExecuteReader ();
            if (registros.Read () == true) {
                string username = registros.GetString (1);
                string usercorreo = registros.GetString (2);
                string contrasenia = registros.GetString (3);

                var serviciocorreo = new Datos_Email_Sistema ();
                serviciocorreo.EnviarCorreo (
                    asunto: "SYSTEM: Solicitud de recuperación de contraseña",
                    cuerpo: "Hola, " + username + " parece que haz tenido un inconveniente al iniciar sesion. \n" +
                    "Haz solicitado recuperar tu contraseña. \n" +
                    "Tú contraseña es: " + contrasenia +
                    "\n Te recomendamos que cambies tu contraseña de inmediato una vez que entre al sistema.",
                    receptor: new List<string> { usercorreo }
                    );
                return "Hola, " + username + " Haz solicitado recuperar tu contraseña. \n" +
                    "Por favor resiva tu bandeja de correo electrónico. \n" +
                    "Y no olvides cambiar tu contraseña una vez dentro del sistema.";
            } else {
                return "Lo sentimos, no existe una cuenta asociada a este usuario o correo electronico";
            }

        }
    }
}
