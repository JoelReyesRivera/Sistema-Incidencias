namespace Sistema_Incidencias
{
    partial class frmConsultarAulasAsignadas
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
            this.dataGridAulas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCIÓN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAulas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAulas
            // 
            this.dataGridAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAulas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DESCRIPCIÓN});
            this.dataGridAulas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAulas.Location = new System.Drawing.Point(0, 0);
            this.dataGridAulas.Name = "dataGridAulas";
            this.dataGridAulas.RowHeadersWidth = 51;
            this.dataGridAulas.RowTemplate.Height = 24;
            this.dataGridAulas.Size = new System.Drawing.Size(419, 452);
            this.dataGridAulas.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 75;
            // 
            // DESCRIPCIÓN
            // 
            this.DESCRIPCIÓN.HeaderText = "DESCRIPCIÓN";
            this.DESCRIPCIÓN.MinimumWidth = 6;
            this.DESCRIPCIÓN.Name = "DESCRIPCIÓN";
            this.DESCRIPCIÓN.Width = 200;
            // 
            // frmConsultarAulasAsignadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 452);
            this.Controls.Add(this.dataGridAulas);
            this.Name = "frmConsultarAulasAsignadas";
            this.Text = "Aulas Asignadas";
            this.Load += new System.EventHandler(this.frmConsultarAulasAsignadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAulas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAulas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCIÓN;
    }
}