using Control;
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
        Adm_Login admLogin = Adm_Login.GetAdm();

        public Frm_Ayuda()
        {
            InitializeComponent();
        }

        private void Frm_Ayuda_Load(object sender, EventArgs e)
        {
            //this.pncontenido.BackColor = Color.FromArgb(200, 255, 255, 255);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            switch (admLogin.TipoUsuario())
            {
                case "Gerente":
                    System.Diagnostics.Process.Start("https://docs.google.com/document/d/1i9QP0QT5JUKx3qXi7gQXPC3ds55L7C4nWttKpE6r8Bo/edit?usp=sharing");
                    break;
                case "Cliente":
                    System.Diagnostics.Process.Start("");
                    break;
                case "Secretaria":
                    System.Diagnostics.Process.Start("");
                    break;
                default:
                    break;
            }
        }
    }
}
