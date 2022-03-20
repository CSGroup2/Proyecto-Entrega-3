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
    public partial class Frm_Ayuda : Form
    {
        Btn_Comportamiento cbtn = new Btn_Comportamiento();

        public Frm_Ayuda()
        {
            InitializeComponent();
        }

        private void Frm_Ayuda_Load(object sender, EventArgs e)
        {
            this.pncontenido.BackColor = Color.FromArgb(200, 255, 255, 255);
        }
    }
}
