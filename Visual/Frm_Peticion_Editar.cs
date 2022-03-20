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
    public partial class Frm_Peticion_Editar : Form
    {
        Btn_Comportamiento cbtn = new Btn_Comportamiento();
        public Frm_Peticion_Editar()
        {
            InitializeComponent();
        }

        private void Frm_Peticion_Editar_Load(object sender, EventArgs e)
        {
            this.pncontenido.BackColor = Color.FromArgb(200, 255, 255, 255);
        }
    }
}
