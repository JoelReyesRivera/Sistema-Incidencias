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
    public partial class frmIncidenciaConcluida : Form
    {
        private String Usuario;
        public frmIncidenciaConcluida(String Usuario)
        {
            InitializeComponent();
            this.Usuario = Usuario;
            cmbIncidencias.SelectedIndex = -1;
        }

        private void frmIncidenciaConcluida_Load(object sender, EventArgs e)
        {
            List<int> Id = ManejaIncidencia.ObtenerIncidenciaTec(Usuario);
            cmbIncidencias.Items.Clear();
            txtNombreTec.Text = Usuario;

            foreach (var ID in ManejaIncidencia.ObtenerIncidenciaTec(Usuario))
            {
                cmbIncidencias.Items.Add(ID);
            }

           /* foreach (var T in ManejaIncidencia.ObtenerTecnico())
            {
                cmbTecnico.Items.Add(T);
            }
            */

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(cmbIncidencias.SelectedItem.ToString());
            string Tecnico = Usuario;
            DateTime Fecha = Convert.ToDateTime(dateTimeFecha.Value.ToString());
            ManejaIncidencia.finalizarIncidenciaTecnico(ID,Fecha, Tecnico);
            this.Close();
        }
    }
}
