using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesCliente;
using EntidadesFacturacion;
using EntidadesProductos;

namespace Facturacion
{
    public partial class FormPuntoDeVenta : Form
    {
        #region Campos

        public List<Factura> lFacturas;
        public List<Cliente> lClientes;
        public List<Producto> lProductos;
        private Cliente auxCliente;
        private List<Producto> segundaLista;
        public int nFactura;
        private float montoAPagar;
        public bool ok;


        #endregion
        public FormPuntoDeVenta()
        {
            InitializeComponent();
            this.lFacturas = new List<Factura>();
            this.lClientes = new List<Cliente>();
            this.lProductos = new List<Producto>();
            this.auxCliente = new Cliente();
            this.segundaLista = new List<Producto>();
            this.ok = false;


        }
        public FormPuntoDeVenta(List<Factura> lFacturas, List<Producto> lProductos, List<Cliente> lCliente, int nFactura) : this()
        {
            this.lFacturas = lFacturas;
            this.lClientes = lCliente;
            this.lProductos = lProductos;
            this.nFactura = nFactura;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            FormArticulos formArticulos = new FormArticulos(this.lProductos);
            formArticulos.ShowDialog();
            this.segundaLista = formArticulos.listaAux;
            this.montoAPagar = formArticulos.total;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente(this.lClientes);
            formCliente.ShowDialog();
            this.auxCliente = formCliente.auxCliente;
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            FormPago formPago = new FormPago(this.montoAPagar);
            formPago.ShowDialog();
            this.lblCuotas.Text = formPago.cuotas.ToString();
            this.lblPrecioEfectivo.Text = formPago.efectivo.ToString();
            this.lblPrecioTarjeta.Text = formPago.tarjeta.ToString();
            this.lblMontoTotal.Text = formPago.total.ToString();
        }

        private void FormPuntoDeVenta_Load(object sender, EventArgs e)
        {
            this.lblFactura.Text = this.nFactura.ToString();
            this.lblFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Factura aux = new Factura(this.auxCliente, this.segundaLista, this.nFactura);
            this.lFacturas.Add(aux);
            this.ok = true;
        }
    }
}
