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
    public partial class frmAgregarDepartamentoTecnico : Form
    {
        public frmAgregarDepartamentoTecnico()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String NombreDeptoTecnico = txtNombreDeptoTecnico.Text;
            if (NombreDeptoTecnico == ManejaDepartamento.ObtenerNombreDepartamentoTecnico().ToString())
            {
                MessageBox.Show("NOMBRE YA REGISTRADO", "ADMINISTRADOR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                ManejaDepartamento.AgregarDeptoTecnico(NombreDeptoTecnico);
                this.Close();
            }
        }
    }
}
