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
    public partial class FormPlanillaStock : Form
    {
        #region Campos

        private List<Producto> listaProductos;
        private ERubro rubro;
        private int codigo;

        #endregion

        #region Constructores
        private FormPlanillaStock()
        {
            InitializeComponent();
            this.listaProductos = new List<Producto>();
            this.codigo = int.MaxValue;
            this.rubro = ERubro.Todos;
        }

        public FormPlanillaStock(List<Producto> lista) : this()
        {
            this.listaProductos = lista;
        }
        public FormPlanillaStock(List<Producto> lista, ERubro rubro) : this(lista)
        {
            this.rubro = rubro;
        }
        public FormPlanillaStock(List<Producto> lista, int codigo) : this(lista)
        {
            this.codigo = codigo;
        }

        #endregion

        #region Metodos
        private void FormPlanillaStock_Load(object sender, EventArgs e)
        {
            int i;
            if((this.rubro == ERubro.Todos) && this.codigo == int.MaxValue)
            {
                foreach (Producto item in this.listaProductos)
                {
                    i = this.dgvStock.Rows.Add();
                    this.dgvStock.Rows[i].Cells[0].Value = item.codigo;
                    this.dgvStock.Rows[i].Cells[1].Value = item.Nombre;
                    this.dgvStock.Rows[i].Cells[2].Value = item.RubroString();
                    this.dgvStock.Rows[i].Cells[3].Value = item.Precio;
                    this.dgvStock.Rows[i].Cells[4].Value = item.Cantidad;
                }
            }
            else
            {
                if (this.codigo != int.MaxValue)
                {
                    Producto aux = new Producto();
                    Producto p = new Producto();

                    if (aux.Chequeo(this.listaProductos, this.codigo, out p))
                    {
                        i = this.dgvStock.Rows.Add();
                        this.dgvStock.Rows[i].Cells[0].Value = p.codigo;
                        this.dgvStock.Rows[i].Cells[1].Value = p.Nombre;
                        this.dgvStock.Rows[i].Cells[2].Value = p.RubroString();
                        this.dgvStock.Rows[i].Cells[3].Value = p.Precio;
                        this.dgvStock.Rows[i].Cells[4].Value = p.Cantidad;
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    switch(this.rubro)
                    {
                        case ERubro.Auriculares:
                            foreach (Producto item in this.listaProductos)
                            {
                                if(item.Rubro == ERubro.Auriculares)
                                {
                                    i = this.dgvStock.Rows.Add();
                                    this.dgvStock.Rows[i].Cells[0].Value = item.codigo;
                                    this.dgvStock.Rows[i].Cells[1].Value = item.Nombre;
                                    this.dgvStock.Rows[i].Cells[2].Value = item.RubroString();
                                    this.dgvStock.Rows[i].Cells[3].Value = item.Precio;
                                    this.dgvStock.Rows[i].Cells[4].Value = item.Cantidad;
                                }
                            }
                            break;
                        case ERubro.ComponentesPC:
                            foreach (Producto item in this.listaProductos)
                            {
                                if (item.Rubro == ERubro.ComponentesPC)
                                {
                                    i = this.dgvStock.Rows.Add();
                                    this.dgvStock.Rows[i].Cells[0].Value = item.codigo;
                                    this.dgvStock.Rows[i].Cells[1].Value = item.Nombre;
                                    this.dgvStock.Rows[i].Cells[2].Value = item.RubroString();
                                    this.dgvStock.Rows[i].Cells[3].Value = item.Precio;
                                    this.dgvStock.Rows[i].Cells[4].Value = item.Cantidad;
                                }
                            }
                            break;
                        case ERubro.Microfonos:
                            foreach (Producto item in this.listaProductos)
                            {
                                if (item.Rubro == ERubro.Microfonos)
                                {
                                    i = this.dgvStock.Rows.Add();
                                    this.dgvStock.Rows[i].Cells[0].Value = item.codigo;
                                    this.dgvStock.Rows[i].Cells[1].Value = item.Nombre;
                                    this.dgvStock.Rows[i].Cells[2].Value = item.RubroString();
                                    this.dgvStock.Rows[i].Cells[3].Value = item.Precio;
                                    this.dgvStock.Rows[i].Cells[4].Value = item.Cantidad;
                                }
                            }
                            break;
                        case ERubro.Monitores:
                            foreach (Producto item in this.listaProductos)
                            {
                                if (item.Rubro == ERubro.Monitores)
                                {
                                    i = this.dgvStock.Rows.Add();
                                    this.dgvStock.Rows[i].Cells[0].Value = item.codigo;
                                    this.dgvStock.Rows[i].Cells[1].Value = item.Nombre;
                                    this.dgvStock.Rows[i].Cells[2].Value = item.RubroString();
                                    this.dgvStock.Rows[i].Cells[3].Value = item.Precio;
                                    this.dgvStock.Rows[i].Cells[4].Value = item.Cantidad;
                                }
                            }
                            break;
                        case ERubro.MouseTeclados:
                            foreach (Producto item in this.listaProductos)
                            {
                                if (item.Rubro == ERubro.MouseTeclados)
                                {
                                    i = this.dgvStock.Rows.Add();
                                    this.dgvStock.Rows[i].Cells[0].Value = item.codigo;
                                    this.dgvStock.Rows[i].Cells[1].Value = item.Nombre;
                                    this.dgvStock.Rows[i].Cells[2].Value = item.RubroString();
                                    this.dgvStock.Rows[i].Cells[3].Value = item.Precio;
                                    this.dgvStock.Rows[i].Cells[4].Value = item.Cantidad;
                                }
                            }
                            break;
                        default:
                            foreach (Producto item in this.listaProductos)
                            {
                                if (item.Rubro == ERubro.Parlantes)
                                {
                                    i = this.dgvStock.Rows.Add();
                                    this.dgvStock.Rows[i].Cells[0].Value = item.codigo;
                                    this.dgvStock.Rows[i].Cells[1].Value = item.Nombre;
                                    this.dgvStock.Rows[i].Cells[2].Value = item.RubroString();
                                    this.dgvStock.Rows[i].Cells[3].Value = item.Precio;
                                    this.dgvStock.Rows[i].Cells[4].Value = item.Cantidad;
                                }
                            }
                            break;
                    }
                }
            }
        }
        #endregion

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
