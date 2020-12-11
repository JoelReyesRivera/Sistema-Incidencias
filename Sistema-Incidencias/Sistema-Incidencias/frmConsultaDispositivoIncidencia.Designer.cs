namespace Sistema_Incidencias
{
    partial class frmConsultaDispositivoIncidencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INCIDENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REPORTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_SOLUCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUCIONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_SOLUCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.INCIDENCIA,
            this.REPORTO,
            this.FECHA,
            this.FECHA_SOLUCION,
            this.SOLUCIONO,
            this.TIPO_SOLUCION});
            this.dgvIncidencias.Location = new System.Drawing.Point(3, 102);
            this.dgvIncidencias.Name = "dgvIncidencias";
            this.dgvIncidencias.ReadOnly = true;
            this.dgvIncidencias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvIncidencias.Size = new System.Drawing.Size(1229, 499);
            this.dgvIncidencias.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dispositivo";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(172, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.FillWeight = 70F;
            this.ID.HeaderText = "ID INCIDENCIA";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
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
            this.FECHA.HeaderText = "FECHA_REPORTE";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            // 
            // FECHA_SOLUCION
            // 
            this.FECHA_SOLUCION.HeaderText = "FECHA_SOLUCION";
            this.FECHA_SOLUCION.Name = "FECHA_SOLUCION";
            this.FECHA_SOLUCION.ReadOnly = true;
            // 
            // SOLUCIONO
            // 
            this.SOLUCIONO.HeaderText = "SOLUCIONO";
            this.SOLUCIONO.Name = "SOLUCIONO";
            this.SOLUCIONO.ReadOnly = true;
            // 
            // TIPO_SOLUCION
            // 
            this.TIPO_SOLUCION.HeaderText = "TIPO_SOLUCION";
            this.TIPO_SOLUCION.Name = "TIPO_SOLUCION";
            this.TIPO_SOLUCION.ReadOnly = true;
            // 
            // frmConsultaDispositivoIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 601);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIncidencias);
            this.Name = "frmConsultaDispositivoIncidencia";
            this.Text = "Historial de incidencia por dispositivo";
            this.Load += new System.EventHandler(this.frmConsultaDispositivoIncidencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIncidencias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn INCIDENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn REPORTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_SOLUCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUCIONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_SOLUCION;
    }
}