using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual {
    public partial class Frm_Cliente_Consultar : Form {
        Btn_Comportamiento cbtn = new Btn_Comportamiento ();
        Adm_Cliente admCliente = Adm_Cliente.GetAdm ();
        Adm_Ambulancia admA = Adm_Ambulancia.GetAdm();
        Frm_Menu menu;

        public Frm_Cliente_Consultar () {
            InitializeComponent ();
        }

        public Frm_Cliente_Consultar(Frm_Menu menuoriginal)
        {
            InitializeComponent();
            this.menu = menuoriginal; 
        }

        private void FrmClienteConsul_Load (object sender, EventArgs e) {
            this.pncontenido.BackColor = Color.FromArgb (140, 255, 255, 255);
            admA.ListarAmbulancias(dgvAmbulancias);
        }

        #region Efecto boton consultar
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

        #region Efecto boton guardar
        private void btnguardar_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }

        private void btnguardar_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }

        #endregion

        #region Efecto boton imprimir
        private void btnimprimir_MouseMove (object sender, MouseEventArgs e) {
            cbtn.activaboton (sender);
        }

        private void btnimprimir_MouseLeave (object sender, EventArgs e) {
            cbtn.desactivaboton (sender);
        }
        #endregion

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)dgvAmbulancias.DataSource;
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "Pdf File |*.pdf";
            //saveFileDialog1.FileName = "lista_ambulancia.pdf";
            saveFileDialog1.Title = "SGAR: Ambulancias - Guardar";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = saveFileDialog1.FileName;
                admCliente.CrearPdf2(dt, file);
                if (File.Exists(file))
                {
                    Process.Start(file);
                }
            }
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnmostrartodos_Click(object sender, EventArgs e)
        {
            admA.ListarAmbulancias(dgvAmbulancias);
        }
    }
}
