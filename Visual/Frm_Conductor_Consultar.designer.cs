
namespace Visual {
    partial class Frm_Conductor_Consultar {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Imprimir = new FontAwesome.Sharp.IconButton();
            this.btn_Modificar = new FontAwesome.Sharp.IconButton();
            this.pncontenido = new System.Windows.Forms.Panel();
            this.btn_MostrarTodos = new FontAwesome.Sharp.IconButton();
            this.btn_Consultar = new FontAwesome.Sharp.IconButton();
            this.cmb_Disponibilidad = new System.Windows.Forms.ComboBox();
            this.chb_Disponibilidad = new System.Windows.Forms.CheckBox();
            this.rdb_Nombre = new System.Windows.Forms.RadioButton();
            this.rdb_Cedula = new System.Windows.Forms.RadioButton();
            this.txt_CedulaNombre = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgv_Conductor = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pncontenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Conductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 63);
            this.panel1.TabIndex = 1;
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
            this.label2.Size = new System.Drawing.Size(480, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consulta de Conductores";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BackgroundImage = global::Visual.Properties.Resources._9;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btn_Imprimir);
            this.panel2.Controls.Add(this.btn_Modificar);
            this.panel2.Controls.Add(this.pncontenido);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 513);
            this.panel2.TabIndex = 2;
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Imprimir.FlatAppearance.BorderSize = 0;
            this.btn_Imprimir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Imprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btn_Imprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btn_Imprimir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btn_Imprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Imprimir.Location = new System.Drawing.Point(357, 421);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Imprimir.Size = new System.Drawing.Size(183, 52);
            this.btn_Imprimir.TabIndex = 16;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            this.btn_Imprimir.MouseLeave += new System.EventHandler(this.btnimprimir_MouseLeave);
            this.btn_Imprimir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnimprimir_MouseMove);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btn_Modificar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btn_Modificar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btn_Modificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Modificar.Location = new System.Drawing.Point(149, 421);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Modificar.Size = new System.Drawing.Size(183, 52);
            this.btn_Modificar.TabIndex = 15;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            this.btn_Modificar.MouseLeave += new System.EventHandler(this.btnguardar_MouseLeave);
            this.btn_Modificar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnguardar_MouseMove);
            // 
            // pncontenido
            // 
            this.pncontenido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pncontenido.BackColor = System.Drawing.Color.White;
            this.pncontenido.Controls.Add(this.btn_MostrarTodos);
            this.pncontenido.Controls.Add(this.btn_Consultar);
            this.pncontenido.Controls.Add(this.cmb_Disponibilidad);
            this.pncontenido.Controls.Add(this.chb_Disponibilidad);
            this.pncontenido.Controls.Add(this.rdb_Nombre);
            this.pncontenido.Controls.Add(this.rdb_Cedula);
            this.pncontenido.Controls.Add(this.txt_CedulaNombre);
            this.pncontenido.Controls.Add(this.label14);
            this.pncontenido.Controls.Add(this.dgv_Conductor);
            this.pncontenido.Location = new System.Drawing.Point(20, 23);
            this.pncontenido.Name = "pncontenido";
            this.pncontenido.Size = new System.Drawing.Size(638, 370);
            this.pncontenido.TabIndex = 14;
            // 
            // btn_MostrarTodos
            // 
            this.btn_MostrarTodos.FlatAppearance.BorderSize = 0;
            this.btn_MostrarTodos.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MostrarTodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btn_MostrarTodos.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_MostrarTodos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btn_MostrarTodos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_MostrarTodos.IconSize = 35;
            this.btn_MostrarTodos.Location = new System.Drawing.Point(420, 24);
            this.btn_MostrarTodos.Name = "btn_MostrarTodos";
            this.btn_MostrarTodos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_MostrarTodos.Size = new System.Drawing.Size(171, 37);
            this.btn_MostrarTodos.TabIndex = 57;
            this.btn_MostrarTodos.Text = "Mostrar Todos";
            this.btn_MostrarTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_MostrarTodos.UseVisualStyleBackColor = true;
            this.btn_MostrarTodos.Click += new System.EventHandler(this.btn_MostrarTodos_Click);
            this.btn_MostrarTodos.MouseLeave += new System.EventHandler(this.btnmostrartodos_MouseLeave);
            this.btn_MostrarTodos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnmostrartodos_MouseMove);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.FlatAppearance.BorderSize = 0;
            this.btn_Consultar.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Consultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btn_Consultar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btn_Consultar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btn_Consultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Consultar.IconSize = 35;
            this.btn_Consultar.Location = new System.Drawing.Point(420, 97);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Consultar.Size = new System.Drawing.Size(171, 37);
            this.btn_Consultar.TabIndex = 16;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            this.btn_Consultar.MouseLeave += new System.EventHandler(this.btnconsultar_MouseLeave);
            this.btn_Consultar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnconsultar_MouseMove);
            // 
            // cmb_Disponibilidad
            // 
            this.cmb_Disponibilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Disponibilidad.FormattingEnabled = true;
            this.cmb_Disponibilidad.Location = new System.Drawing.Point(88, 56);
            this.cmb_Disponibilidad.Name = "cmb_Disponibilidad";
            this.cmb_Disponibilidad.Size = new System.Drawing.Size(152, 21);
            this.cmb_Disponibilidad.TabIndex = 56;
            // 
            // chb_Disponibilidad
            // 
            this.chb_Disponibilidad.AutoSize = true;
            this.chb_Disponibilidad.BackColor = System.Drawing.Color.Transparent;
            this.chb_Disponibilidad.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_Disponibilidad.Location = new System.Drawing.Point(258, 59);
            this.chb_Disponibilidad.Name = "chb_Disponibilidad";
            this.chb_Disponibilidad.Size = new System.Drawing.Size(124, 19);
            this.chb_Disponibilidad.TabIndex = 55;
            this.chb_Disponibilidad.Text = "Disponibilidad";
            this.chb_Disponibilidad.UseVisualStyleBackColor = false;
            this.chb_Disponibilidad.CheckedChanged += new System.EventHandler(this.chb_Disponibilidad_CheckedChanged);
            // 
            // rdb_Nombre
            // 
            this.rdb_Nombre.AutoSize = true;
            this.rdb_Nombre.BackColor = System.Drawing.Color.Transparent;
            this.rdb_Nombre.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Nombre.Location = new System.Drawing.Point(337, 16);
            this.rdb_Nombre.Name = "rdb_Nombre";
            this.rdb_Nombre.Size = new System.Drawing.Size(67, 19);
            this.rdb_Nombre.TabIndex = 52;
            this.rdb_Nombre.Text = "Nombre";
            this.rdb_Nombre.UseVisualStyleBackColor = false;
            // 
            // rdb_Cedula
            // 
            this.rdb_Cedula.AutoSize = true;
            this.rdb_Cedula.BackColor = System.Drawing.Color.Transparent;
            this.rdb_Cedula.Checked = true;
            this.rdb_Cedula.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Cedula.Location = new System.Drawing.Point(258, 16);
            this.rdb_Cedula.Name = "rdb_Cedula";
            this.rdb_Cedula.Size = new System.Drawing.Size(67, 19);
            this.rdb_Cedula.TabIndex = 51;
            this.rdb_Cedula.TabStop = true;
            this.rdb_Cedula.Text = "Cédula";
            this.rdb_Cedula.UseVisualStyleBackColor = false;
            this.rdb_Cedula.CheckedChanged += new System.EventHandler(this.rdb_Cedula_CheckedChanged);
            // 
            // txt_CedulaNombre
            // 
            this.txt_CedulaNombre.Location = new System.Drawing.Point(88, 17);
            this.txt_CedulaNombre.Name = "txt_CedulaNombre";
            this.txt_CedulaNombre.Size = new System.Drawing.Size(152, 20);
            this.txt_CedulaNombre.TabIndex = 50;
            this.txt_CedulaNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CedulaNombre_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(36, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 15);
            this.label14.TabIndex = 49;
            this.label14.Text = "Dato: ";
            // 
            // dgv_Conductor
            // 
            this.dgv_Conductor.AllowUserToAddRows = false;
            this.dgv_Conductor.AllowUserToDeleteRows = false;
            this.dgv_Conductor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Conductor.Location = new System.Drawing.Point(32, 153);
            this.dgv_Conductor.Name = "dgv_Conductor";
            this.dgv_Conductor.ReadOnly = true;
            this.dgv_Conductor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Conductor.Size = new System.Drawing.Size(559, 182);
            this.dgv_Conductor.TabIndex = 48;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // Frm_Conductor_Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Conductor_Consultar";
            this.Text = "FrmConductorConsul";
            this.Load += new System.EventHandler(this.Frm_Conductor_Consultar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pncontenido.ResumeLayout(false);
            this.pncontenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Conductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_Modificar;
        private System.Windows.Forms.Panel pncontenido;
        private System.Windows.Forms.ComboBox cmb_Disponibilidad;
        private System.Windows.Forms.CheckBox chb_Disponibilidad;
        private System.Windows.Forms.RadioButton rdb_Nombre;
        private System.Windows.Forms.RadioButton rdb_Cedula;
        private System.Windows.Forms.TextBox txt_CedulaNombre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgv_Conductor;
        private FontAwesome.Sharp.IconButton btn_Consultar;
        private FontAwesome.Sharp.IconButton btn_MostrarTodos;
        private FontAwesome.Sharp.IconButton btn_Imprimir;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}