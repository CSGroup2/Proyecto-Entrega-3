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
    public partial class Frm_Cliente_Editar : Form {
        Btn_Comportamiento cbtn = new Btn_Comportamiento ();
        int idclientemodi;
        Adm_General admgeneral = Adm_General.GetAdm();

        public Frm_Cliente_Editar () {
            InitializeComponent ();
        }

        public Frm_Cliente_Editar(int idcliente)
        {
            InitializeComponent();
            this.idclientemodi = idcliente;
        }

        private void FrmClienteModifi_Load (object sender, EventArgs e) {
            this.pncontenido.BackColor = Color.FromArgb (200, 255, 255, 255);
            this.cargarhospitales();
            this.cargarestados(); 
        }

        private void cargardatoscliente()
        {

        }

        private void cargarhospitales()
        {
            cbxestado.Items.Clear();
            cbxestado.DataSource = admgeneral.LlenarComboHospitales();
            cbxestado.ValueMember = "ID_HOSPITAL";
            cbxestado.DisplayMember = "NOMBRE_HOSPITAL";
        }

        private void cargarestados()
        {
            cbxestado1.Items.Clear();
            cbxestado1.DataSource = admgeneral.listerEstados();
            cbxestado1.ValueMember = "ID_ESTADO";
            cbxestado1.DisplayMember = "NOMBRE_ESTADO";
        }

        #region Efecto boton Guardar
        private void btnguardar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activabotonPer (sender, Color.LimeGreen);
        }
        private void btnguardar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion

        #region Efecto boton Cancelar
        private void btncancelar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activabotonPer (sender, Color.Firebrick);
        }

        private void btncancelar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion
    }
}
