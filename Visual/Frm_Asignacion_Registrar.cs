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
    public partial class Frm_Asignacion_Registrar : Form
    {
        Adm_Asignacion adm = Adm_Asignacion.GetAdm();
        public Frm_Asignacion_Registrar()
        {
            InitializeComponent();
            lbl_id_ambulancia.Visible = false;
            lbl_id_conductor.Visible = false;
            btnGuardar.Enabled = false;
            btnAsignar.Enabled = false;
            btnConductor.Enabled = false;
            btnAmbulancia.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConductor_Click(object sender, EventArgs e)
        {
            Frm_Asignar_Conductor frm = new Frm_Asignar_Conductor(this);
            frm.ShowDialog();
        }

        private void btnAmbulancia_Click(object sender, EventArgs e)
        {
            Frm_Asignar_Ambulancia frm = new Frm_Asignar_Ambulancia(this);
            frm.ShowDialog();
        }

        private void btnPeticion_Click(object sender, EventArgs e)
        {
            if (lblIdPeticion.Text == "")
            {
                Frm_Asignar_PeticionConsulta frm = new Frm_Asignar_PeticionConsulta(this);
                frm.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Está asignando una petición,\n si desea hacer otra primero limpie los campos.");
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            string id_conductor = lbl_id_conductor.Text.ToString(), id_ambulancia = lbl_id_ambulancia.Text.ToString(), id_peticion = lblIdPeticion.Text.ToString();
            if(id_conductor!="" && id_ambulancia!="" && id_peticion != "")
            {
                adm.enlistarCond_AmbAsignados(id_peticion, id_conductor, id_ambulancia, dgvAmb_Cond, lbl_cantAmbulancia, lblAmb_Restantes);
                adm.LimpiarLabelsCA(lbl_id_ambulancia, lbl_id_conductor, lbl_conductor, lbl_Placa);
                btnAmbulancia.Enabled = false;
                btnAsignar.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string id_peticion = lblIdPeticion.Text;
            adm.guardarAsignacion(id_peticion);
            btnGuardar.Enabled = false;
            adm.LimpiarTodo(lblAmb_Restantes, lblCliente, lblIdPeticion, lbl_cantAmbulancia, lbl_conductor, lbl_id_ambulancia,
                lbl_id_conductor, lbl_Placa, lbl_TipoAmbulancia, dgvAmb_Cond);
        }

        private void lblIdPeticion_TextChanged(object sender, EventArgs e)
        {
            if (lblIdPeticion.Text != "")
            {
                btnConductor.Enabled = true;
                btnLimpiar.Enabled = true;
            }
        }

        private void lbl_conductor_TextChanged(object sender, EventArgs e)
        {
            if (lbl_conductor.Text != "") 
            {
                btnAmbulancia.Enabled = true;
            }
        }

        private void lbl_Placa_TextChanged(object sender, EventArgs e)
        {
            if (lbl_Placa.Text != "")
                btnAsignar.Enabled = true;
        }

        private void lblAmb_Restantes_TextChanged(object sender, EventArgs e)
        {
            if (lblAmb_Restantes.Text == "0") 
            {
                btnAmbulancia.Enabled = false;
                btnConductor.Enabled = false;
                btnAsignar.Enabled = false;
                btnGuardar.Enabled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            adm.LimpiarTodo(lblAmb_Restantes,lblCliente, lblIdPeticion,lbl_cantAmbulancia,lbl_conductor,lbl_id_ambulancia,
                lbl_id_conductor,lbl_Placa,lbl_TipoAmbulancia,dgvAmb_Cond);
        }
    }
}
