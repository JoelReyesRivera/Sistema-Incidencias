namespace Sistema_Incidencias
{
    partial class frmConsultaDispositivosAlmacen
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
            this.dgvDispositivos = new System.Windows.Forms.DataGridView();
            this.NumeroDeSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiracionGarantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngresoAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispositivos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDispositivos
            // 
            this.dgvDispositivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDispositivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroDeSerie,
            this.Nombre,
            this.ExpiracionGarantia,
            this.Modelo,
            this.Descripcion,
            this.Marca,
            this.Aula,
            this.IngresoAlmacen});
            this.dgvDispositivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDispositivos.Location = new System.Drawing.Point(0, 0);
            this.dgvDispositivos.Name = "dgvDispositivos";
            this.dgvDispositivos.ReadOnly = true;
            this.dgvDispositivos.RowHeadersWidth = 51;
            this.dgvDispositivos.RowTemplate.Height = 24;
            this.dgvDispositivos.Size = new System.Drawing.Size(1761, 450);
            this.dgvDispositivos.TabIndex = 0;
            // 
            // NumeroDeSerie
            // 
            this.NumeroDeSerie.HeaderText = "Número de Serie";
            this.NumeroDeSerie.MinimumWidth = 6;
            this.NumeroDeSerie.Name = "NumeroDeSerie";
            this.NumeroDeSerie.Width = 175;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // ExpiracionGarantia
            // 
            this.ExpiracionGarantia.HeaderText = "FechaExpiraciónGarantía";
            this.ExpiracionGarantia.MinimumWidth = 6;
            this.ExpiracionGarantia.Name = "ExpiracionGarantia";
            this.ExpiracionGarantia.Width = 200;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 6;
            this.Modelo.Name = "Modelo";
            this.Modelo.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.Width = 125;
            // 
            // Aula
            // 
            this.Aula.HeaderText = "Aula";
            this.Aula.MinimumWidth = 6;
            this.Aula.Name = "Aula";
            this.Aula.Width = 125;
            // 
            // IngresoAlmacen
            // 
            this.IngresoAlmacen.HeaderText = "IngresoAlmacén";
            this.IngresoAlmacen.MinimumWidth = 6;
            this.IngresoAlmacen.Name = "IngresoAlmacen";
            this.IngresoAlmacen.Width = 125;
            // 
            // frmConsultaDispositivosAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1761, 450);
            this.Controls.Add(this.dgvDispositivos);
            this.Name = "frmConsultaDispositivosAlmacen";
            this.Text = "Dispositivos Almacenados";
            this.Load += new System.EventHandler(this.frmConsultaDispositivosAlmacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispositivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDispositivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDeSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiracionGarantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aula;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngresoAlmacen;
    }
}