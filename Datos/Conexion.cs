using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Xml;

namespace Datos {
    public class Conexion {
        public SqlConnection abrir_conexion () {
            
            /*
            string ConnectionString = "";

            XmlTextReader xtr = new XmlTextReader (@"hostlocal.xml"); // "" realatie path
            while (xtr.Read()) {
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "name") {
                    ConnectionString = xtr.ReadElementString ();
                }
            }
            */
            
            string ConnectionString = "server=localhost; database=PYCSLosrapidos; integrated security=true";
            SqlConnection conexion = new SqlConnection (ConnectionString);
            conexion.Open ();
            //MessageBox.Show("SE ABRIO LA CONEXION DESDE LA CAPA ACCESO A DATOS");
            return conexion;
        }

        //Cerrar conexion a BD
        public void cerrar_conexion (SqlConnection conexion) {
            conexion.Close ();
            //MessageBox.Show("SE CERRO LA CONEXION DESDE LA CAPA ACCESO A DATOS");
        }

    }
}
