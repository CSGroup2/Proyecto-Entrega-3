using Datos;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control
{
    public class Adm_Cliente
    {
        /* conprobar nombre alexander castro
            Aplicar el patron de diseño Singleton:
            1. Crear 1 atributo estático y privado de la misma clase.
            2. Cambiar el constructor de public a private.
            3.1. Crear un getter del atributo estático del tipo de la clase.
            3.2.Verificar si atributo es null, si es así, crearlo.
        */

        private static Adm_Cliente adm_client = null;    // 1.
        Cliente client = null;
        Usuario usuario = null;
        Datos_Cliente Datos_client = null;
        Validacion validacion = null;


        // Constructor: Adm_Cliente
        private Adm_Cliente()  // 2.
        {                 
            client = new Cliente();
            usuario = new Usuario();
            Datos_client = new Datos_Cliente();
            validacion = new Validacion();
        }

        // Getter: GetAdm
        public static Adm_Cliente GetAdm()
        {     // 3.1.
            if (adm_client == null)
            {                  //3.2
                adm_client = new Adm_Cliente();
            }
            return adm_client;
        }

        //Metodo para cargar la lista de hospitales afiliados a un combo box
        public void LlenarComboHospitales(ComboBox cmbhospitales)
        {
            cmbhospitales.Items.Clear();
            cmbhospitales.DataSource = Datos_client.ConsultarHospitales();
            cmbhospitales.ValueMember = "ID_HOSPITAL";
            cmbhospitales.DisplayMember = "NOMBRE_HOSPITAL";
        }

        #region Validaciones
        // Methods for KeyPress
        public void validarSoloNumerosKeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allows numbers on press
            validacion.validarSoloNumerosKeyPress(sender, e);
        }

        public void validarSoloLettrasKeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allows alphabetic characters
            validacion.validarSoloLettrasKeyPress(sender, e);
        }

        public void validarSoloCorreoKeypress(object sender, KeyPressEventArgs e)
        {
            // Only allows eamil characters
            validacion.validarSoloCorreoKeypress(sender, e);
        }
        
        //Valida si realmente un sexo se ha escogido
        public string esSexo(RadioButton rdb_Masculino, RadioButton rdb_Femenino)
        {
            return validacion.esSexo(rdb_Masculino, rdb_Femenino);
        }
        //verifica que todos los datos sean correctos, o que se envien datos incompletos
        public  bool validarDatosCliente(TextBox txt_Cedula, ComboBox cmbhospital, TextBox txt_Nombre1, TextBox txt_Nombre2, TextBox txt_Apellido1, TextBox txt_Apellido2, TextBox txt_Correo, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNac, TextBox txt_NombreUsuario, TextBox txt_Contrasenia1, TextBox txt_Contrasenia2, ErrorProvider errorProvider1)
        {
            bool validaciondatos = validacion.esCorrectoDatosCliente(txt_Cedula, cmbhospital, txt_Nombre1, txt_Nombre2, txt_Apellido1, txt_Apellido2, txt_Correo, txt_Telefono, rdb_Masculino, rdb_Femenino, dtp_FechaNac, txt_NombreUsuario, txt_Contrasenia1, txt_Contrasenia2, errorProvider1);
            if (!validaciondatos)
            {
                MessageBox.Show("¡Error al llenar los campos!", "SGAR LOS RAPIDOS S.A", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return validaciondatos;
        }
        #endregion


        #region Metodos que se comunicaran con la capa datos para la BD

        //Metodo "GuardarDatosCliente" inserta un cliente con sus respectivos datos y su nueva cuenta de usuario.
        public string guardarDatosCliente(string Cedula, int id_hospital , string Nombre1, string Nombre2, string Apellido1, string Apellido2, string Correo, string Telefono, string sexo, DateTime dtp_FechaNac, string NombreUsuario, string Contrasenia1)
        {
            string mensaje = "";
            usuario = new Usuario(0, Correo, NombreUsuario, Contrasenia1);
            client = new Cliente(id_hospital, usuario, 0,  Cedula, Nombre1, Nombre2, Apellido1, Apellido2, sexo, dtp_FechaNac, Telefono);
            mensaje = Datos_client.insertarDatosCliente(client);

            return mensaje;
        }

        #endregion


        //Metodo para limpiar los componentes posterior a una insersion.
        public void limpiarCamposGuardarCliente(TextBox txt_Cedula, ComboBox cbxhospital ,TextBox txt_Nombre1, TextBox txt_Nombre2, TextBox txt_Apellido1, TextBox txt_Apellido2, TextBox txt_Correo, TextBox txt_Telefono, RadioButton rdb_Masculino, RadioButton rdb_Femenino, DateTimePicker dtp_FechaNac, TextBox txt_NombreUsuario, TextBox txt_Contrasenia1, TextBox txt_Contrasenia2, ErrorProvider errorProvider1)
        {
            errorProvider1.Clear();
            txt_Cedula.Clear();
            cbxhospital.SelectedIndex = 0;
            txt_Nombre1.Clear();
            txt_Nombre2.Clear();
            txt_Apellido1.Clear();
            txt_Apellido2.Clear();
            txt_Correo.Clear();
            txt_Telefono.Clear();
            rdb_Masculino.Checked = false;
            rdb_Femenino.Checked = false;
            dtp_FechaNac.Value = DateTime.Today;
            txt_NombreUsuario.Clear();
            txt_Contrasenia1.Clear();
            txt_Contrasenia2.Clear();
        }

        //método para crear pdf con los datos del datagridview
        public void CrearPdf(DataTable dt, string file)
        {
            PdfWriter pdfWriter = new PdfWriter(file);
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document documento = new Document(pdf, PageSize.LETTER);

            documento.SetMargins(60, 20, 55, 20);
            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            /*EL SIGUIENTE ARRAY ES PARA DETALLAR LOS NOMBRES DE LAS COLUMNAS EN LA TABLA DEL PDF
              MODIFICALO EN EL MISMO ORDEN QUE UBICASTE LAS COLUMNAS DE TU DATAGRIDVIEW*/
            string[] columnas = { "Nº", "id", "disponibilidad", "placa", "modelo", "tipo", "capacidad", "observación" };
            float[] tamanios = { 2, 2, 3, 4, 4, 3, 2, 5 };

            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }

            int fila = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //RECORRE EL DATATABLE PARA AGREGAR ESOS DATOS A LA PDF - PON EL MISMO ORDEN DE LAS COLUMNAS QUE DECLARASTE ARRIBA
                tabla.AddCell(new Cell().Add(new Paragraph(fila + "").SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(dt.Rows[i]["id"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(dt.Rows[i]["disponibilidad"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(dt.Rows[i]["placa"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(dt.Rows[i]["modelo"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(dt.Rows[i]["tipo_ambulancia"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(dt.Rows[i]["capacidad"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(dt.Rows[i]["observacion"].ToString()).SetFont(fontContenido)));
                fila++;
            }
            documento.Add(tabla);
            documento.Close();
        }

        public void CrearPdf2(DataTable dt, string file)
        {
            PdfWriter pdfWriter = new PdfWriter(file);
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document documento = new Document(pdf, PageSize.LETTER);

            documento.SetMargins(60, 20, 55, 20);
            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            /*EL SIGUIENTE ARRAY ES PARA DETALLAR LOS NOMBRES DE LAS COLUMNAS EN LA TABLA DEL PDF
              MODIFICALO EN EL MISMO ORDEN QUE UBICASTE LAS COLUMNAS DE TU DATAGRIDVIEW*/
            


            string[] columnas = { "Nº", "id", "disponibilidad", "placa", "modelo", "tipo", "capacidad", "observación" };
            float[] tamanios = { 2, 2, 3, 4, 4, 3, 2, 5 };

            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            //Table tabla = new Table(); 
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }

            int fila = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //RECORRE EL DATATABLE PARA AGREGAR ESOS DATOS A LA PDF - PON EL MISMO ORDEN DE LAS COLUMNAS QUE DECLARASTE ARRIBA
                tabla.AddCell(new Cell().Add(new Paragraph(fila + "").SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(dt.Rows[i]["id"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(dt.Rows[i]["disponibilidad"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(dt.Rows[i]["placa"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(dt.Rows[i]["modelo"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(dt.Rows[i]["tipo_ambulancia"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(dt.Rows[i]["capacidad"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(dt.Rows[i]["observacion"].ToString()).SetFont(fontContenido)));
                fila++;
            }
            documento.Add(tabla);
            documento.Close();
        }

    }
}
