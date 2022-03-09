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
    public partial class Frm_Asignar_PeticionConsulta : Form
    {
        Frm_Asignacion_Registrar frm;
        Adm_Asignacion adm = Adm_Asignacion.GetAdm();

        public Frm_Asignar_PeticionConsulta(Frm_Asignacion_Registrar frmA)
        {
            InitializeComponent();
            adm.llenarTablaPeticion(dgvPeticion);
            this.frm = frmA;
            btnElegir.Enabled = false;
        }

        public static string GetValorCelda(DataGridView dgv, int num)
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
            frm.lblIdPeticion.Text = GetValorCelda(dgvPeticion,0);
            frm.lblCliente.Text = GetValorCelda(dgvPeticion, 1);
            frm.lbl_TipoAmbulancia.Text = GetValorCelda(dgvPeticion,2);
            frm.lbl_cantAmbulancia.Text = GetValorCelda(dgvPeticion,3);
            frm.lblAmb_Restantes.Text = GetValorCelda(dgvPeticion,3);
            this.Close();
        }

        private void dgvPeticion_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (GetValorCelda(dgvPeticion, 0) != "")
                btnElegir.Enabled = true;
        }
    }
}
