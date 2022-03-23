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
        Adm_PDF admPDF = Adm_PDF.GetAdm();
        Adm_General admGeneral = Adm_General.GetAdm ();
        Validacion validacion = new Validacion ();
        Frm_Menu frmMenu;

        public Frm_Conductor_Consultar () {
            InitializeComponent ();
        }

        public Frm_Conductor_Consultar (Frm_Menu Menu) {
            // Constructor overcharge
            InitializeComponent ();
            this.frmMenu = Menu;
        }

        private void Frm_Conductor_Consultar_Load (object sender, EventArgs e) {
            // Load changes
            this.pncontenido.BackColor = Color.FromArgb (140, 255, 255, 255);
            load_listarDisponibilidad ();
            load_listarDatosConductor ();
        }

        #region Frm load at begining

        public void load_listarDisponibilidad () {
            cmb_Disponibilidad.DataSource = admGeneral.listarDisponibilidad ();
            cmb_Disponibilidad.ValueMember = "ID_DISPONIBILIDAD";
            cmb_Disponibilidad.DisplayMember = "NOMBRE_DISPONIBILIDAD";
            cmb_Disponibilidad.Enabled = false;
        }

        public void load_listarDatosConductor () {
            admConductor.listarDatosConductor (dgv_Conductor);
        }

        #endregion

        #region Frm behavior

        #region Efectos botones

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

        #endregion

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

        #endregion

        private void btn_MostrarTodos_Click (object sender, EventArgs e) {
            admConductor.listarDatosConductor (dgv_Conductor);
        }

        private void btn_Consultar_Click (object sender, EventArgs e) {
            // Search for "conductor" data
            string cedula_nombre = null;
            string disponibilidad = null;
            errorProvider.Clear ();
            if (txt_CedulaNombre.Text.Trim () == "" && chb_Disponibilidad.Checked == false) {
                errorProvider.SetError (txt_CedulaNombre, "Opcional 1");
                errorProvider.SetError (chb_Disponibilidad, "Opcional 2");
            } else {
                if (!String.IsNullOrWhiteSpace (txt_CedulaNombre.Text)) {
                    cedula_nombre = txt_CedulaNombre.Text.Trim ().Replace (" ", String.Empty);
                }
                if (chb_Disponibilidad.Checked) {
                    disponibilidad = cmb_Disponibilidad.SelectedValue.ToString ();
                }
                dgv_Conductor.Refresh ();
                dgv_Conductor.DataSource = admConductor.buscarDatosConductor (cedula_nombre, disponibilidad);
            }
        }

        private void btn_Modificar_Click (object sender, EventArgs e) {
            int posicion = 0;
            int idConductor = 0;
            posicion = dgv_Conductor.CurrentRow.Index;
            if (posicion >= 0) {
                idConductor = validacion.AEntero (dgv_Conductor.Rows[posicion].Cells["ID"].Value.ToString ());
                frmMenu.abrirhijoform (new Frm_Conductor_Editar (posicion, idConductor));
            } else {
                MessageBox.Show ("Seleccione un conductor.");
            }
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
            if (dataTable_resultado.Rows.Count > 0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                    // Captures file's path
                    string file = saveFileDialog1.FileName;
                    
                    string[] columnas = { "Nº", "ID", "Cédula", "Estado", "Nombres", "Apellidos", "Disponibilidad", "Telefono", "Sexo", "Fecha_Nac", "Fecha_Contrato"};
                    float[] tamanios = { 1, float.Parse("1.5"), 1, 1, 3, 3, 3, 1, 2, 3, 3 };

                    // Creates PDF file
                    admPDF.CrearPdf(dataTable_resultado, file, columnas, tamanios, 2);
                    //
                    if (File.Exists(file)) {
                        // Opens PDF file
                        Process.Start(file);
                    }
                }
            } else
            {
                MessageBox.Show("No hay datos para imprimir");
            }
        }


    }
}
