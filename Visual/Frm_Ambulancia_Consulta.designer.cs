
namespace Visual {
    partial class Frm_Ambulancia_Consultar {
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnimprimir = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.pncontenido = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbModelo = new System.Windows.Forms.RadioButton();
            this.rdbPlaca = new System.Windows.Forms.RadioButton();
            this.chbTipo = new System.Windows.Forms.CheckBox();
            this.btnMostrartodos = new FontAwesome.Sharp.IconButton();
            this.btnConsultar = new FontAwesome.Sharp.IconButton();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.chbDisponibilidad = new System.Windows.Forms.CheckBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvAmbulancias = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            this.pncontenido.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmbulancias)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BackgroundImage = global::Visual.Properties.Resources._9;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnimprimir);
            this.panel2.Controls.Add(this.btnguardar);
            this.panel2.Controls.Add(this.pncontenido);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 419);
            this.panel2.TabIndex = 4;
            // 
            // btnimprimir
            // 
            this.btnimprimir.FlatAppearance.BorderSize = 0;
            this.btnimprimir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnimprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnimprimir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnimprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnimprimir.Location = new System.Drawing.Point(357, 343);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnimprimir.Size = new System.Drawing.Size(183, 52);
            this.btnimprimir.TabIndex = 16;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.MouseLeave += new System.EventHandler(this.btnimprimir_MouseLeave);
            this.btnimprimir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnimprimir_MouseMove);
            // 
            // btnguardar
            // 
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnguardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.Location = new System.Drawing.Point(149, 343);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnguardar.Size = new System.Drawing.Size(183, 52);
            this.btnguardar.TabIndex = 15;
            this.btnguardar.Text = "Modificar";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.MouseLeave += new System.EventHandler(this.btnguardar_MouseLeave);
            this.btnguardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnguardar_MouseMove);
            // 
            // pncontenido
            // 
            this.pncontenido.BackColor = System.Drawing.Color.White;
            this.pncontenido.Controls.Add(this.groupBox1);
            this.pncontenido.Controls.Add(this.chbTipo);
            this.pncontenido.Controls.Add(this.btnMostrartodos);
            this.pncontenido.Controls.Add(this.btnConsultar);
            this.pncontenido.Controls.Add(this.cmbTipo);
            this.pncontenido.Controls.Add(this.chbDisponibilidad);
            this.pncontenido.Controls.Add(this.txtDato);
            this.pncontenido.Controls.Add(this.label14);
            this.pncontenido.Controls.Add(this.dgvAmbulancias);
            this.pncontenido.Location = new System.Drawing.Point(20, 15);
            this.pncontenido.Name = "pncontenido";
            this.pncontenido.Size = new System.Drawing.Size(622, 308);
            this.pncontenido.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbModelo);
            this.groupBox1.Controls.Add(this.rdbPlaca);
            this.groupBox1.Location = new System.Drawing.Point(237, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 39);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            // 
            // rdbModelo
            // 
            this.rdbModelo.AutoSize = true;
            this.rdbModelo.BackColor = System.Drawing.Color.Transparent;
            this.rdbModelo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbModelo.Location = new System.Drawing.Point(100, 17);
            this.rdbModelo.Name = "rdbModelo";
            this.rdbModelo.Size = new System.Drawing.Size(67, 19);
            this.rdbModelo.TabIndex = 52;
            this.rdbModelo.Text = "Modelo";
            this.rdbModelo.UseVisualStyleBackColor = false;
            // 
            // rdbPlaca
            // 
            this.rdbPlaca.AutoSize = true;
            this.rdbPlaca.BackColor = System.Drawing.Color.Transparent;
            this.rdbPlaca.Checked = true;
            this.rdbPlaca.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPlaca.Location = new System.Drawing.Point(11, 17);
            this.rdbPlaca.Name = "rdbPlaca";
            this.rdbPlaca.Size = new System.Drawing.Size(60, 19);
            this.rdbPlaca.TabIndex = 51;
            this.rdbPlaca.TabStop = true;
            this.rdbPlaca.Text = "Placa";
            this.rdbPlaca.UseVisualStyleBackColor = false;
            // 
            // chbTipo
            // 
            this.chbTipo.AutoSize = true;
            this.chbTipo.BackColor = System.Drawing.Color.Transparent;
            this.chbTipo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTipo.Location = new System.Drawing.Point(25, 63);
            this.chbTipo.Name = "chbTipo";
            this.chbTipo.Size = new System.Drawing.Size(54, 19);
            this.chbTipo.TabIndex = 59;
            this.chbTipo.Text = "Tipo";
            this.chbTipo.UseVisualStyleBackColor = false;
            // 
            // btnMostrartodos
            // 
            this.btnMostrartodos.FlatAppearance.BorderSize = 0;
            this.btnMostrartodos.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrartodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnMostrartodos.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnMostrartodos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnMostrartodos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMostrartodos.IconSize = 35;
            this.btnMostrartodos.Location = new System.Drawing.Point(420, 52);
            this.btnMostrartodos.Name = "btnMostrartodos";
            this.btnMostrartodos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMostrartodos.Size = new System.Drawing.Size(171, 37);
            this.btnMostrartodos.TabIndex = 57;
            this.btnMostrartodos.Text = "Mostrar Todos";
            this.btnMostrartodos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMostrartodos.UseVisualStyleBackColor = true;
            this.btnMostrartodos.Click += new System.EventHandler(this.btnMostrartodos_Click);
            this.btnMostrartodos.MouseLeave += new System.EventHandler(this.btnmostrartodos_MouseLeave);
            this.btnMostrartodos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnmostrartodos_MouseMove);
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnConsultar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnConsultar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnConsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultar.IconSize = 35;
            this.btnConsultar.Location = new System.Drawing.Point(235, 52);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConsultar.Size = new System.Drawing.Size(168, 37);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            this.btnConsultar.MouseLeave += new System.EventHandler(this.btnconsultar_MouseLeave);
            this.btnConsultar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnconsultar_MouseMove);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(80, 63);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(145, 21);
            this.cmbTipo.TabIndex = 56;
            // 
            // chbDisponibilidad
            // 
            this.chbDisponibilidad.AutoSize = true;
            this.chbDisponibilidad.BackColor = System.Drawing.Color.Transparent;
            this.chbDisponibilidad.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDisponibilidad.Location = new System.Drawing.Point(453, 18);
            this.chbDisponibilidad.Name = "chbDisponibilidad";
            this.chbDisponibilidad.Size = new System.Drawing.Size(124, 19);
            this.chbDisponibilidad.TabIndex = 55;
            this.chbDisponibilidad.Text = "Disponibilidad";
            this.chbDisponibilidad.UseVisualStyleBackColor = false;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(80, 18);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(145, 20);
            this.txtDato.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 15);
            this.label14.TabIndex = 49;
            this.label14.Text = "Dato: ";
            // 
            // dgvAmbulancias
            // 
            this.dgvAmbulancias.AllowUserToAddRows = false;
            this.dgvAmbulancias.AllowUserToDeleteRows = false;
            this.dgvAmbulancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmbulancias.Location = new System.Drawing.Point(25, 103);
            this.dgvAmbulancias.Name = "dgvAmbulancias";
            this.dgvAmbulancias.ReadOnly = true;
            this.dgvAmbulancias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAmbulancias.Size = new System.Drawing.Size(566, 182);
            this.dgvAmbulancias.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 63);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.label2.Location = new System.Drawing.Point(102, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(481, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consulta de Ambulancias";
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // Frm_Ambulancia_Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 482);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Ambulancia_Consultar";
            this.Text = "FrmAmbulanciaConsul";
            this.Load += new System.EventHandler(this.FrmAmbulanciaConsul_Load);
            this.panel2.ResumeLayout(false);
            this.pncontenido.ResumeLayout(false);
            this.pncontenido.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmbulancias)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnimprimir;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.Panel pncontenido;
        private FontAwesome.Sharp.IconButton btnMostrartodos;
        private FontAwesome.Sharp.IconButton btnConsultar;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.CheckBox chbDisponibilidad;
        private System.Windows.Forms.RadioButton rdbModelo;
        private System.Windows.Forms.RadioButton rdbPlaca;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvAmbulancias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbTipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorP;
    }
}