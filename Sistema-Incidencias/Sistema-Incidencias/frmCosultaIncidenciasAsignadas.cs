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
    public partial class frmCosultaIncidenciasAsignadas : Form
    {
        public frmCosultaIncidenciasAsignadas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            string Query = "SELECT ID_INCIDENCIA,ADMINISTRADOR,NUMERO_SERIE,MARCA,MODELO,AULA,FECHA,ESTATUS,TECNICO,DETALLE FROM VW_IncidenciasAsignadas";
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
                    string Admin = Lector.GetValue(1).ToString();
                    string Dispositivo = Lector.GetValue(2).ToString();
                    string Marca = Lector.GetValue(3).ToString();
                    string Modelo = Lector.GetValue(4).ToString();
                    string Ubicado = Lector.GetValue(5).ToString();
                    string Fecha = Lector.GetValue(6).ToString();
                    string Estatus = Lector.GetValue(7).ToString();
                    string Tecnico = Lector.GetValue(8).ToString();
                    string Incidencia = Lector.GetValue(9).ToString();
                    dgvIncidencias.Rows.Add(ID,Admin,Dispositivo,Marca,Modelo,Ubicado,Fecha,Estatus,Tecnico,Incidencia);
                }
            }
            Conecta.Close();
        }
    }
}
