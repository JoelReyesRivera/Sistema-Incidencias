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
            this.btnGuardar.Location = new System.Drawing.Point(60, 151);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 46);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblNombreDeptoTecnico
            // 
            this.lblNombreDeptoTecnico.AutoSize = true;
            this.lblNombreDeptoTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDeptoTecnico.Location = new System.Drawing.Point(85, 39);
            this.lblNombreDeptoTecnico.Name = "lblNombreDeptoTecnico";
            this.lblNombreDeptoTecnico.Size = new System.Drawing.Size(81, 25);
            this.lblNombreDeptoTecnico.TabIndex = 27;
            this.lblNombreDeptoTecnico.Text = "Nombre";
            // 
            // txtNombreDeptoTecnico
            // 
            this.txtNombreDeptoTecnico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreDeptoTecnico.Location = new System.Drawing.Point(33, 95);
            this.txtNombreDeptoTecnico.MaxLength = 25;
            this.txtNombreDeptoTecnico.Name = "txtNombreDeptoTecnico";
            this.txtNombreDeptoTecnico.Size = new System.Drawing.Size(197, 22);
            this.txtNombreDeptoTecnico.TabIndex = 28;
            // 
            // frmAgregarDepartamentoTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 258);
            this.Controls.Add(this.txtNombreDeptoTecnico);
            this.Controls.Add(this.lblNombreDeptoTecnico);
            this.Controls.Add(this.btnGuardar);
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