namespace Sistema_Incidencias
{
    partial class frmUpdateTecnico
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cmbDepartamentoTecnico = new System.Windows.Forms.ComboBox();
            this.lblDepTecnico = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(130, 39);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(119, 36);
            this.lblUsuario.TabIndex = 18;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(73, 87);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(237, 34);
            this.txtUsuario.TabIndex = 19;
            // 
            // cmbDepartamentoTecnico
            // 
            this.cmbDepartamentoTecnico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamentoTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbDepartamentoTecnico.FormattingEnabled = true;
            this.cmbDepartamentoTecnico.Location = new System.Drawing.Point(78, 191);
            this.cmbDepartamentoTecnico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartamentoTecnico.Name = "cmbDepartamentoTecnico";
            this.cmbDepartamentoTecnico.Size = new System.Drawing.Size(232, 25);
            this.cmbDepartamentoTecnico.TabIndex = 22;
            // 
            // lblDepTecnico
            // 
            this.lblDepTecnico.AutoSize = true;
            this.lblDepTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepTecnico.Location = new System.Drawing.Point(44, 137);
            this.lblDepTecnico.Name = "lblDepTecnico";
            this.lblDepTecnico.Size = new System.Drawing.Size(313, 36);
            this.lblDepTecnico.TabIndex = 21;
            this.lblDepTecnico.Text = "Departamento Tecnico";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(130, 249);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 46);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmUpdateTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 346);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbDepartamentoTecnico);
            this.Controls.Add(this.lblDepTecnico);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Name = "frmUpdateTecnico";
            this.Text = "frmUpdateTecnico";
            this.Load += new System.EventHandler(this.frmUpdateTecnico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ComboBox cmbDepartamentoTecnico;
        private System.Windows.Forms.Label lblDepTecnico;
        private System.Windows.Forms.Button btnGuardar;
    }
}