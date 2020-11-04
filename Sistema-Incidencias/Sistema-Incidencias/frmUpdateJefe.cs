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
    public partial class frmUpdateJefe : Form
    {
        public String Usuario;
        Jefe  jefe;

        public frmUpdateJefe(string Usuario)
        {
            this.Usuario = Usuario;
            InitializeComponent();
        }

        private void frmUpdateJefe_Load(object sender, EventArgs e)
        {
            jefe = ManejaUsuario.GetJefe(Usuario);
            txtUsuario.Text = jefe.Usuario;
            List<String> departamentos = ManejaDepartamento.ObtenerDepartamentoJefe();
            cmbDepartamento.Items.Clear();
            txtUsuario.Enabled = false;

            foreach (var dep in departamentos)
            {
                cmbDepartamento.Items.Add(dep);
                if (dep == jefe.Departamento)
                {
                    cmbDepartamento.SelectedItem = dep;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String departamento = cmbDepartamento.SelectedItem.ToString();
            if (departamento == jefe.Departamento)
            {
                MessageBox.Show("NO HAY CAMBIOS EN LA INFORMACIÓN", "ERROR AL ACTUALIZAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int depId = ManejaDepartamento.ObtenerDepartamentoJefeId(departamento);
            ManejaUsuario.ActualizarDepartamentoJefe(Usuario, depId);
            this.Close();
        }
    }
}
