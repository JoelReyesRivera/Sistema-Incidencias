using LibreriaBD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Incidencias
{
    public class ManejaUsuario
    {
        public bool Autenticado(String nombre, String password)
        {
            bool autenticado = false;
            SqlConnection connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            if (connection == null)
            {
                foreach (SqlError item in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(item.Message);
                }
            }
            String comando = "SELECT PASSWORD FROM USUARIO WHERE NOMBRE = " + nombre;
            SqlDataReader lector = null;
            lector = UsoBD.Consulta(comando, connection);
            SqlCommand sqlCommand = new SqlCommand(comando, connection);
            try
            {
                lector = sqlCommand.ExecuteReader();
            }
            catch (SqlException ex)
            {
                foreach (SqlError item in ex.Errors)
                {
                    MessageBox.Show(item.Message.ToString());
                }
                connection.Close();
                return false;
            }
            if (lector.Read())
            {
                if (password == lector.GetValue(0).ToString())
                {
                    autenticado = true;
                }

            }
            connection.Close();
            return autenticado;
        }

        public static bool AñadirAdmin(String usuario, String password)
        {
            SqlConnection connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            if (connection == null)
            {
                foreach (SqlError item in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(item.Message);
                }
            }
            string command = "INSERT INTO ADMINISTRADOR(Usuario, Password)";
            command += " VALUES(@Usuario, @password)";
            SqlCommand comandoInsersion = new SqlCommand(command, connection);
            comandoInsersion.Parameters.AddWithValue("@Usuario", usuario);
            comandoInsersion.Parameters.AddWithValue("@password", password);
            try
            {
                comandoInsersion.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                 connection.Close();
                return false;
            }
            connection.Close();
            MessageBox.Show("GUARDADO EXITOSAMENTE", "ADMINISTRADOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public static bool AñadirJefe(String usuario, String password, int departamento)
        {
            SqlConnection connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            if (connection == null)
            {
                foreach (SqlError item in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(item.Message);
                }
            }
            string command = "INSERT INTO JEFE_DEPARTAMENTO(Usuario, Password, Departamento)";
            command += " VALUES(@Usuario, @password, @departamento)";
            SqlCommand comandoInsersion = new SqlCommand(command, connection);
            comandoInsersion.Parameters.AddWithValue("@Usuario", usuario);
            comandoInsersion.Parameters.AddWithValue("@password", password);
            comandoInsersion.Parameters.AddWithValue("@departamento", departamento);

            try
            {
                comandoInsersion.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return false;
            }
            connection.Close();
            MessageBox.Show("GUARDADO EXITOSAMENTE", "ADMINISTRADOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
        public static bool AñadirTecnico(String usuario, String password, int departamentoTecnico)
        {
            SqlConnection connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            if (connection == null)
            {
                foreach (SqlError item in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(item.Message);
                }
            }
            string command = "INSERT INTO TECNICO(USUARIO, PASSWORD, DEPARTAMENTO_TECNICO)";
            command += " VALUES(@Usuario, @password, @departamentoTecnico)";
            SqlCommand comandoInsersion = new SqlCommand(command, connection);
            comandoInsersion.Parameters.AddWithValue("@Usuario", usuario);
            comandoInsersion.Parameters.AddWithValue("@password", password);
            comandoInsersion.Parameters.AddWithValue("@departamentoTecnico", departamentoTecnico);

            try
            {
                comandoInsersion.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return false;
            }
            connection.Close();
            MessageBox.Show("GUARDADO EXITOSAMENTE", "ADMINISTRADOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
    }
}
