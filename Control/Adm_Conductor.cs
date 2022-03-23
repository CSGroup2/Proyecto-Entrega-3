using Datos;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control {
    public class Adm_Conductor {

        /*
           Aplicar el patron de diseño Singleton:
           1. Crear 1 atributo estático y privado de la misma clase.
           2. Cambiar el constructor de public a private.
           3.1. Crear un getter del atributo estático del tipo de la clase.
           3.2.Verificar si atributo es null, si es así, crearlo.
       */

        private static Adm_Conductor adm_conductor = null;    // 1.
        List<Conductor> Lista_Conductor = null;
        Conductor Conductor = null;
        Datos_Conductor Datos_Conductor = null;
        Validacion Validacion = null;

        //Persona Persona = null;

        //public Usuario_Cache UsuarioCache { get => usuarioCache; set => usuarioCache = value; }

        // Constructor: Adm_Login
        private Adm_Conductor () {                  // 2.
            Lista_Conductor = new List<Conductor> ();
            Conductor = new Conductor ();
            Datos_Conductor = new Datos_Conductor ();
            Validacion = new Validacion ();
        }

        // Getter: GetAdm
        public static Adm_Conductor GetAdm () {     // 3.1.
            if (adm_conductor == null) {                  //3.2
                adm_conductor = new Adm_Conductor ();
            }
            return adm_conductor;
        }

        /*---------------------Frm_Conductor_Consultar---------------------------------*/

        #region Frm_Conductor_Consultar

        public void listarDatosConductor (DataGridView dgv_Conductor) {
            dgv_Conductor.Refresh ();
            dgv_Conductor.DataSource = Datos_Conductor.listarDatosConductor ();
        }
        
        public void listarDisponibilidad (ComboBox cbx_Disponibilidad) {
            cbx_Disponibilidad.DataSource = Datos_Conductor.listarDatosDisponibilidad ();
            cbx_Disponibilidad.ValueMember = "ID_DISPONIBILIDAD";
            cbx_Disponibilidad.DisplayMember = "NOMBRE_DISPONIBILIDAD";
        }

        public DataTable buscarDatosConductor (string cedula_nombre, string disponibilidad) {
           return Datos_Conductor.buscarDatosConductor (cedula_nombre, disponibilidad);
        }

        #endregion

        /*---------------------Frm_Conductor_Editar---------------------------------*/

        #region Frm_Conductor_Editar

        public void buscarDatosConductorEditar (int posicion, int idConductor, Label lbl_IdConductor, TextBox txt_Cedula, ComboBox cmb_Estado, TextBox txt_Nombre1, TextBox txt_Nombre2, TextBox txt_Apellido1, TextBox txt_Apellido2, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNacimiento, DateTimePicker dtp_FechaContrato) {
            Conductor = new Conductor ();
            Conductor = Datos_Conductor.buscarDatosConductorEditar (idConductor);
            lbl_IdConductor.Text = Conductor.Id_conductor.ToString ();
            txt_Cedula.Text = Conductor.Cedula.ToString ();
            cmb_Estado.SelectedItem = Conductor.Estado;
            txt_Nombre1.Text = Conductor.Nombre_1.ToString ();
            txt_Nombre2.Text = Conductor.Nombre_2.ToString ();
            txt_Apellido1.Text = Conductor.Apellido_1.ToString ();
            txt_Apellido2.Text = Conductor.Apellido_2.ToString ();
            //txt_Correo.Text = Conductor.
            txt_Telefono.Text = Conductor.Telefono.ToString ();
            if (Conductor.Sexo.ToString() == "Masculino") {
                rdb_Masculino.Checked = true;
            } else {
                rdb_Femenino.Checked = true;
            }
            dtp_FechaNacimiento.Text = Conductor.Fecha_nac.ToString ();
            dtp_FechaContrato.Text = Conductor.Fecha_contrato.ToString ();
        }

        

        public string actualizarDatosConductor (int id, string cedula, string estado, string nombre1, string nombre2, string apellido1, string apellido2, string telefono, string sexo, DateTime fecha_nac, DateTime fecha_contrato) {
            string mensaje = "¡"; // '¡' in case of incorrec data on fields   
            Conductor = new Conductor (id, fecha_contrato, "", 0, cedula, nombre1, nombre2, apellido1, apellido2, sexo, fecha_nac, telefono, estado);
            mensaje = Datos_Conductor.actualizarDatosConductor (Conductor);
            MessageBox.Show (mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return mensaje;
        }

        public void limpiarCamposGuardarConductorEditar (TextBox txt_Cedula, TextBox txt_Nombre1, TextBox txt_Nombre2, TextBox txt_Apellido1, TextBox txt_Apellido2, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNacimiento, DateTimePicker dtp_FechaContrato, ErrorProvider errorProvider) {
            errorProvider.Clear ();
            txt_Cedula.Clear ();
            txt_Nombre1.Clear ();
            txt_Nombre2.Clear ();
            txt_Apellido1.Clear ();
            txt_Apellido2.Clear ();
            txt_Telefono.Clear ();
            rdb_Masculino.Checked = false;
            rdb_Femenino.Checked = false;
            dtp_FechaNacimiento.Value = DateTime.Today;
            dtp_FechaContrato.Value = DateTime.Today;
        }

        #endregion

        /*---------------------Frm_Conductor_Registrar---------------------------------*/

        #region Frm_Conductor_Registrar

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

        // Methods for Buttons
        public string guardarDatosConductor (string cedula, string nombre1, string nombre2, string apellido1, string apellido2, string telefono, string sexo, DateTime fecha_nac, DateTime fecha_contrato) {
            string mensaje = "¡"; // '¡' in case of incorrec data on fields   
            Conductor = new Conductor (0, fecha_contrato, "", 0, cedula, nombre1, nombre2, apellido1, apellido2, sexo, fecha_nac, telefono, "");
            mensaje = Datos_Conductor.insertarDatosConductor (Conductor);
            MessageBox.Show (mensaje, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return mensaje;
        }

        public void limpiarCamposGuardarConductor (TextBox txt_Cedula, TextBox txt_Nombre1, TextBox txt_Nombre2, TextBox txt_Apellido1, TextBox txt_Apellido2, TextBox txt_Correo, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNac, DateTimePicker dtp_FechaContrato, ErrorProvider errorProvider1) {
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
        }

        

        // Validations
        public string esSexoValidacion (RadioButton rdb_Masculino, RadioButton rdb_Femenino) {
            return Validacion.esSexo (rdb_Masculino, rdb_Femenino);
        }

        public bool esCorrectoDatosConductorValidacion (TextBox txt_Cedula, TextBox txt_Nombre1, TextBox txt_Apellido1, TextBox txt_Apellido2, TextBox txt_Correo, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNac, DateTimePicker dtp_FechaContrato, ErrorProvider errorProvider1) {
            return Validacion.esCorrectoDatosConductor (txt_Cedula, txt_Nombre1, txt_Apellido1, txt_Apellido2, txt_Correo, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNac, dtp_FechaContrato, errorProvider1);
        }

        public bool esCorrectoDatosConductorValidacionEditar (TextBox txt_Cedula, TextBox txt_Nombre1, TextBox txt_Apellido1, TextBox txt_Apellido2, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNacimiento, DateTimePicker dtp_FechaContrato, ErrorProvider errorProvider) {
          return Validacion.esCorrectoDatosConductorEditar (txt_Cedula, txt_Nombre1, txt_Apellido1 ,txt_Apellido2, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNacimiento, dtp_FechaContrato, errorProvider);
        }

        #endregion


        /*- Billy ------------------------------------------------------*/

        #region

        internal void ListarConductoresDisponibles (DataGridView dgvConductores) {
            dgvConductores.Refresh ();
            Datos_Conductor = new Datos_Conductor ();
            dgvConductores.DataSource = Datos_Conductor.ListarConductoresDisponibles ();
        }

        #endregion
    }
}
