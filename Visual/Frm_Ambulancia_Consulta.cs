
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
    public partial class Frm_Ambulancia_Consultar : Form {

        Adm_Ambulancia admA = Adm_Ambulancia.GetAdm();
        Adm_PDF admPDF = Adm_PDF.GetAdm();
        public int buscarOb, buscarOp;
        Btn_Comportamiento cbtn = new Btn_Comportamiento ();

        Frm_Menu menu;

        public Frm_Ambulancia_Consultar () {
            InitializeComponent ();
        }

        public Frm_Ambulancia_Consultar(Frm_Menu menuu)
        {
            InitializeComponent();
            this.menu = menuu;
        }

        private void FrmAmbulanciaConsul_Load (object sender, EventArgs e) {
            this.pncontenido.BackColor = Color.FromArgb (140, 255, 255, 255);
            admA.LlenarComboTipoAmbulancia(cmbTipo);
            admA.ListarAmbulancias(dgvAmbulancias);
        }

        #region Efecto boton Consultar 
        private void btnconsultar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }
        private void btnconsultar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion

        #region Efecto boton mostrar todos
        private void btnmostrartodos_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }

        private void btnmostrartodos_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion

        #region Efecto boton Guardar
        private void btnguardar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }

        private void btnguardar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion

        #region Efecto boton Imprimir
        private void btnimprimir_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }

        private void btnimprimir_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion

        private void btnMostrartodos_Click(object sender, EventArgs e)
        {
            admA.ListarAmbulancias(dgvAmbulancias);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int posicion = dgvAmbulancias.CurrentRow.Index;
            if (posicion >= 0)
            {
                menu.abrirhijoform(new Frm_Ambulancia_Editar(dgvAmbulancias));
            }
            else
            {
                MessageBox.Show("Seleccione una ambulancia");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)dgvAmbulancias.DataSource;
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "Pdf File |*.pdf";
            //saveFileDialog1.FileName = "lista_ambulancia.pdf";
            saveFileDialog1.Title = "SGAR: Ambulancias - Guardar";
            if (dt.Rows.Count > 0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string file = saveFileDialog1.FileName;
                    string[] columnas = { "Nº", "id", "disponibilidad", "placa", "modelo", "tipo", "capacidad", "observación" };
                    float[] tamanios = { 2, 2, 3, 4, 4, 3, 2, 5 };
                    admPDF.CrearPdf(dt, file, columnas, tamanios, 1);
                    if (File.Exists(file))
                    {
                        Process.Start(file);
                    }
                }
            }else{
                MessageBox.Show("No hay datos para imprimir");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string msj = "", placa = "";
            int posicion = dgvAmbulancias.CurrentRow.Index;
            if (posicion >= 0)
            {
                placa = dgvAmbulancias.Rows[posicion].Cells["placa"].Value.ToString();
                dgvAmbulancias.Rows.RemoveAt(posicion);
                msj = admA.EliminarDatosAmbulancia(placa);
                MessageBox.Show(msj);
            }
            else
            {
                MessageBox.Show("Seleccione una ambulancia");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int tipo = 0;
            if (admA.ValidarC(rdbPlaca, txtDato, chbTipo, cmbTipo, errorP))
            {
                if (rdbPlaca.Checked == true)
                {
                    buscarOb = 1;
                }
                else
                {
                    buscarOb = 2;
                }
                if (chbDisponibilidad.Checked == true && chbTipo.Checked == true)
                {
                    buscarOp = 3;
                    tipo = Int32.Parse(cmbTipo.SelectedValue.ToString());
                }
                else if (chbTipo.Checked == true)
                {
                    buscarOp = 2;
                    tipo = Int32.Parse(cmbTipo.SelectedValue.ToString());
                }
                else if(chbDisponibilidad.Checked == true)
                {
                    buscarOp = 1;
                }
                else
                {
                    buscarOp = 0;
                }
                string dato = txtDato.Text;
                dgvAmbulancias.Refresh();
                dgvAmbulancias.DataSource = admA.ConsultarAmbulancias(dato, tipo, buscarOb, buscarOp);
            }
        }
    }
}
