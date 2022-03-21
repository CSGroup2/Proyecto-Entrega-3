using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Visual
{
    public partial class Frm_Mensaje : Form
    {
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        public Frm_Mensaje()
        {
            InitializeComponent();
            TextBox[] texts = { lblTitulo, txtMensaje};
            foreach (TextBox item in texts)
                item.GotFocus += delegate { HideCaret(item.Handle); };
        }

        private void Frm_Mensaje_Load(object sender, EventArgs e)
        {
            lblTitulo.Select(lblTitulo.TextLength, 0);
            txtMensaje.Select(txtMensaje.TextLength, 0);
        }
    }
}
