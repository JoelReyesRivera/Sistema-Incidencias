namespace Sistema_Incidencias
{
    partial class frmConsultaDispositivoCambios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvIncidencias = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANTIGUO_DISPOSITIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUEVO_DISPOSITIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_CAMBIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAMBIADO_POR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIncidencias
            // 
            this.dgvIncidencias.AllowUserToAddRows = false;
            this.dgvIncidencias.AllowUserToDeleteRows = false;
            this.dgvIncidencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIncidencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIncidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncidencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ANTIGUO_DISPOSITIVO,
            this.NUEVO_DISPOSITIVO,
            this.FECHA_CAMBIO,
            this.CAMBIADO_POR});
            this.dgvIncidencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIncidencias.Location = new System.Drawing.Point(0, 0);
            this.dgvIncidencias.Name = "dgvIncidencias";
            this.dgvIncidencias.ReadOnly = true;
            this.dgvIncidencias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvIncidencias.RowHeadersWidth = 51;
            this.dgvIncidencias.Size = new System.Drawing.Size(1046, 493);
            this.dgvIncidencias.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID_INCIDENCIA";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ANTIGUO_DISPOSITIVO
            // 
            this.ANTIGUO_DISPOSITIVO.HeaderText = "ANTIGUO_DISPOSITIVO";
            this.ANTIGUO_DISPOSITIVO.Name = "ANTIGUO_DISPOSITIVO";
            this.ANTIGUO_DISPOSITIVO.ReadOnly = true;
            // 
            // NUEVO_DISPOSITIVO
            // 
            this.NUEVO_DISPOSITIVO.HeaderText = "NUEVO_DISPOSITIVO";
            this.NUEVO_DISPOSITIVO.Name = "NUEVO_DISPOSITIVO";
            this.NUEVO_DISPOSITIVO.ReadOnly = true;
            // 
            // FECHA_CAMBIO
            // 
            this.FECHA_CAMBIO.HeaderText = "FECHA_CAMBIO";
            this.FECHA_CAMBIO.Name = "FECHA_CAMBIO";
            this.FECHA_CAMBIO.ReadOnly = true;
            // 
            // CAMBIADO_POR
            // 
            this.CAMBIADO_POR.HeaderText = "CAMBIADO_POR";
            this.CAMBIADO_POR.Name = "CAMBIADO_POR";
            this.CAMBIADO_POR.ReadOnly = true;
            // 
            // frmConsultaDispositivoCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 493);
            this.Controls.Add(this.dgvIncidencias);
            this.Name = "frmConsultaDispositivoCambios";
            this.Text = "Historial de cambios de dispositivo";
            this.Load += new System.EventHandler(this.frmConsultaDispositivoCambios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIncidencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ANTIGUO_DISPOSITIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUEVO_DISPOSITIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CAMBIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAMBIADO_POR;
    }
}