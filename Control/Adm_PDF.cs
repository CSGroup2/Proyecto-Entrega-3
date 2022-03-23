using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Control
{
    public class Adm_PDF
    {
        /* conprobar nombre alexander castro mora 
           Aplicar el patron de diseño Singleton:
           1. Crear 1 atributo estático y privado de la misma clase.
           2. Cambiar el constructor de public a private.
           3.1. Crear un getter del atributo estático del tipo de la clase.
           3.2.Verificar si atributo es null, si es así, crearlo.
       */
        private static Adm_PDF adm_pdf = null;    // 1.

        // Constructor: Adm_Cliente
        private Adm_PDF()  // 2.
        {
        }

        // Getter: GetAdm
        public static Adm_PDF GetAdm()
        {     // 3.1.
            if (adm_pdf == null)
            {                  //3.2
                adm_pdf = new Adm_PDF();
            }
            return adm_pdf;
        }

        //método para crear pdf con los datos del datagridview
        public void CrearPdf(DataTable dt, string file, string[] columnas, float[] tamanios, int orientacion)
        {
            PageSize orientacionpagina;
            if (orientacion == 1)
            {
                orientacionpagina = PageSize.LETTER;
            }
            else
            {
                orientacionpagina = PageSize.LETTER.Rotate();
            }

            PdfWriter pdfWriter = new PdfWriter(file);
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document documento = new Document(pdf, orientacionpagina);      
         
            
            iText.IO.Image.ImageData imageData = iText.IO.Image.ImageDataFactory.Create("..\\..\\Resources\\LosRapidos.png");
            Image image = new Image(imageData);
            image.SetHeight(75);
            image.SetWidth(75);
            documento.Add(image);

            documento.SetMargins(60, 20, 55, 20);
            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));
            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }
            //RECORRE EL DATATABLE PARA AGREGAR ESOS DATOS A LA PDF
            int fila = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tabla.AddCell(new Cell().Add(new Paragraph(fila + "").SetFont(fontContenido)));
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    tabla.AddCell(new Cell().Add(new Paragraph(dt.Rows[i][j].ToString()).SetFont(fontContenido)));
                }
                fila++;
            }
            documento.Add(tabla);
            documento.Close();
        }

    }
}
