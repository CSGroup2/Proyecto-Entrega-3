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

        private void btn1_Click(object sender, EventArgs e)
        {
            string titulo = "\r\n¿Cómo se registra un empleado en SGAR?\r\n";
            string msj = "\r\n 1- Hacer clic en el botón del menú del cargo que desea agregar (Secretaria/Conductor). \r\n" +
            "\r\n 2 - Hacer clic en el botón 'Registrar' y llenar los datos correspondientes para tener un registro exitoso.";
            Frm_Mensaje mensaje = new Frm_Mensaje();
            mensaje.lblTitulo.Text = titulo;
            mensaje.txtMensaje.Text = msj;
            mensaje.ShowDialog();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string titulo = "\r\n¿Cómo se registra una ambulancia en SGAR?\r\n";
            string msj = "\r\n 1- Hacer clic en el botón del menú 'Ambulancia'.\r\n" +
            "\r\n 2 - Hacer clic en el botón 'Registrar' y llenar los datos correspondientes para tener un registro exitoso.";
            Frm_Mensaje mensaje = new Frm_Mensaje();
            mensaje.lblTitulo.Text = titulo;
            mensaje.txtMensaje.Text = msj;
            mensaje.ShowDialog();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string titulo = "\r\n¿Cómo se registra un cliente en SGAR?\r\n";
            string msj = "\r\n 1- Hacer clic en el botón del menú 'Cliente'.\r\n" +
            "\r\n 2- Hacer clic en el botón 'Registrar' y llenar los datos correspondientes para tener un registro exitoso.";
            Frm_Mensaje mensaje = new Frm_Mensaje();
            mensaje.lblTitulo.Text = titulo;
            mensaje.txtMensaje.Text = msj;
            mensaje.ShowDialog();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string titulo = "\r\n¿Cómo consultar los datos de las ambulancias en SGAR?\r\n";
            string msj = "\r\n 1- Hacer clic en el botón del menú 'Ambulancia'.\r\n" +
            "\r\n 2- Hacer clic en el botón 'Consultar'.\r\n"+
            "\r\n 3- Seleccionar entre la opción - placa - y - modelo -, e ingresa el dato según seleccione.\r\n"+ 
            "\r\n 4- Seleccionar las casillas si se desea filtrar aún más los registros de las ambulancias.\r\n"+
            "\r\n 5- Hacer clic en 'Buscar'.\r\n";
            Frm_Mensaje mensaje = new Frm_Mensaje();
            mensaje.lblTitulo.Text = titulo;
            mensaje.txtMensaje.Text = msj;
            mensaje.ShowDialog();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string titulo = "\r\n¿Cómo consultar los datos de los clientes/conductores/secretarias en SGAR?\r\n";
            string msj = "\r\n 1- Hacer clic en el botón del menú 'Cliente'.\r\n" +
            "\r\n 2- Hacer clic en el botón 'Consultar'.\r\n" +
            "\r\n 3- Seleccionar entre la opción - nombre - y - cédula -, e ingresa el dato según seleccione.\r\n" +
            "\r\n 4- Seleccionar las casillas si se desea filtrar aún más los registros de clientes/conductores/secretarias.\r\n" +
            "\r\n 5- Hacer clic en 'Buscar'.\r\n";
            Frm_Mensaje mensaje = new Frm_Mensaje();
            mensaje.lblTitulo.Text = titulo;
            mensaje.txtMensaje.Text = msj;
            mensaje.ShowDialog();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string titulo = "\r\n¿Cómo modificar los datos de las clientes/conductores/secretarias en SGAR?\r\n";
            string msj = "\r\n 1- Hacer clic en el botón del menú 'Cliente' o 'Conductor' o 'Secretaria'.\r\n" +
            "\r\n 2- Hacer clic en el botón 'Consultar'.\r\n" +
            "\r\n 3- Seleccionar un registro de la tabla.\r\n" +
            "\r\n 4- Hacer clic en el botón 'Modificar'.\r\n" +
            "\r\n 5- Se abre la ventana de edición, modificar los datos y dar clic en el botón 'Guardar'.\r\n"+
            "\r\n  \r\n o \r\n " +
            "\r\n 1- Hacer clic en el botón del menú 'Cliente' o 'Conductor' o 'Secretaria'." +
            "\r\n 2- Hacer clic en el botón 'Modificar'." +
            "\r\n 3- Buscar por cédula." +
            "\r\n 4- Modificar los datos y dar clic en el botón 'Guardar'.";

            Frm_Mensaje mensaje = new Frm_Mensaje();
            mensaje.lblTitulo.Text = titulo;
            mensaje.txtMensaje.Text = msj;
            mensaje.ShowDialog();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string titulo = "\r\n¿Cómo modificar los datos de las ambulancias en SGAR?\r\n";
            string msj = "\r\n 1- Hacer clic en el botón del menú 'Ambulancia'.\r\n" +
            "\r\n 2- Hacer clic en el botón 'Consultar'.\r\n" +
            "\r\n 3- Seleccionar un registro de la tabla.\r\n" +
            "\r\n 4- Hacer clic en el botón 'Modificar'.\r\n" +
            "\r\n 5- Se abre la ventana de edición, modificar los datos y dar clic en el botón 'Guardar'.\r\n" +
            "\r\n  \r\n o \r\n " +
            "\r\n 1- Hacer clic en el botón del menú 'Ambulancia'." +
            "\r\n 2- Hacer clic en el botón 'Modificar'." +
            "\r\n 3- Buscar por la placa del vehículo." +
            "\r\n 4- Modificar los datos y dar clic en el botón 'Guardar'.";

            Frm_Mensaje mensaje = new Frm_Mensaje();
            mensaje.lblTitulo.Text = titulo;
            mensaje.txtMensaje.Text = msj;
            mensaje.ShowDialog();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string titulo = "\r\n¿Cómo se registra una petición en SGAR?\r\n";
            string msj = "\r\n 1- Hacer clic en el botón del menú 'Peticiones'.\r\n" +
            "\r\n 2- Hacer clic en el botón 'Registrar' y llenar los datos correspondientes para tener un registro exitoso.";
            Frm_Mensaje mensaje = new Frm_Mensaje();
            mensaje.lblTitulo.Text = titulo;
            mensaje.txtMensaje.Text = msj;
            mensaje.ShowDialog();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string titulo = "\r\n¿Cómo consultar los datos de las peticiones en SGAR?\r\n";
            string msj = "\r\n 1- Hacer clic en el botón del menú 'Peticiones'.\r\n" +
            "\r\n 2- Hacer clic en el botón 'Consultar'.\r\n" +
            "\r\n 3- Ingresa el punto de destino para filtrar las peticiones.\r\n" +
            "\r\n 4- Hacer clic en 'Buscar'.\r\n";
            Frm_Mensaje mensaje = new Frm_Mensaje();
            mensaje.lblTitulo.Text = titulo;
            mensaje.txtMensaje.Text = msj;
            mensaje.ShowDialog();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            string titulo = "\r\n¿Cómo modificar los datos de las peticiones en SGAR?\r\n";
            string msj = "\r\n 1- Hacer clic en el botón del menú 'Peticiones'.\r\n" +
            "\r\n 2- Hacer clic en el botón 'Consultar'.\r\n" +
            "\r\n 3- Seleccionar un registro de la tabla.\r\n" +
            "\r\n 4- Hacer clic en el botón 'Modificar'.\r\n" +
            "\r\n 5- Se abre la ventana de edición, modificar los datos y dar clic en el botón 'Guardar'.\r\n" +
            "\r\n  \r\n o \r\n " +
            "\r\n 1- Hacer clic en el botón del menú 'Peticiones'." +
            "\r\n 2- Hacer clic en el botón 'Modificar'." +
            "\r\n 3- Buscar por ?." +
            "\r\n 4- Modificar los datos y dar clic en el botón 'Guardar'.";

            Frm_Mensaje mensaje = new Frm_Mensaje();
            mensaje.lblTitulo.Text = titulo;
            mensaje.txtMensaje.Text = msj;
            mensaje.ShowDialog();
        }
    }
}
