﻿
namespace Visual {
    partial class Frm_Cliente_Consultar {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.panel2 = new System.Windows.Forms.Panel ();
            this.btnimprimir = new FontAwesome.Sharp.IconButton ();
            this.btnguardar = new FontAwesome.Sharp.IconButton ();
            this.pncontenido = new System.Windows.Forms.Panel ();
            this.comboBox1 = new System.Windows.Forms.ComboBox ();
            this.checkBox1 = new System.Windows.Forms.CheckBox ();
            this.btnmostrartodos = new FontAwesome.Sharp.IconButton ();
            this.btnconsultar = new FontAwesome.Sharp.IconButton ();
            this.cbxbuscarestado = new System.Windows.Forms.ComboBox ();
            this.chxestado = new System.Windows.Forms.CheckBox ();
            this.opnombres = new System.Windows.Forms.RadioButton ();
            this.opcedula = new System.Windows.Forms.RadioButton ();
            this.txtCriterio = new System.Windows.Forms.TextBox ();
            this.label14 = new System.Windows.Forms.Label ();
            this.dgv_listarTodos = new System.Windows.Forms.DataGridView ();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn ();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn ();
            this.hospital = new System.Windows.Forms.DataGridViewTextBoxColumn ();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn ();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn ();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn ();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn ();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn ();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn ();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn ();
            this.panel1 = new System.Windows.Forms.Panel ();
            this.label2 = new System.Windows.Forms.Label ();
            this.panel2.SuspendLayout ();
            this.pncontenido.SuspendLayout ();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarTodos)).BeginInit ();
            this.panel1.SuspendLayout ();
            this.SuspendLayout ();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BackgroundImage = global::Visual.Properties.Resources._9;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add (this.btnimprimir);
            this.panel2.Controls.Add (this.btnguardar);
            this.panel2.Controls.Add (this.pncontenido);
            this.panel2.Location = new System.Drawing.Point (0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size (662, 419);
            this.panel2.TabIndex = 4;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnimprimir.FlatAppearance.BorderSize = 0;
            this.btnimprimir.Font = new System.Drawing.Font ("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.ForeColor = System.Drawing.Color.FromArgb (((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnimprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnimprimir.IconColor = System.Drawing.Color.FromArgb (((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnimprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnimprimir.Location = new System.Drawing.Point (356, 346);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Padding = new System.Windows.Forms.Padding (10, 0, 0, 0);
            this.btnimprimir.Size = new System.Drawing.Size (183, 52);
            this.btnimprimir.TabIndex = 16;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.MouseLeave += new System.EventHandler (this.btnimprimir_MouseLeave);
            this.btnimprimir.MouseMove += new System.Windows.Forms.MouseEventHandler (this.btnimprimir_MouseMove);
            // 
            // btnguardar
            // 
            this.btnguardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.Font = new System.Drawing.Font ("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.FromArgb (((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnguardar.IconColor = System.Drawing.Color.FromArgb (((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.Location = new System.Drawing.Point (148, 346);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Padding = new System.Windows.Forms.Padding (10, 0, 0, 0);
            this.btnguardar.Size = new System.Drawing.Size (183, 52);
            this.btnguardar.TabIndex = 15;
            this.btnguardar.Text = "Modificar";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.MouseLeave += new System.EventHandler (this.btnguardar_MouseLeave);
            this.btnguardar.MouseMove += new System.Windows.Forms.MouseEventHandler (this.btnguardar_MouseMove);
            // 
            // pncontenido
            // 
            this.pncontenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pncontenido.BackColor = System.Drawing.Color.White;
            this.pncontenido.Controls.Add (this.comboBox1);
            this.pncontenido.Controls.Add (this.checkBox1);
            this.pncontenido.Controls.Add (this.btnmostrartodos);
            this.pncontenido.Controls.Add (this.btnconsultar);
            this.pncontenido.Controls.Add (this.cbxbuscarestado);
            this.pncontenido.Controls.Add (this.chxestado);
            this.pncontenido.Controls.Add (this.opnombres);
            this.pncontenido.Controls.Add (this.opcedula);
            this.pncontenido.Controls.Add (this.txtCriterio);
            this.pncontenido.Controls.Add (this.label14);
            this.pncontenido.Controls.Add (this.dgv_listarTodos);
            this.pncontenido.Location = new System.Drawing.Point (20, 28);
            this.pncontenido.Name = "pncontenido";
            this.pncontenido.Size = new System.Drawing.Size (622, 299);
            this.pncontenido.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point (472, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size (127, 21);
            this.comboBox1.TabIndex = 59;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font ("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point (384, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size (82, 19);
            this.checkBox1.TabIndex = 58;
            this.checkBox1.Text = "Hospital";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // btnmostrartodos
            // 
            this.btnmostrartodos.FlatAppearance.BorderSize = 0;
            this.btnmostrartodos.Font = new System.Drawing.Font ("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrartodos.ForeColor = System.Drawing.Color.FromArgb (((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnmostrartodos.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnmostrartodos.IconColor = System.Drawing.Color.FromArgb (((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnmostrartodos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnmostrartodos.IconSize = 35;
            this.btnmostrartodos.Location = new System.Drawing.Point (428, 52);
            this.btnmostrartodos.Name = "btnmostrartodos";
            this.btnmostrartodos.Padding = new System.Windows.Forms.Padding (10, 0, 0, 0);
            this.btnmostrartodos.Size = new System.Drawing.Size (171, 37);
            this.btnmostrartodos.TabIndex = 57;
            this.btnmostrartodos.Text = "Mostrar Todos";
            this.btnmostrartodos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnmostrartodos.UseVisualStyleBackColor = true;
            this.btnmostrartodos.MouseLeave += new System.EventHandler (this.btnmostrartodos_MouseLeave);
            this.btnmostrartodos.MouseMove += new System.Windows.Forms.MouseEventHandler (this.btnmostrartodos_MouseMove);
            // 
            // btnconsultar
            // 
            this.btnconsultar.FlatAppearance.BorderSize = 0;
            this.btnconsultar.Font = new System.Drawing.Font ("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultar.ForeColor = System.Drawing.Color.FromArgb (((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnconsultar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnconsultar.IconColor = System.Drawing.Color.FromArgb (((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnconsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnconsultar.IconSize = 35;
            this.btnconsultar.Location = new System.Drawing.Point (253, 52);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Padding = new System.Windows.Forms.Padding (10, 0, 0, 0);
            this.btnconsultar.Size = new System.Drawing.Size (146, 37);
            this.btnconsultar.TabIndex = 16;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.MouseLeave += new System.EventHandler (this.btnconsultar_MouseLeave);
            this.btnconsultar.MouseMove += new System.Windows.Forms.MouseEventHandler (this.btnconsultar_MouseMove);
            // 
            // cbxbuscarestado
            // 
            this.cbxbuscarestado.FormattingEnabled = true;
            this.cbxbuscarestado.Location = new System.Drawing.Point (101, 62);
            this.cbxbuscarestado.Name = "cbxbuscarestado";
            this.cbxbuscarestado.Size = new System.Drawing.Size (108, 21);
            this.cbxbuscarestado.TabIndex = 56;
            // 
            // chxestado
            // 
            this.chxestado.AutoSize = true;
            this.chxestado.BackColor = System.Drawing.Color.Transparent;
            this.chxestado.Font = new System.Drawing.Font ("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxestado.Location = new System.Drawing.Point (27, 64);
            this.chxestado.Name = "chxestado";
            this.chxestado.Size = new System.Drawing.Size (68, 19);
            this.chxestado.TabIndex = 55;
            this.chxestado.Text = "Estado";
            this.chxestado.UseVisualStyleBackColor = false;
            // 
            // opnombres
            // 
            this.opnombres.AutoSize = true;
            this.opnombres.BackColor = System.Drawing.Color.Transparent;
            this.opnombres.Font = new System.Drawing.Font ("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opnombres.Location = new System.Drawing.Point (301, 20);
            this.opnombres.Name = "opnombres";
            this.opnombres.Size = new System.Drawing.Size (67, 19);
            this.opnombres.TabIndex = 52;
            this.opnombres.Text = "Nombre";
            this.opnombres.UseVisualStyleBackColor = false;
            // 
            // opcedula
            // 
            this.opcedula.AutoSize = true;
            this.opcedula.BackColor = System.Drawing.Color.Transparent;
            this.opcedula.Checked = true;
            this.opcedula.Font = new System.Drawing.Font ("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcedula.Location = new System.Drawing.Point (222, 20);
            this.opcedula.Name = "opcedula";
            this.opcedula.Size = new System.Drawing.Size (67, 19);
            this.opcedula.TabIndex = 51;
            this.opcedula.TabStop = true;
            this.opcedula.Text = "Cédula";
            this.opcedula.UseVisualStyleBackColor = false;
            // 
            // txtCriterio
            // 
            this.txtCriterio.Location = new System.Drawing.Point (76, 20);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size (133, 20);
            this.txtCriterio.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font ("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point (24, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size (49, 15);
            this.label14.TabIndex = 49;
            this.label14.Text = "Dato: ";
            // 
            // dgv_listarTodos
            // 
            this.dgv_listarTodos.AllowUserToAddRows = false;
            this.dgv_listarTodos.AllowUserToDeleteRows = false;
            this.dgv_listarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_listarTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listarTodos.Columns.AddRange (new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.estado,
            this.hospital,
            this.Cedula,
            this.Nombres,
            this.Apellidos,
            this.Sexo,
            this.FechaNac,
            this.telefono,
            this.correo});
            this.dgv_listarTodos.Location = new System.Drawing.Point (24, 99);
            this.dgv_listarTodos.Name = "dgv_listarTodos";
            this.dgv_listarTodos.ReadOnly = true;
            this.dgv_listarTodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listarTodos.Size = new System.Drawing.Size (575, 182);
            this.dgv_listarTodos.TabIndex = 48;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // hospital
            // 
            this.hospital.HeaderText = "Hospital";
            this.hospital.Name = "hospital";
            this.hospital.ReadOnly = true;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cédula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // FechaNac
            // 
            this.FechaNac.HeaderText = "Fech. Nacimiento";
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb (((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add (this.label2);
            this.panel1.Location = new System.Drawing.Point (0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size (662, 63);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font ("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb (((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.label2.Location = new System.Drawing.Point (141, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (389, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consulta de Clientes";
            // 
            // Frm_Cliente_Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (662, 482);
            this.Controls.Add (this.panel2);
            this.Controls.Add (this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Cliente_Consultar";
            this.Text = "FrmClienteConsul";
            this.Load += new System.EventHandler (this.FrmClienteConsul_Load);
            this.panel2.ResumeLayout (false);
            this.pncontenido.ResumeLayout (false);
            this.pncontenido.PerformLayout ();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listarTodos)).EndInit ();
            this.panel1.ResumeLayout (false);
            this.panel1.PerformLayout ();
            this.ResumeLayout (false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnimprimir;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.Panel pncontenido;
        private FontAwesome.Sharp.IconButton btnmostrartodos;
        private FontAwesome.Sharp.IconButton btnconsultar;
        private System.Windows.Forms.ComboBox cbxbuscarestado;
        private System.Windows.Forms.CheckBox chxestado;
        private System.Windows.Forms.RadioButton opnombres;
        private System.Windows.Forms.RadioButton opcedula;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgv_listarTodos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospital;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
    }
}