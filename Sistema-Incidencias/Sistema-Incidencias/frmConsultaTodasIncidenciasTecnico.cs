using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibreriaBD;


namespace Sistema_Incidencias
{
    public partial class frmConsultaTodasIncidenciasTecnico : Form
    {
        private String Usuario;
        public frmConsultaTodasIncidenciasTecnico(String Usuario)
        {
            this.Usuario = Usuario;
            InitializeComponent();
        }

        private void frmConsultaTodasIncidenciasTecnico_Load(object sender, EventArgs e)
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
            string Query = "SELECT * FROM VW_IncidenciasTecnico WHERE TECNICO= " + "'" + Usuario + "'";
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
                dgvTodosIncidentesTec.Rows.Clear();
                while (Lector.Read())
                {

                    string ID = Lector.GetValue(1).ToString();
                    string Dispositivo = Lector.GetValue(2).ToString();
                    string Marca = Lector.GetValue(3).ToString();
                    string Modelo = Lector.GetValue(4).ToString();
                    string Ubicado = Lector.GetValue(5).ToString();
                    string Incidencia = Lector.GetValue(6).ToString();
                    string Reporta = Lector.GetValue(7).ToString();
                    string Fecha = Lector.GetValue(8).ToString();
                    string FechaSolucion= Lector.GetValue(9).ToString();
                    string Estatus = Lector.GetValue(10).ToString();

                    dgvTodosIncidentesTec.Rows.Add(ID, Dispositivo, Marca, Modelo, Ubicado, Incidencia,Reporta, Fecha,FechaSolucion, Estatus);
                }
            }
            Conecta.Close();
        }
    }
    
}
