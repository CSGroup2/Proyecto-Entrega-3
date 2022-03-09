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
    public partial class Frm_Peticion_Registrar : Form {

        Adm_Peticion adm = Adm_Peticion.GetAdm();

        public Frm_Peticion_Registrar () {
            InitializeComponent ();
            adm.datosCliente(lbl_cedula,lbl_nombre, lbl_apellido);
            adm.llenarTipoAmb(cmb_TAmb);
        }

        // Cerrar formulario
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Guardar peticion
        private void btnguardar_Click(object sender, EventArgs e)
        {
            string msj = "";
            string cantAmb = nud_Ambulancia.Value.ToString(), punto_Origen = txt_Origen.Text, 
                punto_Destino = txt_Destino.Text, tipo_ambulancia = Convert.ToString(cmb_TAmb.SelectedValue);
            //verificamos si los campos están llenos
            if (txt_Origen.Text != "" && txt_Destino.Text != "" && cmb_TAmb.SelectedIndex != 0) 
            {
                msj = adm.guardarPeticion(cantAmb, tipo_ambulancia, punto_Origen, punto_Destino);
                MessageBox.Show(msj);
            }
            else
                MensajeError("Por favor ingrese los datos necesarios.");
        }

        // Borrar lo que tipeó
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            adm.borrarTipeos(nud_Ambulancia, txt_Origen, txt_Destino, cmb_TAmb);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txt_Destino_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsLetterOrDigit(c) && (e.KeyChar != Convert.ToChar(Keys.Back)) && !char.IsWhiteSpace(c) && c!='.')
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_Origen_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsLetterOrDigit(c) && (e.KeyChar != Convert.ToChar(Keys.Back)) && !char.IsWhiteSpace(c) && c != '.')
            {
                e.Handled = true;
                return;
            }
        }
    }
}
