using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual {
    public partial class Frm_Conductor_Consultar : Form {

        Btn_Comportamiento cbtn = new Btn_Comportamiento ();
        Adm_Conductor admConductor = Adm_Conductor.GetAdm ();
        Adm_General admGeneral = Adm_General.GetAdm ();

        public Frm_Conductor_Consultar () {
            InitializeComponent ();
        }

        #region Efecto boton consultar
        private void btnconsultar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }

        private void btnconsultar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }
        #endregion

        #region Efecto boton mostrar todos
        private void btnmostrartodos_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }

        private void btnmostrartodos_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }
        #endregion

        #region Efecto boton guardar
        private void btnguardar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }

        private void btnguardar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }
        #endregion

        #region Efecto boton imprimir
        private void btnimprimir_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }

        private void btnimprimir_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }
        #endregion

        private void Frm_Conductor_Consultar_Load (object sender, EventArgs e) {
            // Load changes
            this.pncontenido.BackColor = Color.FromArgb (140, 255, 255, 255);
            // admConductor.listarDisponibilidad (cmb_Disponibilidad);
            // admGeneral.

            admConductor.listarDatosConductor (dgv_Conductor);
            cmb_Disponibilidad.Enabled = false;
        }

        private void chb_Disponibilidad_CheckedChanged (object sender, EventArgs e) {
            if (chb_Disponibilidad.Checked) {
                cmb_Disponibilidad.Enabled = true;
            } else {
                cmb_Disponibilidad.Enabled = false;
            }
        }

        private void txt_CedulaNombre_KeyPress (object sender, KeyPressEventArgs e) {
            if (rdb_Cedula.Checked) {
                txt_CedulaNombre.MaxLength = 10;
                // Only allows numbers on press
                admConductor.validarSoloNumerosKeyPress (sender, e);
            } else {
                txt_CedulaNombre.MaxLength = 300;
                // Only allows alphabetic characters
                admConductor.validarSoloLettrasKeyPress (sender, e);
            }
        }

        private void rdb_Cedula_CheckedChanged (object sender, EventArgs e) {
            txt_CedulaNombre.Clear ();
        }

        private void btn_MostrarTodos_Click (object sender, EventArgs e) {
            admConductor.listarDatosConductor (dgv_Conductor);
        }

        private void btn_Consultar_Click (object sender, EventArgs e) {
            string cedula = null;
            string nombre = null;
            string disponibilidad = null;
            errorProvider.Clear ();
            if (txt_CedulaNombre.Text.Trim () == "" && chb_Disponibilidad.Checked == false) {
                errorProvider.SetError (txt_CedulaNombre, "Opcional 1");
                errorProvider.SetError (chb_Disponibilidad, "Opcional 2");
            } else {
                if (rdb_Cedula.Checked) {
                    cedula = txt_CedulaNombre.Text.Trim ();
                } else {
                    nombre = txt_CedulaNombre.Text.Trim ();
                }
                if (chb_Disponibilidad.Checked) {
                    disponibilidad = cmb_Disponibilidad.SelectedValue.ToString ();
                }
                admConductor.buscarDatosConductor (dgv_Conductor, cedula, nombre, disponibilidad);
            }
        }

        private void btn_Modificar_Click (object sender, EventArgs e) {

        }

        private void btn_Imprimir_Click (object sender, EventArgs e) {
            DataTable dataTable_resultado = new DataTable ();
            // Convert DataGridView to DataTable
            dataTable_resultado = (DataTable)dgv_Conductor.DataSource;
            // Defines the file extension
            saveFileDialog1.DefaultExt = "pdf";
            // Defines a filter for the file explorer
            saveFileDialog1.Filter = "Pdf File |*.pdf";
            // Defines a title to saveFileDialog
            saveFileDialog1.Title = "SGAR: Conductores - Guardar";
            if (saveFileDialog1.ShowDialog () == DialogResult.OK) {
                // Captures file's path
                string file = saveFileDialog1.FileName;
                // Creates PDF file
                admConductor.CrearPdf (dataTable_resultado, file);
                //
                if (File.Exists (file)) {
                    // Opens PDF file
                    Process.Start (file);
                }
            }
        }


    }
}
