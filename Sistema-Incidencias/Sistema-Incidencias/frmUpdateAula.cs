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
    public partial class frmUpdateAula : Form
    {
        ManejaAulas manejaAulas;
        public frmUpdateAula()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string Descripcion = txtDescripcion.Text;
            string JefeDepto = cmbJefeDepto.Text;
            if (Descripcion == ManejaAulas.ObtenerDescripcionAula().ToString())
            {
                MessageBox.Show("DESCRIPCION YA REGISTRADA", "ADMINISTRADOR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                ManejaAulas.AgregarAula(Descripcion, JefeDepto);
                this.Close();
            }
        }

        private void frmUpdateAula_Load(object sender, EventArgs e)
        {
            List<String> departamentos = ManejaUsuario.ObtenerJefeDepto();
            cmbJefeDepto.Items.Clear();

            foreach (var dep in departamentos)
            {
                cmbJefeDepto.Items.Add(dep);
            }
        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }
    }
}
