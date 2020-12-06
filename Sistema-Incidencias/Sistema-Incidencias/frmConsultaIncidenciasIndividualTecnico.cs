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
    public partial class frmConsultaIncidenciasIndividualTecnico : Form
    {
        private String Usuario;
        public frmConsultaIncidenciasIndividualTecnico(string Usuario)
        {
            InitializeComponent();
            this.Usuario = Usuario;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmConsultaIncidenciasIndividualTecnico_Load(object sender, EventArgs e)
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
            string Query = "SELECT ID_INCIDENCIA FROM VW_IncidenciasAsignadas WHERE TECNICO='" + Usuario+"'";
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
                while (Lector.Read())
                    cmbIncidencias.Items.Add(Lector.GetValue(0).ToString());
            }
            Conecta.Close();
        
    }
        private void cmbIncidencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIncidencias.SelectedIndex == -1)
                return;

            string ID = cmbIncidencias.SelectedItem.ToString();

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
            string Query = "SELECT NUMERO_SERIE,MARCA,MODELO,AULA,FECHA,ESTATUS,DETALLE FROM VW_IncidenciasAsignadas WHERE TECNICO = " + "'"+Usuario+"'"+" AND ID_INCIDENCIA =" + ID;
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
                while (Lector.Read())
                {
                    txtDispositivo.Text = Lector.GetValue(0).ToString();
                    txtMarca.Text = Lector.GetValue(1).ToString();
                    txtModelo.Text = Lector.GetValue(2).ToString();
                    txtUbicado.Text = Lector.GetValue(3).ToString();
                    txtFecha.Text = Lector.GetValue(4).ToString();
                    txtEstatus.Text = Lector.GetValue(5).ToString();
                    txtIncidencia.Text = Lector.GetValue(6).ToString();

                }
            }
            Conecta.Close();
        }

    }
}
