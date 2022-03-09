using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Visual {
    public partial class Frm_Secretaria_Registrar : Form {
        Adm_Secretaria admSecretaria = Adm_Secretaria.GetAdm ();

        public Frm_Secretaria_Registrar () {
            InitializeComponent ();
        }

        private void txt_Cedula_KeyPress (object sender, KeyPressEventArgs e) {
            admSecretaria.validarSoloNumerosKeyPress (sender, e);
        }

        private void txt_Nombre1_KeyPress (object sender, KeyPressEventArgs e) {
            admSecretaria.validarSoloLettrasKeyPress (sender, e);
        }

        private void txt_Correo_KeyPress (object sender, KeyPressEventArgs e) {
            admSecretaria.validarSoloCorreoKeypress (sender, e);
        }

        private void btn_Guardar_Click (object sender, EventArgs e) {
            errorProvider1.Clear ();
            if (admSecretaria.esCorrectoDatosSecretariaValidacion (txt_Cedula, txt_Nombre1, txt_Nombre2, txt_Apellido1, txt_Apellido2, txt_Correo, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNac, dtp_FechaContrato, txt_NombreUsuario, txt_Contrasenia1, txt_Contrasenia2, errorProvider1)) {
                string
                   cedula = txt_Cedula.Text.Trim (),
                   nombre1 = txt_Nombre1.Text.Trim (),
                   nombre2 = txt_Nombre2.Text.Trim (),
                   apellido1 = txt_Apellido1.Text.Trim (),
                   apellido2 = txt_Apellido2.Text.Trim (),
                   correo = txt_Correo.Text.Trim (),
                   telefono = txt_Telefono.Text.Trim (),
                   sexo = admSecretaria.esSexoValidacion (rdb_Masculino, rdb_Femenino),
                   nombre_usuario = txt_NombreUsuario.Text.Trim (),
                   contrasenia1 = txt_Contrasenia1.Text.Trim ();
                DateTime
                    fecha_nac = dtp_FechaNac.Value.Date,
                    fecha_contrato = dtp_FechaContrato.Value.Date;
                string mensaje = admSecretaria.guardarDatosSecretaria (cedula, nombre1, nombre2, apellido1, apellido2, correo, telefono, sexo, fecha_nac, fecha_contrato, nombre_usuario, contrasenia1);
                if (mensaje[0] != '¡') {
                    admSecretaria.limpiarCamposGuardarSecretaria (txt_Cedula, txt_Nombre1, txt_Nombre2, txt_Apellido1, txt_Apellido2, txt_Correo, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNac, dtp_FechaContrato, txt_NombreUsuario, txt_Contrasenia1, txt_Contrasenia2, errorProvider1);
                }
            }
        }

        private void btn_Cancelar_Click (object sender, EventArgs e) {
            this.Close ();
        }

        private void btn_Limpiar_Click (object sender, EventArgs e) {
            admSecretaria.limpiarCamposGuardarSecretaria (txt_Cedula, txt_Nombre1, txt_Nombre2, txt_Apellido1, txt_Apellido2, txt_Correo, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNac, dtp_FechaContrato, txt_NombreUsuario, txt_Contrasenia1, txt_Contrasenia2, errorProvider1);
        }


    }
}
