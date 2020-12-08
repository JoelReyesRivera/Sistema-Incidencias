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
    public partial class frmConsultaDispositivosAlmacen : Form
    {
        public frmConsultaDispositivosAlmacen()
        {
            InitializeComponent();
        }

        private void frmConsultaDispositivosAlmacen_Load(object sender, EventArgs e)
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
            string Query = "SELECT D.NUMERO_SERIE, P.NOMBRE, D.FECHA_EXPIRACION_GARANTIA, D.MODELO, D.DESCRIPCION, M.NOMBRE, A.DESCRIPCION, PA.FECHA_INGRESO FROM DISPOSITIVO D INNER JOIN PROVEEDOR P ON P.ID = D.PROVEEDOR INNER JOIN MARCA M ON M.ID = D.MARCA INNER JOIN AULA A ON A.ID = D.AULA INNER JOIN PERTENECE_ALMACEN PA ON PA.DISPOSITIVO = D.NUMERO_SERIE";
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
                dgvDispositivos.Rows.Clear();
                while (Lector.Read())
                    dgvDispositivos.Rows.Add(Lector.GetValue(0).ToString(), Lector.GetValue(1).ToString(), Lector.GetValue(2).ToString(), Lector.GetValue(3).ToString(), Lector.GetValue(4).ToString(), Lector.GetValue(5).ToString(), Lector.GetValue(6).ToString(), Lector.GetValue(7).ToString());
            }
            Conecta.Close();
        }
    }
}
