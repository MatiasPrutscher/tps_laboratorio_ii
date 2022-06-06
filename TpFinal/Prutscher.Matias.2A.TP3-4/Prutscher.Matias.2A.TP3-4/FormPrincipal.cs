using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion;
using Stock;
using Consulta;
using EntidadesCliente;
using EntidadesProductos;
using Archivos;
using EntidadesFacturacion;
using System.IO;

namespace Prutscher.Matias._2A.TP3_4
{
    public partial class formPrincipal : Form
    {
        #region Campos

        static string rutaFacturas;
        static string rutaStock;
        static string rutaClientes;
        private List<Factura> listaFacturas;
        private List<Producto> listaProductos;
        private List<Cliente> listaClientes;
        public int nFactura;

        #endregion

        #region Propiedades

        public List<Factura> ListaFacturas { get => listaFacturas; set => listaFacturas = value; }
        public List<Producto> ListaProductos { get => listaProductos; set => listaProductos = value; }
        public List<Cliente> ListaClientes { get => listaClientes; set => listaClientes = value; }

        #endregion

        #region Constructores
        static formPrincipal()
        {
            string applicationData = Application.StartupPath + @"\Info\";
            string archivoFacturas = "listaFacturas.xml";
            rutaFacturas = Path.Combine(applicationData, archivoFacturas);
            string archivoStock = "listaStock.xml";
            rutaStock = Path.Combine(applicationData, archivoStock);
            string archivoCliente = "listaClientes.xml";
            rutaClientes = Path.Combine(applicationData, archivoCliente);
        }
        public formPrincipal()
        {
            this.listaFacturas = new List<Factura>();
            this.listaProductos = new List<Producto>();
            this.listaClientes = new List<Cliente>();
            InitializeComponent();
            this.nFactura = 0;
        }
        #endregion

        #region Metodos

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            Genericos<List<Producto>> listaProductosAux = new Genericos<List<Producto>>();
            Genericos<List<Cliente>> listaClientesAux = new Genericos<List<Cliente>>();
            Genericos<List<Factura>> listaFacturasAux = new Genericos<List<Factura>>();

            List<Cliente> auxClientes;
            List<Producto> auxProducto;
            List<Factura> auxFactura;

            try
            {
                listaClientesAux.RecuperarDatos(rutaClientes, out auxClientes);
                listaProductosAux.RecuperarDatos(rutaStock, out auxProducto);
                listaFacturasAux.RecuperarDatos(rutaFacturas, out auxFactura);

                if(auxClientes != null)
                {
                    this.ListaClientes = auxClientes;
                }
                if(auxFactura != null)
                {
                    this.ListaFacturas = auxFactura;
                }
                if(auxProducto != null)
                {
                    this.ListaProductos = auxProducto;
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void puntoDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPuntoDeVenta formPuntoDeVenta = new FormPuntoDeVenta(this.listaFacturas, this.listaProductos, this.listaClientes,this.nFactura);
            formPuntoDeVenta.ShowDialog();
            if(formPuntoDeVenta.ok)
            {
                this.nFactura += 1;
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notaDeCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNotaDeCredito formNotaDeCredito = new FormNotaDeCredito();
            formNotaDeCredito.ShowDialog();
        }

        private void cargaDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genericos<Producto> listaProductosAux = new Genericos<Producto>();
            FormCargaDeArticulos formCargaDeArticulos = new FormCargaDeArticulos(this.listaProductos);
            formCargaDeArticulos.ShowDialog();
            this.listaProductos.Add(formCargaDeArticulos.producto);
            listaProductosAux.GuardarDatos(rutaStock, this.listaProductos);


        }

        private void bajaDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genericos<Producto> listaProductosAux = new Genericos<Producto>();
            FormBajaDeProductos formBajaDeProductos = new FormBajaDeProductos(this.listaProductos);
            formBajaDeProductos.ShowDialog();
            this.listaProductos = formBajaDeProductos.listaProductos;
            listaProductosAux.GuardarDatos(rutaStock, this.listaProductos);
        }

        private void consultaDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaDeVentas formConsultaDeVentas = new FormConsultaDeVentas();
            formConsultaDeVentas.ShowDialog();
        }

        private void consultaDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaDeStock formConsultaDeStock = new FormConsultaDeStock(this.listaProductos);
            formConsultaDeStock.ShowDialog();
        }

        #endregion
    }
}
