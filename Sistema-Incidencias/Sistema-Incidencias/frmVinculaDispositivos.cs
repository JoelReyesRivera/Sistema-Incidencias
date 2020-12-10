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
    public partial class frmVinculaDispositivos : Form
    {
        public frmVinculaDispositivos()
        {
            InitializeComponent();
        }

        private void frmVinculaDispositivos_Load(object sender, EventArgs e)
        {
            cmbDispositivo1.Items.Clear();
            cmbDispositivo2.Items.Clear();
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
            string Query = "SELECT NUMERO_SERIE FROM DISPOSITIVO WHERE NUMERO_SERIE NOT IN(SELECT NUMERO_SERIE_COMPONENTE FROM COMPONENTE)";
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
                    cmbDispositivo1.Items.Add(Lector.GetValue(0).ToString());
                    cmbDispositivo2.Items.Add(Lector.GetValue(0).ToString());
                }
            }
            Conecta.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!valida())
            {
                return;
            }
            SqlConnection connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            if (connection == null)
            {
                foreach (SqlError item in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(item.Message);
                }
            }
            string command = "INSERT INTO COMPONENTE(NUMERO_SERIE_PADRE,NUMERO_SERIE_COMPONENTE)";
            command += "VALUES(@NUMERO_SERIE_PADRE,@NUMERO_SERIE_COMPONENTE)";
            SqlCommand comandoInsersion = new SqlCommand(command, connection);
            comandoInsersion.Parameters.AddWithValue("@NUMERO_SERIE_PADRE", cmbDispositivo1.SelectedItem.ToString());
            comandoInsersion.Parameters.AddWithValue("@NUMERO_SERIE_COMPONENTE", cmbDispositivo2.SelectedItem.ToString());
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
            MessageBox.Show("DISPOSITIVO VINCULADO", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool valida()
        {
            if (cmbDispositivo1.SelectedItem.ToString() == cmbDispositivo2.SelectedItem.ToString())
            {
                MessageBox.Show("NO SE PUEDE SELECCIONAR EL MISMO DISPOSITIVO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbDispositivo1.SelectedIndex==-1 || cmbDispositivo2.SelectedIndex == -1)
            {
                MessageBox.Show("SELECCIONAR DISPOSITIVOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void cmbDispositivo1_SelectedIndexChanged(object sender, EventArgs e)
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
            string Query = "SELECT DESCRIPCION, MODELO FROM VW_Dispositivos WHERE NUMERO_SERIE = "+cmbDispositivo1.SelectedItem.ToString();
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
                    txtDescripcion.Text=(Lector.GetValue(0).ToString());
                    txtModelo.Text=(Lector.GetValue(1).ToString());
                }
            }
            Conecta.Close();
        }

        private void cmbDispositivo2_SelectedIndexChanged(object sender, EventArgs e)
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
            string Query = "SELECT DESCRIPCION, MODELO FROM VW_Dispositivos WHERE NUMERO_SERIE = " + cmbDispositivo2.SelectedItem.ToString();
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
                    txtDescripcion2.Text = (Lector.GetValue(0).ToString());
                    txtModelo2.Text = (Lector.GetValue(1).ToString());
                }
            }
            Conecta.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbDispositivo1.SelectedIndex = -1;
            cmbDispositivo2.SelectedIndex = -1;
            txtModelo.Text = "";
            txtModelo2.Text = "";
            txtDescripcion.Text = "";
            txtDescripcion2.Text = "";
        }
    }
}
