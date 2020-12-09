namespace Sistema_Incidencias
{
    partial class frmVinculaDispositivos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNoSerie = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDispositivo1 = new System.Windows.Forms.ComboBox();
            this.cmbDispositivo2 = new System.Windows.Forms.ComboBox();
            this.txtDescripcion2 = new System.Windows.Forms.TextBox();
            this.txtModelo2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(263, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(214, 16);
            this.lblTitulo.TabIndex = 35;
            this.lblTitulo.Text = "VINCULANDO DISPOSITIVOS";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(126, 323);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(82, 23);
            this.btnLimpiar.TabIndex = 34;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(607, 355);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 37);
            this.btnSalir.TabIndex = 33;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(445, 355);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(77, 37);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Location = new System.Drawing.Point(387, 151);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion.TabIndex = 29;
            // 
            // txtModelo
            // 
            this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModelo.Location = new System.Drawing.Point(590, 151);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(109, 20);
            this.txtModelo.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Modelo";
            // 
            // lblNoSerie
            // 
            this.lblNoSerie.AutoSize = true;
            this.lblNoSerie.Location = new System.Drawing.Point(60, 152);
            this.lblNoSerie.Name = "lblNoSerie";
            this.lblNoSerie.Size = new System.Drawing.Size(51, 13);
            this.lblNoSerie.TabIndex = 18;
            this.lblNoSerie.Text = "No. Serie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "No. Serie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "DISPOSITIVO PRINCIPAL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "CONTIENE DISPOSITIVO";
            // 
            // cmbDispositivo1
            // 
            this.cmbDispositivo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDispositivo1.FormattingEnabled = true;
            this.cmbDispositivo1.Location = new System.Drawing.Point(126, 150);
            this.cmbDispositivo1.Name = "cmbDispositivo1";
            this.cmbDispositivo1.Size = new System.Drawing.Size(149, 21);
            this.cmbDispositivo1.TabIndex = 44;
            this.cmbDispositivo1.SelectedIndexChanged += new System.EventHandler(this.cmbDispositivo1_SelectedIndexChanged);
            // 
            // cmbDispositivo2
            // 
            this.cmbDispositivo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDispositivo2.FormattingEnabled = true;
            this.cmbDispositivo2.Location = new System.Drawing.Point(126, 260);
            this.cmbDispositivo2.Name = "cmbDispositivo2";
            this.cmbDispositivo2.Size = new System.Drawing.Size(149, 21);
            this.cmbDispositivo2.TabIndex = 45;
            this.cmbDispositivo2.SelectedIndexChanged += new System.EventHandler(this.cmbDispositivo2_SelectedIndexChanged);
            // 
            // txtDescripcion2
            // 
            this.txtDescripcion2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion2.Location = new System.Drawing.Point(387, 261);
            this.txtDescripcion2.Name = "txtDescripcion2";
            this.txtDescripcion2.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion2.TabIndex = 49;
            // 
            // txtModelo2
            // 
            this.txtModelo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModelo2.Location = new System.Drawing.Point(590, 262);
            this.txtModelo2.Name = "txtModelo2";
            this.txtModelo2.Size = new System.Drawing.Size(109, 20);
            this.txtModelo2.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Modelo";
            // 
            // frmVinculaDispositivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 441);
            this.Controls.Add(this.txtDescripcion2);
            this.Controls.Add(this.txtModelo2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDispositivo2);
            this.Controls.Add(this.cmbDispositivo1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNoSerie);
            this.Name = "frmVinculaDispositivos";
            this.Text = "frmVinculaDispositivos";
            this.Load += new System.EventHandler(this.frmVinculaDispositivos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNoSerie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDispositivo1;
        private System.Windows.Forms.ComboBox cmbDispositivo2;
        private System.Windows.Forms.TextBox txtDescripcion2;
        private System.Windows.Forms.TextBox txtModelo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}