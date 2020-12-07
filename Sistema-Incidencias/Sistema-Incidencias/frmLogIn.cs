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
        private String[] TipoUsuario = { "ADMINISTRADOR", "TECNICO", "JEFE_DEPARTAMENTO"};
        public FormMenuLogIn()
        {
            InitializeComponent();
            usuarios = new ManejaUsuario();
        }

        private void FormMenuLogIn_Load(object sender, EventArgs e)
        {

        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmMenuSignUp form = new frmMenuSignUp();
            form.ShowDialog();

        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (!ValidaDatos())
                return;

            String Usuario = txtUsuario.Text.Trim();
            String Password = txtPassword.Text.Trim();
            String TipoUsuario = "";
            bool Existe = false;

            for (int i = 0; i < 3; i++)
            {
                TipoUsuario = this.TipoUsuario[i].ToString();

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
                string Query = "SELECT COUNT(USUARIO) FROM " + TipoUsuario + " WHERE USUARIO =" + "'" + Usuario + "'" + " AND PASSWORD = " + "'" + Password + "'";
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
                        if (R>0){
                            Existe = true;
                            break;
                        }
                    }
                    if (Existe)
                        break;
                }
                
            }
            if (!Existe)
            {
                MessageBox.Show("LAS CREDENCIALES NO COINCIDEN CON NINGÚN USUARIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("SESIÓN INICIADA CORRECTAMENTE", "LOGIN CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NextPantalla(TipoUsuario, Usuario);
        }
        private void NextPantalla(string TipoUsuario, String Usuario)
        {
            switch (TipoUsuario)
            {
                case "JEFE_DEPARTAMENTO":
                    frmMenuPrincipalJefeDep JD = new frmMenuPrincipalJefeDep(Usuario);
                    JD.ShowDialog();
                    break;
                case "TECNICO":
                    frmMenuPrincipalTecnico menu = new frmMenuPrincipalTecnico(Usuario);
                    menu.ShowDialog();
                    break;
                case "ADMINISTRADOR":
                    frmMenuPrincipalAdmin A = new frmMenuPrincipalAdmin(Usuario);
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
            return true;
        }
    }
}
