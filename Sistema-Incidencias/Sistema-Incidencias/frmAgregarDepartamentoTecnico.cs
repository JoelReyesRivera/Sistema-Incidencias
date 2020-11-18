using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaBD;
using System.Data.SqlClient;

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
           // if (NombreDeptoTecnico == ManejaDepartamento.ObtenerNombreDepartamentoTecnico().ToString())
           if(validaDepTec(NombreDeptoTecnico))
            {
                MessageBox.Show("DEPARTAMENTO YA REGISTRADO", "ADMINISTRADOR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                ManejaDepartamento.AgregarDeptoTecnico(NombreDeptoTecnico);
                this.Close();
            }
        }

        public bool validaDepTec(string nombre)
        {

            bool encontro = false;
            String Conexion = Utileria.GetConnectionString();
            SqlConnection Conecta = UsoBD.ConectaBD(Conexion);
            if (Conecta == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();

            }
            string Query = "SELECT NOMBRE FROM DEPARTAMENTO_TECNICO WHERE NOMBRE = " + "'" + nombre + "'";
            SqlDataReader Lector = null;
            Lector = UsoBD.Consulta(Query, Conecta);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL REALIZAR LA CONSULTA");
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();

            }
            if (Lector.HasRows)
            {
                if (Lector.Read())

                {
                    if (nombre == Lector.GetValue(0).ToString())
                    {
                        encontro = true;
                    }

                }

            }
            Conecta.Close();
            return encontro;
        }
    }
}
