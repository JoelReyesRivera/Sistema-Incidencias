﻿namespace Sistema_Incidencias
{
    partial class MenuSignUp
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
            this.btnAmdin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTecnico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAmdin
            // 
            this.btnAmdin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmdin.Location = new System.Drawing.Point(33, 57);
            this.btnAmdin.Name = "btnAmdin";
            this.btnAmdin.Size = new System.Drawing.Size(360, 51);
            this.btnAmdin.TabIndex = 0;
            this.btnAmdin.Text = "Administrador";
            this.btnAmdin.UseVisualStyleBackColor = true;
            this.btnAmdin.Click += new System.EventHandler(this.btnAmdin_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(360, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Jefe Departamento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTecnico
            // 
            this.btnTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTecnico.Location = new System.Drawing.Point(33, 271);
            this.btnTecnico.Name = "btnTecnico";
            this.btnTecnico.Size = new System.Drawing.Size(360, 51);
            this.btnTecnico.TabIndex = 2;
            this.btnTecnico.Text = "Tecnico";
            this.btnTecnico.UseVisualStyleBackColor = true;
            // 
            // MenuSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 378);
            this.Controls.Add(this.btnTecnico);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAmdin);
            this.Name = "MenuSignUp";
            this.Text = "MenuSignUp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAmdin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTecnico;
    }
}