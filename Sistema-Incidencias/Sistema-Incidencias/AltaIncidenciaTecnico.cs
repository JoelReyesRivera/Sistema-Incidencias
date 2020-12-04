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
    public partial class AltaIncidenciaTecnico : Form
    {
        public AltaIncidenciaTecnico()
        {
            InitializeComponent();
        }

        private void AltaIncidenciaTecnico_Load(object sender, EventArgs e)
        {
            List<int> Id = ManejaIncidencia.ObtenerIncidencia();
            cmbIncidencia.Items.Clear();
            List<string> Admin = ManejaIncidencia.ObtenerAdministrador();
            cmbAdministrador.Items.Clear();
            List<string> Tecnico = ManejaIncidencia.ObtenerTecnico();
            cmbTecnico.Items.Clear();



            foreach (var ID in ManejaIncidencia.ObtenerIncidencia() )
            {
                cmbIncidencia.Items.Add(ID);
            }
            foreach (var A in ManejaIncidencia.ObtenerAdministrador())
            {
                cmbAdministrador.Items.Add(A);
            }

            foreach (var T in ManejaIncidencia.ObtenerTecnico())
            {
                cmbTecnico.Items.Add(T);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(cmbIncidencia.SelectedItem.ToString());
            string Administrador = cmbAdministrador.SelectedItem.ToString();
            string Tecnico = cmbTecnico.SelectedItem.ToString();
            DateTime Fecha = Convert.ToDateTime(dateTimeFecha.Value.ToString());
            ManejaIncidencia.AñadirIncidenciaTecnico(ID, Administrador, Tecnico, Fecha);
            this.Close();
          
        }

        private void dateTimeFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
