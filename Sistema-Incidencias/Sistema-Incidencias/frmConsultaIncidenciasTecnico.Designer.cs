﻿namespace Sistema_Incidencias
{
    partial class frmConsultaIncidenciasTecnico
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
            this.dgvTodosIncidentesTec = new System.Windows.Forms.DataGridView();
            this.Col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Dispositivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Ubicado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_FechaRepor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_DetIncidencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosIncidentesTec)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTodosIncidentesTec
            // 
            this.dgvTodosIncidentesTec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodosIncidentesTec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_ID,
            this.col_Dispositivo,
            this.Col_Marca,
            this.Col_Modelo,
            this.Col_Ubicado,
            this.Col_FechaRepor,
            this.Col_Estatus,
            this.Col_DetIncidencia});
            this.dgvTodosIncidentesTec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTodosIncidentesTec.Location = new System.Drawing.Point(0, 0);
            this.dgvTodosIncidentesTec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTodosIncidentesTec.Name = "dgvTodosIncidentesTec";
            this.dgvTodosIncidentesTec.RowHeadersWidth = 51;
            this.dgvTodosIncidentesTec.Size = new System.Drawing.Size(1256, 594);
            this.dgvTodosIncidentesTec.TabIndex = 0;
            // 
            // Col_ID
            // 
            this.Col_ID.HeaderText = "ID INCIDENCIA";
            this.Col_ID.MinimumWidth = 6;
            this.Col_ID.Name = "Col_ID";
            this.Col_ID.Width = 125;
            // 
            // col_Dispositivo
            // 
            this.col_Dispositivo.HeaderText = "DISPOSITIVO";
            this.col_Dispositivo.MinimumWidth = 6;
            this.col_Dispositivo.Name = "col_Dispositivo";
            this.col_Dispositivo.Width = 125;
            // 
            // Col_Marca
            // 
            this.Col_Marca.HeaderText = "MARCA";
            this.Col_Marca.MinimumWidth = 6;
            this.Col_Marca.Name = "Col_Marca";
            this.Col_Marca.Width = 125;
            // 
            // Col_Modelo
            // 
            this.Col_Modelo.HeaderText = "MODELO";
            this.Col_Modelo.MinimumWidth = 6;
            this.Col_Modelo.Name = "Col_Modelo";
            this.Col_Modelo.Width = 125;
            // 
            // Col_Ubicado
            // 
            this.Col_Ubicado.HeaderText = "UBICADO";
            this.Col_Ubicado.MinimumWidth = 6;
            this.Col_Ubicado.Name = "Col_Ubicado";
            this.Col_Ubicado.Width = 125;
            // 
            // Col_FechaRepor
            // 
            this.Col_FechaRepor.HeaderText = "FECHA ASIGNADA";
            this.Col_FechaRepor.MinimumWidth = 6;
            this.Col_FechaRepor.Name = "Col_FechaRepor";
            this.Col_FechaRepor.Width = 125;
            // 
            // Col_Estatus
            // 
            this.Col_Estatus.HeaderText = "ESTATUS";
            this.Col_Estatus.MinimumWidth = 6;
            this.Col_Estatus.Name = "Col_Estatus";
            this.Col_Estatus.Width = 125;
            // 
            // Col_DetIncidencia
            // 
            this.Col_DetIncidencia.HeaderText = "DETALLE DE INCIDENCIA";
            this.Col_DetIncidencia.MinimumWidth = 6;
            this.Col_DetIncidencia.Name = "Col_DetIncidencia";
            this.Col_DetIncidencia.Width = 200;
            // 
            // frmConsultaIncidenciasTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 594);
            this.Controls.Add(this.dgvTodosIncidentesTec);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConsultaIncidenciasTecnico";
            this.Text = "Incidencias ";
            this.Load += new System.EventHandler(this.frmConsultaTodasIncidenciasTecnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosIncidentesTec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTodosIncidentesTec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Dispositivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Ubicado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_FechaRepor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_DetIncidencia;
    }
}