using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual {
    public partial class Frm_Ambulancia_Editar : Form {

        Adm_Ambulancia admA = Adm_Ambulancia.GetAdm();
        Btn_Comportamiento cbtn = new Btn_Comportamiento ();

        public Frm_Ambulancia_Editar () {
            InitializeComponent ();
            admA.LlenarComboTipoAmbulancia(cmbTipo);
            admA.LlenarComboDisponibilidad(cmbDisp);
            admA.BloquearCampos(txtPlaca, btnBuscar, txtModelo, cmbTipo, txtCapacidad, txtObservacion, cmbDisp);
        }

        public Frm_Ambulancia_Editar(DataGridView dgvAmbulancia)
        {
            InitializeComponent();
            admA.DesbloquearCampos(txtPlaca, btnBuscar, txtModelo, cmbTipo, txtCapacidad, txtObservacion, cmbDisp);
            int posicion = dgvAmbulancia.CurrentRow.Index;
            string placa = dgvAmbulancia.Rows[posicion].Cells["placa"].Value.ToString();
            admA.LlenarCamposEditar(posicion, placa, txtPlaca, txtModelo, cmbTipo, txtCapacidad, txtObservacion, cmbDisp);
        }

        private void FrmAmbulanciaModifi_Load (object sender, EventArgs e) {
            this.pncontenido.BackColor = Color.FromArgb (200, 255, 255, 255);
            
        }

        #region Efecto boton Guardar
        private void btnguardar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activabotonPer (sender, Color.LimeGreen);
        }

        private void btnguardar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion

        #region Efecto boton cancelar
        private void btncancelar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activabotonPer (sender, Color.Firebrick);
        }

        private void btncancelar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text.ToUpper();
            if(admA.BuscarPlaca(placa, cmbDisp, txtModelo,cmbTipo, txtCapacidad, txtObservacion)){
                admA.DesbloquearCampos(txtPlaca, btnBuscar, txtModelo, cmbTipo, txtCapacidad, txtObservacion, cmbDisp);
            }
            else
            {
                MessageBox.Show("La placa no existe");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (admA.Validar(txtPlaca, txtModelo, cmbTipo, txtCapacidad, txtObservacion, errorP))
            {
                string msj = "";
                string placa = txtPlaca.Text.ToUpper(), modelo = txtModelo.Text, observacion = txtObservacion.Text;
                int capacidad = Int32.Parse(txtCapacidad.Text), tipoA = Int32.Parse(cmbTipo.SelectedValue.ToString()),
                                disponibilidad = Int32.Parse(cmbDisp.SelectedValue.ToString());
                errorP.Clear();
                msj = admA.ActualizarDatosAmbulancia(placa, disponibilidad, modelo, tipoA, capacidad, observacion);
                MessageBox.Show(msj); 
            }
            admA.LimpiarCamposE(txtPlaca, txtModelo, cmbTipo, txtCapacidad, txtObservacion, cmbDisp);
            admA.BloquearCampos(txtPlaca, btnBuscar, txtModelo, cmbTipo, txtCapacidad, txtObservacion, cmbDisp);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
