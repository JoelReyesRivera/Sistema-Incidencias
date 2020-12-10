using LibreriaBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Incidencias
{
    public partial class frmConsultasConcluidasAdmin : Form
    {
        public frmConsultasConcluidasAdmin()
        {
            InitializeComponent();
        }

        private void frmConsultasConcluidasAdmin_Load(object sender, EventArgs e)
        {
            string Conexion = Utileria.GetConnectionString();
            SqlConnection Conecta = UsoBD.ConectaBD(Conexion);
            if (Conecta == null)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return;
            }
            string Query = "SELECT * FROM VW_IncidenciasConcluidas";
            SqlDataReader Lector = null;
            Lector = UsoBD.Consulta(Query, Conecta);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL REALIZAR CONSULTA");
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return;
            }
            if (Lector.HasRows)
            {
                dgvIncidencias.Rows.Clear();
                while (Lector.Read())
                {

                    string ID = Lector.GetValue(0).ToString();
                    string Dispositivo = Lector.GetValue(1).ToString();
                    string Marca = Lector.GetValue(2).ToString();
                    string Modelo = Lector.GetValue(3).ToString();
                    string Ubicado = Lector.GetValue(4).ToString();
                    string Incidencia = Lector.GetValue(5).ToString();
                    string Reporto = Lector.GetValue(6).ToString();
                    string FechaRep = Lector.GetValue(7).ToString();
                    string FechaSol = Lector.GetValue(8).ToString();
                    string Estatus = Lector.GetValue(9).ToString();
                    string Soluciono = Lector.GetValue(10).ToString();
                    string tipoSolucion = Lector.GetValue(11).ToString();

                    dgvIncidencias.Rows.Add(ID, Dispositivo, Marca, Modelo, Ubicado, Incidencia, Reporto, FechaRep, FechaSol, Estatus, Soluciono, tipoSolucion);
                }
            }
            Conecta.Close();
        }
    }
}
