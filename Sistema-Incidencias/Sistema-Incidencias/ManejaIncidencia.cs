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
    class ManejaIncidencia
    {
        public static List<int> ObtenerIncidencia()
        {
            List<int> list = new List<int>();
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
            String comando = "SELECT  ID FROM INCIDENCIA WHERE ESTATUS=0";
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
                list.Add(Convert.ToInt32(lector.GetValue(0)));
            }
            connection.Close();
            return list;
        }


        public static List<string> ObtenerAdministrador()
        {
            List<string> list = new List<string>();
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
            String comando = "SELECT  USUARIO FROM ADMINISTRADOR";
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

        public static List<string> ObtenerTecnico()
        {
            List<string> list = new List<string>();
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
            String comando = "SELECT USUARIO FROM TECNICO";
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


       
        public static bool AñadirIncidenciaTecnico(int ID, String Admin, String Tecnico, DateTime fecha)
        {
            SqlConnection connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            if (connection == null)
            {
                foreach (SqlError item in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(item.Message);
                }
            }
            string command = "INSERT INTO INCIDENCIA_TECNICO(ID_INCIDENCIA, ADMINISTRADOR, TECNICO,FECHA_ASIGNACION)";
            command += " VALUES(@ID, @Admin, @Tecnico, @fecha)";
            SqlCommand comandoInsersion = new SqlCommand(command, connection);
            comandoInsersion.Parameters.AddWithValue("@ID", ID);
            comandoInsersion.Parameters.AddWithValue("@Admin", Admin);
            comandoInsersion.Parameters.AddWithValue("@Tecnico",Tecnico);
            comandoInsersion.Parameters.AddWithValue("@fecha", fecha);
            ActualizarStatusIncidencia(ID);

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
            MessageBox.Show("GUARDADO EXITOSAMENTE", "TECNICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }


        public static bool ActualizarStatusIncidencia(int id)
        {
            SqlConnection connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            if (connection == null)
            {
                foreach (SqlError item in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(item.Message);
                }
            }
            string command = "UPDATE INCIDENCIA SET ESTATUS = 2 WHERE ID= @ID";
            SqlCommand comandoInsersion = new SqlCommand(command, connection);
            comandoInsersion.Parameters.AddWithValue("@ID", id);

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

            return true;
        }


        //FINALIZAR INCIDENCIA
        public static List<int> ObtenerIncidenciaTec( string usuario)
        {
            List<int> list = new List<int>();
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
            String comando = "SELECT  ID FROM INCIDENCIA_TECNICO WHERE TECNICO= '"+ usuario + "'";
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
                list.Add(Convert.ToInt32(lector.GetValue(0)));
            }
            connection.Close();
            return list;
        }

        public static bool finalizarIncidenciaTecnico(int ID, DateTime fecha, String Tecnico)
        {
            SqlConnection connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            if (connection == null)
            {
                foreach (SqlError item in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(item.Message);
                }
            }
            string command = "INSERT INTO INCIDENCIA_CONCLUIDA (ID_INCIDENCIA,FECHA_SOLUCION, SOLUCIONADO_POR)";
            command += " VALUES(@ID, @fecha, @Tecnico)";
            SqlCommand comandoInsersion = new SqlCommand(command, connection);
            comandoInsersion.Parameters.AddWithValue("@ID", ID);
            comandoInsersion.Parameters.AddWithValue("@fecha", fecha);
            comandoInsersion.Parameters.AddWithValue("@Tecnico", Tecnico);
            ActualizarStatusIncidenciaFin(ID);
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
            MessageBox.Show("FINALIZADA EXITOSAMENTE", "Finalización", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }


        public static bool ActualizarStatusIncidenciaFin(int id)
        {
            SqlConnection connection = UsoBD.ConectaBD(Utileria.GetConnectionString());
            if (connection == null)
            {
                foreach (SqlError item in UsoBD.ESalida.Errors)
                {
                    MessageBox.Show(item.Message);
                }
            }
            string command = "UPDATE INCIDENCIA SET ESTATUS = 1 WHERE ID= @ID";
            SqlCommand comandoInsersion = new SqlCommand(command, connection);
            comandoInsersion.Parameters.AddWithValue("@ID", id);

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

            return true;
        }

    }
}
