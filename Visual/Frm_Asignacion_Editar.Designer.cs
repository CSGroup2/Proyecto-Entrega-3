﻿
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
            this.lblIdPeticion = new System.Windows.Forms.Label();
            this.lbl_TipoAmbulancia = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_cantAmbulancia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAmbulancia = new FontAwesome.Sharp.IconButton();
            this.btnConductor = new FontAwesome.Sharp.IconButton();
            this.lbl_Placa = new System.Windows.Forms.Label();
            this.lbl_conductor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAsignar = new FontAwesome.Sharp.IconButton();
            this.lblAmb_Restantes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAmb_Cond = new System.Windows.Forms.DataGridView();
            this.Peticion_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conductor_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ambulancia_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.lbl_id_ambulancia = new System.Windows.Forms.Label();
            this.lbl_id_conductor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmb_Cond)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdPeticion
            // 
            this.lblIdPeticion.BackColor = System.Drawing.Color.Transparent;
            this.lblIdPeticion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIdPeticion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIdPeticion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPeticion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblIdPeticion.Location = new System.Drawing.Point(212, 19);
            this.lblIdPeticion.Name = "lblIdPeticion";
            this.lblIdPeticion.Size = new System.Drawing.Size(194, 26);
            this.lblIdPeticion.TabIndex = 20;
            this.lblIdPeticion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TipoAmbulancia
            // 
            this.lbl_TipoAmbulancia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TipoAmbulancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TipoAmbulancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_TipoAmbulancia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoAmbulancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_TipoAmbulancia.Location = new System.Drawing.Point(212, 85);
            this.lbl_TipoAmbulancia.Name = "lbl_TipoAmbulancia";
            this.lbl_TipoAmbulancia.Size = new System.Drawing.Size(194, 26);
            this.lbl_TipoAmbulancia.TabIndex = 21;
            this.lbl_TipoAmbulancia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblCliente.Location = new System.Drawing.Point(212, 52);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(194, 26);
            this.lblCliente.TabIndex = 22;
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(36, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tipo de Ambulancia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(66, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Petición Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(132, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cliente:";
            // 
            // lbl_cantAmbulancia
            // 
            this.lbl_cantAmbulancia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cantAmbulancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_cantAmbulancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_cantAmbulancia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantAmbulancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_cantAmbulancia.Location = new System.Drawing.Point(212, 117);
            this.lbl_cantAmbulancia.Name = "lbl_cantAmbulancia";
            this.lbl_cantAmbulancia.Size = new System.Drawing.Size(56, 26);
            this.lbl_cantAmbulancia.TabIndex = 24;
            this.lbl_cantAmbulancia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(45, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Cant. Ambulancias:";
            // 
            // btnAmbulancia
            // 
            this.btnAmbulancia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAmbulancia.FlatAppearance.BorderSize = 0;
            this.btnAmbulancia.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmbulancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnAmbulancia.IconChar = FontAwesome.Sharp.IconChar.Ambulance;
            this.btnAmbulancia.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnAmbulancia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAmbulancia.IconSize = 28;
            this.btnAmbulancia.Location = new System.Drawing.Point(412, 177);
            this.btnAmbulancia.Name = "btnAmbulancia";
            this.btnAmbulancia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAmbulancia.Size = new System.Drawing.Size(189, 33);
            this.btnAmbulancia.TabIndex = 29;
            this.btnAmbulancia.Text = "Ambulancia";
            this.btnAmbulancia.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAmbulancia.UseVisualStyleBackColor = true;
            // 
            // btnConductor
            // 
            this.btnConductor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnConductor.FlatAppearance.BorderSize = 0;
            this.btnConductor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConductor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnConductor.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnConductor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnConductor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConductor.IconSize = 30;
            this.btnConductor.Location = new System.Drawing.Point(412, 144);
            this.btnConductor.Name = "btnConductor";
            this.btnConductor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConductor.Size = new System.Drawing.Size(189, 32);
            this.btnConductor.TabIndex = 30;
            this.btnConductor.Text = "Conductor";
            this.btnConductor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConductor.UseVisualStyleBackColor = true;
            // 
            // lbl_Placa
            // 
            this.lbl_Placa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Placa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Placa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Placa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Placa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_Placa.Location = new System.Drawing.Point(212, 182);
            this.lbl_Placa.Name = "lbl_Placa";
            this.lbl_Placa.Size = new System.Drawing.Size(194, 26);
            this.lbl_Placa.TabIndex = 27;
            this.lbl_Placa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_conductor
            // 
            this.lbl_conductor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_conductor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_conductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_conductor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_conductor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_conductor.Location = new System.Drawing.Point(212, 149);
            this.lbl_conductor.Name = "lbl_conductor";
            this.lbl_conductor.Size = new System.Drawing.Size(194, 26);
            this.lbl_conductor.TabIndex = 28;
            this.lbl_conductor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(94, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ambulancia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(106, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Conductor:";
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
            this.btnAsignar.Location = new System.Drawing.Point(431, 228);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAsignar.Size = new System.Drawing.Size(170, 41);
            this.btnAsignar.TabIndex = 33;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAsignar.UseVisualStyleBackColor = true;
            // 
            // lblAmb_Restantes
            // 
            this.lblAmb_Restantes.BackColor = System.Drawing.Color.Transparent;
            this.lblAmb_Restantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmb_Restantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAmb_Restantes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmb_Restantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblAmb_Restantes.Location = new System.Drawing.Point(256, 231);
            this.lblAmb_Restantes.Name = "lblAmb_Restantes";
            this.lblAmb_Restantes.Size = new System.Drawing.Size(56, 26);
            this.lblAmb_Restantes.TabIndex = 32;
            this.lblAmb_Restantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(16, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 51);
            this.label2.TabIndex = 31;
            this.label2.Text = "Ambulancias Restantes para completar la asignación:";
            // 
            // dgvAmb_Cond
            // 
            this.dgvAmb_Cond.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAmb_Cond.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAmb_Cond.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmb_Cond.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Peticion_Codigo,
            this.Conductor_Codigo,
            this.Ambulancia_Codigo});
            this.dgvAmb_Cond.Enabled = false;
            this.dgvAmb_Cond.Location = new System.Drawing.Point(12, 275);
            this.dgvAmb_Cond.Name = "dgvAmb_Cond";
            this.dgvAmb_Cond.Size = new System.Drawing.Size(644, 186);
            this.dgvAmb_Cond.TabIndex = 36;
            // 
            // Peticion_Codigo
            // 
            this.Peticion_Codigo.HeaderText = "Petición Código";
            this.Peticion_Codigo.Name = "Peticion_Codigo";
            this.Peticion_Codigo.ReadOnly = true;
            // 
            // Conductor_Codigo
            // 
            this.Conductor_Codigo.HeaderText = "Conductor Código";
            this.Conductor_Codigo.Name = "Conductor_Codigo";
            this.Conductor_Codigo.ReadOnly = true;
            // 
            // Ambulancia_Codigo
            // 
            this.Ambulancia_Codigo.HeaderText = "Ambulancia Código";
            this.Ambulancia_Codigo.Name = "Ambulancia_Codigo";
            this.Ambulancia_Codigo.ReadOnly = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 40;
            this.btnCancelar.Location = new System.Drawing.Point(109, 467);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCancelar.Size = new System.Drawing.Size(170, 41);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 40;
            this.btnGuardar.Location = new System.Drawing.Point(374, 467);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGuardar.Size = new System.Drawing.Size(170, 41);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lbl_id_ambulancia
            // 
            this.lbl_id_ambulancia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id_ambulancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_id_ambulancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_id_ambulancia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_ambulancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_id_ambulancia.Location = new System.Drawing.Point(349, 117);
            this.lbl_id_ambulancia.Name = "lbl_id_ambulancia";
            this.lbl_id_ambulancia.Size = new System.Drawing.Size(56, 26);
            this.lbl_id_ambulancia.TabIndex = 37;
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
            this.lbl_id_conductor.Location = new System.Drawing.Point(287, 117);
            this.lbl_id_conductor.Name = "lbl_id_conductor";
            this.lbl_id_conductor.Size = new System.Drawing.Size(56, 26);
            this.lbl_id_conductor.TabIndex = 38;
            this.lbl_id_conductor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_id_conductor.Visible = false;
            // 
            // Frm_Asignacion_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Visual.Properties.Resources._9;
            this.ClientSize = new System.Drawing.Size(669, 521);
            this.Controls.Add(this.lbl_id_ambulancia);
            this.Controls.Add(this.lbl_id_conductor);
            this.Controls.Add(this.dgvAmb_Cond);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.lblAmb_Restantes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAmbulancia);
            this.Controls.Add(this.btnConductor);
            this.Controls.Add(this.lbl_Placa);
            this.Controls.Add(this.lbl_conductor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_cantAmbulancia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblIdPeticion);
            this.Controls.Add(this.lbl_TipoAmbulancia);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Name = "Frm_Asignacion_Editar";
            this.Text = "Frm_Asignacion_Editar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmb_Cond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblIdPeticion;
        internal System.Windows.Forms.Label lbl_TipoAmbulancia;
        internal System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label lbl_cantAmbulancia;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnAmbulancia;
        private FontAwesome.Sharp.IconButton btnConductor;
        internal System.Windows.Forms.Label lbl_Placa;
        internal System.Windows.Forms.Label lbl_conductor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnAsignar;
        internal System.Windows.Forms.Label lblAmb_Restantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAmb_Cond;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peticion_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conductor_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ambulancia_Codigo;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        internal System.Windows.Forms.Label lbl_id_ambulancia;
        internal System.Windows.Forms.Label lbl_id_conductor;
    }
}