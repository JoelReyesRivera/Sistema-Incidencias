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
    public partial class frmUpdateTecnico : Form
    {
        public String Usuario;
        Tecnico tecnico;
        public frmUpdateTecnico(String Usuario)
        {
            this.Usuario = Usuario;
            InitializeComponent();
        }

        private void frmUpdateTecnico_Load(object sender, EventArgs e)
        {
            tecnico = ManejaUsuario.GetTecnico(Usuario);
            txtUsuario.Text = tecnico.Usuario;
            List<String> departamentos = ManejaDepartamento.ObtenerDepartamentoTecnico();
            cmbDepartamentoTecnico.Items.Clear();
            txtUsuario.Enabled = false;

            foreach (var dep in departamentos)
            {
                cmbDepartamentoTecnico.Items.Add(dep);
                if(dep == tecnico.Departamento)
                {
                    cmbDepartamentoTecnico.SelectedItem= dep;
                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            String departamento = cmbDepartamentoTecnico.SelectedItem.ToString();
            if (departamento == tecnico.Departamento)
            {
                MessageBox.Show("NO HAY CAMBIOS EN LA INFORMACIÓN", "ERROR AL ACTUALIZAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int depId = ManejaDepartamento.ObtenerDepartamentoTecnicoId(departamento);
            ManejaUsuario.ActualizarDepartamentoTecnico(Usuario, depId);
            this.Close();
        }
    }
}
