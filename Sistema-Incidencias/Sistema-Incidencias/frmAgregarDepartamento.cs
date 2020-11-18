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
    

    public partial class frmAgregarDepartamento : Form
    {
        public frmAgregarDepartamento()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String NombreDepto = txtNombreDepto.Text;
            if(NombreDepto == ManejaDepartamento.ObtenerNombreDepartamento().ToString())
            {
                MessageBox.Show("NOMBRE YA REGISTRADO", "ADMINISTRADOR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else
            {
                ManejaDepartamento.AgregarDepto(NombreDepto);
                this.Close();
            }
               
            
           
        }
    }
}
