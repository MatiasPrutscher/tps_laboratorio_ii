using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesProductos;

namespace Stock
{
    public partial class FormCargaDeArticulos : Form
    {
        #region Campos

        private List<Producto> listaProductos;
        public Producto producto;

        #endregion
        #region Constructores
        public FormCargaDeArticulos()
        {
            InitializeComponent();
            this.producto = new Producto();
        }

        public FormCargaDeArticulos(List<Producto> productos):this()
        {
            this.listaProductos = productos;
        }

        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCargaDeArticulos_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            txtProducto.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            cmbRubro.SelectedIndex = -1;

            Producto aux = new Producto();
            int auxCodigo;
            int index = -1;
            bool repite;

            try
            {
                auxCodigo = int.Parse(txtCodigo.Text);
            }
            catch (Exception)
            {
                throw;
            }
            try
            {
                if (aux.Chequeo(this.listaProductos, auxCodigo, out index))
                {
                    txtProducto.Text = this.listaProductos[index].Nombre;
                    txtCantidad.Text = this.listaProductos[index].Cantidad.ToString();
                    txtPrecio.Text = this.listaProductos[index].Precio.ToString();
                    cmbRubro.SelectedIndex = this.listaProductos[index].indexEProducto();
                    repite = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.producto.codigo = int.Parse(txtCodigo.Text);
                this.producto.Nombre = txtProducto.Text;
                this.producto.Precio = float.Parse(txtPrecio.Text);
                this.producto.Rubro = (ERubro)cmbRubro.SelectedIndex;
                this.producto.Cantidad = int.Parse(txtCantidad.Text);
            }
            catch (Exception)
            {

                throw;
            }
            MessageBox.Show("Se agrego el producto al stock", "Agregado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
