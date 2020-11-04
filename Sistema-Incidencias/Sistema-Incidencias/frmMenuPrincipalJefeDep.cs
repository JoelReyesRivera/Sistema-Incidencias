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
    public partial class frmMenuPrincipalJefeDep : Form
    {
        public String Usuario;
        public frmMenuPrincipalJefeDep(string Usuario)
        {

            this.Usuario = Usuario;
            InitializeComponent();
        }

        private void actualizarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateJefe frm = new frmUpdateJefe(Usuario);
            frm.ShowDialog();
        }
    }
}
