﻿namespace Sistema_Incidencias
{
    partial class frmConsultaTodasIncidenciasTecnico
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
            this.Col_DetIncidencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Reportado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_FechaRepor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_FechaSol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Col_DetIncidencia,
            this.Col_Reportado,
            this.Col_FechaRepor,
            this.Col_FechaSol,
            this.Col_Estatus});
            this.dgvTodosIncidentesTec.Location = new System.Drawing.Point(1, -2);
            this.dgvTodosIncidentesTec.Name = "dgvTodosIncidentesTec";
            this.dgvTodosIncidentesTec.Size = new System.Drawing.Size(881, 461);
            this.dgvTodosIncidentesTec.TabIndex = 0;
            // 
            // Col_ID
            // 
            this.Col_ID.HeaderText = "ID INCIDENCIA";
            this.Col_ID.Name = "Col_ID";
            // 
            // col_Dispositivo
            // 
            this.col_Dispositivo.HeaderText = "DISPOSITIVO";
            this.col_Dispositivo.Name = "col_Dispositivo";
            // 
            // Col_Marca
            // 
            this.Col_Marca.HeaderText = "MARCA";
            this.Col_Marca.Name = "Col_Marca";
            // 
            // Col_Modelo
            // 
            this.Col_Modelo.HeaderText = "MODELO";
            this.Col_Modelo.Name = "Col_Modelo";
            // 
            // Col_Ubicado
            // 
            this.Col_Ubicado.HeaderText = "UBICADO";
            this.Col_Ubicado.Name = "Col_Ubicado";
            // 
            // Col_DetIncidencia
            // 
            this.Col_DetIncidencia.HeaderText = "DETALLE DE INCIDENCIA";
            this.Col_DetIncidencia.Name = "Col_DetIncidencia";
            // 
            // Col_Reportado
            // 
            this.Col_Reportado.HeaderText = "REPORTADO POR";
            this.Col_Reportado.Name = "Col_Reportado";
            // 
            // Col_FechaRepor
            // 
            this.Col_FechaRepor.HeaderText = "FECHA DE REPORTE";
            this.Col_FechaRepor.Name = "Col_FechaRepor";
            // 
            // Col_FechaSol
            // 
            this.Col_FechaSol.HeaderText = "FECHA DE SOLUCION";
            this.Col_FechaSol.Name = "Col_FechaSol";
            // 
            // Col_Estatus
            // 
            this.Col_Estatus.HeaderText = "ESTATUS";
            this.Col_Estatus.Name = "Col_Estatus";
            // 
            // frmConsultaTodasIncidenciasTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 483);
            this.Controls.Add(this.dgvTodosIncidentesTec);
            this.Name = "frmConsultaTodasIncidenciasTecnico";
            this.Text = "frmConsultaTodasIncidenciasTecnico";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_DetIncidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Reportado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_FechaRepor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_FechaSol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Estatus;
    }
}