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
            lector.Close();
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

        public static Tecnico GetTecnico(String nombre)
        {

            Tecnico tecnico = null;
            SqlConnection connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            if (connection == null)
            {
                foreach (SqlError item in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(item.Message);
                }
                return tecnico;
            }
            SqlDataReader lector = null;
            String comando = "SELECT USUARIO,PASSWORD,D.NOMBRE FROM TECNICO T INNER JOIN DEPARTAMENTO_TECNICO D ON T.DEPARTAMENTO_TECNICO = D.ID  WHERE T.USUARIO =  '" + nombre + "'";
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
                return tecnico;
            }
            if (lector.Read())
            {
                String usuario = lector.GetValue(0).ToString();
                String password = lector.GetValue(1).ToString();
                String departamento = lector.GetValue(2).ToString();
                tecnico = new Tecnico(usuario, password, departamento);
            }
            connection.Close();
            return tecnico;
        }
        public static bool ActualizarDepartamentoTecnico(String usuario, int departamentoTecnico)
        {
            SqlConnection connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            if (connection == null)
            {
                foreach (SqlError item in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(item.Message);
                }
            }
            string command = "UPDATE TECNICO SET DEPARTAMENTO_TECNICO = @departamentoTecnico WHERE USUARIO= @Usuario";
            SqlCommand comandoInsersion = new SqlCommand(command, connection);
            comandoInsersion.Parameters.AddWithValue("@Usuario", usuario);
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
            MessageBox.Show("ACTUALIZADO EXITOSAMENTE", "TECNICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }



        public static Jefe GetJefe(String nombre)
        {

            Jefe jefe = null;
            SqlConnection connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            if (connection == null)
            {
                foreach (SqlError item in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(item.Message);
                }
                return jefe;
            }
            
            SqlDataReader lector = null;
            String comando = "SELECT USUARIO, PASSWORD, D.NOMBRE FROM JEFE_DEPARTAMENTO J INNER JOIN DEPARTAMENTO D ON J.DEPARTAMENTO = D.ID  WHERE J.USUARIO = '" + nombre + "'";
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
                return jefe;
            }
            if (lector.Read())
            {
                String usuario = lector.GetValue(0).ToString();
                String password = lector.GetValue(1).ToString();
                String departamento = lector.GetValue(2).ToString();
                jefe = new Jefe(usuario, password, departamento);
            }
            connection.Close();
            return jefe;
        }

        public static bool ActualizarDepartamentoJefe(String usuario, int departamentoJefe)
        {
            SqlConnection connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            if (connection == null)
            {
                foreach (SqlError item in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(item.Message);
                }
            }
            string command = "UPDATE JEFE_DEPARTAMENTO SET DEPARTAMENTO = @departamentoJefe WHERE USUARIO= @Usuario";
            SqlCommand comandoInsersion = new SqlCommand(command, connection);
            comandoInsersion.Parameters.AddWithValue("@Usuario", usuario);
            comandoInsersion.Parameters.AddWithValue("@departamentoJefe", departamentoJefe);
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
            MessageBox.Show("ACTUALIZADO EXITOSAMENTE", "JEFE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }


    }

}
