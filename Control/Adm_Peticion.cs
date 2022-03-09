using Model;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control
{
    public class Adm_Peticion
    {

        /*
            Aplicar el patron de diseño Singleton:
            1. Crear 1 atributo estático y privado de la misma clase.
            2. Cambiar el constructor de public a private.
            3.1. Crear un getter del atributo estático del tipo de la clase.
            3.2.Verificar si atributo es null, si es así, crearlo.
        */

        private static Adm_Peticion adm=null;   // 1.

        Validacion v = null;
        Peticion peticion = null;
        Cliente cliente = null;

        List<Peticion> lista = null;

        Adm_Login admL = Adm_Login.GetAdm();
        Adm_Ambulancia admA = Adm_Ambulancia.GetAdm();

        public List<Peticion> Lista { get => lista; set => lista = value; }

        // Constructor: Adm_Peticion
        private Adm_Peticion()                  // 2.
        {
            v = new Validacion();
            peticion = new Peticion();
            lista = new List<Peticion>();
            cliente = new Cliente();
        }

        // Getter: GetAdm
        public static Adm_Peticion GetAdm()     // 3.1.
        {
            if (adm == null)                    //3.2
            {
                adm = new Adm_Peticion();
            }
            return adm;
        }

        /*--------------------------Frm_Peticion_Registrar-------------------------------*/


        //Guarda la peticion en una lista y en la base de datos
        public string guardarPeticion(string cantAmb, string tipo_ambulancia,string punto_Origen, string punto_Destino)
        {
            string mensaje = "",msj="";
            cliente = new Cliente();
            cliente.Id_cliente = admL.IdUsuario();
            //cliente.Id_cliente = 100; //solo para el TEST

            int tAmb = v.AEntero(tipo_ambulancia);
            int nAmb = v.AEntero(cantAmb);

            peticion = new Peticion(cliente, tAmb, nAmb, punto_Origen, punto_Destino,"En Progreso");
            
            Lista.Add(peticion);                                 //Añadir la peticion a la lista
            mensaje = datosPeticion.insetarPeticion(peticion);   //Mandar la peticion a la base de datos

            if (mensaje[0] == '1')
                msj="Su petición fue ingresada correctamente.";
            else
                msj="Error: " + mensaje;
            //msj = "Error no se pudo ingresar la petición."; //solo para el TEST
            return msj;
        }

        // Llena los labels del frm con los datos del Cliente
        public void datosCliente(Label lbl_cedula, Label lbl_nombre, Label lbl_apellido)
        {
            lbl_cedula.Text = CedulaUsuario();
            lbl_nombre.Text = admL.NombreUsuario();
            lbl_apellido.Text = admL.ApellidoUsuario();
        }

        // Llena el combobox del tipo de ambulancias que existen en la base de datos
        public void llenarTipoAmb(ComboBox cmb_TAmb)
        {
            admA.LlenarComboTipoAmbulancia(cmb_TAmb);
        }

        //borra los datos ingresados por el usuario y los deja en su estado default
        public void borrarTipeos(NumericUpDown nud_Ambulancia, TextBox txt_Origen, TextBox txt_Destino, ComboBox cmb_TAmb)
        {
            nud_Ambulancia.Value=1;
            txt_Origen.Text = "";
            txt_Destino.Text = "";
            cmb_TAmb.SelectedIndex = 0;
        }

        //devuelve la cedula del usuario para colocarla en un label
        public string CedulaUsuario()
        {
            string cedula = "";
            cedula = datosPeticion.consultarCedula(admL.IdUsuario());
            return cedula;
        }

        /*--------------------------Frm_Peticion_Consultar-------------------------------*/

        //Llena el dgv con las peticiones que se encuentran "En Progreso"
        internal void llenarTablaPeticion(DataGridView dgvPeticion)
        {
            dgvPeticion.Refresh();
            dgvPeticion.DataSource = datosPeticion.listarPeticionesPendientes();
        }

        /*--------------------------Enviar a Base de Datos-------------------------------*/

        //Objeto para interactuar con el proyecto Datos y aplicar MVC
        Datos_Peticion datosPeticion = new Datos_Peticion();
    }
}
