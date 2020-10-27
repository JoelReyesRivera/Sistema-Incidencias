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
    public partial class frmSign_UpAdmin : Form
    {
        public frmSign_UpAdmin()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidaDatos())
                return;
            string usuario = txtUsuario.Text;
            if (validaUsuario(usuario) == true)
            {
                MessageBox.Show("EL USUARIO YA ESTÁ REGISTRADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                ManejaUsuario.AñadirAdmin(txtUsuario.Text, txtPassword.Text);
            }
        }
        

        private void frmSign_UpAdmin_Load(object sender, EventArgs e)
        {

        }

        private bool ValidaDatos()
        {
            String Usuario = txtUsuario.Text.Trim();
            String Password = txtPassword.Text.Trim();

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
            string Query = "SELECT USUARIO FROM ADMINISTRADOR WHERE USUARIO = " + "'" + nombre + "'";
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
                    encontro = true;
            }
            Conecta.Close();
            return encontro;
        }
    }
}
