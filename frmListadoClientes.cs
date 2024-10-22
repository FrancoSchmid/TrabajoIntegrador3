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
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        
        private void btnListar_Click(object sender, EventArgs e)
        {
            clsCliente X = new clsCliente();
            X.Listar(dgvListaClientes);

            lblCantidadCliente.Text = X.Cantidad.ToString();
            lblTotalDeuda.Text = X.Deuda.ToString();
            lblPromedioDeuda.Text = X.ToString();
        }
        
    }
}
