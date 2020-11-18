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
    class ManejaDepartamento
    {
        public static List<String> ObtenerDepartamentos()
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
            String comando = "SELECT  Nombre FROM DEPARTAMENTO";
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
       
        public static int ObtenerDepartamentoTecnicoId(String nombre)
        {
            int valor = -1;
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
            String comando = "SELECT  id FROM DEPARTAMENTO_TECNICO WHERE Nombre = '" + nombre + "'";
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
                return valor;
            }
            while (lector.Read())
            {
                 valor =  Int16.Parse(lector.GetValue(0).ToString());
            }
            connection.Close();
            return valor;
        }

        public static String ObtenerNombreDepartamento()
        {
            string Nombre="";
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
            String comando = "SELECT NOMBRE FROM DEPARTAMENTO ";
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
                return Nombre;
            }
            while (lector.Read())
            {
                Nombre = lector.GetValue(0).ToString();
            }
            connection.Close();
            return Nombre;
        }

        public static String ObtenerNombreDepartamentoTecnico()
        {
            string Nombre = " ";
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
            String comando = "SELECT NOMBRE FROM DEPARTAMENTO_TECNICO ";
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
                return Nombre;
            }
            while (lector.Read())
            {
                Nombre = lector.GetValue(0).ToString();
            }
            connection.Close();
            return Nombre;
        }

        public static int ObtenerDepartamentoId(String nombre)
        {
            int valor = -1;
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
            String comando = "SELECT  id FROM DEPARTAMENTO WHERE Nombre = '" + nombre + "'";
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
                return valor;
            }
            while (lector.Read())
            {
                valor = Int16.Parse(lector.GetValue(0).ToString());
            }
            connection.Close();
            return valor;
        }

        public static List<String> ObtenerDepartamentoTecnico()
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
            String comando = "SELECT  NOMBRE FROM DEPARTAMENTO_TECNICO";
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



        public static List<String> ObtenerDepartamentoJefe()
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
            String comando = "SELECT  NOMBRE FROM DEPARTAMENTO";
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

        public static int ObtenerDepartamentoJefeId(String nombre)
        {
            int valor = -1;
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
            String comando = "SELECT  id FROM DEPARTAMENTO WHERE Nombre = '" + nombre + "'";
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
                return valor;
            }
            while (lector.Read())
            {
                valor = Int16.Parse(lector.GetValue(0).ToString());
            }
            connection.Close();
            return valor;
        }
        public static bool AgregarDepto(String Nombre)
        {
            
            SqlConnection connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            if (connection == null)
            {
                foreach (SqlError item in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(item.Message);
                }
            }
            string command = "INSERT INTO DEPARTAMENTO(NOMBRE)";
            command += " VALUES(@Nombre)";
            SqlCommand comandoInsersion = new SqlCommand(command, connection);
            comandoInsersion.Parameters.AddWithValue("@Nombre", Nombre);

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

        public static bool AgregarDeptoTecnico(String Nombre)
        {

            SqlConnection connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            if (connection == null)
            {
                foreach (SqlError item in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(item.Message);
                }
            }
            string command = "INSERT INTO DEPARTAMENTO_TECNICO(NOMBRE)";
            command += " VALUES(@Nombre)";
            SqlCommand comandoInsersion = new SqlCommand(command, connection);
            comandoInsersion.Parameters.AddWithValue("@Nombre", Nombre);

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
