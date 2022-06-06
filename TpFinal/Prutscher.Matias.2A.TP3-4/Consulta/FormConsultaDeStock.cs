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

namespace Consulta
{
    public partial class FormConsultaDeStock : Form
    {
        #region Campos

        List<Producto> listaProductos;

        #endregion

        #region Constructores
        public FormConsultaDeStock()
        {
            InitializeComponent();
            this.listaProductos = new List<Producto>();
        }

        public FormConsultaDeStock(List<Producto> lista) : this()
        {
            this.listaProductos = lista;
        }

        #endregion

        #region Metodos
        private void FormConsultaDeStock_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                FormPlanillaStock formPlanillaStock;

                if (txtCodigo.Text == "")
                {
                    if (cmbRubro.SelectedIndex == -1 || cmbRubro.SelectedIndex == 6)
                    {
                        cmbRubro.SelectedIndex = 6;
                        formPlanillaStock = new FormPlanillaStock(this.listaProductos);
                    }
                    else
                    {
                        formPlanillaStock = new FormPlanillaStock(this.listaProductos, (ERubro)cmbRubro.SelectedIndex);
                    }
                }
                else
                {
                    formPlanillaStock = new FormPlanillaStock(this.listaProductos, int.Parse(txtCodigo.Text));
                }

                formPlanillaStock.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }

        }
        #endregion
    }
}
