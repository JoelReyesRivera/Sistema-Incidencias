namespace Sistema_Incidencias
{
    partial class frmMenuPrincipalAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipalAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.incidenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidenciasConcluidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialAsignadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialPorTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispositivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enUsoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispostivosEnAlmacénToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialEnIncidenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiosDeDispositivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vincularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoTecnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incidenciasToolStripMenuItem,
            this.dispositivosToolStripMenuItem,
            this.aulasToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(659, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // incidenciasToolStripMenuItem
            // 
            this.incidenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarTécnicoToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.incidenciasToolStripMenuItem.Name = "incidenciasToolStripMenuItem";
            this.incidenciasToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.incidenciasToolStripMenuItem.Text = "Incidencias";
            // 
            // asignarTécnicoToolStripMenuItem
            // 
            this.asignarTécnicoToolStripMenuItem.Name = "asignarTécnicoToolStripMenuItem";
            this.asignarTécnicoToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.asignarTécnicoToolStripMenuItem.Text = "Asignar Incidencia a  técnico";
            this.asignarTécnicoToolStripMenuItem.Click += new System.EventHandler(this.asignarTécnicoToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.individualToolStripMenuItem,
            this.incidenciasConcluidasToolStripMenuItem,
            this.historialAsignadasToolStripMenuItem,
            this.historialPorTécnicoToolStripMenuItem,
            this.todasToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // individualToolStripMenuItem
            // 
            this.individualToolStripMenuItem.Name = "individualToolStripMenuItem";
            this.individualToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.individualToolStripMenuItem.Text = "Individual";
            this.individualToolStripMenuItem.Click += new System.EventHandler(this.individualToolStripMenuItem_Click);
            // 
            // incidenciasConcluidasToolStripMenuItem
            // 
            this.incidenciasConcluidasToolStripMenuItem.Name = "incidenciasConcluidasToolStripMenuItem";
            this.incidenciasConcluidasToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.incidenciasConcluidasToolStripMenuItem.Text = "Incidencias concluidas";
            this.incidenciasConcluidasToolStripMenuItem.Click += new System.EventHandler(this.incidenciasConcluidasToolStripMenuItem_Click);
            // 
            // historialAsignadasToolStripMenuItem
            // 
            this.historialAsignadasToolStripMenuItem.Name = "historialAsignadasToolStripMenuItem";
            this.historialAsignadasToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.historialAsignadasToolStripMenuItem.Text = "Historial Asignadas";
            this.historialAsignadasToolStripMenuItem.Click += new System.EventHandler(this.historialAsignadasToolStripMenuItem_Click);
            // 
            // historialPorTécnicoToolStripMenuItem
            // 
            this.historialPorTécnicoToolStripMenuItem.Name = "historialPorTécnicoToolStripMenuItem";
            this.historialPorTécnicoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.historialPorTécnicoToolStripMenuItem.Text = "Historial por técnico";
            this.historialPorTécnicoToolStripMenuItem.Click += new System.EventHandler(this.historialPorTécnicoToolStripMenuItem_Click);
            // 
            // todasToolStripMenuItem
            // 
            this.todasToolStripMenuItem.Name = "todasToolStripMenuItem";
            this.todasToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.todasToolStripMenuItem.Text = "Todas";
            this.todasToolStripMenuItem.Click += new System.EventHandler(this.todasToolStripMenuItem_Click);
            // 
            // dispositivosToolStripMenuItem
            // 
            this.dispositivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.vincularToolStripMenuItem});
            this.dispositivosToolStripMenuItem.Name = "dispositivosToolStripMenuItem";
            this.dispositivosToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.dispositivosToolStripMenuItem.Text = "Dispositivos";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enUsoToolStripMenuItem,
            this.dispostivosEnAlmacénToolStripMenuItem,
            this.historialEnIncidenciaToolStripMenuItem,
            this.cambiosDeDispositivoToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // enUsoToolStripMenuItem
            // 
            this.enUsoToolStripMenuItem.Name = "enUsoToolStripMenuItem";
            this.enUsoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.enUsoToolStripMenuItem.Text = "Dispositivos en uso";
            this.enUsoToolStripMenuItem.Click += new System.EventHandler(this.enUsoToolStripMenuItem_Click);
            // 
            // dispostivosEnAlmacénToolStripMenuItem
            // 
            this.dispostivosEnAlmacénToolStripMenuItem.Name = "dispostivosEnAlmacénToolStripMenuItem";
            this.dispostivosEnAlmacénToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.dispostivosEnAlmacénToolStripMenuItem.Text = "Dispostivos en almacén";
            this.dispostivosEnAlmacénToolStripMenuItem.Click += new System.EventHandler(this.dispostivosEnAlmacénToolStripMenuItem_Click);
            // 
            // historialEnIncidenciaToolStripMenuItem
            // 
            this.historialEnIncidenciaToolStripMenuItem.Name = "historialEnIncidenciaToolStripMenuItem";
            this.historialEnIncidenciaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.historialEnIncidenciaToolStripMenuItem.Text = "Historial en incidencia";
            this.historialEnIncidenciaToolStripMenuItem.Click += new System.EventHandler(this.historialEnIncidenciaToolStripMenuItem_Click);
            // 
            // cambiosDeDispositivoToolStripMenuItem
            // 
            this.cambiosDeDispositivoToolStripMenuItem.Name = "cambiosDeDispositivoToolStripMenuItem";
            this.cambiosDeDispositivoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.cambiosDeDispositivoToolStripMenuItem.Text = "Historial de Cambios";
            this.cambiosDeDispositivoToolStripMenuItem.Click += new System.EventHandler(this.cambiosDeDispositivoToolStripMenuItem_Click);
            // 
            // vincularToolStripMenuItem
            // 
            this.vincularToolStripMenuItem.Name = "vincularToolStripMenuItem";
            this.vincularToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.vincularToolStripMenuItem.Text = "Vincular";
            this.vincularToolStripMenuItem.Click += new System.EventHandler(this.vincularToolStripMenuItem_Click);
            // 
            // aulasToolStripMenuItem
            // 
            this.aulasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem3,
            this.consultarToolStripMenuItem1});
            this.aulasToolStripMenuItem.Name = "aulasToolStripMenuItem";
            this.aulasToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aulasToolStripMenuItem.Text = "Aulas";
            // 
            // agregarToolStripMenuItem3
            // 
            this.agregarToolStripMenuItem3.Name = "agregarToolStripMenuItem3";
            this.agregarToolStripMenuItem3.Size = new System.Drawing.Size(125, 22);
            this.agregarToolStripMenuItem3.Text = "Agregar";
            this.agregarToolStripMenuItem3.Click += new System.EventHandler(this.agregarToolStripMenuItem3_Click);
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            this.consultarToolStripMenuItem1.Click += new System.EventHandler(this.consultarToolStripMenuItem1_Click);
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departamentoToolStripMenuItem,
            this.departamentoTecnicoToolStripMenuItem});
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem2,
            this.consultaToolStripMenuItem1});
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.departamentoToolStripMenuItem.Text = "Departamento";
            // 
            // agregarToolStripMenuItem2
            // 
            this.agregarToolStripMenuItem2.Name = "agregarToolStripMenuItem2";
            this.agregarToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.agregarToolStripMenuItem2.Text = "Agregar";
            this.agregarToolStripMenuItem2.Click += new System.EventHandler(this.agregarToolStripMenuItem2_Click);
            // 
            // departamentoTecnicoToolStripMenuItem
            // 
            this.departamentoTecnicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1});
            this.departamentoTecnicoToolStripMenuItem.Name = "departamentoTecnicoToolStripMenuItem";
            this.departamentoTecnicoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.departamentoTecnicoToolStripMenuItem.Text = "Departamento tecnico";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.registrarToolStripMenuItem.Text = "Agregar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(562, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(576, 107);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblUsuario.TabIndex = 2;
            // 
            // consultaToolStripMenuItem1
            // 
            this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.consultaToolStripMenuItem1.Text = "Consulta";
            this.consultaToolStripMenuItem1.Click += new System.EventHandler(this.consultaToolStripMenuItem1_Click);
            // 
            // frmMenuPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 420);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuPrincipalAdmin";
            this.Text = "Menu Administrador";
            this.Load += new System.EventHandler(this.PantallaIincio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dispositivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem departamentoTecnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem incidenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarTécnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vincularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enUsoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispostivosEnAlmacénToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidenciasConcluidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialAsignadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialEnIncidenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiosDeDispositivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialPorTécnicoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
    }
}