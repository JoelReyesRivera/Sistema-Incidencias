using LibreriaBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Incidencias
{
    public partial class frmConsultaDispositivos : Form
    {
        public frmConsultaDispositivos()
        {
            InitializeComponent();
        }

        private void frmConsultaDispositivos_Load(object sender, EventArgs e)
        {
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
            string Query = "SELECT * FROM  VW_Dispositivos WHERE UBICACION != "+"'ALMACÉN'";
            SqlDataReader Lector = null;
            Lector = UsoBD.Consulta(Query, Conecta);
            if (Lector == null)
            {
                MessageBox.Show("ERROR AL REALIZAR CONSULTA");
                foreach (SqlError Error in UsoBD.ESalida.Errors)
                    MessageBox.Show(Error.Message);
                Conecta.Close();
                return;
            }
            if (Lector.HasRows)
            {
                dataGridView1.Rows.Clear();
                while (Lector.Read())
                {

                    string numSerie = Lector.GetValue(0).ToString();
                    string descripcion = Lector.GetValue(1).ToString();
                    string modelo = Lector.GetValue(2).ToString();
                    string marca = Lector.GetValue(3).ToString();
                    string ubicacion = Lector.GetValue(4).ToString();
                    string garantia = Lector.GetValue(5).ToString();

                    dataGridView1.Rows.Add(numSerie,descripcion, modelo, marca, ubicacion, garantia);
                }
            }
            Conecta.Close();
        }
    }
}
