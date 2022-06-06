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

namespace Facturacion
{
    public partial class FormArticulos : Form
    {
        #region Campos

        private List<Producto> lProductos;
        public List<Producto> listaAux;
        private int index;
        private int aux;
        public float total;

        #endregion
        public FormArticulos()
        {
            InitializeComponent();
            this.lProductos = new List<Producto>();
            this.listaAux = new List<Producto>();
            this.index = 0;
            this.aux = 0;
            this.total = 0;
        }
        public FormArticulos(List<Producto> lista) : this()
        {
            this.lProductos = lista;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormArticulos_Load(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
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
                if (aux.Chequeo(this.lProductos, auxCodigo, out index))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("{0} - {1} - {2}", this.lProductos[index].Nombre, this.lProductos[index].Precio, this.lProductos[index].Cantidad);
                    lblInfo.Text = sb.ToString();
                    this.index = index;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int i;
            int aux = 1;
            Producto pAux = new Producto();
            pAux = this.lProductos[this.index];
            float subtotal = pAux.Precio * aux;
            i = this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[i].Cells[0].Value = pAux.codigo;
            this.dataGridView1.Rows[i].Cells[1].Value = pAux.Nombre;
            if(aux > this.lProductos[this.index].Cantidad)
            {
                MessageBox.Show("Stock insuficiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.dataGridView1.Rows[i].Cells[2].Value = aux;
                pAux.Cantidad = aux;
            }
            this.dataGridView1.Rows[i].Cells[3].Value = this.lProductos[this.index].Precio;
            this.dataGridView1.Rows[i].Cells[4].Value = subtotal;
            this.listaAux.Add(pAux);
            this.total += subtotal;
            this.lvlPrecioTotal.Text = this.total.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(this.aux != -1)
            {
                dataGridView1.Rows.RemoveAt(this.aux);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.aux = e.RowIndex;
        }
    }
}
