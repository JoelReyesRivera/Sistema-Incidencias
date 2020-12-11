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
    public partial class frmConsultaAulasAdmin : Form
    {
        ManejaAulas aulas;
        public frmConsultaAulasAdmin()
        {
            InitializeComponent();
            aulas = new ManejaAulas();
        }

        private void frmConsultaAulasAdmin_Load(object sender, EventArgs e)
        {
            List<Aula> lista = aulas.ObtenerAulasAdmin();
            if (lista.Count == 0)
            {
                MessageBox.Show("NO HAY AULAS ASIGNADAS", "ERROR AL CONSULTAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            foreach (var item in lista)
            {
                dataGridAulas.Rows.Add(item.ID, item.Descripcion, item.JefeDepartamento);
            }
        }
    }
}
