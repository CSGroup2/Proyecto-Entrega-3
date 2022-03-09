
namespace Visual {
    partial class Frm_Cliente_Registrar {
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pncontenido = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_confirmarcontra = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxhospitales = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_numtelf = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_fechanac = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.opr_femenino = new System.Windows.Forms.RadioButton();
            this.opr_masculino = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_apellido2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_apellido1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gboxnombres = new System.Windows.Forms.GroupBox();
            this.txt_nombre2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errpvdatoscliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.pncontenido.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gboxnombres.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errpvdatoscliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 32.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.label2.Location = new System.Drawing.Point(152, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registro de Clientes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 85);
            this.panel1.TabIndex = 2;
            // 
            // pncontenido
            // 
            this.pncontenido.BackColor = System.Drawing.Color.White;
            this.pncontenido.Controls.Add(this.groupBox2);
            this.pncontenido.Controls.Add(this.cbxhospitales);
            this.pncontenido.Controls.Add(this.label13);
            this.pncontenido.Controls.Add(this.txt_correo);
            this.pncontenido.Controls.Add(this.label10);
            this.pncontenido.Controls.Add(this.txt_numtelf);
            this.pncontenido.Controls.Add(this.label9);
            this.pncontenido.Controls.Add(this.dtp_fechanac);
            this.pncontenido.Controls.Add(this.label8);
            this.pncontenido.Controls.Add(this.opr_femenino);
            this.pncontenido.Controls.Add(this.opr_masculino);
            this.pncontenido.Controls.Add(this.label7);
            this.pncontenido.Controls.Add(this.groupBox1);
            this.pncontenido.Controls.Add(this.txt_cedula);
            this.pncontenido.Controls.Add(this.label5);
            this.pncontenido.Controls.Add(this.gboxnombres);
            this.pncontenido.Location = new System.Drawing.Point(24, 28);
            this.pncontenido.Name = "pncontenido";
            this.pncontenido.Size = new System.Drawing.Size(639, 368);
            this.pncontenido.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_confirmarcontra);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_contra);
            this.groupBox2.Controls.Add(this.txt_usuario);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(10, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(622, 95);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuenta";
            // 
            // txt_confirmarcontra
            // 
            this.txt_confirmarcontra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmarcontra.Location = new System.Drawing.Point(403, 55);
            this.txt_confirmarcontra.Name = "txt_confirmarcontra";
            this.txt_confirmarcontra.PasswordChar = '*';
            this.txt_confirmarcontra.Size = new System.Drawing.Size(191, 26);
            this.txt_confirmarcontra.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label14.Location = new System.Drawing.Point(308, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 18);
            this.label14.TabIndex = 35;
            this.label14.Text = "Contraseña:";
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
            // txt_contra
            // 
            this.txt_contra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contra.Location = new System.Drawing.Point(105, 55);
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.PasswordChar = '*';
            this.txt_contra.Size = new System.Drawing.Size(185, 26);
            this.txt_contra.TabIndex = 32;
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.SystemColors.Window;
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_usuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(105, 19);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(185, 26);
            this.txt_usuario.TabIndex = 29;
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
            // cbxhospitales
            // 
            this.cbxhospitales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxhospitales.FormattingEnabled = true;
            this.cbxhospitales.Location = new System.Drawing.Point(419, 13);
            this.cbxhospitales.Name = "cbxhospitales";
            this.cbxhospitales.Size = new System.Drawing.Size(194, 28);
            this.cbxhospitales.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label13.Location = new System.Drawing.Point(332, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 18);
            this.label13.TabIndex = 26;
            this.label13.Text = "Hospital:";
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_correo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.Location = new System.Drawing.Point(84, 145);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(222, 26);
            this.txt_correo.TabIndex = 19;
            this.txt_correo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_formatocorreo_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label10.Location = new System.Drawing.Point(14, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Correo:";
            // 
            // txt_numtelf
            // 
            this.txt_numtelf.BackColor = System.Drawing.SystemColors.Window;
            this.txt_numtelf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_numtelf.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numtelf.Location = new System.Drawing.Point(419, 145);
            this.txt_numtelf.MaxLength = 10;
            this.txt_numtelf.Name = "txt_numtelf";
            this.txt_numtelf.Size = new System.Drawing.Size(194, 26);
            this.txt_numtelf.TabIndex = 17;
            this.txt_numtelf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soloNumeros_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label9.Location = new System.Drawing.Point(335, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Num. Telf:";
            // 
            // dtp_fechanac
            // 
            this.dtp_fechanac.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechanac.Location = new System.Drawing.Point(157, 210);
            this.dtp_fechanac.Name = "dtp_fechanac";
            this.dtp_fechanac.Size = new System.Drawing.Size(256, 26);
            this.dtp_fechanac.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label8.Location = new System.Drawing.Point(15, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fech. Nacimiento:";
            // 
            // opr_femenino
            // 
            this.opr_femenino.AutoSize = true;
            this.opr_femenino.BackColor = System.Drawing.Color.Transparent;
            this.opr_femenino.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opr_femenino.Location = new System.Drawing.Point(208, 178);
            this.opr_femenino.Name = "opr_femenino";
            this.opr_femenino.Size = new System.Drawing.Size(98, 24);
            this.opr_femenino.TabIndex = 14;
            this.opr_femenino.Text = "Femenino";
            this.opr_femenino.UseVisualStyleBackColor = false;
            // 
            // opr_masculino
            // 
            this.opr_masculino.AutoSize = true;
            this.opr_masculino.BackColor = System.Drawing.Color.Transparent;
            this.opr_masculino.Checked = true;
            this.opr_masculino.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opr_masculino.Location = new System.Drawing.Point(84, 178);
            this.opr_masculino.Name = "opr_masculino";
            this.opr_masculino.Size = new System.Drawing.Size(102, 24);
            this.opr_masculino.TabIndex = 13;
            this.opr_masculino.TabStop = true;
            this.opr_masculino.Text = "Masculino";
            this.opr_masculino.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(16, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sexo:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_apellido2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_apellido1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(330, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 85);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apellidos";
            // 
            // txt_apellido2
            // 
            this.txt_apellido2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_apellido2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido2.Location = new System.Drawing.Point(146, 47);
            this.txt_apellido2.Name = "txt_apellido2";
            this.txt_apellido2.Size = new System.Drawing.Size(137, 26);
            this.txt_apellido2.TabIndex = 4;
            this.txt_apellido2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sololetras_KeyPress);
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
            // txt_apellido1
            // 
            this.txt_apellido1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_apellido1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido1.Location = new System.Drawing.Point(146, 17);
            this.txt_apellido1.Name = "txt_apellido1";
            this.txt_apellido1.Size = new System.Drawing.Size(137, 26);
            this.txt_apellido1.TabIndex = 0;
            this.txt_apellido1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sololetras_KeyPress);
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
            // txt_cedula
            // 
            this.txt_cedula.BackColor = System.Drawing.SystemColors.Window;
            this.txt_cedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cedula.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cedula.Location = new System.Drawing.Point(138, 15);
            this.txt_cedula.MaxLength = 10;
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(169, 26);
            this.txt_cedula.TabIndex = 6;
            this.txt_cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soloNumeros_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(16, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Num. Cédula:";
            // 
            // gboxnombres
            // 
            this.gboxnombres.BackColor = System.Drawing.Color.Transparent;
            this.gboxnombres.Controls.Add(this.txt_nombre2);
            this.gboxnombres.Controls.Add(this.label3);
            this.gboxnombres.Controls.Add(this.txt_nombre1);
            this.gboxnombres.Controls.Add(this.label4);
            this.gboxnombres.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxnombres.Location = new System.Drawing.Point(10, 51);
            this.gboxnombres.Name = "gboxnombres";
            this.gboxnombres.Size = new System.Drawing.Size(316, 85);
            this.gboxnombres.TabIndex = 4;
            this.gboxnombres.TabStop = false;
            this.gboxnombres.Text = "Nombres";
            // 
            // txt_nombre2
            // 
            this.txt_nombre2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre2.Location = new System.Drawing.Point(147, 47);
            this.txt_nombre2.Name = "txt_nombre2";
            this.txt_nombre2.Size = new System.Drawing.Size(149, 26);
            this.txt_nombre2.TabIndex = 4;
            this.txt_nombre2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sololetras_KeyPress);
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
            // txt_nombre1
            // 
            this.txt_nombre1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nombre1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre1.Location = new System.Drawing.Point(147, 15);
            this.txt_nombre1.Name = "txt_nombre1";
            this.txt_nombre1.Size = new System.Drawing.Size(149, 26);
            this.txt_nombre1.TabIndex = 0;
            this.txt_nombre1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sololetras_KeyPress);
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
            // btnlimpiar
            // 
            this.btnlimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlimpiar.FlatAppearance.BorderSize = 0;
            this.btnlimpiar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnlimpiar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiar.Location = new System.Drawing.Point(479, 416);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnlimpiar.Size = new System.Drawing.Size(183, 52);
            this.btnlimpiar.TabIndex = 11;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.MouseLeave += new System.EventHandler(this.btnlimpiar_MouseLeave);
            this.btnlimpiar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnlimpiar_MouseMove);
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btncancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncancelar.Location = new System.Drawing.Point(232, 416);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btncancelar.Size = new System.Drawing.Size(214, 52);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.MouseLeave += new System.EventHandler(this.btncancelar_MouseLeave);
            this.btncancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btncancelar_MouseMove);
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
            this.btnguardar.Location = new System.Drawing.Point(24, 416);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnguardar.Size = new System.Drawing.Size(183, 52);
            this.btnguardar.TabIndex = 15;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            this.btnguardar.MouseLeave += new System.EventHandler(this.btnguardar_MouseLeave);
            this.btnguardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnguardar_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BackgroundImage = global::Visual.Properties.Resources._8;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnguardar);
            this.panel2.Controls.Add(this.btncancelar);
            this.panel2.Controls.Add(this.btnlimpiar);
            this.panel2.Controls.Add(this.pncontenido);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 491);
            this.panel2.TabIndex = 3;
            // 
            // errpvdatoscliente
            // 
            this.errpvdatoscliente.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errpvdatoscliente.ContainerControl = this;
            // 
            // Frm_Cliente_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 576);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Cliente_Registrar";
            this.Text = "FrmClienteReg";
            this.Load += new System.EventHandler(this.FrmClienteReg_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pncontenido.ResumeLayout(false);
            this.pncontenido.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboxnombres.ResumeLayout(false);
            this.gboxnombres.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errpvdatoscliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pncontenido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_confirmarcontra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_contra;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxhospitales;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_numtelf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_fechanac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton opr_femenino;
        private System.Windows.Forms.RadioButton opr_masculino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_apellido2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_apellido1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gboxnombres;
        private System.Windows.Forms.TextBox txt_nombre2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre1;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider errpvdatoscliente;
    }
}