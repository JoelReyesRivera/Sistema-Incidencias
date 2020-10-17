using System;
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
    public partial class frmSign_UpAdmin : Form
    {
        public frmSign_UpAdmin()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ManejaUsuario.AñadirAdmin(txtUsuario.Text, txtPassword.Text);
        }
    }
}
