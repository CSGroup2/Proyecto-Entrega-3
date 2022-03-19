﻿using Datos;
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
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Control
{
    public class Adm_Ambulancia
    {
        private static Adm_Ambulancia adm = new Adm_Ambulancia();
        Datos_Ambulancia dAmbulancia = new Datos_Ambulancia();

        List<Ambulancia> ambulancias = null;
        Ambulancia a = null;

        public List<Ambulancia> Ambulancias { get => ambulancias; set => ambulancias = value; }

        private Adm_Ambulancia()
        {
            ambulancias = new List<Ambulancia>();
        }

        public static Adm_Ambulancia GetAdm()
        {
            if(adm == null)
            {
                adm = new Adm_Ambulancia();
            }
            return adm;
        }

        //método para cargar los datos al combobox de Tipo Ambulancia
        public void LlenarComboTipoAmbulancia(ComboBox cmbTipo)
        {
            //cmbTipo.Items.Clear();
            cmbTipo.DataSource = dAmbulancia.ConsultarTipo();
            cmbTipo.ValueMember = "ID_TIPO_AMBULANCIA";
            cmbTipo.DisplayMember = "NOMBRE_TIPO_AMBULANCIA";
            
        }

        // Método que valida las entradas de datos en módulo ambulancias y lanza un error visible para el usuario
        public bool Validar(TextBox txtPlaca, TextBox txtModelo, ComboBox cmbTipo, TextBox txtCapacidad, TextBox txtObservacion, ErrorProvider errorP)
        {
            bool no_error = true;
            string placa = txtPlaca.Text;
            var regexP = new Regex("[a-zA-Z]{3}[0-9]{3}|[a-zA-Z]{3}[0-9]{4}");
            var regexC = new Regex("[1-9]{1}|[0-9]{2}");
            if (String.IsNullOrEmpty(txtPlaca.Text.Trim()))
            {
                errorP.SetError(txtPlaca, "Ingrese la placa");
                no_error = false;
            }
            if (!regexP.IsMatch(placa))
            {
                errorP.SetError(txtPlaca, "La placa debe contener de 3 letras y 3-4 dígitos");
                no_error = false;
            }
            if (String.IsNullOrEmpty(txtModelo.Text))
            {
                errorP.SetError(txtModelo, "Ingrese el modelo de la ambulancia");
                no_error = false;
            }
            if (cmbTipo.Text == "--Seleccione--")
            {
                errorP.SetError(cmbTipo, "Seleccione un tipo de ambulancia");
                no_error = false;
            }
            if (String.IsNullOrEmpty(txtCapacidad.Text.Trim()))
            {
                errorP.SetError(txtCapacidad, "Ingrese la capacidad de la ambulancia");
                no_error = false;
            }
            if (!regexC.IsMatch(txtCapacidad.Text))
            {
                errorP.SetError(txtCapacidad, "Ingrese números");
                no_error = false;
            }
            if (String.IsNullOrEmpty(txtObservacion.Text))
            {
                errorP.SetError(txtObservacion, "Ingrese detalles de la ambulancia");
                no_error = false;
            }
            return no_error;
        }

        //método para receptar los datos y guardar en la BD
        public string InsertarDatosAmbulancia(string placa, string modelo, int tipoA, int capacidad, string observacion)
        {
            string msj = "";
            if (dAmbulancia.ConsultarPlaca(placa) == false)
            {
                a = new Ambulancia(1, placa, modelo, tipoA, capacidad, observacion, 1);
                Ambulancias.Add(a);
                msj = dAmbulancia.InsertarAmbulancia(a);
            }
            else
            {
                msj = "La ambulancia ya está registrada";
            }
            return msj;
        }

        //método para limpiar campos del formulario de registro de ambulancias
        public void LimpiarCampos(TextBox txtPlaca, TextBox txtModelo, ComboBox cmbTipo, TextBox txtCapacidad, TextBox txtObservacion)
        {
            txtPlaca.Text = "";
            txtModelo.Text = "";
            cmbTipo.SelectedIndex = 0;
            txtCapacidad.Text = "";
            txtObservacion.Text = "";
        }

        // método para validar los campos de formulario consultar ambulancias
        public bool ValidarC(RadioButton rdbPlaca, TextBox txtDato, CheckBox chbTipo, ComboBox cmbTipo, ErrorProvider errorP)
        {
            bool no_error = true;
            if (rdbPlaca.Checked)
            {
                if (String.IsNullOrEmpty(txtDato.Text.Trim()))
                {
                    errorP.SetError(txtDato, "Ingrese la placa");
                    no_error = false;
                }
            }
            else
            {
                if (String.IsNullOrEmpty(txtDato.Text))
                {
                    errorP.SetError(txtDato, "Ingrese el modelo de la ambulancia");
                    no_error = false;
                }
            }
            if(chbTipo.Checked)
            {
                if (cmbTipo.Text == "--Seleccione--")
                {
                    errorP.SetError(cmbTipo, "Seleccione un tipo de ambulancia");
                    no_error = false;
                }
            }
            return no_error;
        }

        // método para consultar ambulancias por filtros
        public DataTable ConsultarAmbulancias(string dato, int tipo, int disponibilidad, int buscarOb, int buscarOp)
        {
            DataTable dtresult = new DataTable();
            dtresult = dAmbulancia.ConsultarAmbulancias(dato, tipo, disponibilidad, buscarOb, buscarOp);
            return dtresult;
        }

        // método para listar todas las ambulancias registradas
        public void ListarAmbulancias(DataGridView dgvAmbulancias)
        {
            dgvAmbulancias.Refresh();
            dgvAmbulancias.DataSource = dAmbulancia.ListarAmbulancias();
        }

        // método para listar sólo las ambulancias disponibles para poder asignarle a un conductor (Adm_Asignacion)
        public void ListarAmbulanciasDisponibles(DataGridView dgvAmbulancia)
        {
            dgvAmbulancia.Refresh();
            dgvAmbulancia.DataSource = dAmbulancia.ListarAmbulanciasDisponibles();
        }

        //método para cargar los datos al combobox de Disponibilidad
        public void LlenarComboDisponibilidad(ComboBox cmbDisp)
        {
            //cmbDisp.Items.Clear();
            cmbDisp.DataSource = dAmbulancia.ConsultarDisponibilidad();
            cmbDisp.ValueMember = "ID_DISPONIBILIDAD";
            cmbDisp.DisplayMember = "NOMBRE_DISPONIBILIDAD";

        }

        // método para cargar los datos de una fila seleccionada a los campos de la ventana Editar
        public void LlenarCamposEditar(int posicion, string placa, TextBox txtPlaca, TextBox txtModelo, ComboBox cmbTipo, TextBox txtCapacidad, TextBox txtObservacion, ComboBox cmbDisp)
        {
            if (posicion >= 0)
            {
                a = dAmbulancia.ConsultarAmbulanciasXplaca(placa);
                //cmbDisp.Items.Clear();
                txtPlaca.Text = a.Placa.ToString();
                LlenarComboDisponibilidad(cmbDisp);
                cmbDisp.SelectedIndex = a.Disponibilidad;
                txtModelo.Text = a.Modelo.ToString();
                //cmbTipo.Items.Clear();
                LlenarComboTipoAmbulancia(cmbTipo);
                cmbTipo.SelectedIndex = a.Tipo_ambulancia;
                txtCapacidad.Text = a.Capacidad.ToString();
                txtObservacion.Text = a.Observacion.ToString();
            }
        }

        //método para llenar los campos de edición según la placa buscada
        public bool BuscarPlaca(string placa, ComboBox cmbDisp, TextBox txtModelo, ComboBox cmbTipo, TextBox txtCapacidad, TextBox txtObservacion)
        {
            bool existePlaca = false;
            var regexP = new Regex("[a-zA-Z]{3}[0-9]{3}|[a-zA-Z]{3}[0-9]{4}");
            if (regexP.IsMatch(placa))
            {
                a = dAmbulancia.ConsultarAmbulanciasXplaca(placa);
                if (a != null)
                {
                    //cmbDisp.Items.Clear();
                    LlenarComboDisponibilidad(cmbDisp);
                    cmbDisp.SelectedIndex = a.Disponibilidad;
                    txtModelo.Text = a.Modelo.ToString();
                    //cmbTipo.Items.Clear();
                    LlenarComboTipoAmbulancia(cmbTipo);
                    cmbTipo.SelectedIndex = a.Tipo_ambulancia;
                    txtCapacidad.Text = a.Capacidad.ToString();
                    txtObservacion.Text = a.Observacion.ToString();
                }
                existePlaca = true;
            }
            else
            {
                existePlaca = false;
            }
            return existePlaca;
        }

        // método para actualizar los datos de la ambulancia 
        public string ActualizarDatosAmbulancia(string placa, int disponibilidad, string modelo, int tipoA, int capacidad, string observacion)
        {
            string msj = "";
            a.Placa = placa;
            a.Disponibilidad = disponibilidad;
            a.Modelo = modelo;
            a.Tipo_ambulancia = tipoA;
            a.Capacidad = capacidad;
            a.Observacion = observacion;
            msj = dAmbulancia.EditarAmbulancias(a);
            return msj;
        }

        public void LimpiarCamposE(TextBox txtPlaca, TextBox txtModelo, ComboBox cmbTipo, TextBox txtCapacidad, TextBox txtObservacion, ComboBox cmbDisp)
        {
            txtPlaca.Text = "";
            txtModelo.Text = "";
            cmbTipo.SelectedIndex = 0;
            txtCapacidad.Text = "";
            txtObservacion.Text = "";
            cmbDisp.SelectedIndex = 0;
        }

        public void BloquearCampos(TextBox txtPlaca, Button btnBuscar,TextBox txtModelo, ComboBox cmbTipo, TextBox txtCapacidad, TextBox txtObservacion, ComboBox cmbDisp)
        {
            txtPlaca.Enabled = true;
            btnBuscar.Enabled = true;
            txtModelo.Enabled = false;
            cmbTipo.Enabled = false;
            txtCapacidad.Enabled = false;
            txtObservacion.Enabled = false;
            cmbDisp.Enabled = false;
        }

        public void DesbloquearCampos(TextBox txtPlaca, Button btnBuscar, TextBox txtModelo, ComboBox cmbTipo, TextBox txtCapacidad, TextBox txtObservacion, ComboBox cmbDisp)
        {
            txtPlaca.Enabled = false;
            btnBuscar.Enabled = false;
            txtModelo.Enabled = true;
            cmbTipo.Enabled = true;
            txtCapacidad.Enabled = true;
            txtObservacion.Enabled = true;
            cmbDisp.Enabled = true;
        }

        public string EliminarDatosAmbulancia(string placa)
        {
            string msj = "";
            msj = dAmbulancia.EliminarAmbulancia(placa);
            return msj;
        }

        public void CrearPdf (string dato, int tipo, int disponibilidad, int buscarOb, int buscarOp, string file) {
            PdfWriter pdfWriter = new PdfWriter (file);
            PdfDocument pdf = new PdfDocument (pdfWriter);
            Document documento = new Document (pdf, PageSize.LETTER);

            documento.SetMargins (60, 20, 55, 20);
            PdfFont fontColumnas = PdfFontFactory.CreateFont (StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont (StandardFonts.HELVETICA);

            string [] columnas = { "Nº", "id", "placa", "modelo", "tipo", "capacidad", "observación", "disponibilidad" };
            float [] tamanios = { 2, 2, 3, 4, 4, 2, 5, 3 };

            Table tabla = new Table (UnitValue.CreatePercentArray (tamanios));
            tabla.SetWidth (UnitValue.CreatePercentValue (100));

            foreach (string columna in columnas) {
                tabla.AddHeaderCell (new Cell ().Add (new Paragraph (columna).SetFont (fontColumnas)));
            }

            DataTable dtresult = new DataTable();
            dtresult = dAmbulancia.ConsultarAmbulancias(dato, tipo, disponibilidad, buscarOb, buscarOp);
            int f = 1;
            for (int i = 0; i < dtresult.Rows.Count; i++)
            {
            
                tabla.AddCell (new Cell ().Add (new Paragraph (f + "").SetFont (fontContenido)));
                tabla.AddCell (new Cell ().Add (new Paragraph (dtresult.Rows[i]["id"].ToString()).SetFont (fontContenido)));
                tabla.AddCell (new Cell ().Add (new Paragraph (dtresult.Rows[i]["placa"].ToString()).SetFont (fontContenido)));
                tabla.AddCell (new Cell ().Add (new Paragraph (dtresult.Rows[i]["modelo"].ToString()).SetFont (fontContenido)));
                tabla.AddCell (new Cell ().Add (new Paragraph (dtresult.Rows[i]["tipo_ambulancia"].ToString()).SetFont (fontContenido)));
                tabla.AddCell (new Cell ().Add (new Paragraph (dtresult.Rows[i]["capacidad"].ToString()).SetFont (fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(dtresult.Rows[i]["observacion"].ToString()).SetFont(fontContenido)));
                tabla.AddCell (new Cell().Add(new Paragraph(dtresult.Rows[i]["disponibilidad"].ToString()).SetFont(fontContenido)));
                f++;
            }
            documento.Add (tabla);
            documento.Close ();
        }
    }
}
