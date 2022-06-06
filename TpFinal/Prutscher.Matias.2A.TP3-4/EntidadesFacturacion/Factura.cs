using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesProductos;
using EntidadesCliente;


namespace EntidadesFacturacion
{
    public class Factura
    {
        #region Campos

        public List<Producto> productos;
        private Cliente cliente;
        public float precio;
        public int nFactura;

        #endregion

        #region Constructor

        public Factura()
        {
            this.productos = new List<Producto>();
        }

        public Factura(Cliente cliente, List<Producto> productos, int nFactura) : this()
        {
            this.Cliente = cliente;
            this.productos = productos;
            this.nFactura = nFactura;
        }

        #endregion

        #region Propiedades

        public Cliente Cliente { get => cliente; set => cliente = value; }

        #endregion

        #region Metodos

        private float ValorFactura(List<Producto> productos)
        {
            float aux = 0;
            foreach (Producto item in productos)
            {
                aux += item.Precio;
            }

            return aux;
        }

        

        #endregion

    }
}
