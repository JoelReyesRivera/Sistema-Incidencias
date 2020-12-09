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
    public partial class frmAgregaDispositivo : Form
    {
        public frmAgregaDispositivo()
        {
            InitializeComponent();
            cmbProveedor.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
            cmbAula.SelectedIndex = -1;
            dtpGarantíaExpira.MinDate = System.DateTime.Now;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregaDispositivo_Load(object sender, EventArgs e)
        {
            LoadComboBoxs();
        }
        private void LoadComboBoxs()
        {
            LoadCMBProveedor();
            LoadCMBMarca();
            LoadCMBAula();
        }
        private void LoadCMBProveedor()
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
            string Query = "SELECT NOMBRE FROM PROVEEDOR";
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
                cmbProveedor.Items.Clear();
                while (Lector.Read())
                    cmbProveedor.Items.Add(Lector.GetValue(0).ToString());
            }
            Conecta.Close();
        }
        private void LoadCMBMarca()
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
            string Query = "SELECT NOMBRE FROM MARCA";
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
                cmbMarca.Items.Clear();
                while (Lector.Read())
                    cmbMarca.Items.Add(Lector.GetValue(0).ToString());
            }
            Conecta.Close();
        }
        private void LoadCMBAula()
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
            string Query = "SELECT DESCRIPCION FROM AULA";
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
                cmbAula.Items.Clear();
                while (Lector.Read())
                    cmbAula.Items.Add(Lector.GetValue(0).ToString());
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

            if (!ValidaDatos())
                return;

            string NoSerie = txtNoSerie.Text.Trim();
            string Proveedor = cmbProveedor.Text.Trim();
            string GarantíaExpira = dtpGarantíaExpira.Value.ToString("yyyy-MM-dd");
            string Modelo = txtModelo.Text.Trim();
            string Descripcion = txtDescripcion.Text.Trim();
            string Marca = cmbMarca.SelectedItem.ToString();
            string Aula = cmbAula.SelectedItem.ToString();
            int R;

            string Query = "SPAgregaDispositivo";
            SqlCommand cmd = new SqlCommand(Query, Conecta);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOSERIE", NoSerie);
            cmd.Parameters.AddWithValue("@PROVEEDOR", Proveedor);
            cmd.Parameters.AddWithValue("@GARANTIA", GarantíaExpira);
            cmd.Parameters.AddWithValue("@MODELO", Modelo);
            cmd.Parameters.AddWithValue("@DESCRIPCION", Descripcion);
            cmd.Parameters.AddWithValue("@MARCA", Marca);
            cmd.Parameters.AddWithValue("@AULA", Aula);


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
                    MessageBox.Show("DISPOSITIVO AGREGADO CORRECTAMENTE","AGREGADO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;
                case 1:
                    MessageBox.Show("EL NÚMERO DE SERIE ESTÁ REGISTRADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show("ERROR INTERNO EN LA TRANSACCIÓN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            Limpia();
            Conecta.Close();
        }
        private void Limpia()
        {
            txtNoSerie.Text = "";
            txtDescripcion.Text = "";
            txtModelo.Text = "";
            cmbAula.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
            dtpGarantíaExpira.Value = System.DateTime.Now;
        }
        private bool ValidaDatos()
        {
            if (txtNoSerie.Text.Length == 0)
            {
                MessageBox.Show("ERROR","NÚMERO DE SERIE VACÍO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            if (cmbProveedor.SelectedIndex==-1)
            {
                MessageBox.Show("ERROR", "PROVEEDOR NO SELECCIONADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtModelo.Text.Length==0)
            {
                MessageBox.Show("ERROR", "MODELO VACÍO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtDescripcion.Text.Length == 0)
            {
                MessageBox.Show("ERROR", "DESCRIPCION VACÍA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbMarca.SelectedIndex==-1)
            {
                MessageBox.Show("ERROR", "MARCA NO SELECCIONADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbAula.SelectedIndex == -1)
            {
                MessageBox.Show("ERROR", "AULA NO SELECCIONADA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
