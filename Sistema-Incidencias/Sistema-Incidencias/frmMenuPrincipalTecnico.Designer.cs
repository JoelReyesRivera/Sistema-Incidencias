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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipalTecnico));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dispositivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enUsoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enAlmacénToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concluidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periflToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(622, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dispositivosToolStripMenuItem
            // 
            this.dispositivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.dispositivosToolStripMenuItem.Name = "dispositivosToolStripMenuItem";
            this.dispositivosToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.dispositivosToolStripMenuItem.Text = "Dispositivos";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enUsoToolStripMenuItem,
            this.enAlmacénToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // enUsoToolStripMenuItem
            // 
            this.enUsoToolStripMenuItem.Name = "enUsoToolStripMenuItem";
            this.enUsoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.enUsoToolStripMenuItem.Text = "Dispositivos en uso";
            this.enUsoToolStripMenuItem.Click += new System.EventHandler(this.enUsoToolStripMenuItem_Click);
            // 
            // enAlmacénToolStripMenuItem
            // 
            this.enAlmacénToolStripMenuItem.Name = "enAlmacénToolStripMenuItem";
            this.enAlmacénToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.enAlmacénToolStripMenuItem.Text = "Dispositivos en almacén";
            this.enAlmacénToolStripMenuItem.Click += new System.EventHandler(this.enAlmacénToolStripMenuItem_Click);
            // 
            // incidenciaToolStripMenuItem
            // 
            this.incidenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finalizarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.incidenciaToolStripMenuItem.Name = "incidenciaToolStripMenuItem";
            this.incidenciaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.incidenciaToolStripMenuItem.Text = "Incidencia";
            // 
            // finalizarToolStripMenuItem
            // 
            this.finalizarToolStripMenuItem.Name = "finalizarToolStripMenuItem";
            this.finalizarToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
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
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.consultarToolStripMenuItem.Text = "Consultar Incidencias";
            // 
            // asignadasToolStripMenuItem
            // 
            this.asignadasToolStripMenuItem.Name = "asignadasToolStripMenuItem";
            this.asignadasToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.asignadasToolStripMenuItem.Text = "Individuales";
            this.asignadasToolStripMenuItem.Click += new System.EventHandler(this.asignadasToolStripMenuItem_Click);
            // 
            // finalizadasToolStripMenuItem
            // 
            this.finalizadasToolStripMenuItem.Name = "finalizadasToolStripMenuItem";
            this.finalizadasToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.finalizadasToolStripMenuItem.Text = "Todas";
            this.finalizadasToolStripMenuItem.Click += new System.EventHandler(this.finalizadasToolStripMenuItem_Click);
            // 
            // concluidasToolStripMenuItem
            // 
            this.concluidasToolStripMenuItem.Name = "concluidasToolStripMenuItem";
            this.concluidasToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.concluidasToolStripMenuItem.Text = "Concluidas";
            this.concluidasToolStripMenuItem.Click += new System.EventHandler(this.concluidasToolStripMenuItem_Click);
            // 
            // periflToolStripMenuItem
            // 
            this.periflToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarDepartamentoToolStripMenuItem});
            this.periflToolStripMenuItem.Name = "periflToolStripMenuItem";
            this.periflToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.periflToolStripMenuItem.Text = "Pefil";
            this.periflToolStripMenuItem.Click += new System.EventHandler(this.periflToolStripMenuItem_Click);
            // 
            // actualizarDepartamentoToolStripMenuItem
            // 
            this.actualizarDepartamentoToolStripMenuItem.Name = "actualizarDepartamentoToolStripMenuItem";
            this.actualizarDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.actualizarDepartamentoToolStripMenuItem.Text = "Actualizar Departamento";
            this.actualizarDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.actualizarDepartamentoToolStripMenuItem_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(539, 107);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblUsuario.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(525, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenuPrincipalTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 445);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenuPrincipalTecnico";
            this.Text = "Menu Técnico";
            this.Load += new System.EventHandler(this.frmMenuPrincipalTecnico_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem enUsoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enAlmacénToolStripMenuItem;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}