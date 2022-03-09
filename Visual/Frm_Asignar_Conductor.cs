using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Visual
{
    public partial class Frm_Asignar_Conductor : Form
    {
        Frm_Asignacion_Registrar frm;
        Adm_Asignacion adm = Adm_Asignacion.GetAdm();
        //private string id_conductor = "";

        public Frm_Asignar_Conductor(Frm_Asignacion_Registrar frmA)
        {
            InitializeComponent();
            adm.llenarTablaConductorAsignar(dgvConductores);
            this.frm = frmA;
            btnElegir.Enabled = false;
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

        private void btnElegir_Click(object sender, EventArgs e)
        {
            frm.lbl_id_conductor.Text = GetValorCelda(dgvConductores, 0);
            frm.lbl_conductor.Text = GetValorCelda(dgvConductores,1);
            this.Close();
        }

        private void dgvConductores_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (GetValorCelda(dgvConductores, 0) != "")
                btnElegir.Enabled = true;
        }
    }
}
