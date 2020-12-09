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
    public partial class frmFinalizarIncidencia : Form
    {
        private String Usuario;
        public frmFinalizarIncidencia(String Usuario)
        {
            InitializeComponent();
            this.Usuario = Usuario;
            cmbIncidencias.SelectedIndex = -1;
            cmbDispositvosCambio.Enabled = false;
        }

        private void frmIncidenciaConcluida_Load(object sender, EventArgs e)
        {
            List<int> Id = ManejaIncidencia.ObtenerIncidenciaTec(Usuario);
            cmbIncidencias.Items.Clear();

            foreach (var ID in ManejaIncidencia.ObtenerIncidenciaTec(Usuario))
                cmbIncidencias.Items.Add(ID);
            LoadDispositivos();
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

            if (!valida())
                return;

            int ID = Convert.ToInt32(cmbIncidencias.SelectedItem.ToString());
            string Nuevo_Dispositivo = "";


            int Tipo_Solucion = 0;
            if (rbCambio.Checked)
            {
                Tipo_Solucion = 1;
                Nuevo_Dispositivo = cmbDispositvosCambio.SelectedItem.ToString();
                
            }
            string Query = "SPFinalizaIncidencia";
            SqlCommand cmd = new SqlCommand(Query, Conecta);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_INCIDENCIA", ID);
            cmd.Parameters.AddWithValue("@SOLUCIONADO_POR", Usuario);
            cmd.Parameters.AddWithValue("@TIPO_SOLUCION", Tipo_Solucion);
            cmd.Parameters.AddWithValue("@NUEVO_DISPOSITIVO", Nuevo_Dispositivo);


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
            int R = Convert.ToInt32(returnParameter.Value);
            switch (R)
            {
                case 0:
                    MessageBox.Show("INCIDENCIA FINALIZADA CORRECTAMENTE", "AGREGADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            cmbIncidencias.SelectedIndex = -1;
            cmbDispositvosCambio.SelectedIndex = -1;
            txtIncidencia.Text = "";
            txtNumeroSerie.Text = "";
            rbReparacion.Checked = true;
            cmbDispositvosCambio.Enabled = false;
        }
        private bool valida()
        {
            if (cmbIncidencias.SelectedIndex < 0)
            {
                MessageBox.Show("NO SE HA SELECCIONADO UNA INCIDENCIA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (rbCambio.Checked)
            {
                if (cmbDispositvosCambio.SelectedItem.ToString() == txtNumeroSerie.Text)
                {
                    MessageBox.Show("NO SE PUEDE SELECCIONAR EL MISMO DISPOSITIVO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (cmbDispositvosCambio.SelectedIndex < 0)
                {
                    MessageBox.Show("NO SE HA SELECCIONADO NUEVO DISPOSITIVO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }

            return true;
        }

        private void cmbIncidencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIncidencias.SelectedIndex == -1)
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
            string Query = "SELECT DISPOSITIVO, INCIDENCIA FROM VW_Incidencias WHERE ID = "+cmbIncidencias.SelectedItem.ToString();
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
                    txtNumeroSerie.Text = Lector.GetValue(0).ToString();
                    txtIncidencia.Text = Lector.GetValue(1).ToString();
                }
            }
            Conecta.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReparacion.Checked)
                cmbDispositvosCambio.Enabled = false;
            else
            {
                cmbDispositvosCambio.Enabled = true;
                cmbDispositvosCambio.SelectedIndex = 0;
            }

        }
        private void LoadDispositivos()
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
            string Query = "SELECT NUMERO_SERIE FROM DISPOSITIVO";
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
                    cmbDispositvosCambio.Items.Add(Lector.GetValue(0).ToString());
                }
            }
            Conecta.Close();
        }

        private void cmbDispositvosCambio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbCambio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReparacion.Checked)
                cmbDispositvosCambio.Enabled = false;
            else
            {
                cmbDispositvosCambio.Enabled = true;
                cmbDispositvosCambio.SelectedIndex = 0;
            }
        }
    }
}
