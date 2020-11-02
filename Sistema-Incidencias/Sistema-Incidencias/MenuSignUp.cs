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
    public partial class MenuSignUp : Form
    {
        public MenuSignUp()
        {
            InitializeComponent();
        }

        private void btnAmdin_Click(object sender, EventArgs e)
        {
            frmSign_UpAdmin form = new frmSign_UpAdmin();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUpJefeDepartamento signUpJefeDepartamento = new SignUpJefeDepartamento();
            signUpJefeDepartamento.ShowDialog();
        }

        private void btnTecnico_Click(object sender, EventArgs e)
        {
            SignUpTecnicoDepartamento form = new SignUpTecnicoDepartamento();
            form.ShowDialog();
        }
    }
}
