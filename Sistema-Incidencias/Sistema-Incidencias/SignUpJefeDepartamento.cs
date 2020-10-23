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
    public partial class SignUpJefeDepartamento : Form
    {
        public SignUpJefeDepartamento()
        {
            InitializeComponent();
        }

        private void SignUpJefeDepartamento_Load(object sender, EventArgs e)
        {
            List<String> departamentos = ManejaDepartamento.ObtenerDepartamentos();
            cmbDepartamento.Items.Clear();
            cmbDepartamento.SelectedItem = 0;

            foreach (var dep in departamentos)
            {
                cmbDepartamento.Items.Add(dep);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;

           
            if (!ValidaDatos())
                return;
            
            if (validaUsuario(usuario)==true)
                
            {
                MessageBox.Show("EL USUARIO YA ESTÁ REGISTRADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
 
            }
            else
            {
                 ManejaUsuario.AñadirJefe(txtUsuario.Text, txtPassword.Text, ManejaDepartamento.ObtenerDepartamentoId(cmbDepartamento.SelectedItem.ToString()));
            
            }
           
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool ValidaDatos()
        {
            String Usuario = txtUsuario.Text.Trim();
            String Password = txtPassword.Text.Trim();

            if (String.IsNullOrEmpty(Usuario))
            {
                MessageBox.Show("NO HA PROPORCIONADO EL USUARIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (String.IsNullOrEmpty(Password))
            {
                MessageBox.Show("NO HA PROPORCIONADO UNA CONTRASEÑA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbDepartamento.SelectedIndex==0)
            {
                MessageBox.Show("NO HA SELECCIONADO EL TIPO DE DEPARTAMENTO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string Query = "SELECT USUARIO FROM JEFE_DEPARTAMENTO WHERE USUARIO = " + "'" + nombre + "'";
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
                    if (nombre== Lector.GetValue(0).ToString())
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
