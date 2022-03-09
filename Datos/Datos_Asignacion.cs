using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos {
    public class Datos_Asignacion
    {
        Conexion con = new Conexion(); //Objeto para conectar con la base de datos

        //guarda la asignacion completa en la BD
        public string insetarAsignacion(List<Asignacion_Cabecera> ac, List<Asignacion_Detalle> ad)
        {
            string msj = "";
            SqlConnection conexion = con.abrir_conexion();

            try 
            {
                SqlTransaction Sqltra = conexion.BeginTransaction();
                //comando
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = Sqltra;
                comando.CommandText = "sp_insertar_asignacion_cabecera";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter param_id_cab = new SqlParameter();
                param_id_cab.ParameterName = "@id_a_cabecera";
                param_id_cab.SqlDbType = SqlDbType.Int;
                param_id_cab.Direction = ParameterDirection.Output;
                comando.Parameters.Add(param_id_cab);

                SqlParameter param_id_peticion = new SqlParameter();
                param_id_peticion.ParameterName = "@id_peticion";
                param_id_peticion.SqlDbType = SqlDbType.Int;
                param_id_peticion.Value = ac[0].Peticion.Id_peticion;
                comando.Parameters.Add(param_id_peticion);

                SqlParameter param_id_secretaria = new SqlParameter();
                param_id_secretaria.ParameterName = "@id_secretaria";
                param_id_secretaria.SqlDbType = SqlDbType.Int;
                param_id_secretaria.Value = ac[0].Secretaria.Id_secretaria;
                comando.Parameters.Add(param_id_secretaria);

                SqlParameter param_condicion = new SqlParameter();
                param_condicion.ParameterName = "@condicion";
                param_condicion.SqlDbType = SqlDbType.VarChar;
                param_condicion.Value = ac[0].Condicion;
                comando.Parameters.Add(param_condicion);

                msj = comando.ExecuteNonQuery() == 1 ? "1" : "Error.";

                //envia los datos ya ingresados en la tabla cabecera a tabla detalle
                if (msj.Equals("1")) 
                {
                    ac[0].Id_asignacion_cabecera = Convert.ToInt32(comando.Parameters["@id_a_cabecera"].Value);
                    foreach (Asignacion_Detalle x in ad)
                    {
                        x.Id_asignacion_cabecera = ac[0].Id_asignacion_cabecera;
                        msj = insertarDetalle(x, ref Sqltra, ref conexion);
                        if (!msj.Equals("1"))
                        {
                            break;
                        }
                    }
                    ac[0].Peticion.Id_peticion = Convert.ToInt32(comando.Parameters["@id_peticion"].Value);
                    msj = actualizarPeticion(ac[0].Peticion.Id_peticion);
                }
                if (msj.Equals("1")) 
                {
                    Sqltra.Commit();
                }
                else
                {
                    Sqltra.Rollback();
                }

                con.cerrar_conexion(conexion);
                
                msj = "1";
            }
            catch (Exception ex)
            {
                con.cerrar_conexion(conexion);
                msj = "en cabecera error " + ex.Message;
            }
            return msj;
        }

        //actualiza la peticion a condicion "Asignada"
        private string actualizarPeticion(int id_peticion)
        {
            string msj = "";
            SqlConnection conexion = con.abrir_conexion();
            try 
            {
                //comando
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "sp_actualizar_peticiones_asignada";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter param_id_peticion = new SqlParameter();
                param_id_peticion.ParameterName = "@id_peticion";
                param_id_peticion.SqlDbType = SqlDbType.Int;
                param_id_peticion.Value = id_peticion;
                comando.Parameters.Add(param_id_peticion);

                msj = comando.ExecuteNonQuery() == 1 ? "1" : "No se pudo actualizar el stock";
                con.cerrar_conexion(conexion);
            }
            catch (Exception ex)
            {
                con.cerrar_conexion(conexion);
                msj = "en detalle error" + ex.Message + ex.StackTrace;
            }
            return msj;
        }

        //Inserta datos en asignacion detalle 
        private string insertarDetalle(Asignacion_Detalle x, ref SqlTransaction Sqltra, ref SqlConnection conexion)
        {
            string msj = "";
            try 
            {
                //comando
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = Sqltra;
                comando.CommandText = "sp_insertar_asignacion_detalle";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter param_id_a_detalle = new SqlParameter();
                param_id_a_detalle.ParameterName = "@id_a_detalle";
                param_id_a_detalle.SqlDbType = SqlDbType.Int;
                param_id_a_detalle.Direction = ParameterDirection.Output;
                comando.Parameters.Add(param_id_a_detalle);

                SqlParameter param_id_cad_det = new SqlParameter();
                param_id_cad_det.ParameterName = "@id_a_cabecera";
                param_id_cad_det.SqlDbType = SqlDbType.Int;
                param_id_cad_det.Value = x.Id_asignacion_cabecera;
                comando.Parameters.Add(param_id_cad_det);

                SqlParameter param_id_conductor = new SqlParameter();
                param_id_conductor.ParameterName = "@id_conductor";
                param_id_conductor.SqlDbType = SqlDbType.Int;
                param_id_conductor.Value = x.Conductor.Id_conductor;
                comando.Parameters.Add(param_id_conductor);

                SqlParameter param_id_ambulancia = new SqlParameter();
                param_id_ambulancia.ParameterName = "@id_ambulancia";
                param_id_ambulancia.SqlDbType = SqlDbType.Int;
                param_id_ambulancia.Value = x.Ambulancia.Id_ambulancia;
                comando.Parameters.Add(param_id_ambulancia);

                msj = comando.ExecuteNonQuery() == 1 ? "1" : "No se ingreso el registro";

                if (msj.Equals("1")) 
                {
                    msj = OcuparConductores(x.Conductor.Id_conductor, ref Sqltra,ref conexion);
                    if (msj.Equals("1")) 
                    {
                        msj = OcuparAmbulancias(x.Ambulancia.Id_ambulancia,ref Sqltra,ref conexion);
                    }
                }

            } catch (Exception ex) 
            {
                msj = "en detalle error" + ex.Message + ex.StackTrace;
            }
            return msj;
        }

        //Cambia la disponibilidad de las ambulancias
        private string OcuparAmbulancias(int id_ambulancia, ref SqlTransaction Sqltra, ref SqlConnection conexion)
        {
            string msj = "";
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = Sqltra;
                comando.CommandText = "sp_ocupar_ambulancia";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter param_id_conductor = new SqlParameter();
                param_id_conductor.ParameterName = "@id_ambulancia";
                param_id_conductor.SqlDbType = SqlDbType.Int;
                param_id_conductor.Value = id_ambulancia;
                comando.Parameters.Add(param_id_conductor);

                msj = comando.ExecuteNonQuery() == 1 ? "1" : "No se ingreso el registro";
            }
            catch (Exception ex)
            {
                msj = "en conductor error" + ex.Message + ex.StackTrace;
            }
            return msj;
        }

        //cambia la disponibilidad de los conductores
        private string OcuparConductores(int id_conductor, ref SqlTransaction Sqltra, ref SqlConnection conexion)
        {
            string msj = "";
            try 
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = Sqltra;
                comando.CommandText = "sp_ocupar_conductor";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter param_id_conductor = new SqlParameter();
                param_id_conductor.ParameterName = "@id_conductor";
                param_id_conductor.SqlDbType = SqlDbType.Int;
                param_id_conductor.Value = id_conductor;
                comando.Parameters.Add(param_id_conductor);

                msj = comando.ExecuteNonQuery() == 1 ? "1" : "No se ingreso el registro";
            }
            catch (Exception ex)
            {
                msj = "en conductor error" + ex.Message + ex.StackTrace;
            }
            return msj;
        }
    }
}
