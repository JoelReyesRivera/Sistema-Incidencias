namespace Sistema_Incidencias
{
    partial class frmAgregarDepartamento
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
            this.txtNombreDepto = new System.Windows.Forms.TextBox();
            this.lblNombreDepto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(70, 232);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 37);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombreDepto
            // 
            this.txtNombreDepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreDepto.Location = new System.Drawing.Point(56, 105);
            this.txtNombreDepto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreDepto.MaxLength = 25;
            this.txtNombreDepto.Name = "txtNombreDepto";
            this.txtNombreDepto.Size = new System.Drawing.Size(133, 20);
            this.txtNombreDepto.TabIndex = 25;
            // 
            // lblNombreDepto
            // 
            this.lblNombreDepto.AutoSize = true;
            this.lblNombreDepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDepto.Location = new System.Drawing.Point(42, 46);
            this.lblNombreDepto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreDepto.Name = "lblNombreDepto";
            this.lblNombreDepto.Size = new System.Drawing.Size(172, 20);
            this.lblNombreDepto.TabIndex = 26;
            this.lblNombreDepto.Text = "Nombre Departamento";
            // 
            // frmAgregarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 315);
            this.Controls.Add(this.lblNombreDepto);
            this.Controls.Add(this.txtNombreDepto);
            this.Controls.Add(this.btnGuardar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAgregarDepartamento";
            this.Text = "frmAgregarDepartamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombreDepto;
        private System.Windows.Forms.Label lblNombreDepto;
    }
}