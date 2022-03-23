
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.btnmodificar = new FontAwesome.Sharp.IconButton();
            this.pncontenido = new System.Windows.Forms.Panel();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_HOSPITAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxhospital = new System.Windows.Forms.ComboBox();
            this.chxhospital = new System.Windows.Forms.CheckBox();
            this.btnmostrartodos = new FontAwesome.Sharp.IconButton();
            this.btnconsultar = new FontAwesome.Sharp.IconButton();
            this.cbxestado = new System.Windows.Forms.ComboBox();
            this.chxestado = new System.Windows.Forms.CheckBox();
            this.opnombres = new System.Windows.Forms.RadioButton();
            this.opcedula = new System.Windows.Forms.RadioButton();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel2.SuspendLayout();
            this.pncontenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BackgroundImage = global::Visual.Properties.Resources._9;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnImprimir);
            this.panel2.Controls.Add(this.btnmodificar);
            this.panel2.Controls.Add(this.pncontenido);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 419);
            this.panel2.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 35;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEliminar.Location = new System.Drawing.Point(20, 346);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(183, 52);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.Location = new System.Drawing.Point(434, 346);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnImprimir.Size = new System.Drawing.Size(183, 52);
            this.btnImprimir.TabIndex = 16;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            this.btnImprimir.MouseLeave += new System.EventHandler(this.btnimprimir_MouseLeave);
            this.btnImprimir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnimprimir_MouseMove);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnmodificar.FlatAppearance.BorderSize = 0;
            this.btnmodificar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnmodificar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnmodificar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnmodificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnmodificar.Location = new System.Drawing.Point(225, 346);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnmodificar.Size = new System.Drawing.Size(183, 52);
            this.btnmodificar.TabIndex = 15;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            this.btnmodificar.MouseLeave += new System.EventHandler(this.btnguardar_MouseLeave);
            this.btnmodificar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnguardar_MouseMove);
            // 
            // pncontenido
            // 
            this.pncontenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pncontenido.BackColor = System.Drawing.Color.White;
            this.pncontenido.Controls.Add(this.dgvClientes);
            this.pncontenido.Controls.Add(this.cbxhospital);
            this.pncontenido.Controls.Add(this.chxhospital);
            this.pncontenido.Controls.Add(this.btnmostrartodos);
            this.pncontenido.Controls.Add(this.btnconsultar);
            this.pncontenido.Controls.Add(this.cbxestado);
            this.pncontenido.Controls.Add(this.chxestado);
            this.pncontenido.Controls.Add(this.opnombres);
            this.pncontenido.Controls.Add(this.opcedula);
            this.pncontenido.Controls.Add(this.txtCriterio);
            this.pncontenido.Controls.Add(this.label14);
            this.pncontenido.Location = new System.Drawing.Point(20, 28);
            this.pncontenido.Name = "pncontenido";
            this.pncontenido.Size = new System.Drawing.Size(622, 299);
            this.pncontenido.TabIndex = 14;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CLIENTE,
            this.NOMBRE_ESTADO,
            this.NOMBRE_HOSPITAL,
            this.Cedula,
            this.Nombres,
            this.Apellidos,
            this.Sexo,
            this.Fecha_Nac,
            this.telefono,
            this.correo});
            this.dgvClientes.Location = new System.Drawing.Point(25, 98);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(572, 182);
            this.dgvClientes.TabIndex = 61;
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.DataPropertyName = "ID_CLIENTE";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ID_CLIENTE.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID_CLIENTE.HeaderText = "Codigo";
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            this.ID_CLIENTE.ReadOnly = true;
            // 
            // NOMBRE_ESTADO
            // 
            this.NOMBRE_ESTADO.DataPropertyName = "NOMBRE_ESTADO";
            this.NOMBRE_ESTADO.HeaderText = "Estado";
            this.NOMBRE_ESTADO.Name = "NOMBRE_ESTADO";
            this.NOMBRE_ESTADO.ReadOnly = true;
            // 
            // NOMBRE_HOSPITAL
            // 
            this.NOMBRE_HOSPITAL.DataPropertyName = "NOMBRE_HOSPITAL";
            this.NOMBRE_HOSPITAL.HeaderText = "Hospital";
            this.NOMBRE_HOSPITAL.Name = "NOMBRE_HOSPITAL";
            this.NOMBRE_HOSPITAL.ReadOnly = true;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "CEDULA";
            this.Cedula.HeaderText = "Cédula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Fecha_Nac
            // 
            this.Fecha_Nac.DataPropertyName = "Fecha_Nac";
            this.Fecha_Nac.HeaderText = "Fech. Nacimiento";
            this.Fecha_Nac.Name = "Fecha_Nac";
            this.Fecha_Nac.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            this.correo.Width = 200;
            // 
            // cbxhospital
            // 
            this.cbxhospital.Enabled = false;
            this.cbxhospital.FormattingEnabled = true;
            this.cbxhospital.Location = new System.Drawing.Point(470, 20);
            this.cbxhospital.Name = "cbxhospital";
            this.cbxhospital.Size = new System.Drawing.Size(127, 21);
            this.cbxhospital.TabIndex = 59;
            // 
            // chxhospital
            // 
            this.chxhospital.AutoSize = true;
            this.chxhospital.BackColor = System.Drawing.Color.Transparent;
            this.chxhospital.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxhospital.Location = new System.Drawing.Point(382, 21);
            this.chxhospital.Name = "chxhospital";
            this.chxhospital.Size = new System.Drawing.Size(82, 19);
            this.chxhospital.TabIndex = 58;
            this.chxhospital.Text = "Hospital";
            this.chxhospital.UseVisualStyleBackColor = false;
            this.chxhospital.CheckedChanged += new System.EventHandler(this.chxhospital_CheckedChanged);
            // 
            // btnmostrartodos
            // 
            this.btnmostrartodos.FlatAppearance.BorderSize = 0;
            this.btnmostrartodos.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrartodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnmostrartodos.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnmostrartodos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnmostrartodos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnmostrartodos.IconSize = 35;
            this.btnmostrartodos.Location = new System.Drawing.Point(426, 52);
            this.btnmostrartodos.Name = "btnmostrartodos";
            this.btnmostrartodos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnmostrartodos.Size = new System.Drawing.Size(171, 37);
            this.btnmostrartodos.TabIndex = 57;
            this.btnmostrartodos.Text = "Mostrar Todos";
            this.btnmostrartodos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnmostrartodos.UseVisualStyleBackColor = true;
            this.btnmostrartodos.Click += new System.EventHandler(this.btnmostrartodos_Click);
            this.btnmostrartodos.MouseLeave += new System.EventHandler(this.btnmostrartodos_MouseLeave);
            this.btnmostrartodos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnmostrartodos_MouseMove);
            // 
            // btnconsultar
            // 
            this.btnconsultar.FlatAppearance.BorderSize = 0;
            this.btnconsultar.Font = new System.Drawing.Font("Century Gothic", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnconsultar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnconsultar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnconsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnconsultar.IconSize = 35;
            this.btnconsultar.Location = new System.Drawing.Point(251, 52);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnconsultar.Size = new System.Drawing.Size(146, 37);
            this.btnconsultar.TabIndex = 16;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            this.btnconsultar.MouseLeave += new System.EventHandler(this.btnconsultar_MouseLeave);
            this.btnconsultar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnconsultar_MouseMove);
            // 
            // cbxestado
            // 
            this.cbxestado.Enabled = false;
            this.cbxestado.FormattingEnabled = true;
            this.cbxestado.Location = new System.Drawing.Point(99, 62);
            this.cbxestado.Name = "cbxestado";
            this.cbxestado.Size = new System.Drawing.Size(108, 21);
            this.cbxestado.TabIndex = 56;
            // 
            // chxestado
            // 
            this.chxestado.AutoSize = true;
            this.chxestado.BackColor = System.Drawing.Color.Transparent;
            this.chxestado.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxestado.Location = new System.Drawing.Point(25, 64);
            this.chxestado.Name = "chxestado";
            this.chxestado.Size = new System.Drawing.Size(68, 19);
            this.chxestado.TabIndex = 55;
            this.chxestado.Text = "Estado";
            this.chxestado.UseVisualStyleBackColor = false;
            this.chxestado.CheckedChanged += new System.EventHandler(this.chxestado_CheckedChanged);
            // 
            // opnombres
            // 
            this.opnombres.AutoSize = true;
            this.opnombres.BackColor = System.Drawing.Color.Transparent;
            this.opnombres.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opnombres.Location = new System.Drawing.Point(299, 20);
            this.opnombres.Name = "opnombres";
            this.opnombres.Size = new System.Drawing.Size(67, 19);
            this.opnombres.TabIndex = 52;
            this.opnombres.Text = "Nombre";
            this.opnombres.UseVisualStyleBackColor = false;
            // 
            // opcedula
            // 
            this.opcedula.AutoSize = true;
            this.opcedula.BackColor = System.Drawing.Color.Transparent;
            this.opcedula.Checked = true;
            this.opcedula.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcedula.Location = new System.Drawing.Point(220, 20);
            this.opcedula.Name = "opcedula";
            this.opcedula.Size = new System.Drawing.Size(67, 19);
            this.opcedula.TabIndex = 51;
            this.opcedula.TabStop = true;
            this.opcedula.Text = "Cédula";
            this.opcedula.UseVisualStyleBackColor = false;
            this.opcedula.CheckedChanged += new System.EventHandler(this.opcedula_CheckedChanged);
            // 
            // txtCriterio
            // 
            this.txtCriterio.Location = new System.Drawing.Point(74, 20);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(133, 20);
            this.txtCriterio.TabIndex = 50;
            this.txtCriterio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCriterio_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 15);
            this.label14.TabIndex = 49;
            this.label14.Text = "Dato: ";
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
            this.label2.Location = new System.Drawing.Point(141, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consulta de Clientes";
            // 
            // Frm_Cliente_Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 482);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Cliente_Consultar";
            this.Text = "FrmClienteConsul";
            this.Load += new System.EventHandler(this.FrmClienteConsul_Load);
            this.panel2.ResumeLayout(false);
            this.pncontenido.ResumeLayout(false);
            this.pncontenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private FontAwesome.Sharp.IconButton btnmodificar;
        private System.Windows.Forms.Panel pncontenido;
        private FontAwesome.Sharp.IconButton btnmostrartodos;
        private FontAwesome.Sharp.IconButton btnconsultar;
        private System.Windows.Forms.ComboBox cbxestado;
        private System.Windows.Forms.CheckBox chxestado;
        private System.Windows.Forms.RadioButton opnombres;
        private System.Windows.Forms.RadioButton opcedula;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxhospital;
        private System.Windows.Forms.CheckBox chxhospital;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_HOSPITAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Nac;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private FontAwesome.Sharp.IconButton btnEliminar;
    }
}