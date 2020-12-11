namespace Sistema_Incidencias
{
    partial class frmAgregarDepartamentoTecnico
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNombreDeptoTecnico = new System.Windows.Forms.Label();
            this.txtNombreDeptoTecnico = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(68, 226);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 37);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblNombreDeptoTecnico
            // 
            this.lblNombreDeptoTecnico.AutoSize = true;
            this.lblNombreDeptoTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDeptoTecnico.Location = new System.Drawing.Point(82, 60);
            this.lblNombreDeptoTecnico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreDeptoTecnico.Name = "lblNombreDeptoTecnico";
            this.lblNombreDeptoTecnico.Size = new System.Drawing.Size(65, 20);
            this.lblNombreDeptoTecnico.TabIndex = 27;
            this.lblNombreDeptoTecnico.Text = "Nombre";
            // 
            // txtNombreDeptoTecnico
            // 
            this.txtNombreDeptoTecnico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreDeptoTecnico.Location = new System.Drawing.Point(44, 100);
            this.txtNombreDeptoTecnico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreDeptoTecnico.MaxLength = 25;
            this.txtNombreDeptoTecnico.Name = "txtNombreDeptoTecnico";
            this.txtNombreDeptoTecnico.Size = new System.Drawing.Size(149, 20);
            this.txtNombreDeptoTecnico.TabIndex = 28;
            // 
            // frmAgregarDepartamentoTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 300);
            this.Controls.Add(this.txtNombreDeptoTecnico);
            this.Controls.Add(this.lblNombreDeptoTecnico);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAgregarDepartamentoTecnico";
            this.Text = "Agregar Departamento A Técnico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNombreDeptoTecnico;
        private System.Windows.Forms.TextBox txtNombreDeptoTecnico;
    }
}