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
    public partial class frmAltaIncidencia : Form
    {
        private String JEFE_DEPTO;

        public frmAltaIncidencia(String JEFE_DEPTO)
        {
            InitializeComponent();
            this.JEFE_DEPTO = JEFE_DEPTO;
        }

        private void frmAltaIncidencia_Load(object sender, EventArgs e)
        {
            LoadCMBDispositivos();
        }
        private void LoadCMBDispositivos()
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
            string Query = "SELECT NUMERO_SERIE FROM VW_Dispositivos WHERE UBICACION != 'ALMACÉN'";
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
                cmbDispositivos.Items.Clear();
                while (Lector.Read())
                    cmbDispositivos.Items.Add(Lector.GetValue(0).ToString());
            }
            Conecta.Close();
        }

        private void cmbDispositivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDispositivos.SelectedIndex == -1)
                return;

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
            string Numero_serie = cmbDispositivos.SelectedItem.ToString();
            string Query = "SELECT M.NOMBRE,D.MODELO,D.DESCRIPCION,A.DESCRIPCION FROM DISPOSITIVO D";
            Query += " INNER JOIN MARCA M ON D.MARCA = M.ID";
            Query += " INNER JOIN AULA A ON A.ID = D.AULA";
            Query += " WHERE NUMERO_SERIE = '" + Numero_serie +"'";
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
                    txtMarca.Text = Lector.GetValue(0).ToString();
                    txtModelo.Text = Lector.GetValue(1).ToString(); 
                    txtDescr.Text = Lector.GetValue(2).ToString();
                    txtAula.Text = Lector.GetValue(3).ToString();
                }
            }
            Conecta.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpia();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
            DialogResult Res = MessageBox.Show("¿DESEA GUARDAR?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Res == DialogResult.No)
                return;

            if (!validaDatos())
                return;

            string NoSerie = cmbDispositivos.SelectedItem.ToString();
            string Descripcion = txtDescripcion.Text.Trim();
            int R;

            string Query = "SPAgregaIncidencia";
            SqlCommand cmd = new SqlCommand(Query, Conecta);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOSERIE", NoSerie);
            cmd.Parameters.AddWithValue("@JEFE_DEPTO", JEFE_DEPTO);
            cmd.Parameters.AddWithValue("@DESCRIPCION", Descripcion);

            SqlParameter returnParameter = cmd.Parameters.Add("Res", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show("ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (SqlError Error in Ex.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
            }
            R = Convert.ToInt32(returnParameter.Value);
            switch (R)
            {
                case 0:
                    MessageBox.Show("INCIDENCIA REGISTRADA", "REGISTRADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("ERROR INTERNO EN LA TRANSACCIÓN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            Limpia();
            Conecta.Close();

        }
        private bool validaDatos()
        {
            if (cmbDispositivos.SelectedIndex == -1)
            {
                MessageBox.Show("ERROR", "DISPOSITIVO NO SELECCIONADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtDescr.Text.Length == 0)
            {
                MessageBox.Show("ERROR", "DESCRIPCION VACÍA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void Limpia()
        {
            cmbDispositivos.SelectedIndex = -1;
            txtAula.Text = "";
            txtDescr.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtDescripcion.Text = "";
        }
    }
}
