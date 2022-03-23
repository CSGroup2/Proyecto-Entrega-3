using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual {
    public partial class Frm_Conductor_Editar : Form {
        Btn_Comportamiento cbtn = new Btn_Comportamiento ();
        Adm_Conductor admConductor = Adm_Conductor.GetAdm ();
        Adm_General admGeneral = Adm_General.GetAdm ();
        Adm_Ambulancia admAmbulancia = Adm_Ambulancia.GetAdm ();

        public Frm_Conductor_Editar () {
            InitializeComponent ();
            cargarEstados ();
            cargarDisponibilidad ();
        }

        public Frm_Conductor_Editar (int posicion, int idConductor) {
            // Constructor overcharge
            InitializeComponent ();
            cargarEstados ();
            cargarDisponibilidad ();
            llenarCamposEditar (posicion, idConductor);
        }



        #region <<Load components at start----------------------------------------------

        private void Frm_Conductor_Editar_Load (object sender, EventArgs e) {
            this.pncontenido.BackColor = Color.FromArgb (200, 255, 255, 255);
            cargarEstados ();
            cargarDisponibilidad ();
        }

        private void cargarDisponibilidad () {
            admAmbulancia.LlenarComboDisponibilidad (cmb_Disponibilidad);
        }

        private void cargarEstados () {
            cmb_Estado.Items.Clear ();
            cmb_Estado.DataSource = admGeneral.listerEstados ();
            cmb_Estado.ValueMember = "ID_ESTADO";
            cmb_Estado.DisplayMember = "NOMBRE_ESTADO";
        }

        private void llenarCamposEditar (int posicion, int idConductor) {
            admConductor.buscarDatosConductorEditar (posicion, idConductor, lbl_IdConductor, txt_Cedula, cmb_Estado, txt_Nombre1, txt_Nombre2, txt_Apellido1, txt_Apellido2, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNacimiento, dtp_FechaContrato);
        }

        #endregion <<Load components at start----------------------------------------------


        #region KeyPress Events------------------------------------------------
        private void txt_Cedula_KeyPress (object sender, KeyPressEventArgs e) {
            // Only allows numbers on press
            admConductor.validarSoloNumerosKeyPress (sender, e);
        }

        private void txt_Nombre1_KeyPress (object sender, KeyPressEventArgs e) {
            // Only allows alphabetic characters
            admConductor.validarSoloLettrasKeyPress (sender, e);
        }

        private void txt_Correo_KeyPress (object sender, KeyPressEventArgs e) {
            // Only allows eamil characters
            admConductor.validarSoloCorreoKeypress (sender, e);
        }
        #endregion



        #region Efecto boton Cancelar
        private void btn_Cancelar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activabotonPer (sender, Color.Firebrick);
        }

        private void btn_Cancelar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion

        #region Efecto boton guardar
        private void btn_Guardar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activabotonPer (sender, Color.LimeGreen);
        }

        private void btn_Guardar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion

        private void btn_Guardar_Click (object sender, EventArgs e) {
            errorProvider.Clear ();
            if (admConductor.esCorrectoDatosConductorValidacionEditar (txt_Cedula, txt_Nombre1, txt_Apellido1, txt_Apellido2, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNacimiento, dtp_FechaContrato, errorProvider)) {
                int id = Convert.ToInt32(lbl_IdConductor.Text);
                string
                   cedula = txt_Cedula.Text.Trim (),
                   estado = cmb_Estado.Text,
                   nombre1 = txt_Nombre1.Text.Trim (),
                   nombre2 = txt_Nombre2.Text.Trim (),
                   apellido1 = txt_Apellido1.Text.Trim (),
                   apellido2 = txt_Apellido2.Text.Trim (),
                   disponibilidad = cmb_Estado.Text,
                   telefono = txt_Telefono.Text.Trim (),
                   sexo = admConductor.esSexoValidacion (rdb_Masculino, rdb_Femenino);
                DateTime
                    fecha_nac = dtp_FechaNacimiento.Value.Date,
                    fecha_contrato = dtp_FechaContrato.Value.Date;
                string mensaje = admConductor.actualizarDatosConductor (id, cedula, estado, nombre1, nombre2, apellido1, apellido2, telefono, sexo, fecha_nac, fecha_contrato);
                if (mensaje[0] != '¡') {
                    admConductor.limpiarCamposGuardarConductorEditar (txt_Cedula, txt_Nombre1, txt_Nombre2, txt_Apellido1, txt_Apellido2, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNacimiento, dtp_FechaContrato, errorProvider);
                }
            }
        }

        private void btn_Cancelar_Click (object sender, EventArgs e) {
            this.Close ();
        }

    }
}
