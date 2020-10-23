using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaBD;

namespace Sistema_Incidencias
{
    public partial class SignUpTecnico : Form
    {
        public SignUpTecnico()
        {
            InitializeComponent();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void SignUpTecnico_Load(object sender, EventArgs e)
        {
            List<String> departamentos = ManejaDepartamento.ObtenerDepartamentoTecnico();
            cmbDepartamentoTecnico.Items.Clear();

            foreach (var dep in departamentos)
            {
                cmbDepartamentoTecnico.Items.Add(dep);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            if (!ValidaDatos())
                return;

            if (validaUsuario(usuario) == true)
            {
                MessageBox.Show("EL USUARIO YA ESTÁ REGISTRADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                ManejaUsuario.AñadirTecnico(txtUsuario.Text, txtPassword.Text, ManejaDepartamento.ObtenerDepartamentoTecnicoId(cmbDepartamentoTecnico.SelectedItem.ToString()));

            }
        }
        private bool ValidaDatos()
        {
            String Usuario = txtUsuario.Text.Trim();
            String Password = txtPassword.Text.Trim();
            String Departamento = cmbDepartamentoTecnico.SelectedItem.ToString();

            if (String.IsNullOrEmpty(Usuario))
            {
                MessageBox.Show("NO SE HA INGRESADO EL USUARIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (String.IsNullOrEmpty(Password))
            {
                MessageBox.Show("NO SE HA INGRESADO UNA CONTRASEÑA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (String.IsNullOrEmpty(Departamento))
            {
                MessageBox.Show("TIPO DE DEPARTAMENTO NO VÁLIDO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public bool validaUsuario(string nombre)
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
            string Query = "SELECT USUARIO FROM TECNICO WHERE USUARIO = " + "'" + nombre + "'";
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
                    if (nombre.Equals(Lector.GetValue(0).ToString()))
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
