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
    public partial class Frm_Asignacion_Editar : Form
    {
        int idAs = 0;
        Adm_Asignacion adm = Adm_Asignacion.GetAdm();
        public Frm_Asignacion_Editar(int idAs)
        {
            InitializeComponent();
            adm.LlenarCamposAsignacionEditar(idAs, lblCliente, lbl_TipoAmbulancia, lbl_cantAmbulancia, lblOrigen, lblDestino);
            adm.LlenarCombos(cmbConductores, cmbAmbulancias);
            adm.LlenarDgvEditar(idAs, dgvAmb_Cond);
            this.idAs = idAs;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            string idConductor = cmbConductores.SelectedValue.ToString(),
                nombreConductor = cmbConductores.GetItemText(cmbConductores.SelectedItem).ToString(),
                idAmbulancia = cmbAmbulancias.SelectedValue.ToString(),
                nombreAmbulancia = cmbAmbulancias.GetItemText(cmbAmbulancias.SelectedItem).ToString();

            int v = dgvAmb_Cond.CurrentRow.Index;

            if (idConductor != "0" || idAmbulancia != "0")
            {
                if (idConductor != "0")
                {
                    dgvAmb_Cond[1, v].Value = idConductor;
                    dgvAmb_Cond[2, v].Value = nombreConductor;
                }
                if (idAmbulancia != "0")
                {
                    dgvAmb_Cond[3, v].Value = idAmbulancia;
                    dgvAmb_Cond[4, v].Value = nombreAmbulancia;
                }
                MessageBox.Show("Asignado con exito.");
                cmbAmbulancias.SelectedValue = 0;
                cmbConductores.SelectedValue = 0;
            }
            else
                MessageBox.Show("Elija conductores o ambulancias para asignar.");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            adm.LimpiarCmbs(cmbAmbulancias,cmbConductores);
            adm.LlenarDgvEditar(idAs, dgvAmb_Cond);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string msj = "";
            for (int i=0;i< dgvAmb_Cond.Rows.Count;i++) {
                int id_detalle = Int32.Parse(dgvAmb_Cond[0, i].Value.ToString());
                int id_conductor = Int32.Parse(dgvAmb_Cond[1, i].Value.ToString());
                int id_ambulancia = Int32.Parse(dgvAmb_Cond[3, i].Value.ToString());

                msj = adm.EditarAsignacionDetalle(id_detalle, id_conductor, id_ambulancia);
            }
            if (msj == "1")
                MessageBox.Show("Guardado con éxito.");
            else
                MessageBox.Show(msj);
        }
    }
}
