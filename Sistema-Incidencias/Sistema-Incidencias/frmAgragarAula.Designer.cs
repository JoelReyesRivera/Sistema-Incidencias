namespace Sistema_Incidencias
{
    partial class frmAgregarAulas
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
            this.btnAsignarAula = new System.Windows.Forms.Button();
            this.cmbAulas = new System.Windows.Forms.ComboBox();
            this.lblAula = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblJefe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAsignarAula
            // 
            this.btnAsignarAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarAula.Location = new System.Drawing.Point(103, 281);
            this.btnAsignarAula.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsignarAula.Name = "btnAsignarAula";
            this.btnAsignarAula.Size = new System.Drawing.Size(187, 47);
            this.btnAsignarAula.TabIndex = 9;
            this.btnAsignarAula.Text = "Asignar Aula";
            this.btnAsignarAula.UseVisualStyleBackColor = true;
            this.btnAsignarAula.Click += new System.EventHandler(this.btnAsignarAula_Click);
            // 
            // cmbAulas
            // 
            this.cmbAulas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAulas.FormattingEnabled = true;
            this.cmbAulas.Location = new System.Drawing.Point(80, 215);
            this.cmbAulas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAulas.Name = "cmbAulas";
            this.cmbAulas.Size = new System.Drawing.Size(239, 37);
            this.cmbAulas.TabIndex = 8;
            // 
            // lblAula
            // 
            this.lblAula.AutoSize = true;
            this.lblAula.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAula.Location = new System.Drawing.Point(58, 158);
            this.lblAula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAula.Name = "lblAula";
            this.lblAula.Size = new System.Drawing.Size(282, 40);
            this.lblAula.TabIndex = 7;
            this.lblAula.Text = "Aulas disponibles";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(80, 97);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(239, 34);
            this.txtUsuario.TabIndex = 6;
            // 
            // lblJefe
            // 
            this.lblJefe.AutoSize = true;
            this.lblJefe.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJefe.Location = new System.Drawing.Point(58, 38);
            this.lblJefe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJefe.Name = "lblJefe";
            this.lblJefe.Size = new System.Drawing.Size(303, 40);
            this.lblJefe.TabIndex = 5;
            this.lblJefe.Text = "Jefe Departamento";
            // 
            // frmAgregarAulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 359);
            this.Controls.Add(this.btnAsignarAula);
            this.Controls.Add(this.cmbAulas);
            this.Controls.Add(this.lblAula);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblJefe);
            this.Name = "frmAgregarAulas";
            this.Text = "Asignar Aulas";
            this.Load += new System.EventHandler(this.frmAgregarAulas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAsignarAula;
        private System.Windows.Forms.ComboBox cmbAulas;
        private System.Windows.Forms.Label lblAula;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblJefe;
    }
}