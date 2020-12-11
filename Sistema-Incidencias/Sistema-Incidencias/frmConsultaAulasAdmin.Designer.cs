namespace Sistema_Incidencias
{
    partial class frmConsultaAulasAdmin
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
            this.JEFE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAulas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAulas
            // 
            this.dataGridAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAulas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DESCRIPCIÓN,
            this.JEFE});
            this.dataGridAulas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAulas.Location = new System.Drawing.Point(0, 0);
            this.dataGridAulas.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridAulas.Name = "dataGridAulas";
            this.dataGridAulas.RowHeadersWidth = 51;
            this.dataGridAulas.RowTemplate.Height = 24;
            this.dataGridAulas.Size = new System.Drawing.Size(374, 530);
            this.dataGridAulas.TabIndex = 1;
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
            // 
            // JEFE
            // 
            this.JEFE.HeaderText = "JEFE";
            this.JEFE.Name = "JEFE";
            this.JEFE.Width = 150;
            // 
            // frmConsultaAulasAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 530);
            this.Controls.Add(this.dataGridAulas);
            this.Name = "frmConsultaAulasAdmin";
            this.Text = "Consulta de aulas";
            this.Load += new System.EventHandler(this.frmConsultaAulasAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAulas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAulas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCIÓN;
        private System.Windows.Forms.DataGridViewTextBoxColumn JEFE;
    }
}