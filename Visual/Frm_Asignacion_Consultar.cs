using System;
using Control;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Visual
{
    public partial class Frm_Asignacion_Consultar : Form
    {
        Adm_Asignacion adm = Adm_Asignacion.GetAdm();
        Adm_PDF admPDF = Adm_PDF.GetAdm();
        public Frm_Asignacion_Consultar()
        {
            InitializeComponent();
            adm.LlenarTablaAsignaciones(dgvAsignaciones);
        }

        private static string GetValorCelda(DataGridView dgv, int num)
        {
            string valor = "";

            valor = dgv.Rows[dgv.CurrentRow.Index].Cells[num].Value.ToString();

            return valor;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            adm.LimpiarCamposConsulta(txt_Cedula, rdbCumplida, rdbProgreso);
            adm.LlenarTablaAsignaciones(dgvAsignaciones);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txt_Cedula.Text != "" || (rdbCumplida.Checked == true || rdbProgreso.Checked == true))
            {
                adm.FiltarAsignaciones(dgvAsignaciones, txt_Cedula, rdbCumplida, rdbProgreso);
            }
            else {
                MessageBox.Show("Ingrese datos para buscar.");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)dgvAsignaciones.DataSource;
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "Pdf File |*.pdf";
            saveFileDialog1.Title = "SGAR: Asignaciones - Guardar";
            if (dt.Rows.Count > 0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string file = saveFileDialog1.FileName;
                    string[] columnas = { "Nº", "ID Asignación", "ID Petición", "Cédula", "Nombre", "Tipo Ambulancia", "# Ambulancias", "Origen", "Destino", "Estado" };
                    float[] tamanios = { 2, 2, 2, 3, 3, 3, 3, 4, 4, 3 };
                    admPDF.CrearPdf(dt, file, columnas, tamanios, 2);
                    if (File.Exists(file))
                    {
                        Process.Start(file);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay datos para imprimir");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idAs = Int32.Parse(GetValorCelda(dgvAsignaciones,0));
            Frm_Asignacion_Editar frmE = new Frm_Asignacion_Editar(idAs);
            frmE.ShowDialog();
        }
    }
}
