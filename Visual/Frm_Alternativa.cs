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
    public partial class Frm_Alternativa : Form
    {
        Btn_Comportamiento cbtn = new Btn_Comportamiento();
        Adm_Login admLogin = Adm_Login.GetAdm();

        public Frm_Alternativa()
        {
            InitializeComponent();
        }

        private void Frm_Ayuda_Load(object sender, EventArgs e)
        {
            this.pncontenido.BackColor = Color.FromArgb(200, 255, 255, 255);
            switch (admLogin.TipoUsuario())
            {
                case "Gerente":
                    btn8.Visible = false;
                    btn9.Visible = false;
                    btn10.Visible = false;
                    btn11.Visible = false;
                    break;
                case "Cliente":
                    btn1.Visible = false;
                    btn2.Visible = false;
                    btn3.Visible = false;
                    btn4.Visible = false;
                    btn5.Visible = false;
                    btn6.Visible = false;
                    btn7.Visible = false;
                    btn11.Visible = false;
                    break;
                case "Secretaria":
                    btn1.Visible = false;
                    btn3.Visible = false;
                    btn5.Visible = false;
                    btn6.Visible = false;
                    btn8.Visible = false;
                    btn10.Visible = false;
                    break;
                default:
                    break;
            }
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

            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1i9QP0QT5JUKx3qXi7gQXPC3ds55L7C4nWttKpE6r8Bo/edit?usp=sharing");
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
            "\r\n 2- Hacer clic en el botón 'Consultar'.\r\n" +
            "\r\n 3- Seleccionar entre la opción - placa - y - modelo -, e ingresa el dato según seleccione.\r\n" +
            "\r\n 4- Seleccionar las casillas si se desea filtrar aún más los registros de las ambulancias.\r\n" +
            "\r\n 5- Hacer clic en 'Buscar'.\r\n";
            Frm_Mensaje mensaje = new Frm_Mensaje();
            mensaje.lblTitulo.Text = titulo;
            mensaje.txtMensaje.Text = msj;
            mensaje.ShowDialog();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string titulo = "\r\n¿Cómo consultar los datos de los clientes/conductores/secretarias en SGAR?\r\n";
            string msj = "\r\n 1- Hacer clic en el botón del menú 'Cliente' o 'Conductor' o 'Secretaria'.\r\n" +
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
            "\r\n 5- Se abre la ventana de edición, modificar los datos y dar clic en el botón 'Guardar'.\r\n" +
            "\r\n  \r\n o \r\n " +
            "\r\n 1- Hacer clic en el botón del menú 'Cliente' o 'Conductor' o 'Secretaria'.\r\n" +
            "\r\n 2- Hacer clic en el botón 'Modificar'.\r\n" +
            "\r\n 3- Buscar por cédula.\r\n" +
            "\r\n 4- Modificar los datos y dar clic en el botón 'Guardar'.\r\n";

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
            "\r\n 1- Hacer clic en el botón del menú 'Ambulancia'.\r\n" +
            "\r\n 2- Hacer clic en el botón 'Modificar'.\r\n" +
            "\r\n 3- Buscar por la placa del vehículo.\r\n" +
            "\r\n 4- Modificar los datos y dar clic en el botón 'Guardar'.\r\n";

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
            "\r\n 1- Hacer clic en el botón del menú 'Peticiones'.\r\n" +
            "\r\n 2- Hacer clic en el botón 'Modificar'.\r\n" +
            "\r\n 3- Buscar por ?.\r\n" +
            "\r\n 4- Modificar los datos y dar clic en el botón 'Guardar'.\r\n";

            Frm_Mensaje mensaje = new Frm_Mensaje();
            mensaje.lblTitulo.Text = titulo;
            mensaje.txtMensaje.Text = msj;
            mensaje.ShowDialog();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            string titulo = "\r\n¿Cómo asignar ambulancia-conductor?\r\n";
            string msj = "\r\n 1- Hacer clic en el botón del menú 'Peticiones'.\r\n" +
            "\r\n 2- Hacer clic en el botón 'Asignar'.\r\n" +
            "\r\n 3- Hacer clic en el botón 'Petición'.\r\n" +
            "\r\n 4- Seleccionar una petición de la tabla.\r\n" +
            "\r\n 5- Hacer clic en el botón 'Elegir' y se llenarán los campos con los datos de la petición.\r\n" +
            "\r\n 6- Hacer clic en el botón 'Conductor' para asignar un conductor a la petición. \r\n " +
            "\r\n 7- Seleccionar un conductor y dar clic en el botón 'Elegir'. \r\n" +
            "\r\n 8- Hacer clic en el botón 'Ambulancia' para asignar un ambulancia a la petición.\r\n" +
            "\r\n 9- Seleccionar una ambulancia y dar clic en el botón 'Elegir'.\r\n" +
            "\r\n 10- Hacer clic en el botón 'Asignar'.\r\n" +
            "\r\n 11- Verificar la cantidad de ambulancias requeridas en la petición para finalizar con la asignación.\r\n" +
            "\r\n 12- Hacer clic en el botón 'Guardar'.\r\n";

            Frm_Mensaje mensaje = new Frm_Mensaje();
            mensaje.lblTitulo.Text = titulo;
            mensaje.txtMensaje.Text = msj;
            mensaje.ShowDialog();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            string titulo = "\r\n¿Cómo se registra un conductor en SGAR?\r\n";
            string msj = "\r\n 1- Hacer clic en el botón del menú 'Conductor'. \r\n" +
            "\r\n 2 - Hacer clic en el botón 'Registrar' y llenar los datos correspondientes para tener un registro exitoso.";
            Frm_Mensaje mensaje = new Frm_Mensaje();
            mensaje.lblTitulo.Text = titulo;
            mensaje.txtMensaje.Text = msj;
            mensaje.ShowDialog();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            string titulo = "\r\n¿Cómo consultar los datos de los conductores en SGAR?\r\n";
            string msj = "\r\n 1- Hacer clic en el botón del menú 'Conductor'.\r\n" +
            "\r\n 2- Hacer clic en el botón 'Consultar'.\r\n" +
            "\r\n 3- Seleccionar entre la opción - nombre - y - cédula -, e ingresa el dato según seleccione.\r\n" +
            "\r\n 4- Seleccionar las casillas si se desea filtrar aún más los registros de conductores.\r\n" +
            "\r\n 5- Hacer clic en 'Buscar'.\r\n";
            Frm_Mensaje mensaje = new Frm_Mensaje();
            mensaje.lblTitulo.Text = titulo;
            mensaje.txtMensaje.Text = msj;
            mensaje.ShowDialog();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            string titulo = "\r\n¿Cómo modificar los datos de los conductores en SGAR?\r\n";
            string msj = "\r\n 1- Hacer clic en el botón del menú 'Conductor'.\r\n" +
            "\r\n 2- Hacer clic en el botón 'Consultar'.\r\n" +
            "\r\n 3- Seleccionar un registro de la tabla.\r\n" +
            "\r\n 4- Hacer clic en el botón 'Modificar'.\r\n" +
            "\r\n 5- Se abre la ventana de edición, modificar los datos y dar clic en el botón 'Guardar'.\r\n" +
            "\r\n  \r\n o \r\n " +
            "\r\n 1- Hacer clic en el botón del menú 'Conductor'.\r\n" +
            "\r\n 2- Hacer clic en el botón 'Modificar'.\r\n" +
            "\r\n 3- Buscar por cédula.\r\n" +
            "\r\n 4- Modificar los datos y dar clic en el botón 'Guardar'.\r\n";

            Frm_Mensaje mensaje = new Frm_Mensaje();
            mensaje.lblTitulo.Text = titulo;
            mensaje.txtMensaje.Text = msj;
            mensaje.ShowDialog();
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
