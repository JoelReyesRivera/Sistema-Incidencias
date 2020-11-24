namespace Sistema_Incidencias
{
    partial class frmConsultaIncidenciasIndividual
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
            this.cmbIncidencias = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIncidencia = new System.Windows.Forms.TextBox();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtUbicado = new System.Windows.Forms.TextBox();
            this.txtReporto = new System.Windows.Forms.TextBox();
            this.txtDispositivo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpia = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // cmbIncidencias
            // 
            this.cmbIncidencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIncidencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIncidencias.FormattingEnabled = true;
            this.cmbIncidencias.Location = new System.Drawing.Point(95, 83);
            this.cmbIncidencias.Name = "cmbIncidencias";
            this.cmbIncidencias.Size = new System.Drawing.Size(121, 24);
            this.cmbIncidencias.TabIndex = 3;
            this.cmbIncidencias.SelectedIndexChanged += new System.EventHandler(this.cmbIncidencias_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "CONSULTA INDIVIDUAL DE INCIDENCIAS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIncidencia);
            this.groupBox1.Controls.Add(this.txtEstatus);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.txtUbicado);
            this.groupBox1.Controls.Add(this.txtReporto);
            this.groupBox1.Controls.Add(this.txtDispositivo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(57, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 357);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de la incidencia";
            // 
            // txtIncidencia
            // 
            this.txtIncidencia.Location = new System.Drawing.Point(51, 287);
            this.txtIncidencia.Multiline = true;
            this.txtIncidencia.Name = "txtIncidencia";
            this.txtIncidencia.Size = new System.Drawing.Size(312, 51);
            this.txtIncidencia.TabIndex = 15;
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(159, 232);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(204, 22);
            this.txtEstatus.TabIndex = 14;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(159, 200);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 22);
            this.txtFecha.TabIndex = 13;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(159, 67);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(204, 22);
            this.txtMarca.TabIndex = 12;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(159, 103);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(204, 22);
            this.txtModelo.TabIndex = 11;
            // 
            // txtUbicado
            // 
            this.txtUbicado.Location = new System.Drawing.Point(159, 135);
            this.txtUbicado.Name = "txtUbicado";
            this.txtUbicado.Size = new System.Drawing.Size(100, 22);
            this.txtUbicado.TabIndex = 10;
            // 
            // txtReporto
            // 
            this.txtReporto.Location = new System.Drawing.Point(159, 168);
            this.txtReporto.Name = "txtReporto";
            this.txtReporto.Size = new System.Drawing.Size(100, 22);
            this.txtReporto.TabIndex = 9;
            // 
            // txtDispositivo
            // 
            this.txtDispositivo.Location = new System.Drawing.Point(159, 35);
            this.txtDispositivo.Name = "txtDispositivo";
            this.txtDispositivo.Size = new System.Drawing.Size(204, 22);
            this.txtDispositivo.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Estatus";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Fecha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Detalle de la incidencia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Reportó";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ubicado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dispositivo";
            // 
            // btnLimpia
            // 
            this.btnLimpia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpia.Location = new System.Drawing.Point(369, 83);
            this.btnLimpia.Name = "btnLimpia";
            this.btnLimpia.Size = new System.Drawing.Size(75, 26);
            this.btnLimpia.TabIndex = 6;
            this.btnLimpia.Text = "Limpiar";
            this.btnLimpia.UseVisualStyleBackColor = true;
            this.btnLimpia.Click += new System.EventHandler(this.btnLimpia_Click);
            // 
            // frmConsultaIncidenciasIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 552);
            this.Controls.Add(this.btnLimpia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbIncidencias);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultaIncidenciasIndividual";
            this.Text = "frmConsultaIncidenciaIndividual";
            this.Load += new System.EventHandler(this.frmConsultaIncidenciaIndividual_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIncidencias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpia;
        private System.Windows.Forms.TextBox txtIncidencia;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtUbicado;
        private System.Windows.Forms.TextBox txtReporto;
        private System.Windows.Forms.TextBox txtDispositivo;
    }
}