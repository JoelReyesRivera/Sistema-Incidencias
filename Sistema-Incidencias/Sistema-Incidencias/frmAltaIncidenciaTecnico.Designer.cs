namespace Sistema_Incidencias
{
    partial class frmAltaIncidenciaTecnico
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
            this.lblIncidencia = new System.Windows.Forms.Label();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.cmbIncidencia = new System.Windows.Forms.ComboBox();
            this.cmbTecnico = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIncidencia
            // 
            this.lblIncidencia.AutoSize = true;
            this.lblIncidencia.Location = new System.Drawing.Point(38, 39);
            this.lblIncidencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncidencia.Name = "lblIncidencia";
            this.lblIncidencia.Size = new System.Drawing.Size(150, 13);
            this.lblIncidencia.TabIndex = 0;
            this.lblIncidencia.Text = "INCIDENCIAS SIN ASIGNAR:";
            // 
            // lblTecnico
            // 
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.Location = new System.Drawing.Point(261, 40);
            this.lblTecnico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(54, 13);
            this.lblTecnico.TabIndex = 2;
            this.lblTecnico.Text = "TECNICO";
            // 
            // cmbIncidencia
            // 
            this.cmbIncidencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIncidencia.FormattingEnabled = true;
            this.cmbIncidencia.Location = new System.Drawing.Point(41, 80);
            this.cmbIncidencia.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIncidencia.Name = "cmbIncidencia";
            this.cmbIncidencia.Size = new System.Drawing.Size(92, 21);
            this.cmbIncidencia.TabIndex = 5;
            // 
            // cmbTecnico
            // 
            this.cmbTecnico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTecnico.FormattingEnabled = true;
            this.cmbTecnico.Location = new System.Drawing.Point(264, 80);
            this.cmbTecnico.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTecnico.Name = "cmbTecnico";
            this.cmbTecnico.Size = new System.Drawing.Size(92, 21);
            this.cmbTecnico.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(126, 189);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 31);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Asignar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(188, 39);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(0, 13);
            this.lblNumero.TabIndex = 10;
            // 
            // frmAltaIncidenciaTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 253);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbTecnico);
            this.Controls.Add(this.cmbIncidencia);
            this.Controls.Add(this.lblTecnico);
            this.Controls.Add(this.lblIncidencia);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAltaIncidenciaTecnico";
            this.Text = "Asignar técnico a incidencia";
            this.Load += new System.EventHandler(this.AltaIncidenciaTecnico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIncidencia;
        private System.Windows.Forms.Label lblTecnico;
        private System.Windows.Forms.ComboBox cmbIncidencia;
        private System.Windows.Forms.ComboBox cmbTecnico;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNumero;
    }
}