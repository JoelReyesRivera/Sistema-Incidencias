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
    public partial class FormMenuLogIn : Form
    {
        public ManejaUsuario usuarios;
        public FormMenuLogIn()
        {
            usuarios = new ManejaUsuario();
            InitializeComponent();
        }

        private void FormMenuLogIn_Load(object sender, EventArgs e)
        {
            cmbTipoUsuario.SelectedIndex = 0;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MenuSignUp form = new MenuSignUp();
            form.ShowDialog();

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (!ValidaDatos())
                return;

            String Usuario = txtUsuario.Text.Trim();
            String Password = txtPassword.Text.Trim();
            String TipoUsuario = cmbTipoUsuario.SelectedItem.ToString().Trim();

            if (TipoUsuario == "JEFE DEPARTAMENTO")
                TipoUsuario = "JEFE_DEPARTAMENTO";

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
            string Query = "SELECT COUNT(USUARIO) FROM " + TipoUsuario + " WHERE USUARIO =" + "'" + Usuario + "'" + " AND PASSWORD = " + "'" +Password+ "'";
            SqlDataReader Lector = null;
            Lector = UsoBD.Consulta(Query, Conecta);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL REALIZAR LA CONSULTA");
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return;
            }
            if (Lector.HasRows)
            {
                int R;
                while (Lector.Read())
                {
                    R = int.Parse(Lector.GetValue(0).ToString());
                    if (R == 0)
                    {
                        MessageBox.Show("LAS CREDENCIALES NO COINCIDEN CON NINGÚN USUARIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Conecta.Close();
                        return;
                    }
                    MessageBox.Show("SESIÓN INICIADA CORRECTAMENTE","ÉXITO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Conecta.Close();
                    break;
                }
            }
            NextPantalla(TipoUsuario);
        }
        private void NextPantalla(string TipoUsuario)
        {
            switch (TipoUsuario)
            {
                case "JEFE_DEPARTAMENTO":
                    //PANTALLA DE JEFE DEPARTAMENTO
                    break;
                case "TECNICO":
                    //PANTALLA TECNICO
                    break;
                case "ADMINISTRADOR":
                    MenuAdmin A = new MenuAdmin();
                    A.ShowDialog();
                    break;
            }
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
            if (cmbTipoUsuario.SelectedIndex == 0)
            {
                MessageBox.Show("NO HA SELECCIONADO EL TIPO DE USUARIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            String TipoUsuario = cmbTipoUsuario.SelectedItem.ToString().Trim();
            if (String.IsNullOrEmpty(TipoUsuario))
            {
                MessageBox.Show("TIPO DE USUARIO NO VÁLIDO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
