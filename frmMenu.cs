﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTrabajoIntegrador3
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoClientes frmListadoClientes = new frmListadoClientes();
            frmListadoClientes.ShowDialog();

            this.Close();
        }

        private void listadoDeClientesDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDeudores frmListaDeudores = new frmListaDeudores();
            frmListaDeudores.ShowDialog();

            this.Close();
        }

        private void agregarNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarCliente frmAgregarCliente = new frmAgregarCliente();
            frmAgregarCliente.ShowDialog();

            this.Close();
        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDesarollador frmDesarollador = new frmDesarollador();
            frmDesarollador.ShowDialog();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarCliente frmBuscarCliente = new frmBuscarCliente();
            frmBuscarCliente.ShowDialog();
            this.Close();
        }
    }
}
