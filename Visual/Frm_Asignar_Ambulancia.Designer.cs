
namespace Visual
{
    partial class Frm_Asignar_Ambulancia
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
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnElegir = new FontAwesome.Sharp.IconButton();
            this.dgvAmbulancia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmbulancia)).BeginInit();
            this.SuspendLayout();
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
            this.btnCancelar.Location = new System.Drawing.Point(164, 251);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCancelar.Size = new System.Drawing.Size(170, 41);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnElegir
            // 
            this.btnElegir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnElegir.FlatAppearance.BorderSize = 0;
            this.btnElegir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnElegir.IconChar = FontAwesome.Sharp.IconChar.Ambulance;
            this.btnElegir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnElegir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnElegir.IconSize = 40;
            this.btnElegir.Location = new System.Drawing.Point(458, 251);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnElegir.Size = new System.Drawing.Size(141, 41);
            this.btnElegir.TabIndex = 21;
            this.btnElegir.Text = "Elegir";
            this.btnElegir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnElegir.UseVisualStyleBackColor = true;
            this.btnElegir.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // dgvAmbulancia
            // 
            this.dgvAmbulancia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAmbulancia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmbulancia.Location = new System.Drawing.Point(34, 25);
            this.dgvAmbulancia.Name = "dgvAmbulancia";
            this.dgvAmbulancia.ReadOnly = true;
            this.dgvAmbulancia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAmbulancia.Size = new System.Drawing.Size(732, 201);
            this.dgvAmbulancia.TabIndex = 20;
            this.dgvAmbulancia.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAmbulancia_CellMouseClick);
            // 
            // Frm_Asignar_Ambulancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Visual.Properties.Resources._8;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 316);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnElegir);
            this.Controls.Add(this.dgvAmbulancia);
            this.DoubleBuffered = true;
            this.Name = "Frm_Asignar_Ambulancia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Elegir_Ambulancia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmbulancia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnElegir;
        private System.Windows.Forms.DataGridView dgvAmbulancia;
    }
}