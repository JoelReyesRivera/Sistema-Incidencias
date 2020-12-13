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
    public partial class frmAutorizarCambio : Form
    {
        public frmAutorizarCambio()
        {
            InitializeComponent();
        }

        private void frmAutorizarCambio_Load(object sender, EventArgs e)
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
            string Query = "SELECT ID FROM CAMBIO_COMPONENTE WHERE APROBADO = 0";
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
                cmbCambio.Items.Clear();
                while (Lector.Read())
                    cmbCambio.Items.Add(Lector.GetValue(0).ToString());
            }
            Conecta.Close();
        }

        private void cmbCambio_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cambio = cmbCambio.SelectedItem.ToString();
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
            string Query = "SELECT NUMERO_SERIE FROM CAMBIO_COMPONENTE C INNER JOIN DISPOSITIVO D ON C.ID_NUEVOCOMPONENTE = D.NUMERO_SERIE WHERE C.ID =" + cambio;
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
                    txtDispositivo.Text =Lector.GetValue(0).ToString();
            }
            Conecta.Close();
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            if (connection == null)
            {
                foreach (SqlError item in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(item.Message);
                }
            }
            string command = "UPDATE CAMBIO_COMPONENTE SET APROBADO=1 WHERE ID = @id ";
            SqlCommand comandoInsersion = new SqlCommand(command, connection);
            comandoInsersion.Parameters.AddWithValue("@id", cmbCambio.SelectedItem.ToString());
            try
            {
                comandoInsersion.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            connection.Close();
            MessageBox.Show("ACTUALIZADO EXITOSAMENTE", "JEFE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
