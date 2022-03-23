
namespace Visual
{
    partial class Frm_Asignacion_Editar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAmb_Cond = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnAsignar = new FontAwesome.Sharp.IconButton();
            this.lbl_id_ambulancia = new System.Windows.Forms.Label();
            this.lbl_id_conductor = new System.Windows.Forms.Label();
            this.lbl_cantAmbulancia = new System.Windows.Forms.Label();
            this.lbl_TipoAmbulancia = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.cmbConductores = new System.Windows.Forms.ComboBox();
            this.cmbAmbulancias = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmb_Cond)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAmb_Cond
            // 
            this.dgvAmb_Cond.AllowUserToAddRows = false;
            this.dgvAmb_Cond.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAmb_Cond.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAmb_Cond.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmb_Cond.Location = new System.Drawing.Point(24, 248);
            this.dgvAmb_Cond.Name = "dgvAmb_Cond";
            this.dgvAmb_Cond.ReadOnly = true;
            this.dgvAmb_Cond.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAmb_Cond.Size = new System.Drawing.Size(644, 225);
            this.dgvAmb_Cond.TabIndex = 42;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 40;
            this.btnCancelar.Location = new System.Drawing.Point(24, 501);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCancelar.Size = new System.Drawing.Size(170, 41);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 40;
            this.btnGuardar.Location = new System.Drawing.Point(498, 501);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGuardar.Size = new System.Drawing.Size(170, 41);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAsignar.FlatAppearance.BorderSize = 0;
            this.btnAsignar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnAsignar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAsignar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnAsignar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAsignar.IconSize = 40;
            this.btnAsignar.Location = new System.Drawing.Point(498, 166);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAsignar.Size = new System.Drawing.Size(170, 41);
            this.btnAsignar.TabIndex = 39;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // lbl_id_ambulancia
            // 
            this.lbl_id_ambulancia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id_ambulancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_id_ambulancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_id_ambulancia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_ambulancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_id_ambulancia.Location = new System.Drawing.Point(328, 90);
            this.lbl_id_ambulancia.Name = "lbl_id_ambulancia";
            this.lbl_id_ambulancia.Size = new System.Drawing.Size(56, 26);
            this.lbl_id_ambulancia.TabIndex = 32;
            this.lbl_id_ambulancia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_id_ambulancia.Visible = false;
            // 
            // lbl_id_conductor
            // 
            this.lbl_id_conductor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id_conductor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_id_conductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_id_conductor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_conductor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_id_conductor.Location = new System.Drawing.Point(266, 90);
            this.lbl_id_conductor.Name = "lbl_id_conductor";
            this.lbl_id_conductor.Size = new System.Drawing.Size(56, 26);
            this.lbl_id_conductor.TabIndex = 30;
            this.lbl_id_conductor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_id_conductor.Visible = false;
            // 
            // lbl_cantAmbulancia
            // 
            this.lbl_cantAmbulancia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cantAmbulancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_cantAmbulancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_cantAmbulancia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantAmbulancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_cantAmbulancia.Location = new System.Drawing.Point(193, 90);
            this.lbl_cantAmbulancia.Name = "lbl_cantAmbulancia";
            this.lbl_cantAmbulancia.Size = new System.Drawing.Size(56, 26);
            this.lbl_cantAmbulancia.TabIndex = 29;
            this.lbl_cantAmbulancia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TipoAmbulancia
            // 
            this.lbl_TipoAmbulancia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TipoAmbulancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TipoAmbulancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_TipoAmbulancia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoAmbulancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_TipoAmbulancia.Location = new System.Drawing.Point(193, 57);
            this.lbl_TipoAmbulancia.Name = "lbl_TipoAmbulancia";
            this.lbl_TipoAmbulancia.Size = new System.Drawing.Size(194, 26);
            this.lbl_TipoAmbulancia.TabIndex = 28;
            this.lbl_TipoAmbulancia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblCliente.Location = new System.Drawing.Point(193, 24);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(194, 26);
            this.lblCliente.TabIndex = 27;
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(118, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ambulancia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(26, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Cant. Ambulancias:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(17, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tipo de Ambulancia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(113, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(130, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Conductor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(407, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 43;
            this.label7.Text = "Origen:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label8.Location = new System.Drawing.Point(404, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 44;
            this.label8.Text = "Destino:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrigen.BackColor = System.Drawing.Color.Transparent;
            this.lblOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOrigen.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblOrigen.Location = new System.Drawing.Point(479, 24);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(194, 26);
            this.lblOrigen.TabIndex = 45;
            this.lblOrigen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDestino
            // 
            this.lblDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDestino.BackColor = System.Drawing.Color.Transparent;
            this.lblDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDestino.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblDestino.Location = new System.Drawing.Point(479, 57);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(194, 26);
            this.lblDestino.TabIndex = 46;
            this.lblDestino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbConductores
            // 
            this.cmbConductores.BackColor = System.Drawing.SystemColors.Window;
            this.cmbConductores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConductores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConductores.FormattingEnabled = true;
            this.cmbConductores.Location = new System.Drawing.Point(244, 162);
            this.cmbConductores.Name = "cmbConductores";
            this.cmbConductores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbConductores.Size = new System.Drawing.Size(177, 27);
            this.cmbConductores.TabIndex = 47;
            // 
            // cmbAmbulancias
            // 
            this.cmbAmbulancias.BackColor = System.Drawing.SystemColors.Window;
            this.cmbAmbulancias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAmbulancias.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAmbulancias.FormattingEnabled = true;
            this.cmbAmbulancias.Location = new System.Drawing.Point(244, 199);
            this.cmbAmbulancias.Name = "cmbAmbulancias";
            this.cmbAmbulancias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbAmbulancias.Size = new System.Drawing.Size(177, 27);
            this.cmbAmbulancias.TabIndex = 48;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 40;
            this.btnLimpiar.Location = new System.Drawing.Point(256, 501);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLimpiar.Size = new System.Drawing.Size(189, 41);
            this.btnLimpiar.TabIndex = 49;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Frm_Aignacion_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Visual.Properties.Resources._9;
            this.ClientSize = new System.Drawing.Size(690, 554);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbAmbulancias);
            this.Controls.Add(this.cmbConductores);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvAmb_Cond);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.lbl_id_ambulancia);
            this.Controls.Add(this.lbl_id_conductor);
            this.Controls.Add(this.lbl_cantAmbulancia);
            this.Controls.Add(this.lbl_TipoAmbulancia);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Name = "Frm_Aignacion_Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Aignacion_Editar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmb_Cond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAmb_Cond;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnAsignar;
        internal System.Windows.Forms.Label lbl_id_ambulancia;
        internal System.Windows.Forms.Label lbl_id_conductor;
        internal System.Windows.Forms.Label lbl_cantAmbulancia;
        internal System.Windows.Forms.Label lbl_TipoAmbulancia;
        internal System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label lblOrigen;
        internal System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.ComboBox cmbConductores;
        private System.Windows.Forms.ComboBox cmbAmbulancias;
        private FontAwesome.Sharp.IconButton btnLimpiar;
    }
}