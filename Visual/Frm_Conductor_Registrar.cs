using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;

namespace Visual {
    public partial class Frm_Conductor_Registrar : Form {

        Adm_Conductor admConductor = Adm_Conductor.GetAdm ();

        Btn_Comportamiento cbtn = new Btn_Comportamiento ();

        public Frm_Conductor_Registrar () {
            InitializeComponent ();
            rdb_Masculino.Checked = false;
        }

        private void FrmConductorReg_Load (object sender, EventArgs e) {
            this.pncontenido.BackColor = Color.FromArgb (200, 255, 255, 255);
        }

        private void textBox7_TextChanged (object sender, EventArgs e) {

        }

        #region Efecto boton limpiar
        private void btnlimpiar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }

        private void btnlimpiar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion

        #region Efecto boton cancelar
        private void btncancelar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }

        private void btncancelar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }

        #endregion

        #region Efecto boton guardar
        private void btnguardar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }

        private void btnguardar_MouseMove_1 (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }
        #endregion



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

        private void btn_Guardar_Click (object sender, EventArgs e) {
            errorProvider1.Clear ();
            if (admConductor.esCorrectoDatosConductorValidacion (txt_Cedula, txt_Nombre1, txt_Nombre2, txt_Apellido1, txt_Apellido2, txt_Correo, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNac, dtp_FechaContrato, errorProvider1)) {
                string
                   cedula = txt_Cedula.Text.Trim (),
                   nombre1 = txt_Nombre1.Text.Trim (),
                   nombre2 = txt_Nombre2.Text.Trim (),
                   apellido1 = txt_Apellido1.Text.Trim (),
                   apellido2 = txt_Apellido2.Text.Trim (),
                   telefono = txt_Telefono.Text.Trim (),
                   sexo = admConductor.esSexoValidacion (rdb_Masculino, rdb_Femenino);
                DateTime
                    fecha_nac = dtp_FechaNac.Value.Date,
                    fecha_contrato = dtp_FechaContrato.Value.Date;
                string mensaje = admConductor.guardarDatosConductor (cedula, nombre1, nombre2, apellido1, apellido2, telefono, sexo, fecha_nac, fecha_contrato);
                if (mensaje[0] != '¡') {
                    admConductor.limpiarCamposGuardarConductor (txt_Cedula, txt_Nombre1, txt_Nombre2, txt_Apellido1, txt_Apellido2, txt_Correo, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNac, dtp_FechaContrato, errorProvider1);
                }
            }
        }

        private void btn_Cancelar_Click (object sender, EventArgs e) {
            this.Close ();
        }

        private void btn_Limpiar_Click (object sender, EventArgs e) {
            admConductor.limpiarCamposGuardarConductor (txt_Cedula, txt_Nombre1, txt_Nombre2, txt_Apellido1, txt_Apellido2, txt_Correo, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNac, dtp_FechaContrato, errorProvider1);
        }

    }
}
