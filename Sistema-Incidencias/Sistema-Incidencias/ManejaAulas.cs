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
    class ManejaAulas
    {
        public List <String >ObtenerAulasDisponibles()
        {
            List<String> list = new List<string>();
            SqlConnection connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            if (connection == null)
            {
                foreach (SqlError item in UsoBD.ESalida.Errors)
                {
                    connection.Close();
                    MessageBox.Show(item.Message);
                }
            }
            SqlDataReader lector = null;
            String comando = "SELECT DESCRIPCION FROM AULA WHERE JEFE_DEPARTAMENTO IS NULL";
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
                return list;
            }
            while (lector.Read())
            {
                list.Add(lector.GetValue(0).ToString());
            }
            connection.Close();
            return list;
        }

        
        public List<Aula> ObtenerAulasAsignadas(string usuario)
        {
            List<Aula> list = new List<Aula>();
            SqlConnection connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            if (connection == null)
            {
                foreach (SqlError item in UsoBD.ESalida.Errors)
                {
                    connection.Close();
                    MessageBox.Show(item.Message);
                }
            }
            SqlDataReader lector = null;
            String comando = "SELECT * FROM AULA WHERE JEFE_DEPARTAMENTO = " + "'" + usuario + "'";
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
                return list;
            }
            while (lector.Read())
            {
                list.Add(new Aula (lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString()));
            }
            connection.Close();
            return list;
        }

        public static string ObtenerDescripcionAula()
        {
            string Descripcion = "";
            SqlConnection connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            if (connection == null)
            {
                foreach (SqlError item in UsoBD.ESalida.Errors)
                {
                    connection.Close();
                    MessageBox.Show(item.Message);
                }
            }
            SqlDataReader lector = null;
            String comando = "SELECT DESCRIPCION FROM AULA ";
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
                return Descripcion;
            }
            while (lector.Read())
            {
                Descripcion = lector.GetValue(0).ToString();
            }
            connection.Close();
            return Descripcion;
        }

        public bool AsignarAula(String aula, String usuario)
        {
            SqlConnection connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            if (connection == null)
            {
                foreach (SqlError item in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(item.Message);
                }
            }
            string command = "UPDATE AULA SET JEFE_DEPARTAMENTO = @Usuario WHERE DESCRIPCION= @aula";
            SqlCommand comandoInsersion = new SqlCommand(command, connection);
            comandoInsersion.Parameters.AddWithValue("@Usuario", usuario);
            comandoInsersion.Parameters.AddWithValue("@aula", aula);
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
            MessageBox.Show("ACTUALIZADO EXITOSAMENTE", "AULA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }


        public static bool AgregarAula(string Descripcion, string JefeDepto)
        {

            SqlConnection connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            if (connection == null)
            {
                foreach (SqlError item in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(item.Message);
                }
            }
            string command = "INSERT INTO AULA(DESCRIPCION, JEFE_DEPARTAMENTO)";
            command += " VALUES(@Descripcion, @JefeDepto)";
            SqlCommand comandoInsersion = new SqlCommand(command, connection);
            comandoInsersion.Parameters.AddWithValue("@Descripcion", Descripcion);
            comandoInsersion.Parameters.AddWithValue("@JefeDepto", JefeDepto);

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
