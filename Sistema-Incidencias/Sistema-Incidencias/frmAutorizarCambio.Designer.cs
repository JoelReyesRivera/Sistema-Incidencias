namespace Sistema_Incidencias
{
    partial class frmAutorizarCambio
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
            this.cmbCambio = new System.Windows.Forms.ComboBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblDispositivo = new System.Windows.Forms.Label();
            this.txtDispositivo = new System.Windows.Forms.TextBox();
            this.btnAutorizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCambio
            // 
            this.cmbCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCambio.FormattingEnabled = true;
            this.cmbCambio.Location = new System.Drawing.Point(57, 97);
            this.cmbCambio.Name = "cmbCambio";
            this.cmbCambio.Size = new System.Drawing.Size(221, 33);
            this.cmbCambio.TabIndex = 0;
            this.cmbCambio.SelectedIndexChanged += new System.EventHandler(this.cmbCambio_SelectedIndexChanged);
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(51, 45);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(248, 36);
            this.lblCambio.TabIndex = 1;
            this.lblCambio.Text = "Cambios Pedidos";
            // 
            // lblDispositivo
            // 
            this.lblDispositivo.AutoSize = true;
            this.lblDispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispositivo.Location = new System.Drawing.Point(89, 156);
            this.lblDispositivo.Name = "lblDispositivo";
            this.lblDispositivo.Size = new System.Drawing.Size(161, 36);
            this.lblDispositivo.TabIndex = 2;
            this.lblDispositivo.Text = "Dispositivo";
            // 
            // txtDispositivo
            // 
            this.txtDispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDispositivo.Location = new System.Drawing.Point(57, 207);
            this.txtDispositivo.Name = "txtDispositivo";
            this.txtDispositivo.ReadOnly = true;
            this.txtDispositivo.Size = new System.Drawing.Size(221, 30);
            this.txtDispositivo.TabIndex = 3;
            // 
            // btnAutorizar
            // 
            this.btnAutorizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutorizar.Location = new System.Drawing.Point(97, 270);
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.Size = new System.Drawing.Size(153, 46);
            this.btnAutorizar.TabIndex = 4;
            this.btnAutorizar.Text = "Autorizar";
            this.btnAutorizar.UseVisualStyleBackColor = true;
            this.btnAutorizar.Click += new System.EventHandler(this.btnAutorizar_Click);
            // 
            // frmAutorizarCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 347);
            this.Controls.Add(this.btnAutorizar);
            this.Controls.Add(this.txtDispositivo);
            this.Controls.Add(this.lblDispositivo);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.cmbCambio);
            this.Name = "frmAutorizarCambio";
            this.Text = "Autorizar Cambio";
            this.Load += new System.EventHandler(this.frmAutorizarCambio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCambio;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblDispositivo;
        private System.Windows.Forms.TextBox txtDispositivo;
        private System.Windows.Forms.Button btnAutorizar;
    }
}