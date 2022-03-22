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
    public partial class Frm_Conductor_Editar : Form {
        Btn_Comportamiento cbtn = new Btn_Comportamiento ();
        Adm_General admGeneral = Adm_General.GetAdm ();

        public Frm_Conductor_Editar () {
            InitializeComponent ();
        }

        public Frm_Conductor_Editar (DataGridView dgv_Conductor) {
            InitializeComponent ();
        }

        private void Frm_Conductor_Editar_Load (object sender, EventArgs e) {
            this.pncontenido.BackColor = Color.FromArgb (200, 255, 255, 255);
            cargarestados ();
        }

        private void cargarestados () {
            cmb_Estado.Items.Clear ();
            cmb_Estado.DataSource = admGeneral.listerEstados ();
            cmb_Estado.ValueMember = "ID_ESTADO";
            cmb_Estado.DisplayMember = "NOMBRE_ESTADO";
        }

        #region Efecto boton Cancelar
        private void btn_Cancelar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activabotonPer (sender, Color.Firebrick);
        }

        private void btn_Cancelar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion

        #region Efecto boton guardar
        private void btn_Guardar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activabotonPer (sender, Color.LimeGreen);
        }

        private void btn_Guardar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion

        private void btn_Guardar_Click (object sender, EventArgs e) {

        }

        private void btn_Cancelar_Click (object sender, EventArgs e) {

        }

        
    }
}
