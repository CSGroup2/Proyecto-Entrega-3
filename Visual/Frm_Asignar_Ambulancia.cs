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
    public partial class Frm_Asignar_Ambulancia : Form
    {
        Frm_Asignacion_Registrar frm;
        Adm_Asignacion adm = Adm_Asignacion.GetAdm();
        public Frm_Asignar_Ambulancia(Frm_Asignacion_Registrar frmA)
        {
            InitializeComponent();
            adm.llenarTablaAmbulanciaAsignar(dgvAmbulancia);
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
            frm.lbl_id_ambulancia.Text = GetValorCelda(dgvAmbulancia, 0);
            frm.lbl_Placa.Text = GetValorCelda(dgvAmbulancia, 2);
            this.Close();
        }

        private void dgvAmbulancia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (GetValorCelda(dgvAmbulancia, 0)!="") 
            {
                btnElegir.Enabled = true;
            }
        }
    }
}
