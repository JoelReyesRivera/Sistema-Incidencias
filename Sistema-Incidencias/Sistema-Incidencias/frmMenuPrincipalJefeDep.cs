﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Incidencias
{
    public partial class frmMenuPrincipalJefeDep : Form
    {
        public String Usuario;
        public frmMenuPrincipalJefeDep(string Usuario)
        {

            this.Usuario = Usuario;
            InitializeComponent();
        }

        private void actualizarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateJefe frm = new frmUpdateJefe(Usuario);
            frm.ShowDialog();
        }

        private void agregarAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarAulas frmAgregarAulas = new frmAgregarAulas(Usuario);
            frmAgregarAulas.ShowDialog();
        }

        private void verAulasAsignadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarAulasAsignadas frmConsultarAulasAsignadas = new frmConsultarAulasAsignadas(Usuario);
            frmConsultarAulasAsignadas.ShowDialog();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMenuPrincipalJefeDep_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Usuario;
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaIncidencia I = new frmAltaIncidencia(Usuario);
            I.ShowDialog();
        }

        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaIncidenciasIndividualJefe I = new frmConsultaIncidenciasIndividualJefe(Usuario);
            I.ShowDialog();
        }

        private void todasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaIncidenciasJefe J = new frmConsultaIncidenciasJefe(Usuario);
            J.ShowDialog();
        }

        private void detalleConcluidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaIncidenciasConcluidasJefe J = new frmConsultaIncidenciasConcluidasJefe(Usuario);
            J.ShowDialog();
        }
    }
}
