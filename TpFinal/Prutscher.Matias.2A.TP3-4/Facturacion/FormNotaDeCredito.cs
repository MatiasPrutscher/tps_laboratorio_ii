using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class FormNotaDeCredito : Form
    {
        public FormNotaDeCredito()
        {
            InitializeComponent();
        }

        private void FormNotaDeCredito_Load(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.ShowDialog();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            FormArticulos formArticulos = new FormArticulos();
            formArticulos.ShowDialog();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            FormPago formPago = new FormPago();
            formPago.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
