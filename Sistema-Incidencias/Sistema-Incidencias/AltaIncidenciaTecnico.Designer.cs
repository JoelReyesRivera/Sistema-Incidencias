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
            this.lblIncidencia.Location = new System.Drawing.Point(11, 42);
            this.lblIncidencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncidencia.Name = "lblIncidencia";
            this.lblIncidencia.Size = new System.Drawing.Size(150, 13);
            this.lblIncidencia.TabIndex = 0;
            this.lblIncidencia.Text = "INCIDENCIAS PENDIENTES:";
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Location = new System.Drawing.Point(184, 42);
            this.lblAdministrador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(98, 13);
            this.lblAdministrador.TabIndex = 1;
            this.lblAdministrador.Text = "ADMINISTRADOR";
            // 
            // lblTecnico
            // 
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.Location = new System.Drawing.Point(39, 134);
            this.lblTecnico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(54, 13);
            this.lblTecnico.TabIndex = 2;
            this.lblTecnico.Text = "TECNICO";
            // 
            // lblFechaAsignacion
            // 
            this.lblFechaAsignacion.AutoSize = true;
            this.lblFechaAsignacion.Location = new System.Drawing.Point(184, 134);
            this.lblFechaAsignacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaAsignacion.Name = "lblFechaAsignacion";
            this.lblFechaAsignacion.Size = new System.Drawing.Size(106, 13);
            this.lblFechaAsignacion.TabIndex = 4;
            this.lblFechaAsignacion.Text = "Fecha de asignacion";
            // 
            // cmbIncidencia
            // 
            this.cmbIncidencia.FormattingEnabled = true;
            this.cmbIncidencia.Location = new System.Drawing.Point(41, 80);
            this.cmbIncidencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbIncidencia.Name = "cmbIncidencia";
            this.cmbIncidencia.Size = new System.Drawing.Size(92, 21);
            this.cmbIncidencia.TabIndex = 5;
            // 
            // cmbAdministrador
            // 
            this.cmbAdministrador.FormattingEnabled = true;
            this.cmbAdministrador.Location = new System.Drawing.Point(184, 88);
            this.cmbAdministrador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbAdministrador.Name = "cmbAdministrador";
            this.cmbAdministrador.Size = new System.Drawing.Size(92, 21);
            this.cmbAdministrador.TabIndex = 6;
            // 
            // cmbTecnico
            // 
            this.cmbTecnico.FormattingEnabled = true;
            this.cmbTecnico.Location = new System.Drawing.Point(41, 165);
            this.cmbTecnico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTecnico.Name = "cmbTecnico";
            this.cmbTecnico.Size = new System.Drawing.Size(92, 21);
            this.cmbTecnico.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(124, 228);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(82, 55);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dateTimeFecha
            // 
            this.dateTimeFecha.CustomFormat = "yyyy/mm/dd";
            this.dateTimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFecha.Location = new System.Drawing.Point(164, 167);
            this.dateTimeFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeFecha.Name = "dateTimeFecha";
            this.dateTimeFecha.Size = new System.Drawing.Size(151, 20);
            this.dateTimeFecha.TabIndex = 11;
            this.dateTimeFecha.ValueChanged += new System.EventHandler(this.dateTimeFecha_ValueChanged);
            // 
            // AltaIncidenciaTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 366);
            this.Controls.Add(this.dateTimeFecha);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbTecnico);
            this.Controls.Add(this.cmbAdministrador);
            this.Controls.Add(this.cmbIncidencia);
            this.Controls.Add(this.lblFechaAsignacion);
            this.Controls.Add(this.lblTecnico);
            this.Controls.Add(this.lblAdministrador);
            this.Controls.Add(this.lblIncidencia);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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