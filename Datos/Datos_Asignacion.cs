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

                msj = comando.ExecuteNonQuery() == 1 ? "1" : "No se pudo actualizar peticion";
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

        public object LlenarTablaAsignaciones(int idSecretario)
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = con.abrir_conexion();
            try
            {
                using (SqlCommand comando = new SqlCommand("sp_listar_asignaciones", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlParameter param_id = new SqlParameter();
                    param_id.ParameterName = "@idS";
                    param_id.SqlDbType = SqlDbType.Int;
                    param_id.Value = idSecretario;
                    comando.Parameters.Add(param_id);
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                dt = null;
                Console.WriteLine("Error al listar las asignaciones " + ex.Message);
            }
            return dt;
        }

        public object LlenarComboConductores()
        {
            DataTable DtResultado = new DataTable("TIPO_AMBULANCIA");
            SqlConnection c1 = con.abrir_conexion();
            try
            {
                string sentencia = "SELECT C.ID_CONDUCTOR AS CODCONDUCTOR, CONCAT(P.NOMBRE_1,' ',P.APELLIDO_1) AS NOMBRE FROM CONDUCTOR C INNER JOIN PERSONA P ON C.ID_PERSONA=P.ID_PERSONA WHERE C.ID_ESTADO=1;";
                SqlCommand comando = new SqlCommand(sentencia, c1);
                SqlDataAdapter SqlDat = new SqlDataAdapter(comando);
                SqlDat.Fill(DtResultado);
                DataRow nuevaFila = DtResultado.NewRow();

                nuevaFila["CODCONDUCTOR"] = 0;
                nuevaFila["NOMBRE"] = "";

                DtResultado.Rows.InsertAt(nuevaFila, 0);
            }
            catch (Exception ex)
            {
                DtResultado = null;
                Console.WriteLine("Error al consultar conductor " + ex.Message);
            }
            finally
            {
                con.cerrar_conexion(c1);
            }
            return DtResultado;
        }

        public object LlenarComboAmbulancia()
        {
            DataTable DtResultado = new DataTable("TIPO_AMBULANCIA");
            SqlConnection c1 = con.abrir_conexion();
            try
            {
                string sentencia = "SELECT A.ID_AMBULANCIA AS CODAMBULANCIA, CONCAT(A.PLACA,' ', A.MODELO) AS NOMBRE FROM AMBULANCIA A WHERE ID_ESTADO=1;";
                SqlCommand comando = new SqlCommand(sentencia, c1);
                SqlDataAdapter SqlDat = new SqlDataAdapter(comando);
                SqlDat.Fill(DtResultado);
                DataRow nuevaFila = DtResultado.NewRow();

                nuevaFila["CODAMBULANCIA"] = 0;
                nuevaFila["NOMBRE"] = "";

                DtResultado.Rows.InsertAt(nuevaFila, 0);
            }
            catch (Exception ex)
            {
                DtResultado = null;
                Console.WriteLine("Error al consultar ambulancia " + ex.Message);
            }
            finally
            {
                con.cerrar_conexion(c1);
            }
            return DtResultado;
        }

        public object FiltrarAsignaciones(int idSecretario, string ced, string condicion)
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = con.abrir_conexion();
            try
            {
                using (SqlCommand comando = new SqlCommand("sp_filtrar_asignaciones", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlParameter param_id = new SqlParameter();
                    param_id.ParameterName = "@idS";
                    param_id.SqlDbType = SqlDbType.Int;
                    param_id.Value = idSecretario;
                    comando.Parameters.Add(param_id);

                    comando.CommandType = CommandType.StoredProcedure;
                    SqlParameter param_cedCliente = new SqlParameter();
                    param_cedCliente.ParameterName = "@cedC";
                    param_cedCliente.SqlDbType = SqlDbType.VarChar;
                    param_cedCliente.Value = ced;
                    comando.Parameters.Add(param_cedCliente);

                    comando.CommandType = CommandType.StoredProcedure;
                    SqlParameter param_condicion = new SqlParameter();
                    param_condicion.ParameterName = "@cond";
                    param_condicion.SqlDbType = SqlDbType.VarChar;
                    param_condicion.Value = condicion;
                    comando.Parameters.Add(param_condicion);

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

        public object consultarAsigDetallexIdAs(int idAs)
        {
            DataTable dt = new DataTable();
            SqlConnection conexion = con.abrir_conexion();
            try
            {
                using (SqlCommand comando = new SqlCommand("sp_consultar_asignacion_detalle_idAs", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlParameter param_idAC = new SqlParameter();
                    param_idAC.ParameterName = "@idAs";
                    param_idAC.SqlDbType = SqlDbType.Int;
                    param_idAC.Value = idAs;
                    comando.Parameters.Add(param_idAC);

                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                dt = null;
                Console.WriteLine("Error al listar los detalles " + ex.Message);
            }
            return dt;
        }

        public Asignacion_Cabecera ConsultarAsignacionXId(int idAs)
        {
            Asignacion_Cabecera ac = new Asignacion_Cabecera();
            Peticion p = new Peticion();
            Cliente c = new Cliente();
            SqlConnection conexion = con.abrir_conexion();
            try
            {
                //comando
                SqlDataReader dr = null;
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "sp_consultar_asignacion_x_id";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter param_id = new SqlParameter();
                param_id.ParameterName = "@idAs";
                param_id.SqlDbType = SqlDbType.Int;
                param_id.Value = idAs;
                comando.Parameters.Add(param_id);

                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    c = new Cliente();
                    c.Nombre_1 = dr["Nombre"].ToString();
                    c.Apellido_1 = dr["Apellido"].ToString();

                    p = new Peticion();
                    p.Cliente = c;
                    p.N_ambulancia = Convert.ToInt32(dr["Cantidad_Ambulancias"]);
                    p.Punto_origen = dr["Origen"].ToString();
                    p.Punto_destino = dr["Destino"].ToString();

                    ac = new Asignacion_Cabecera();
                    ac.Peticion = p;
                    ac.Ambulancia = dr["Tipo_Ambulancia"].ToString();
                    ac.Id_asignacion_cabecera = Convert.ToInt32(dr["Código_Asignación"]);
                }
            }
            catch (Exception ex)
            {
                con.cerrar_conexion(conexion);
                Console.WriteLine("Error al consultar en la placa " + ex.Message);
            }
            return ac;
        }

        public string editarAsignacion(int id_detalle, int id_conductor, int id_ambulancia)
        {
            string msj = "";
            SqlConnection conexion = con.abrir_conexion();

            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandText = "sp_update_asignacion";
                comando.CommandType = CommandType.StoredProcedure;

                SqlParameter param_id_det = new SqlParameter();
                param_id_det.ParameterName = "@id_detalle";
                param_id_det.SqlDbType = SqlDbType.Int;
                param_id_det.Value = id_detalle;
                comando.Parameters.Add(param_id_det);

                SqlParameter param_id_conductor = new SqlParameter();
                param_id_conductor.ParameterName = "@id_conductor";
                param_id_conductor.SqlDbType = SqlDbType.Int;
                param_id_conductor.Value = id_conductor;
                comando.Parameters.Add(param_id_conductor);

                SqlParameter param_id_ambulancia = new SqlParameter();
                param_id_ambulancia.ParameterName = "@id_ambulancia";
                param_id_ambulancia.SqlDbType = SqlDbType.Int;
                param_id_ambulancia.Value = id_ambulancia;
                comando.Parameters.Add(param_id_ambulancia);

                comando.ExecuteNonQuery();
                msj = "1";
            }
            catch (Exception ex)
            {
                con.cerrar_conexion(conexion);
                msj = "en cabecera error " + ex.Message;
            }
            return msj;
        }
    }
}
