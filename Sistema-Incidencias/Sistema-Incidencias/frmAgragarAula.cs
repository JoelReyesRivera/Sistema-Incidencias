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
    public partial class frmAgregarAulas : Form
    {
        Jefe jefe;
        public String Usuario;
        ManejaAulas manejadoraAulas;

        public frmAgregarAulas(String usuario)
        {
            InitializeComponent();
            Usuario = usuario;
            manejadoraAulas = new ManejaAulas();
        }

        private void frmAgregarAulas_Load(object sender, EventArgs e)
        {
            jefe = ManejaUsuario.GetJefe(Usuario);
            txtUsuario.Text = jefe.Usuario;
            List<String> lista = manejadoraAulas.ObtenerAulasDisponibles();
            if (lista.Count == 0)
            {
                MessageBox.Show("NO HAY AULAS DISPONIBLES", "ERROR AL ASIGNAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            foreach (var item in lista)
            {
                cmbAulas.Items.Add(item);
            }
            cmbAulas.SelectedIndex = 0;
        }

        private void btnAsignarAula_Click(object sender, EventArgs e)
        {
            String aula = cmbAulas.SelectedItem.ToString();
            manejadoraAulas.AsignarAula(aula,jefe.Usuario);
            this.Close();
        }
    }
}
