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
            this.pncontenido.BackColor = Color.FromArgb(200, 255, 255, 255);
            /*switch (admLogin.TipoUsuario())
            {
                case "Gerente":
                    btnpeticion.Visible = false;
                    break;
                case "Cliente":
                    btnsecretaria.Visible = false;
                    btncliente.Visible = false;
                    btnambulancia.Visible = false;
                    btnconductor.Visible = false;
                    btnasignar.Visible = false;
                    break;
                case "Secretaria":
                    btnsecretaria.Visible = false;
                    btncliente.Visible = false;
                    btnambulancia.Visible = false;
                    btnconductor.Visible = false;
                    btnregistrar.Visible = false;
                    break;
                default:
                    break;
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msj = "Hola Renán";
            Frm_Mensaje mensaje = new Frm_Mensaje();
            mensaje.txtMensaje.Text = msj;
            mensaje.ShowDialog();
        }
    }
}
