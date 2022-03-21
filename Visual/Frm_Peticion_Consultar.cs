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
    public partial class Frm_Peticion_Consultar : Form
    {
        Adm_Peticion adm = Adm_Peticion.GetAdm();
        public Frm_Peticion_Consultar()
        {
            InitializeComponent();
        }

        private void Frm_Peticion_Consultar_Load(object sender, EventArgs e)
        {
            adm.llenarTablaPeticion(dgvPeticion);
        }

        private static string GetValorCelda(DataGridView dgv, int num)
        {
            string valor = "";

            valor = dgv.Rows[dgv.CurrentRow.Index].Cells[num].Value.ToString();

            return valor;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt_Destino.Text="";
            adm.llenarTablaPeticion(dgvPeticion);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            adm.filtrarXDestino(txt_Destino, dgvPeticion);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(GetValorCelda(dgvPeticion, 0));
            if (id != 0)
            {
                var result = MessageBox.Show("Seguro desea eliminar la petición.", "Advertencia",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                if (result != DialogResult.No)
                MessageBox.Show(adm.eliminarPeticion(id, dgvPeticion).ToString());
            }
            else {
                MessageBox.Show("Seleccione una petición a eliminar.");
            }
            
        }
    }
}
