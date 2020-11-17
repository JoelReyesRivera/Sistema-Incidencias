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
    public partial class frmConsultarAulasAsignadas : Form
    {
        String usuario;
        ManejaAulas aulas;
        public frmConsultarAulasAsignadas(string usuario)
        {
            this.usuario = usuario;
            aulas = new ManejaAulas();
            InitializeComponent();
        }

        private void frmConsultarAulasAsignadas_Load(object sender, EventArgs e)
        {
            List<Aula> lista = aulas.ObtenerAulasAsignadas(usuario);
            if (lista.Count == 0)
            {
                MessageBox.Show("NO HAY AULAS ASIGNADAS", "ERROR AL CONSULTAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            foreach (var item in lista)
            {
                dataGridAulas.Rows.Add(item.ID,item.Descripcion);
            }
        }
    }
}
