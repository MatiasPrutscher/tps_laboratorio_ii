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
    public partial class FormPago : Form
    {
        #region Campos

        public float efectivo;
        public float tarjeta;
        public float total;
        public int cuotas;

        #endregion
        public FormPago()
        {
            InitializeComponent();
            this.total = 0;
            this.tarjeta = 0;
            this.efectivo = 0;
            this.cuotas = 0;
        }
        public FormPago(float total) : this()   
        {
            this.total = total;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPago_Load(object sender, EventArgs e)
        {
            this.txtEfectivo.Text = this.total.ToString();
            this.txtTarjeta.Text = this.tarjeta.ToString();
            this.cmbCuotas.SelectedIndex = 0;
            this.cmbTarjetas.SelectedIndex = 0;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.efectivo = float.Parse(this.txtEfectivo.Text);
                this.tarjeta = float.Parse(this.txtTarjeta.Text);
                this.cuotas = int.Parse(this.cmbCuotas.Text);
            }
            catch (Exception)
            {

                throw;
            }
            this.tarjeta = this.tarjeta * (float)1.2;
            this.total = this.tarjeta + this.efectivo;
            this.lblTotal.Text = this.total.ToString();
            this.Close();
        }
    }
}
