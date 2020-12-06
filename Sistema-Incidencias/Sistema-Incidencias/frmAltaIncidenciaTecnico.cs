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
    public partial class frmAltaIncidenciaTecnico : Form
    {
        string Usuario;
        public frmAltaIncidenciaTecnico(string Usuario)
        {
            InitializeComponent();
            this.Usuario = Usuario;
        }

        private void AltaIncidenciaTecnico_Load(object sender, EventArgs e)
        {
            List<int> Id = ManejaIncidencia.ObtenerIncidencia();
            cmbIncidencia.Items.Clear();
            List<string> Tecnico = ManejaIncidencia.ObtenerTecnico();
            cmbTecnico.Items.Clear();

            foreach (var ID in ManejaIncidencia.ObtenerIncidencia() )
            {
                cmbIncidencia.Items.Add(ID);
            }
            foreach (var T in ManejaIncidencia.ObtenerTecnico())
            {
                cmbTecnico.Items.Add(T);
            }
            lblNumero.Text = cmbIncidencia.Items.Count.ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(cmbIncidencia.SelectedItem.ToString());
            string Administrador = Usuario;
            string Tecnico = cmbTecnico.SelectedItem.ToString();
            DateTime Fecha = DateTime.Now;
            ManejaIncidencia.AñadirIncidenciaTecnico(ID, Administrador, Tecnico, Fecha);
            this.Close();
          
        }
    }
}
