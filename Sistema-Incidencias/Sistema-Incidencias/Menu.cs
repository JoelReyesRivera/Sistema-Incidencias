﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Incidencias
{
    public partial class FormMenuLogIn : Form
    {
        public ManejaUsuario usuarios;
        public FormMenuLogIn()
        {
            usuarios = new ManejaUsuario();

            InitializeComponent();
        }

        private void FormMenuLogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MenuSignUp form = new MenuSignUp();
            form.Show();

        }
    }
}
