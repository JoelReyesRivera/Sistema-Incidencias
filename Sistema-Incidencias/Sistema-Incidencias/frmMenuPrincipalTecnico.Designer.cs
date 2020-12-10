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
            this.dispositivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periflToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concluidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dispositivosToolStripMenuItem,
            this.incidenciaToolStripMenuItem,
            this.periflToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dispositivosToolStripMenuItem
            // 
            this.dispositivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.dispositivosToolStripMenuItem.Name = "dispositivosToolStripMenuItem";
            this.dispositivosToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.dispositivosToolStripMenuItem.Text = "Dispositivos";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // incidenciaToolStripMenuItem
            // 
            this.incidenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finalizarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.incidenciaToolStripMenuItem.Name = "incidenciaToolStripMenuItem";
            this.incidenciaToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.incidenciaToolStripMenuItem.Text = "Incidencia";
            // 
            // finalizarToolStripMenuItem
            // 
            this.finalizarToolStripMenuItem.Name = "finalizarToolStripMenuItem";
            this.finalizarToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.finalizarToolStripMenuItem.Text = "Finalizar Incidencia";
            this.finalizarToolStripMenuItem.Click += new System.EventHandler(this.finalizarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignadasToolStripMenuItem,
            this.finalizadasToolStripMenuItem,
            this.concluidasToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.consultarToolStripMenuItem.Text = "Consultar Incidencias";
            // 
            // asignadasToolStripMenuItem
            // 
            this.asignadasToolStripMenuItem.Name = "asignadasToolStripMenuItem";
            this.asignadasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.asignadasToolStripMenuItem.Text = "Individuales";
            this.asignadasToolStripMenuItem.Click += new System.EventHandler(this.asignadasToolStripMenuItem_Click);
            // 
            // finalizadasToolStripMenuItem
            // 
            this.finalizadasToolStripMenuItem.Name = "finalizadasToolStripMenuItem";
            this.finalizadasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.finalizadasToolStripMenuItem.Text = "Todas";
            this.finalizadasToolStripMenuItem.Click += new System.EventHandler(this.finalizadasToolStripMenuItem_Click);
            // 
            // periflToolStripMenuItem
            // 
            this.periflToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarDepartamentoToolStripMenuItem});
            this.periflToolStripMenuItem.Name = "periflToolStripMenuItem";
            this.periflToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.periflToolStripMenuItem.Text = "Pefil";
            this.periflToolStripMenuItem.Click += new System.EventHandler(this.periflToolStripMenuItem_Click);
            // 
            // actualizarDepartamentoToolStripMenuItem
            // 
            this.actualizarDepartamentoToolStripMenuItem.Name = "actualizarDepartamentoToolStripMenuItem";
            this.actualizarDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.actualizarDepartamentoToolStripMenuItem.Text = "Actualizar Departamento";
            this.actualizarDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.actualizarDepartamentoToolStripMenuItem_Click);
            // 
            // concluidasToolStripMenuItem
            // 
            this.concluidasToolStripMenuItem.Name = "concluidasToolStripMenuItem";
            this.concluidasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.concluidasToolStripMenuItem.Text = "Concluidas";
            this.concluidasToolStripMenuItem.Click += new System.EventHandler(this.concluidasToolStripMenuItem_Click);
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
            this.Text = "Menu Técnico";
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
        private System.Windows.Forms.ToolStripMenuItem asignadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispositivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concluidasToolStripMenuItem;
    }
}