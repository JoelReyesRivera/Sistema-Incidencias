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
    public partial class frmMenuPrincipalAdmin : Form
    {
        private string Usuario;
        public frmMenuPrincipalAdmin(string Usuario)
        {
            InitializeComponent();
            this.Usuario = Usuario;
        }

        private void PantallaIincio_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Usuario;
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregaDispositivo A = new frmAgregaDispositivo();
            A.ShowDialog();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAgregarDepartamento AgregarDepto = new frmAgregarDepartamento();
            AgregarDepto.ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAgregarDepartamentoTecnico AgregarDeptoTecnico = new frmAgregarDepartamentoTecnico();
            AgregarDeptoTecnico.ShowDialog();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmUpdateAula Update = new frmUpdateAula();
            Update.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaIncidenciasIndividual I = new frmConsultaIncidenciasIndividual();
            I.ShowDialog();
        }

        private void todasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaIncidencias C = new frmConsultaIncidencias();
            C.ShowDialog();
        }

        private void asignarTécnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaIncidenciaTecnico altaIncidencia = new frmAltaIncidenciaTecnico(Usuario);
            altaIncidencia.ShowDialog();
        }

        private void vincularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVinculaDispositivos V = new frmVinculaDispositivos();
            V.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void enUsoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaDispositivos frmConsultaDispositivos = new frmConsultaDispositivos();
            frmConsultaDispositivos.ShowDialog();
        }

        private void dispostivosEnAlmacénToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDispositivosEnAlmacen frmDispositivosEnAlmacen = new frmDispositivosEnAlmacen();
            frmDispositivosEnAlmacen.ShowDialog();
        }

        private void incidenciasConcluidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultasConcluidasAdmin frm = new frmConsultasConcluidasAdmin();
            frm.ShowDialog();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenuSignUp F = new frmMenuSignUp();
            F.ShowDialog();
        }

        private void historialAsignadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCosultaIncidenciasAsignadas A = new frmCosultaIncidenciasAsignadas();
            A.ShowDialog();
        }

        private void historialEnIncidenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaDispositivoIncidencia I = new frmConsultaDispositivoIncidencia();
            I.ShowDialog();
        }

        private void historialPorTécnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaDispositivoIncidenciaTecnico T = new frmConsultaDispositivoIncidenciaTecnico();
            T.ShowDialog();
        }

        private void cambiosDeDispositivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaDispositivoCambios D = new frmConsultaDispositivoCambios();
            D.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaAulasAdmin A = new frmConsultaAulasAdmin();
            A.ShowDialog();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaDepartamentos C = new frmConsultaDepartamentos();
            C.ShowDialog();
        }

        private void autorizarCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutorizarCambio frm = new frmAutorizarCambio();
            frm.ShowDialog();
        }
    }
}
