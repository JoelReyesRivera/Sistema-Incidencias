namespace Sistema_Incidencias
{
    partial class frmMenuPrincipalTecnico
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.incidenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periflToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaIncidenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incidenciaToolStripMenuItem,
            this.periflToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // incidenciaToolStripMenuItem
            // 
            this.incidenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finalizarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.altaIncidenciaToolStripMenuItem});
            this.incidenciaToolStripMenuItem.Name = "incidenciaToolStripMenuItem";
            this.incidenciaToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.incidenciaToolStripMenuItem.Text = "Incidencia";
            // 
            // finalizarToolStripMenuItem
            // 
            this.finalizarToolStripMenuItem.Name = "finalizarToolStripMenuItem";
            this.finalizarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.finalizarToolStripMenuItem.Text = "Finalizar";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // periflToolStripMenuItem
            // 
            this.periflToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarDepartamentoToolStripMenuItem});
            this.periflToolStripMenuItem.Name = "periflToolStripMenuItem";
            this.periflToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.periflToolStripMenuItem.Text = "Pefil";
            this.periflToolStripMenuItem.Click += new System.EventHandler(this.periflToolStripMenuItem_Click);
            // 
            // actualizarDepartamentoToolStripMenuItem
            // 
            this.actualizarDepartamentoToolStripMenuItem.Name = "actualizarDepartamentoToolStripMenuItem";
            this.actualizarDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.actualizarDepartamentoToolStripMenuItem.Text = "Actualizar Departamento";
            this.actualizarDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.actualizarDepartamentoToolStripMenuItem_Click);
            // 
            // altaIncidenciaToolStripMenuItem
            // 
            this.altaIncidenciaToolStripMenuItem.Name = "altaIncidenciaToolStripMenuItem";
            this.altaIncidenciaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.altaIncidenciaToolStripMenuItem.Text = "Alta incidencia";
            this.altaIncidenciaToolStripMenuItem.Click += new System.EventHandler(this.altaIncidenciaToolStripMenuItem_Click);
            // 
            // frmMenuPrincipalTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMenuPrincipalTecnico";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem periflToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarDepartamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaIncidenciaToolStripMenuItem;
    }
}