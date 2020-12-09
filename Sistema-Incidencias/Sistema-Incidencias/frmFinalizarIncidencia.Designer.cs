namespace Sistema_Incidencias
{
    partial class frmFinalizarIncidencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbIncidencias = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroSerie = new System.Windows.Forms.TextBox();
            this.txtIncidencia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbReparacion = new System.Windows.Forms.RadioButton();
            this.rbCambio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDispositvosCambio = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id incidencia";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(132, 510);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 32);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Finalizar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbIncidencias
            // 
            this.cmbIncidencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIncidencias.FormattingEnabled = true;
            this.cmbIncidencias.Items.AddRange(new object[] {
            "SELECCIONE"});
            this.cmbIncidencias.Location = new System.Drawing.Point(179, 79);
            this.cmbIncidencias.Name = "cmbIncidencias";
            this.cmbIncidencias.Size = new System.Drawing.Size(138, 21);
            this.cmbIncidencias.TabIndex = 16;
            this.cmbIncidencias.SelectedIndexChanged += new System.EventHandler(this.cmbIncidencias_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Dispositivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Incidencia";
            // 
            // txtNumeroSerie
            // 
            this.txtNumeroSerie.Location = new System.Drawing.Point(179, 132);
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.ReadOnly = true;
            this.txtNumeroSerie.Size = new System.Drawing.Size(138, 20);
            this.txtNumeroSerie.TabIndex = 20;
            // 
            // txtIncidencia
            // 
            this.txtIncidencia.Location = new System.Drawing.Point(179, 184);
            this.txtIncidencia.Multiline = true;
            this.txtIncidencia.Name = "txtIncidencia";
            this.txtIncidencia.ReadOnly = true;
            this.txtIncidencia.Size = new System.Drawing.Size(138, 110);
            this.txtIncidencia.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCambio);
            this.groupBox1.Controls.Add(this.rbReparacion);
            this.groupBox1.Location = new System.Drawing.Point(35, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 71);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de solución";
            // 
            // rbReparacion
            // 
            this.rbReparacion.AutoSize = true;
            this.rbReparacion.Checked = true;
            this.rbReparacion.Location = new System.Drawing.Point(27, 30);
            this.rbReparacion.Name = "rbReparacion";
            this.rbReparacion.Size = new System.Drawing.Size(80, 17);
            this.rbReparacion.TabIndex = 0;
            this.rbReparacion.TabStop = true;
            this.rbReparacion.Text = "Reparación";
            this.rbReparacion.UseVisualStyleBackColor = true;
            this.rbReparacion.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbCambio
            // 
            this.rbCambio.AutoSize = true;
            this.rbCambio.Location = new System.Drawing.Point(149, 30);
            this.rbCambio.Name = "rbCambio";
            this.rbCambio.Size = new System.Drawing.Size(127, 17);
            this.rbCambio.TabIndex = 1;
            this.rbCambio.Text = "Cambio de dispositivo";
            this.rbCambio.UseVisualStyleBackColor = true;
            this.rbCambio.CheckedChanged += new System.EventHandler(this.rbCambio_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nuevo Dispositivo";
            // 
            // cmbDispositvosCambio
            // 
            this.cmbDispositvosCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDispositvosCambio.FormattingEnabled = true;
            this.cmbDispositvosCambio.Location = new System.Drawing.Point(202, 424);
            this.cmbDispositvosCambio.Name = "cmbDispositvosCambio";
            this.cmbDispositvosCambio.Size = new System.Drawing.Size(115, 21);
            this.cmbDispositvosCambio.TabIndex = 24;
            this.cmbDispositvosCambio.SelectedIndexChanged += new System.EventHandler(this.cmbDispositvosCambio_SelectedIndexChanged);
            // 
            // frmFinalizarIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 568);
            this.Controls.Add(this.cmbDispositvosCambio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtIncidencia);
            this.Controls.Add(this.txtNumeroSerie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbIncidencias);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Name = "frmFinalizarIncidencia";
            this.Text = "Finalizar Incidencia";
            this.Load += new System.EventHandler(this.frmIncidenciaConcluida_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbIncidencias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroSerie;
        private System.Windows.Forms.TextBox txtIncidencia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCambio;
        private System.Windows.Forms.RadioButton rbReparacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDispositvosCambio;
    }
}