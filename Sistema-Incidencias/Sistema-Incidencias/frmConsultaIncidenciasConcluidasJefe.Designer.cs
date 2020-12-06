namespace Sistema_Incidencias
{
    partial class frmConsultaIncidenciasConcluidasJefe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvIncidencias = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISPOSITIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UBICADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INCIDENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REPORTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHASOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUCIONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIncidencias
            // 
            this.dgvIncidencias.AllowUserToAddRows = false;
            this.dgvIncidencias.AllowUserToDeleteRows = false;
            this.dgvIncidencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIncidencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIncidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncidencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DISPOSITIVO,
            this.MARCA,
            this.MODELO,
            this.UBICADO,
            this.INCIDENCIA,
            this.REPORTO,
            this.FECHA,
            this.FECHASOL,
            this.ESTATUS,
            this.SOLUCIONO});
            this.dgvIncidencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIncidencias.Location = new System.Drawing.Point(0, 0);
            this.dgvIncidencias.Name = "dgvIncidencias";
            this.dgvIncidencias.ReadOnly = true;
            this.dgvIncidencias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvIncidencias.Size = new System.Drawing.Size(1399, 665);
            this.dgvIncidencias.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // DISPOSITIVO
            // 
            this.DISPOSITIVO.HeaderText = "DISPOSITIVO";
            this.DISPOSITIVO.Name = "DISPOSITIVO";
            this.DISPOSITIVO.ReadOnly = true;
            // 
            // MARCA
            // 
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.Name = "MARCA";
            this.MARCA.ReadOnly = true;
            // 
            // MODELO
            // 
            this.MODELO.HeaderText = "MODELO";
            this.MODELO.Name = "MODELO";
            this.MODELO.ReadOnly = true;
            // 
            // UBICADO
            // 
            this.UBICADO.FillWeight = 50F;
            this.UBICADO.HeaderText = "UBICADO";
            this.UBICADO.Name = "UBICADO";
            this.UBICADO.ReadOnly = true;
            // 
            // INCIDENCIA
            // 
            this.INCIDENCIA.HeaderText = "INCIDENCIA";
            this.INCIDENCIA.Name = "INCIDENCIA";
            this.INCIDENCIA.ReadOnly = true;
            // 
            // REPORTO
            // 
            this.REPORTO.HeaderText = "REPORTO";
            this.REPORTO.Name = "REPORTO";
            this.REPORTO.ReadOnly = true;
            // 
            // FECHA
            // 
            this.FECHA.HeaderText = "RECHA REPORTE";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            // 
            // FECHASOL
            // 
            this.FECHASOL.HeaderText = "FECHA SOLUCION";
            this.FECHASOL.Name = "FECHASOL";
            this.FECHASOL.ReadOnly = true;
            // 
            // ESTATUS
            // 
            this.ESTATUS.HeaderText = "ESTATUS";
            this.ESTATUS.Name = "ESTATUS";
            this.ESTATUS.ReadOnly = true;
            // 
            // SOLUCIONO
            // 
            this.SOLUCIONO.HeaderText = "SOLUCIONO";
            this.SOLUCIONO.Name = "SOLUCIONO";
            this.SOLUCIONO.ReadOnly = true;
            // 
            // frmConsultaIncidenciasConcluidasJefe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 665);
            this.Controls.Add(this.dgvIncidencias);
            this.Name = "frmConsultaIncidenciasConcluidasJefe";
            this.Text = "frmConsultaIncidenciasConcluidasJefe";
            this.Load += new System.EventHandler(this.frmConsultaIncidenciasConcluidasJefe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIncidencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISPOSITIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn UBICADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn INCIDENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn REPORTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHASOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUCIONO;
    }
}