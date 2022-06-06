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
    public partial class FormBajaDeProductos : Form
    {
        #region Campos

        public List<Producto> listaProductos;
        private bool ok;
        private int index;

        #endregion

        #region Constructores
        public FormBajaDeProductos()
        {
            InitializeComponent();
            this.listaProductos = new List<Producto>();
            this.ok = false;
            this.index = 0;
        }
        public FormBajaDeProductos(List<Producto> lista) : this()
        {
            this.listaProductos = lista;
        }

        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBajaDeProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Producto aux = new Producto();
            int auxCodigo;
            int index = 0;

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
                    lblProducto.Text = this.listaProductos[index].Nombre;
                    lblStock.Text = this.listaProductos[index].Cantidad.ToString();
                    lblPrecio.Text = this.listaProductos[index].Precio.ToString();
                    lblRubro.Text = this.listaProductos[index].RubroString();
                    this.ok = true;
                    this.index = index;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.ok == true)
            {
                this.listaProductos.RemoveAt(this.index);
                MessageBox.Show("Producto borrado con exito", "Producto borrado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblProducto.Text = "";
                lblStock.Text = "";
                lblPrecio.Text = "";
                lblRubro.Text = "";
            }
        }
    }
}
