using System;
using Control;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Visual
{
    public partial class Frm_Asignacion_Consultar : Form
    {
        Adm_Asignacion adm = Adm_Asignacion.GetAdm();
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
    }
}
