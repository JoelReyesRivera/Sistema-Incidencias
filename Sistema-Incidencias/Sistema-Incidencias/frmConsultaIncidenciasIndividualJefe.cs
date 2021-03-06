﻿using System;
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
    public partial class frmConsultaIncidenciasIndividualJefe : Form
    {
        private String Usuario;
        public frmConsultaIncidenciasIndividualJefe(String Usuario)
        {
            InitializeComponent();
            this.Usuario = Usuario;
            cmbIncidencias.SelectedIndex = -1;
        }

        private void frmConsultaIncidenciasIndividualJefe_Load(object sender, EventArgs e)
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
            string Query = "SELECT ID FROM INCIDENCIA WHERE REPORTADO_POR = "+"'"+Usuario+"'";
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
                while (Lector.Read())
                    cmbIncidencias.Items.Add(Lector.GetValue(0).ToString());
            }
            Conecta.Close();
        }

        private void cmbIncidencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIncidencias.SelectedIndex == -1)
                return;

            string ID = cmbIncidencias.SelectedItem.ToString();

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
            string Query = "SELECT ID,DISPOSITIVO,MARCA,MODELO,UBICADO,INCIDENCIA,FECHA,ESTATUS FROM VW_Incidencias WHERE ID = " + "'" + ID + "'"+" AND REPORTADO_POR = "+"'"+Usuario+"'";
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
                while (Lector.Read())
                {
                    txtDispositivo.Text = Lector.GetValue(1).ToString();
                    txtMarca.Text = Lector.GetValue(2).ToString();
                    txtModelo.Text = Lector.GetValue(3).ToString();
                    txtUbicado.Text = Lector.GetValue(4).ToString();
                    txtIncidencia.Text = Lector.GetValue(5).ToString();
                    txtFecha.Text = Lector.GetValue(6).ToString();
                    txtEstatus.Text = Lector.GetValue(7).ToString();

                }
            }
            Conecta.Close();
        }

        private void btnLimpia_Click(object sender, EventArgs e)
        {
            Limpia();
        }
        private void Limpia()
        {
            cmbIncidencias.SelectedIndex = -1;
            txtDispositivo.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtUbicado.Text = "";
            txtFecha.Text = "";
            txtEstatus.Text = "";
            txtIncidencia.Text = "";
        }
    }
}
