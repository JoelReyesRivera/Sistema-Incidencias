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
    public partial class SignUpJefeDepartamento : Form
    {
        public SignUpJefeDepartamento()
        {
            InitializeComponent();
        }

        private void SignUpJefeDepartamento_Load(object sender, EventArgs e)
        {
            List <String> departamentos = ManejaDepartamento.ObtenerDepartamentos();
            cmbDepartamento.Items.Clear();

            foreach (var dep in departamentos)
            {
                cmbDepartamento.Items.Add(dep);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
          ManejaUsuario.AñadirJefe(txtUsuario.Text, txtPassword.Text, ManejaDepartamento.ObtenerDepartamentoId(cmbDepartamento.SelectedItem.ToString()));

        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
