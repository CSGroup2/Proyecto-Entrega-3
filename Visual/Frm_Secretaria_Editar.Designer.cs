
namespace Visual
{
    partial class Frm_Secretaria_Editar
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.pncontenido = new System.Windows.Forms.Panel();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtp_FechaContrato = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Contrasenia1 = new System.Windows.Forms.TextBox();
            this.txt_NombreUsuario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_FechaNac = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.rdb_Femenino = new System.Windows.Forms.RadioButton();
            this.rdb_Masculino = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Apellido2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Apellido1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Cedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gboxnombres = new System.Windows.Forms.GroupBox();
            this.txt_Nombre2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nombre1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.chxcontra = new System.Windows.Forms.CheckBox();
            this.chxusuario = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.pncontenido.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gboxnombres.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BackgroundImage = global::Visual.Properties.Resources._8;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnguardar);
            this.panel2.Controls.Add(this.btncancelar);
            this.panel2.Controls.Add(this.pncontenido);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 491);
            this.panel2.TabIndex = 7;
            // 
            // btnguardar
            // 
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btnguardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.Location = new System.Drawing.Point(151, 429);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnguardar.Size = new System.Drawing.Size(183, 52);
            this.btnguardar.TabIndex = 32;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btncancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncancelar.Location = new System.Drawing.Point(350, 429);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btncancelar.Size = new System.Drawing.Size(183, 52);
            this.btncancelar.TabIndex = 31;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // pncontenido
            // 
            this.pncontenido.BackColor = System.Drawing.Color.White;
            this.pncontenido.Controls.Add(this.btnBuscar);
            this.pncontenido.Controls.Add(this.lblcodigo);
            this.pncontenido.Controls.Add(this.label15);
            this.pncontenido.Controls.Add(this.dtp_FechaContrato);
            this.pncontenido.Controls.Add(this.label13);
            this.pncontenido.Controls.Add(this.groupBox2);
            this.pncontenido.Controls.Add(this.txt_Correo);
            this.pncontenido.Controls.Add(this.label10);
            this.pncontenido.Controls.Add(this.txt_Telefono);
            this.pncontenido.Controls.Add(this.label9);
            this.pncontenido.Controls.Add(this.dtp_FechaNac);
            this.pncontenido.Controls.Add(this.label8);
            this.pncontenido.Controls.Add(this.rdb_Femenino);
            this.pncontenido.Controls.Add(this.rdb_Masculino);
            this.pncontenido.Controls.Add(this.label7);
            this.pncontenido.Controls.Add(this.groupBox1);
            this.pncontenido.Controls.Add(this.txt_Cedula);
            this.pncontenido.Controls.Add(this.label5);
            this.pncontenido.Controls.Add(this.gboxnombres);
            this.pncontenido.Location = new System.Drawing.Point(23, 13);
            this.pncontenido.Name = "pncontenido";
            this.pncontenido.Size = new System.Drawing.Size(639, 408);
            this.pncontenido.TabIndex = 14;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 20;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBuscar.Location = new System.Drawing.Point(327, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBuscar.Size = new System.Drawing.Size(44, 30);
            this.btnBuscar.TabIndex = 62;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblcodigo
            // 
            this.lblcodigo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcodigo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(138, 11);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(74, 26);
            this.lblcodigo.TabIndex = 61;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label15.Location = new System.Drawing.Point(16, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 18);
            this.label15.TabIndex = 60;
            this.label15.Text = "Código:";
            // 
            // dtp_FechaContrato
            // 
            this.dtp_FechaContrato.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechaContrato.Location = new System.Drawing.Point(157, 264);
            this.dtp_FechaContrato.Name = "dtp_FechaContrato";
            this.dtp_FechaContrato.Size = new System.Drawing.Size(256, 26);
            this.dtp_FechaContrato.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label13.Location = new System.Drawing.Point(15, 268);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 18);
            this.label13.TabIndex = 29;
            this.label13.Text = "Fech. Contrato:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chxcontra);
            this.groupBox2.Controls.Add(this.chxusuario);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_Contrasenia1);
            this.groupBox2.Controls.Add(this.txt_NombreUsuario);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(19, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 95);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuenta";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label12.Location = new System.Drawing.Point(4, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 18);
            this.label12.TabIndex = 33;
            this.label12.Text = "Contraseña:";
            // 
            // txt_Contrasenia1
            // 
            this.txt_Contrasenia1.Enabled = false;
            this.txt_Contrasenia1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contrasenia1.Location = new System.Drawing.Point(105, 55);
            this.txt_Contrasenia1.Name = "txt_Contrasenia1";
            this.txt_Contrasenia1.PasswordChar = '*';
            this.txt_Contrasenia1.Size = new System.Drawing.Size(185, 26);
            this.txt_Contrasenia1.TabIndex = 32;
            // 
            // txt_NombreUsuario
            // 
            this.txt_NombreUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txt_NombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NombreUsuario.Enabled = false;
            this.txt_NombreUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreUsuario.Location = new System.Drawing.Point(105, 19);
            this.txt_NombreUsuario.Name = "txt_NombreUsuario";
            this.txt_NombreUsuario.Size = new System.Drawing.Size(185, 26);
            this.txt_NombreUsuario.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label11.Location = new System.Drawing.Point(6, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 18);
            this.label11.TabIndex = 30;
            this.label11.Text = "Usuario:";
            // 
            // txt_Correo
            // 
            this.txt_Correo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Correo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Correo.Location = new System.Drawing.Point(84, 169);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(222, 26);
            this.txt_Correo.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label10.Location = new System.Drawing.Point(14, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Correo:";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Telefono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefono.Location = new System.Drawing.Point(419, 169);
            this.txt_Telefono.MaxLength = 10;
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(194, 26);
            this.txt_Telefono.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label9.Location = new System.Drawing.Point(335, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Num. Telf:";
            // 
            // dtp_FechaNac
            // 
            this.dtp_FechaNac.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechaNac.Location = new System.Drawing.Point(157, 232);
            this.dtp_FechaNac.Name = "dtp_FechaNac";
            this.dtp_FechaNac.Size = new System.Drawing.Size(256, 26);
            this.dtp_FechaNac.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label8.Location = new System.Drawing.Point(15, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fech. Nacimiento:";
            // 
            // rdb_Femenino
            // 
            this.rdb_Femenino.AutoSize = true;
            this.rdb_Femenino.BackColor = System.Drawing.Color.Transparent;
            this.rdb_Femenino.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Femenino.Location = new System.Drawing.Point(208, 202);
            this.rdb_Femenino.Name = "rdb_Femenino";
            this.rdb_Femenino.Size = new System.Drawing.Size(98, 24);
            this.rdb_Femenino.TabIndex = 14;
            this.rdb_Femenino.Text = "Femenino";
            this.rdb_Femenino.UseVisualStyleBackColor = false;
            // 
            // rdb_Masculino
            // 
            this.rdb_Masculino.AutoSize = true;
            this.rdb_Masculino.BackColor = System.Drawing.Color.Transparent;
            this.rdb_Masculino.Checked = true;
            this.rdb_Masculino.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Masculino.Location = new System.Drawing.Point(84, 202);
            this.rdb_Masculino.Name = "rdb_Masculino";
            this.rdb_Masculino.Size = new System.Drawing.Size(102, 24);
            this.rdb_Masculino.TabIndex = 13;
            this.rdb_Masculino.TabStop = true;
            this.rdb_Masculino.Text = "Masculino";
            this.rdb_Masculino.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(16, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sexo:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_Apellido2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Apellido1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(330, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 85);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apellidos";
            // 
            // txt_Apellido2
            // 
            this.txt_Apellido2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Apellido2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellido2.Location = new System.Drawing.Point(146, 47);
            this.txt_Apellido2.Name = "txt_Apellido2";
            this.txt_Apellido2.Size = new System.Drawing.Size(137, 26);
            this.txt_Apellido2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(2, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Segundo Apellido:";
            // 
            // txt_Apellido1
            // 
            this.txt_Apellido1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Apellido1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellido1.Location = new System.Drawing.Point(146, 17);
            this.txt_Apellido1.Name = "txt_Apellido1";
            this.txt_Apellido1.Size = new System.Drawing.Size(137, 26);
            this.txt_Apellido1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(2, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Primer Apellido:";
            // 
            // txt_Cedula
            // 
            this.txt_Cedula.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Cedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cedula.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cedula.Location = new System.Drawing.Point(138, 42);
            this.txt_Cedula.MaxLength = 10;
            this.txt_Cedula.Name = "txt_Cedula";
            this.txt_Cedula.Size = new System.Drawing.Size(169, 26);
            this.txt_Cedula.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(16, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Num. Cédula:";
            // 
            // gboxnombres
            // 
            this.gboxnombres.BackColor = System.Drawing.Color.Transparent;
            this.gboxnombres.Controls.Add(this.txt_Nombre2);
            this.gboxnombres.Controls.Add(this.label3);
            this.gboxnombres.Controls.Add(this.txt_Nombre1);
            this.gboxnombres.Controls.Add(this.label4);
            this.gboxnombres.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxnombres.Location = new System.Drawing.Point(10, 78);
            this.gboxnombres.Name = "gboxnombres";
            this.gboxnombres.Size = new System.Drawing.Size(316, 85);
            this.gboxnombres.TabIndex = 4;
            this.gboxnombres.TabStop = false;
            this.gboxnombres.Text = "Nombres";
            // 
            // txt_Nombre2
            // 
            this.txt_Nombre2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nombre2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre2.Location = new System.Drawing.Point(147, 47);
            this.txt_Nombre2.Name = "txt_Nombre2";
            this.txt_Nombre2.Size = new System.Drawing.Size(149, 26);
            this.txt_Nombre2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(4, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Segundo Nombre:";
            // 
            // txt_Nombre1
            // 
            this.txt_Nombre1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nombre1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre1.Location = new System.Drawing.Point(147, 15);
            this.txt_Nombre1.Name = "txt_Nombre1";
            this.txt_Nombre1.Size = new System.Drawing.Size(149, 26);
            this.txt_Nombre1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Primer Nombre:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 85);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 32.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.label2.Location = new System.Drawing.Point(112, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Actualizar Secretaria";
            // 
            // chxcontra
            // 
            this.chxcontra.AutoSize = true;
            this.chxcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxcontra.Location = new System.Drawing.Point(301, 62);
            this.chxcontra.Name = "chxcontra";
            this.chxcontra.Size = new System.Drawing.Size(15, 14);
            this.chxcontra.TabIndex = 64;
            this.chxcontra.UseVisualStyleBackColor = true;
            // 
            // chxusuario
            // 
            this.chxusuario.AutoSize = true;
            this.chxusuario.Location = new System.Drawing.Point(301, 26);
            this.chxusuario.Name = "chxusuario";
            this.chxusuario.Size = new System.Drawing.Size(15, 14);
            this.chxusuario.TabIndex = 63;
            this.chxusuario.UseVisualStyleBackColor = true;
            // 
            // Frm_Secretaria_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Secretaria_Editar";
            this.Text = "Frm_Secretaria_Editar";
            this.panel2.ResumeLayout(false);
            this.pncontenido.ResumeLayout(false);
            this.pncontenido.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboxnombres.ResumeLayout(false);
            this.gboxnombres.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pncontenido;
        private System.Windows.Forms.DateTimePicker dtp_FechaContrato;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Contrasenia1;
        private System.Windows.Forms.TextBox txt_NombreUsuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_FechaNac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdb_Femenino;
        private System.Windows.Forms.RadioButton rdb_Masculino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Apellido2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Apellido1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Cedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gboxnombres;
        private System.Windows.Forms.TextBox txt_Nombre2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nombre1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chxcontra;
        private System.Windows.Forms.CheckBox chxusuario;
    }
}