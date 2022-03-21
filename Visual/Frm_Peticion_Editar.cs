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
    public partial class Frm_Peticion_Editar : Form
    {
        Btn_Comportamiento cbtn = new Btn_Comportamiento();
        int idPet;
        Adm_Peticion adm = Adm_Peticion.GetAdm();
        public Frm_Peticion_Editar(int idPeticion)
        {
            InitializeComponent();
            adm.llenarTipoAmb(cmb_TAmb);
            this.idPet = idPeticion;
            adm.llenarCamposEditar(idPet, lbl_cedula, lbl_nombre, lbl_apellido, nud_Ambulancia, cmb_TAmb, txt_Origen, txt_Destino);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            string cantAmb = nud_Ambulancia.Value.ToString(), punto_Origen = txt_Origen.Text,
                punto_Destino = txt_Destino.Text, tipo_ambulancia = Convert.ToString(cmb_TAmb.SelectedValue);
            if (txt_Origen.Text != "" && txt_Destino.Text != "" && cmb_TAmb.SelectedIndex != 0)
        {
            this.pncontenido.BackColor = Color.FromArgb(200, 255, 255, 255);
                MessageBox.Show(adm.editarPeticion(idPet,cantAmb, tipo_ambulancia, punto_Origen, punto_Destino).ToString());
                this.Close();
            }
            else
                MessageBox.Show("Por favor ingrese los datos necesarios.");
        }
    }
}
