﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;
using FontAwesome.Sharp;

namespace Visual {
    public partial class Frm_Menu : Form {
        Adm_Login admLogin = Adm_Login.GetAdm ();

        /* interaccion de botones*/
        /*almacenar boton*/
        private IconButton currentbtn;
        private Panel LeftBorderBtn;


        public Frm_Menu () {
            InitializeComponent ();
            customdesign ();
            LeftBorderBtn = new Panel ();

            LeftBorderBtn.Size = new Size (7, 54); //Size(7,54) ancho y alto
            pnlateral.Controls.Add (LeftBorderBtn);
        }

        private struct RGBCOLORS {
            public static Color azulbajo = Color.FromArgb (24, 161, 251);
        }

        private void ActivarBoton (object senderBtn, Color color) {
            if (senderBtn != null) {
                desactivarBoton ();

                currentbtn = (IconButton)senderBtn;
                currentbtn.BackColor = Color.FromArgb (37, 36, 81);
                currentbtn.ForeColor = color;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.IconColor = color;
                currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentbtn.ImageAlign = ContentAlignment.MiddleRight;
                LeftBorderBtn.BackColor = color;
                LeftBorderBtn.Location = new Point (0, currentbtn.Location.Y);
                LeftBorderBtn.Visible = true;
                LeftBorderBtn.BringToFront ();
            }
        }

        private void desactivarBoton () {
            if (currentbtn != null) {
                currentbtn.BackColor = Color.FromArgb (31, 30, 68);
                currentbtn.ForeColor = Color.Gainsboro;
                currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                currentbtn.IconColor = Color.Gainsboro;
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        private void customdesign () {
            this.pnsubmgerente.Visible = false;
            this.pnsubmcliente.Visible = false;
            this.pnsubmambulancia.Visible = false;
            this.pnsubmconductor.Visible = false;
            this.pnsubmenupeticion.Visible = false;
        }

        private void hidesubmenu () {
            if (pnsubmgerente.Visible == true) {
                pnsubmgerente.Visible = false;
            }
            if (pnsubmcliente.Visible == true) {
                pnsubmcliente.Visible = false;
            }
            if (pnsubmambulancia.Visible == true) {
                pnsubmambulancia.Visible = false;
            }
            if (pnsubmconductor.Visible == true) {
                pnsubmconductor.Visible = false;
            }
            if (pnsubmenupeticion.Visible == true) {
                pnsubmenupeticion.Visible = false;
            }
        }

        private void showsubmenu (Panel submenu) {
            if (submenu.Visible == false) {
                hidesubmenu ();
                submenu.Visible = true;
            } else {
                submenu.Visible = false;
            }
        }

        private Form FormularioActivo = null;

        private void abrirhijoform (Form FrmHijo) {
            //Si existe formulairo abierto lo cerramos
            if (FormularioActivo != null) {
                FormularioActivo.Close ();
            }
            //almacenamos el form abierto agregamos estilos y mostramos
            FormularioActivo = FrmHijo;
            FrmHijo.TopLevel = false;
            FrmHijo.FormBorderStyle = FormBorderStyle.None;
            FrmHijo.Dock = DockStyle.Fill;
            pnhijo.Controls.Add (FrmHijo);
            pnhijo.Tag = FrmHijo;
            FrmHijo.BringToFront ();
            FrmHijo.Show ();
        }

        /*
        private void iconButton2_Click(object sender, EventArgs e)
        {

        }*/

        private void cargardatos () {

            admLogin.CargarDatos (lblapellido, lblnombres, lbltipo);
            int id = 0;
            admLogin.IdUsuario ();
        }

        private void FrmMenuPr_Load (object sender, EventArgs e) {
            this.permisos ();
            this.cargardatos ();
        }

        private void permisos () {

            //switch (Usuario_Cache.Tipo) {
            switch (admLogin.TipoUsuario ()) {
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
            }
        }

    
        private void btncliente_Click (object sender, EventArgs e) {
            showsubmenu (pnsubmcliente);
            ActivarBoton (sender, RGBCOLORS.azulbajo);
        }

        private void btnconductor_Click (object sender, EventArgs e) {
            showsubmenu (pnsubmconductor);
            ActivarBoton (sender, RGBCOLORS.azulbajo);
        }

        private void btnambulancia_Click (object sender, EventArgs e) {
            showsubmenu (pnsubmambulancia);
            ActivarBoton (sender, RGBCOLORS.azulbajo);
        }

        private void btnpeticion_Click (object sender, EventArgs e) {
            //hidesubmenu();
            showsubmenu (pnsubmenupeticion);
            ActivarBoton (sender, RGBCOLORS.azulbajo);
        }

        #region Modulo Conductor
        private void btnregconduc_Click (object sender, EventArgs e) {
            abrirhijoform (new Frm_Conductor_Registrar ());
        }

        private void btnconsulconduc_Click (object sender, EventArgs e) {
            abrirhijoform (new Frm_Conductor_Consultar ());
        }

        private void btnmodiconductor_Click (object sender, EventArgs e) {
            abrirhijoform (new Frm_Conductor_Editar ());
        }
        #endregion

        #region Modulo Ambulancia
        private void btnregambulancia_Click (object sender, EventArgs e) {
            abrirhijoform (new Frm_Ambulancia_Registrar ());
        }

        private void btnconsulambulancia_Click (object sender, EventArgs e) {
            abrirhijoform (new Frm_Ambulancia_Consultar ());
        }

        private void btnmodifiambulancia_Click (object sender, EventArgs e) {
            abrirhijoform (new Frm_Ambulancia_Editar ());
        }
        #endregion

        #region Modulo Cliente
        private void btnclientereg_Click (object sender, EventArgs e) {
            abrirhijoform (new Frm_Cliente_Registrar ());
        }
        private void btnclienteconsul_Click (object sender, EventArgs e) {
            abrirhijoform (new Frm_Cliente_Consultar ());
        }
        private void btnclientemodi_Click (object sender, EventArgs e) {
            abrirhijoform (new Frm_Cliente_Editar ());
        }
        #endregion

        private void lblnombres_Click (object sender, EventArgs e) {

        }

        private void btncerrarsesion_Click (object sender, EventArgs e) {
            if (MessageBox.Show ("¿Desea cerrar cesion?", "Warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {
                this.Close ();
            }
        }

        #region Efecto boton cerrar_sesion;
        private void btncerrarsesion_MouseMove (object sender, MouseEventArgs e) {
            this.btncerrarsesion.IconColor = Color.RoyalBlue;
        }

        private void btncerrarsesion_MouseLeave (object sender, EventArgs e) {
            this.btncerrarsesion.IconColor = Color.Gainsboro;
        }
        #endregion

        private void timerhorafecha_Tick (object sender, EventArgs e) {
            //mayusculas formato de 24 minusculas formato de 12
            lblhora.Text = DateTime.Now.ToString ("HH:mm:ss");
            lblfecha.Text = DateTime.Now.ToLongDateString ();
        }

        private void btnregistrar_Click (object sender, EventArgs e) {
            abrirhijoform (new Frm_Peticion_Registrar ());
        }

        private void btnasignar_Click(object sender, EventArgs e)
        {
            abrirhijoform(new Frm_Asignacion_Registrar());
        }

        private void btnsecretaria_Click(object sender, EventArgs e)
        {
            showsubmenu(pnsubmgerente);
            ActivarBoton(sender, RGBCOLORS.azulbajo);
        }

        private void btnregsecretaria_Click(object sender, EventArgs e)
        {
            abrirhijoform(new Frm_Secretaria_Registrar());
        }
    }
}
