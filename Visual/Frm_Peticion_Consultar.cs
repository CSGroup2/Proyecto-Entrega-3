﻿using System;
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
    public partial class Frm_Peticion_Consultar : Form
    {
        Adm_Peticion adm = Adm_Peticion.GetAdm();
        public Frm_Peticion_Consultar()
        {
            InitializeComponent();
        }

        private void Frm_Peticion_Consultar_Load(object sender, EventArgs e)
        {
            adm.llenarTablaPeticionUsuario(dgvPeticion);
        }

        private static string GetValorCelda(DataGridView dgv, int num)
        {
            string valor = "";

            valor = dgv.Rows[dgv.CurrentRow.Index].Cells[num].Value.ToString();

            return valor;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt_Destino.Text="";
            adm.llenarTablaPeticionUsuario(dgvPeticion);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            adm.filtrarXDestino(txt_Destino, dgvPeticion);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(GetValorCelda(dgvPeticion, 0));
            string estado = GetValorCelda(dgvPeticion, 6);
            if (id != 0)
            {
                if (estado.Equals("En Progreso"))
                {
                    var result = MessageBox.Show("Seguro desea eliminar la petición."+estado, "Advertencia",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                    if (result != DialogResult.No)
                        MessageBox.Show(adm.eliminarPeticion(id, dgvPeticion).ToString());
                }
                else {
                    MessageBox.Show("No puede eliminar una petición que ya fue asignada.");
                }
            }
            else {
                MessageBox.Show("Seleccione una petición a eliminar.");
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(GetValorCelda(dgvPeticion, 0));
            string estado = GetValorCelda(dgvPeticion, 6);
            if (id != 0)
            {
                if (estado.Equals("En Progreso"))
                {
                    var result = MessageBox.Show("Seguro desea editar la petición.", "Advertencia",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                    if (result != DialogResult.No) {
                        Frm_Peticion_Editar frmE = new Frm_Peticion_Editar(id);
                        frmE.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("No puede editar una petición que ya fue asignada.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una petición a eliminar.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
