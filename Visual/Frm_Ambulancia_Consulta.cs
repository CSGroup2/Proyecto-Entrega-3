
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
    public partial class Frm_Ambulancia_Consultar : Form {

        Adm_Ambulancia admA = Adm_Ambulancia.GetAdm();
        public int buscarOb, buscarOp;
        Btn_Comportamiento cbtn = new Btn_Comportamiento ();

        public Frm_Ambulancia_Consultar () {
            InitializeComponent ();
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int disponibilidad = 0, tipo = 0;
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
                    disponibilidad = 1;
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
                    disponibilidad = 1;
                }
                
                string dato = txtDato.Text;
                dgvAmbulancias.Refresh();
                dgvAmbulancias.DataSource = admA.ConsultarAmbulancias(dato, tipo, disponibilidad, buscarOb, buscarOp);
            }


        }
    }
}
