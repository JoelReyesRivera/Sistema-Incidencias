using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaBD;

namespace Sistema_Incidencias
{
    public partial class SignUpTecnico : Form
    {
        public SignUpTecnico()
        {
            InitializeComponent();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void SignUpTecnico_Load(object sender, EventArgs e)
        {
            List<String> departamentos = ManejaDepartamento.ObtenerDepartamentoTecnico();
            cmbDepartamentoTecnico.Items.Clear();

            foreach (var dep in departamentos)
            {
                cmbDepartamentoTecnico.Items.Add(dep);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ManejaUsuario.AñadirTecnico(txtUsuario.Text, txtPassword.Text, ManejaDepartamento.ObtenerDepartamentoTecnicoId(cmbDepartamentoTecnico.SelectedItem.ToString()));
        }
    }
}
