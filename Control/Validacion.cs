using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Control {
    public class Validacion {

        public int AEntero (string entrada) {
            int x = 0;
            try {
                x = Convert.ToInt32 (entrada);
            } catch (Exception ex) {
                Console.WriteLine (ex.Message);
                //MessageBox.Show("Error: Se esperaba un número entero");
            }
            return x;
        }

        internal string esSexo (RadioButton rdb_Masculino, RadioButton rdb_Femenino) {
            string sexo = "";
            if (rdb_Masculino.Checked) {
                sexo = "Masculino";
            } else if (rdb_Femenino.Checked) {
                sexo = "Femenino";
            }
            return sexo;
        }

        /*-----------------------KeyPress for Frm-------------------------------*/

        #region KeyPress for Frm
        internal void validarSoloNumerosKeyPress (object sender, KeyPressEventArgs e) {
            char c = e.KeyChar;
            if (!char.IsControl (c) && !char.IsDigit (c)) {
                e.Handled = true;
                return;
            }
        }

        internal void validarSoloLettrasKeyPress (object sender, KeyPressEventArgs e) {
            char c = e.KeyChar;
            if (!char.IsLetter (c) && c != ' ' && (c != Convert.ToChar (Keys.Back))) {
                e.Handled = true;
                return;
            }
        }

        internal void validarSoloCorreoKeypress (object sender, KeyPressEventArgs e) {
            char c = e.KeyChar;
            if (!char.IsLetter (c) && !char.IsDigit (e.KeyChar) && (c != '.') && (c != '@') && (c != '-') && (c != '_') && (c != Convert.ToChar (Keys.Back))) {
                e.Handled = true;
                return;
            }
        }
        #endregion

        /*-----------------------Frm_Conductor_Registrar-------------------------------*/

        #region Validation: Frm_Conductor_Registrar - errorprovider emtpy fields & incorrect email
        internal bool esCorrectoDatosConductor (TextBox txt_Cedula, TextBox txt_Nombre1, TextBox txt_Nombre2, TextBox txt_Apellido1, TextBox txt_Apellido2, TextBox txt_Correo, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNac, DateTimePicker dtp_FechaContrato, ErrorProvider errorProvider1) {
            bool salida = true;
            string mensaje = "Campo obligatorio.";
            string correo = txt_Correo.Text.Trim ();
            if (txt_Cedula.Text.Trim () == "") {
                errorProvider1.SetError (txt_Cedula, mensaje);
                salida = false;
            }
            if (txt_Nombre1.Text.Trim () == "") {
                errorProvider1.SetError (txt_Nombre1, mensaje);
                salida = false;
            }
            if (txt_Nombre2.Text.Trim () == "") {
                errorProvider1.SetError (txt_Nombre2, mensaje);
                salida = false;
            }
            if (txt_Apellido1.Text.Trim () == "") {
                errorProvider1.SetError (txt_Apellido1, mensaje);
                salida = false;
            }
            if (txt_Apellido2.Text.Trim () == "") {
                errorProvider1.SetError (txt_Apellido2, mensaje);
                salida = false;
            }
            if (correo == "") {
                errorProvider1.SetError (txt_Correo, mensaje);
                salida = false;
            } else {
                try {
                    var addr = new System.Net.Mail.MailAddress (correo);
                    //return addr.Address == correo;
                } catch {
                    errorProvider1.SetError (txt_Correo, "Correo no valido.");
                    salida = false;
                }
            }
            if (txt_Telefono.Text.Trim () == "") {
                errorProvider1.SetError (txt_Telefono, mensaje);
                salida = false;
            }
            if (rdb_Femenino.Checked == rdb_Masculino.Checked) {
                errorProvider1.SetError (rdb_Femenino, mensaje);
                salida = false;
            }
            if (dtp_FechaNac.Text == null) {
                errorProvider1.SetError (dtp_FechaNac, mensaje);
                salida = false;
            }

            if (dtp_FechaContrato.Text == null) {
                errorProvider1.SetError (dtp_FechaContrato, mensaje);
                salida = false;
            }
            return salida;
        }
        #endregion

        /*------------------------------------------------------*/

        #region Validation: Frm_Secretaria_Registrar - errorprovider emtpy fields & incorrect email
        internal bool esCorrectoDatosSecretaria (TextBox txt_Cedula, TextBox txt_Nombre1, TextBox txt_Nombre2, TextBox txt_Apellido1, TextBox txt_Apellido2, TextBox txt_Correo, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNac, DateTimePicker dtp_FechaContrato, TextBox txt_NombreUsuario, TextBox txt_Contrasenia1, TextBox txt_Contrasenia2, ErrorProvider errorProvider1) {
            bool salida = true;
            string mensaje = "Campo obligatorio.";
            string correo = txt_Correo.Text.Trim ();
            if (txt_Cedula.Text.Trim () == "") {
                errorProvider1.SetError (txt_Cedula, mensaje);
                salida = false;
            }
            if (txt_Nombre1.Text.Trim () == "") {
                errorProvider1.SetError (txt_Nombre1, mensaje);
                salida = false;
            }
            if (txt_Nombre2.Text.Trim () == "") {
                errorProvider1.SetError (txt_Nombre2, mensaje);
                salida = false;
            }
            if (txt_Apellido1.Text.Trim () == "") {
                errorProvider1.SetError (txt_Apellido1, mensaje);
                salida = false;
            }
            if (txt_Apellido2.Text.Trim () == "") {
                errorProvider1.SetError (txt_Apellido2, mensaje);
                salida = false;
            }
            if (correo == "") {
                errorProvider1.SetError (txt_Correo, mensaje);
                salida = false;
            } else {
                try {
                    var addr = new System.Net.Mail.MailAddress (correo);
                    //return addr.Address == correo;
                } catch {
                    errorProvider1.SetError (txt_Correo, "Correo no valido.");
                    salida = false;
                }
            }
            if (txt_Telefono.Text.Trim () == "") {
                errorProvider1.SetError (txt_Telefono, mensaje);
                salida = false;
            }
            if (rdb_Femenino.Checked == rdb_Masculino.Checked) {
                errorProvider1.SetError (rdb_Femenino, mensaje);
                salida = false;
            }
            if (dtp_FechaNac.Text == null) {
                errorProvider1.SetError (dtp_FechaNac, mensaje);
                salida = false;
            }
            if (dtp_FechaContrato.Text == null) {
                errorProvider1.SetError (dtp_FechaContrato, mensaje);
                salida = false;
            }
            if (txt_NombreUsuario.Text.Trim () == "") {
                errorProvider1.SetError (txt_NombreUsuario, mensaje);
                salida = false;
            }
            if (txt_Contrasenia1.Text.Trim () == "") {
                errorProvider1.SetError (txt_Contrasenia1, mensaje);
                salida = false;
            }
            if (txt_Contrasenia2.Text.Trim () == "") {
                errorProvider1.SetError (txt_Contrasenia2, mensaje);
                salida = false;
            }
            if (salida == true && txt_Contrasenia1.Text.Trim () != txt_Contrasenia2.Text.Trim ()) {
                errorProvider1.SetError (txt_Contrasenia2, "Las contraseñas no coinciden.");
                salida = false;
            }
            return salida;
        }
        #endregion



        #region Validaciones de FrmCliente Registrar
        // Validaciones correspondientes para el formulario de Registrar Cliente

        internal bool esCorrectoDatosCliente(TextBox txt_Cedula, ComboBox cmbhospital, TextBox txt_Nombre1, TextBox txt_Nombre2, TextBox txt_Apellido1, TextBox txt_Apellido2, TextBox txt_Correo, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNac, TextBox txt_NombreUsuario, TextBox txt_Contrasenia1, TextBox txt_Contrasenia2, ErrorProvider errorProvider1)
        {
            bool salida = true;
            string mensaje = "Campo obligatorio.";
            string correo = txt_Correo.Text.Trim();
            if (txt_Cedula.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_Cedula, mensaje);
                salida = false;
            }
            if (txt_Nombre1.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_Nombre1, mensaje);
                salida = false;
            }
            if (txt_Nombre2.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_Nombre2, mensaje);
                salida = false;
            }
            if (txt_Apellido1.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_Apellido1, mensaje);
                salida = false;
            }
            if (txt_Apellido2.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_Apellido2, mensaje);
                salida = false;
            }
            if (correo == "")
            {
                errorProvider1.SetError(txt_Correo, mensaje);
                salida = false;
            }
            else
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(correo);
                    //return addr.Address == correo;
                }
                catch
                {
                    errorProvider1.SetError(txt_Correo, "Correo no valido.");
                    salida = false;
                }
            }
            if (txt_Telefono.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_Telefono, mensaje);
                salida = false;
            }
            if (cmbhospital.Text == "--Seleccione--")
            {
                errorProvider1.SetError(cmbhospital, "Seleccione un Hospital");
                salida = false;
            }
            if (rdb_Femenino.Checked == rdb_Masculino.Checked)
            {
                errorProvider1.SetError(rdb_Femenino, mensaje);
                salida = false;
            }
            if (dtp_FechaNac.Text == null)
            {
                errorProvider1.SetError(dtp_FechaNac, mensaje);
                salida = false;
            }
            if (txt_NombreUsuario.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_NombreUsuario, mensaje);
                salida = false;
            }
            if (txt_Contrasenia1.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_Contrasenia1, mensaje);
                salida = false;
            }
            if (txt_Contrasenia2.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_Contrasenia2, mensaje);
                salida = false;
            }
            if (salida == true && txt_Contrasenia1.Text.Trim() != txt_Contrasenia2.Text.Trim())
            {
                errorProvider1.SetError(txt_Contrasenia2, "Las contraseñas no coinciden.");
                salida = false;
            }
            return salida;
        }
        #endregion
    }
}
