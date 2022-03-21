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

        public Frm_Conductor_Consultar () {
            InitializeComponent ();
            this.pncontenido.BackColor = Color.FromArgb (140, 255, 255, 255);
            admConductor.listarDatosConductor (dgv_Conductor);
            admConductor.listarDisponibilidad (cbx_Disponibilidad);
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

        private void btn_Modificar_Click (object sender, EventArgs e) {

        }

        private void btn_Imprimir_Click (object sender, EventArgs e) {
            DataTable dt = new DataTable ();
            // Convert DataGridView to DataTable
            dt = (DataTable)dgv_Conductor.DataSource;
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
                admConductor.CrearPdf (dt, file);

                if (File.Exists (file)) {
                    // Opens PDF file
                    Process.Start (file);
                }
            }
        }

        private void btn_MostrarTodos_Click (object sender, EventArgs e) {

        }

        private void btn_Consultar_Click (object sender, EventArgs e) {

        }
    }
}
