using System;
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
    public partial class frmListaDeudores : Form
    {
        public frmListaDeudores()
        {
            InitializeComponent();
        }

        private void dgvListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCantidadClientes_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalDeuda_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsCliente X = new clsCliente();
            X.ListarDeudores(dgvListaClientesD);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
