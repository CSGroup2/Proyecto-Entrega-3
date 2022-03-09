using Datos;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control {
    public class Adm_Secretaria {

        /*
           Aplicar el patron de diseño Singleton:
           1. Crear 1 atributo estático y privado de la misma clase.
           2. Cambiar el constructor de public a private.
           3.1. Crear un getter del atributo estático del tipo de la clase.
           3.2.Verificar si atributo es null, si es así, crearlo.
       */

        private static Adm_Secretaria adm_secretaria = null;    // 1.
        List<Secretaria> Lista_Secretaria = null;
        Secretaria Secretaria = null;
        Usuario Usuario = null;
        Datos_Secretaria Datos_Secretaria = null;
        Validacion Validacion = null;

        // Constructor: Adm_Login
        private Adm_Secretaria () {                  // 2.
            Lista_Secretaria = new List<Secretaria> ();
            Secretaria = new Secretaria ();
            Usuario = new Usuario ();
            Datos_Secretaria = new Datos_Secretaria ();
            Validacion = new Validacion ();
        }

        // Getter: GetAdm
        public static Adm_Secretaria GetAdm () {        // 3.1.
            if (adm_secretaria == null) {               //3.2
                adm_secretaria = new Adm_Secretaria ();
            }
            return adm_secretaria;
        }

        /*----------------------Frm_Secretaria_Registrar-------------------------------*/

        #region Frm_Secretaria_Registrar

        // Methods for KeyPress
        public void validarSoloNumerosKeyPress (object sender, KeyPressEventArgs e) {
            // Only allows numbers on press
            Validacion.validarSoloNumerosKeyPress (sender, e);
        }
       
        public void validarSoloLettrasKeyPress (object sender, KeyPressEventArgs e) {
            // Only allows alphabetic characters
            Validacion.validarSoloLettrasKeyPress (sender, e);
        }

        public void validarSoloCorreoKeypress (object sender, KeyPressEventArgs e) {
            // Only allows eamil characters
            Validacion.validarSoloCorreoKeypress (sender, e);
        }

        // 
        public string guardarDatosSecretaria (string cedula, string nombre1, string nombre2, string apellido1, string apellido2, string correo, string telefono, string sexo, DateTime fecha_nac, DateTime fecha_contrato, string nombre_usuario, string contrasenia1) {
            string mensaje = "¡";
            Usuario = new Usuario (0, correo, nombre_usuario, contrasenia1);
            Secretaria = new Secretaria (0, Usuario, fecha_contrato, 0, cedula, nombre1, nombre2, apellido1, apellido2, sexo, fecha_nac, telefono);
            mensaje = Datos_Secretaria.insertarDatosSecretaria (Secretaria);
            MessageBox.Show (mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return mensaje;
        }

        public void limpiarCamposGuardarSecretaria (TextBox txt_Cedula, TextBox txt_Nombre1, TextBox txt_Nombre2, TextBox txt_Apellido1, TextBox txt_Apellido2, TextBox txt_Correo, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNac, DateTimePicker dtp_FechaContrato, TextBox txt_NombreUsuario, TextBox txt_Contrasenia1, TextBox txt_Contrasenia2, ErrorProvider errorProvider1) {
            errorProvider1.Clear ();
            txt_Cedula.Clear ();
            txt_Nombre1.Clear ();
            txt_Nombre2.Clear ();
            txt_Apellido1.Clear ();
            txt_Apellido2.Clear ();
            txt_Correo.Clear ();
            txt_Telefono.Clear ();
            rdb_Masculino.Checked = false;
            rdb_Femenino.Checked = false;
            dtp_FechaNac.Value = DateTime.Today;
            dtp_FechaContrato.Value = DateTime.Today;
            txt_NombreUsuario.Clear ();
            txt_Contrasenia1.Clear ();
            txt_Contrasenia2.Clear ();
        }

        #endregion

        public string esSexoValidacion (RadioButton rdb_Masculino, RadioButton rdb_Femenino) {
            return Validacion.esSexo (rdb_Masculino, rdb_Femenino);
        }

        public bool esCorrectoDatosSecretariaValidacion (TextBox txt_Cedula, TextBox txt_Nombre1, TextBox txt_Nombre2, TextBox txt_Apellido1, TextBox txt_Apellido2, TextBox txt_Correo, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNac, DateTimePicker dtp_FechaContrato, TextBox txt_NombreUsuario, TextBox txt_Contrasenia1, TextBox txt_Contrasenia2, ErrorProvider errorProvider1) {
            return Validacion.esCorrectoDatosSecretaria (txt_Cedula, txt_Nombre1, txt_Nombre2, txt_Apellido1, txt_Apellido2, txt_Correo, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNac, dtp_FechaContrato, txt_NombreUsuario, txt_Contrasenia1, txt_Contrasenia2, errorProvider1);
        }

    }
}
