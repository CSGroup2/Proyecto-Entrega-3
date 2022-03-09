
namespace Visual {
    partial class Frm_Peticion_Registrar {
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.pncontenido = new System.Windows.Forms.Panel();
            this.cmb_TAmb = new System.Windows.Forms.ComboBox();
            this.nud_Ambulancia = new System.Windows.Forms.NumericUpDown();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_cedula = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Destino = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Origen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pncontenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Ambulancia)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BackgroundImage = global::Visual.Properties.Resources._9;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnguardar);
            this.panel2.Controls.Add(this.btncancelar);
            this.panel2.Controls.Add(this.btnlimpiar);
            this.panel2.Controls.Add(this.pncontenido);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 496);
            this.panel2.TabIndex = 5;
            // 
            // btnguardar
            // 
            this.btnguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnguardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.Location = new System.Drawing.Point(452, 145);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnguardar.Size = new System.Drawing.Size(183, 52);
            this.btnguardar.TabIndex = 15;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btncancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncancelar.Location = new System.Drawing.Point(452, 220);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btncancelar.Size = new System.Drawing.Size(186, 52);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlimpiar.FlatAppearance.BorderSize = 0;
            this.btnlimpiar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnlimpiar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiar.Location = new System.Drawing.Point(452, 300);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnlimpiar.Size = new System.Drawing.Size(183, 52);
            this.btnlimpiar.TabIndex = 11;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // pncontenido
            // 
            this.pncontenido.BackColor = System.Drawing.Color.White;
            this.pncontenido.Controls.Add(this.cmb_TAmb);
            this.pncontenido.Controls.Add(this.nud_Ambulancia);
            this.pncontenido.Controls.Add(this.lbl_apellido);
            this.pncontenido.Controls.Add(this.label9);
            this.pncontenido.Controls.Add(this.lbl_nombre);
            this.pncontenido.Controls.Add(this.label8);
            this.pncontenido.Controls.Add(this.lbl_cedula);
            this.pncontenido.Controls.Add(this.label4);
            this.pncontenido.Controls.Add(this.label3);
            this.pncontenido.Controls.Add(this.txt_Destino);
            this.pncontenido.Controls.Add(this.label6);
            this.pncontenido.Controls.Add(this.label1);
            this.pncontenido.Controls.Add(this.txt_Origen);
            this.pncontenido.Controls.Add(this.label5);
            this.pncontenido.Location = new System.Drawing.Point(12, 87);
            this.pncontenido.Name = "pncontenido";
            this.pncontenido.Size = new System.Drawing.Size(409, 303);
            this.pncontenido.TabIndex = 14;
            // 
            // cmb_TAmb
            // 
            this.cmb_TAmb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_TAmb.FormattingEnabled = true;
            this.cmb_TAmb.Location = new System.Drawing.Point(183, 162);
            this.cmb_TAmb.Name = "cmb_TAmb";
            this.cmb_TAmb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_TAmb.Size = new System.Drawing.Size(177, 27);
            this.cmb_TAmb.TabIndex = 23;
            // 
            // nud_Ambulancia
            // 
            this.nud_Ambulancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_Ambulancia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Ambulancia.Location = new System.Drawing.Point(283, 129);
            this.nud_Ambulancia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Ambulancia.Name = "nud_Ambulancia";
            this.nud_Ambulancia.Size = new System.Drawing.Size(77, 27);
            this.nud_Ambulancia.TabIndex = 22;
            this.nud_Ambulancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Ambulancia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_apellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_apellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_apellido.Location = new System.Drawing.Point(166, 94);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(194, 26);
            this.lbl_apellido.TabIndex = 19;
            this.lbl_apellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label9.Location = new System.Drawing.Point(40, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Primer Apellido:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_nombre.Location = new System.Drawing.Point(166, 58);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(194, 26);
            this.lbl_nombre.TabIndex = 17;
            this.lbl_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label8.Location = new System.Drawing.Point(38, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Primer Nombre:";
            // 
            // lbl_cedula
            // 
            this.lbl_cedula.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_cedula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_cedula.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_cedula.Location = new System.Drawing.Point(166, 21);
            this.lbl_cedula.Name = "lbl_cedula";
            this.lbl_cedula.Size = new System.Drawing.Size(194, 26);
            this.lbl_cedula.TabIndex = 15;
            this.lbl_cedula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(40, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Num. Ambulancias: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(40, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Punto Destino:";
            // 
            // txt_Destino
            // 
            this.txt_Destino.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Destino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Destino.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Destino.Location = new System.Drawing.Point(166, 239);
            this.txt_Destino.MaxLength = 25;
            this.txt_Destino.Name = "txt_Destino";
            this.txt_Destino.Size = new System.Drawing.Size(194, 26);
            this.txt_Destino.TabIndex = 11;
            this.txt_Destino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Destino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Destino_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(40, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo Ambulancia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(40, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Punto Origen:";
            // 
            // txt_Origen
            // 
            this.txt_Origen.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Origen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Origen.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Origen.Location = new System.Drawing.Point(166, 202);
            this.txt_Origen.MaxLength = 25;
            this.txt_Origen.Name = "txt_Origen";
            this.txt_Origen.Size = new System.Drawing.Size(194, 26);
            this.txt_Origen.TabIndex = 8;
            this.txt_Origen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Origen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Origen_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(40, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Num. Cédula:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 80);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.label2.Location = new System.Drawing.Point(150, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registro de Peticiones";
            // 
            // Frm_Peticion_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Peticion_Registrar";
            this.Text = "FrmPeticionReg";
            this.panel2.ResumeLayout(false);
            this.pncontenido.ResumeLayout(false);
            this.pncontenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Ambulancia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private System.Windows.Forms.Panel pncontenido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Origen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_cedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Destino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_Ambulancia;
        private System.Windows.Forms.ComboBox cmb_TAmb;
        private System.Windows.Forms.Label label6;
    }
}