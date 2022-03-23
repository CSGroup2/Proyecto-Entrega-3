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
        Adm_General admgeneral = Adm_General.GetAdm();
        
        Adm_PDF admpdf = Adm_PDF.GetAdm(); 
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
            if (dgvClientes.Rows.Count==0) { btnmodificar.Enabled = false; }
            this.cargarhospitales();
            this.cargarclientes();
            this.cargarestados();
            this.tamaniocriterio(); 
        }

        #region cargado de datos al iniciar  y helpers
        private void cargarclientes()
        {
            dgvClientes.Refresh();
            dgvClientes.DataSource = admCliente.ListarClientes();
        }

        private void cargarhospitales()
        {
            cbxhospital.Items.Clear();
            cbxhospital.DataSource = admgeneral.LlenarComboHospitales();
            cbxhospital.ValueMember = "ID_HOSPITAL";
            cbxhospital.DisplayMember = "NOMBRE_HOSPITAL";
        }

        private void cargarestados()
        {
            cbxestado.Items.Clear();
            cbxestado.DataSource = admgeneral.listerEstados();
            cbxestado.ValueMember = "ID_ESTADO";
            cbxestado.DisplayMember = "NOMBRE_ESTADO";
        }

        private void habilitardeshabilitar(CheckBox obj,ComboBox combo)
        {
            if (obj.Checked)
            {
                combo.Enabled = true;
            }
            else
            {
                combo.Enabled = false;
            }
        }

        private void tamaniocriterio()
        {
            if (opcedula.Checked)
            {
                txtCriterio.MaxLength = 10;
            }
            else
            {
                txtCriterio.MaxLength = 75;
            }
            txtCriterio.Text = "";
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SGAR LOS RAPIDOS S.A", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SGAR LOS RAPIDOS S.A", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        #endregion

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
            dt = (DataTable)dgvClientes.DataSource;
            string[] columnas = {"N." ,"Código", "Estado", "Hospital", "Cédula", "Nombres", "Apellidos", "Sexo", "Fecha Nacimiento", "Telefono" , "Correo" };
            float[] tamanios = { 2, 2, 2, 4, 4, 4, 4, 2, 3, 3, 4 };
            
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "Pdf File |*.pdf";
            //saveFileDialog1.FileName = "lista_ambulancia.pdf";
            saveFileDialog1.Title = "SGAR: Ambulancias - Guardar";
            if (dt.Rows.Count > 0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string file = saveFileDialog1.FileName;
                    admpdf.CrearPdf(dt, file, columnas, tamanios, 0);
                    if (File.Exists(file))
                    {
                        Process.Start(file);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay datos para imprimir");
            }
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            int buscarOb, buscarOp, hospital = 0, estado = 0;
            if (opcedula.Checked == true)
            {
                buscarOb = 2;
            }
            else
            {
                buscarOb = 1;
            }

            if (chxhospital.Checked == true && chxestado.Checked == true)
            {
                buscarOp = 3;
                hospital = Int32.Parse(cbxhospital.SelectedValue.ToString());
                estado = Int32.Parse(cbxestado.SelectedValue.ToString());
                 
            }
            else if (chxestado.Checked == true)
            {
                buscarOp = 2;
                estado = Int32.Parse(cbxestado.SelectedValue.ToString());
            }
            else if (chxhospital.Checked == true)
            {
                buscarOp = 1;
                hospital = Int32.Parse(cbxhospital.SelectedValue.ToString());
            }
            else
            {
                buscarOp = 0;
            } 
            string dato = txtCriterio.Text.Replace(" ", String.Empty);
            dgvClientes.DataSource = admCliente.ConsultarClientes(dato, estado, hospital, buscarOb, buscarOp);
        }

        private void btnmostrartodos_Click(object sender, EventArgs e)
        {
            this.cargarclientes(); 
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            int posicion = dgvClientes.CurrentRow.Index;
            if (posicion>=0)
            {
                if (MessageBox.Show("¿Desea actualizar el registro seleccionado?", "Warning",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idcliente = Int32.Parse(dgvClientes[posicion, 0].Value.ToString());
                    menu.abrirhijoform(new Frm_Cliente_Editar(idcliente));

                }
            }
        }

        private void chxestado_CheckedChanged(object sender, EventArgs e)
        {
            this.habilitardeshabilitar(chxestado, cbxestado);   
        }

        private void chxhospital_CheckedChanged(object sender, EventArgs e)
        {
            this.habilitardeshabilitar(chxhospital, cbxhospital);

        }

        private void opcedula_CheckedChanged(object sender, EventArgs e)
        {
            this.tamaniocriterio();
        }

        private void txtCriterio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (opcedula.Checked)
            {
                admCliente.validarSoloNumerosKeyPress(sender, e);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de Eliminar el registro?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int posicion = dgvClientes.CurrentRow.Index;
            int idcliente = Int32.Parse(dgvClientes[posicion,0].Value.ToString());
            string mensaje = admCliente.eliminarcliente(idcliente);
            if (mensaje.Contains("¡Error "))
            {
                MensajeError(mensaje);
            }
            else
            {
                MensajeOk(mensaje);
                this.cargarclientes();
            }
            }
        }
    }
}
