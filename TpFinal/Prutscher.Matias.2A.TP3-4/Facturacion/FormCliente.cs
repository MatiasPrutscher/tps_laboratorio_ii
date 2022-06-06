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

namespace Facturacion
{
    public partial class FormCliente : Form
    {
        #region Campos

        public List<Cliente> lClientes;
        private bool esta;
        public int index;
        public Cliente auxCliente;

        #endregion

        #region Contructores
        public FormCliente()
        {
            InitializeComponent();
            this.lClientes = new List<Cliente>();
            this.esta = false;
            this.index = 0;
            this.auxCliente = new Cliente();
        }

        public FormCliente(List<Cliente> lista) :this()
        {
            this.lClientes = lista;
        }

        #endregion

        #region Metodos
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Cliente aux = new Cliente();
            double auxDni;
            int index = 0;

            try
            {
                auxDni = double.Parse(txtDNI.Text);
            }
            catch (Exception)
            {
                throw;
            }
            try
            {
                if (aux.buscarCliente(this.lClientes, auxDni, out index))
                {
                    txtNombre.Text = this.lClientes[index].Nombre;
                    cmbResidencia.SelectedIndex = (int)this.lClientes[index].Residencia;
                    this.esta = true;
                    this.index = index;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!this.esta)
            {
                try
                {
                    auxCliente.Dni = double.Parse(txtDNI.Text);
                    auxCliente.Nombre = txtNombre.Text;
                    auxCliente.Residencia = (EResidencia)cmbResidencia.SelectedIndex;
                }
                catch (Exception)
                {

                    throw;
                }
                this.lClientes.Add(auxCliente);
                this.index = this.lClientes.Count();
            }
            this.Close();
        }
    }
}
