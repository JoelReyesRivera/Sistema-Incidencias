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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void PantallaIincio_Load(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregaDispositivo A = new AgregaDispositivo();
            A.ShowDialog();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAgregarDepartamento AgregarDepto = new frmAgregarDepartamento();
            AgregarDepto.ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAgregarDepartamentoTecnico AgregarDeptoTecnico = new frmAgregarDepartamentoTecnico();
            AgregarDeptoTecnico.ShowDialog();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmUpdateAula Update = new frmUpdateAula();
            Update.ShowDialog();
        }
    }
}
