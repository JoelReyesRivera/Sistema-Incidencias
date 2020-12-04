namespace Sistema_Incidencias
{
    partial class AltaIncidenciaTecnico
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
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.lblFechaAsignacion = new System.Windows.Forms.Label();
            this.cmbIncidencia = new System.Windows.Forms.ComboBox();
            this.cmbAdministrador = new System.Windows.Forms.ComboBox();
            this.cmbTecnico = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dateTimeFecha = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblIncidencia
            // 
            this.lblIncidencia.AutoSize = true;
            this.lblIncidencia.Location = new System.Drawing.Point(52, 52);
            this.lblIncidencia.Name = "lblIncidencia";
            this.lblIncidencia.Size = new System.Drawing.Size(100, 17);
            this.lblIncidencia.TabIndex = 0;
            this.lblIncidencia.Text = "ID INCIDENCIA";
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Location = new System.Drawing.Point(245, 52);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(122, 17);
            this.lblAdministrador.TabIndex = 1;
            this.lblAdministrador.Text = "ADMINISTRADOR";
            // 
            // lblTecnico
            // 
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.Location = new System.Drawing.Point(52, 165);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(68, 17);
            this.lblTecnico.TabIndex = 2;
            this.lblTecnico.Text = "TECNICO";
            // 
            // lblFechaAsignacion
            // 
            this.lblFechaAsignacion.AutoSize = true;
            this.lblFechaAsignacion.Location = new System.Drawing.Point(245, 165);
            this.lblFechaAsignacion.Name = "lblFechaAsignacion";
            this.lblFechaAsignacion.Size = new System.Drawing.Size(139, 17);
            this.lblFechaAsignacion.TabIndex = 4;
            this.lblFechaAsignacion.Text = "Fecha de asignacion";
            // 
            // cmbIncidencia
            // 
            this.cmbIncidencia.FormattingEnabled = true;
            this.cmbIncidencia.Location = new System.Drawing.Point(55, 99);
            this.cmbIncidencia.Name = "cmbIncidencia";
            this.cmbIncidencia.Size = new System.Drawing.Size(121, 24);
            this.cmbIncidencia.TabIndex = 5;
            // 
            // cmbAdministrador
            // 
            this.cmbAdministrador.FormattingEnabled = true;
            this.cmbAdministrador.Location = new System.Drawing.Point(246, 108);
            this.cmbAdministrador.Name = "cmbAdministrador";
            this.cmbAdministrador.Size = new System.Drawing.Size(121, 24);
            this.cmbAdministrador.TabIndex = 6;
            // 
            // cmbTecnico
            // 
            this.cmbTecnico.FormattingEnabled = true;
            this.cmbTecnico.Location = new System.Drawing.Point(55, 203);
            this.cmbTecnico.Name = "cmbTecnico";
            this.cmbTecnico.Size = new System.Drawing.Size(121, 24);
            this.cmbTecnico.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(166, 281);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 68);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dateTimeFecha
            // 
            this.dateTimeFecha.CustomFormat = "yyyy/mm/dd";
            this.dateTimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFecha.Location = new System.Drawing.Point(219, 205);
            this.dateTimeFecha.Name = "dateTimeFecha";
            this.dateTimeFecha.Size = new System.Drawing.Size(200, 22);
            this.dateTimeFecha.TabIndex = 11;
            this.dateTimeFecha.ValueChanged += new System.EventHandler(this.dateTimeFecha_ValueChanged);
            // 
            // AltaIncidenciaTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.dateTimeFecha);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbTecnico);
            this.Controls.Add(this.cmbAdministrador);
            this.Controls.Add(this.cmbIncidencia);
            this.Controls.Add(this.lblFechaAsignacion);
            this.Controls.Add(this.lblTecnico);
            this.Controls.Add(this.lblAdministrador);
            this.Controls.Add(this.lblIncidencia);
            this.Name = "AltaIncidenciaTecnico";
            this.Text = "AltaIncidenciaTecnico";
            this.Load += new System.EventHandler(this.AltaIncidenciaTecnico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIncidencia;
        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.Label lblTecnico;
        private System.Windows.Forms.Label lblFechaAsignacion;
        private System.Windows.Forms.ComboBox cmbIncidencia;
        private System.Windows.Forms.ComboBox cmbAdministrador;
        private System.Windows.Forms.ComboBox cmbTecnico;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dateTimeFecha;
    }
}