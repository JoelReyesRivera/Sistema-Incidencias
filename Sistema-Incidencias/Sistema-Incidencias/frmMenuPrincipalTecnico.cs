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
    public partial class frmMenuPrincipalTecnico : Form
    {
        public String Usuario;
        public frmMenuPrincipalTecnico(String Usuario)
        {
            this.Usuario = Usuario;
            InitializeComponent();
        }

        private void actualizarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTecnico frm = new frmUpdateTecnico(Usuario);
            frm.ShowDialog();
        }

        private void periflToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaIncidenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void finalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFinalizarIncidencia finalizaIncidencia = new frmFinalizarIncidencia(Usuario);
            finalizaIncidencia.ShowDialog();
        }

        private void asignadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaIncidenciasIndividualTecnico vistaIndividualTec = new frmConsultaIncidenciasIndividualTecnico(Usuario);
            vistaIndividualTec.ShowDialog();
        }

        private void finalizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaIncidenciasTecnico todasincTec = new frmConsultaIncidenciasTecnico(Usuario);
            todasincTec.ShowDialog();
        }
    }
}
