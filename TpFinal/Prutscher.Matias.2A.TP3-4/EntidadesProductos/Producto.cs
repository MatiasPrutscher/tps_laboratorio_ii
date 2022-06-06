using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesProductos
{
    public class Producto
    {
        #region Campos

        public int codigo;
        private string nombre;
        private float precio;
        private int cantidad;
        private ERubro rubro;

        #endregion

        #region Constructores

        public Producto()
        {
            this.codigo = -1;
            this.Nombre = "sin datos";
            this.Precio = 0;
            this.Cantidad = 0;
            this.Rubro = ERubro.ComponentesPC;
        }

        public Producto(int codigo, string nombre, float precio, int cantidad, ERubro rubro) : this()
        {
            this.codigo = codigo;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Cantidad = cantidad;
            this.Rubro = rubro;
        }

        #endregion

        #region Propiedades

        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public ERubro Rubro { get => rubro; set => rubro = value; }


        #endregion

        #region Metodos
        public string RubroString()
        {
            string retorno;
            switch (this.Rubro)
            {
                case ERubro.Auriculares:
                    retorno = "auriculares";
                    break;
                case ERubro.Microfonos:
                    retorno = "Micronofos";
                    break;
                case ERubro.Monitores:
                    retorno = "Monitores";
                    break;
                case ERubro.MouseTeclados:
                    retorno = "Mouse y Teclados";
                    break;
                case ERubro.Parlantes:
                    retorno = "Parlantes";
                    break;
                default:
                    retorno = "Componentes de PC";
                    break;
            }
            return retorno;
        }

        public int indexEProducto()
        {
            int retorno;
            switch (this.Rubro)
            {
                case ERubro.Auriculares:
                    retorno = 0;
                    break;
                case ERubro.ComponentesPC:
                    retorno = 1;
                    break;
                case ERubro.Microfonos:
                    retorno = 2;
                    break;
                case ERubro.Monitores:
                    retorno = 3;
                    break;
                case ERubro.MouseTeclados:
                    retorno = 4;
                    break;
                default:
                    retorno = 5;
                    break;
            }
            return retorno;
        }

        #region Sobrecargas
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Codigo: {0}\n", this.codigo);
            sb.AppendFormat("Producto: {0}\n", this.Nombre);
            sb.AppendFormat("Rubro: {0}\n", this.RubroString());
            sb.AppendFormat("Precio: {0}\n", this.Precio);
            sb.AppendFormat("Cantidad en stock: {0}\n", this.Cantidad);

            return sb.ToString();
        }
        public static bool operator ==(Producto a, Producto b)
        {
            return (a.codigo == b.codigo);
        }
        public static bool operator !=(Producto a, Producto b)
        {
            return !(a == b);
        }
        public static bool operator ==(Producto a, int codigo)
        {
            return (a.codigo == codigo);
        }
        public static bool operator !=(Producto a, int codigo)
        {
            return !(a == codigo);
        }
        public bool Chequeo(List<Producto> lista, int codigo)
        {
            bool retorno = false;
            if(lista != null)
            {
                foreach (Producto item in lista)
                {
                    if (item == codigo)
                    {
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }
        public bool Chequeo(List<Producto> lista, int codigo, out int index)
        {
            bool retorno = false;
            int aux = 0;
            index = default;
            if (lista != null)
            {
                foreach (Producto item in lista)
                {
                    if (item == codigo)
                    {
                        retorno = true;
                        index = aux;
                        break;
                    }
                    aux++;
                }
            }

            return retorno;
        }
        public bool Chequeo(List<Producto> lista, Producto p, out int index)
        {
            bool retorno = false;
            int aux = 0;
            index = -1;

            foreach (Producto item in lista)
            {
                if (item == p)
                {
                    retorno = true;
                    index = aux;
                    break;
                }
                aux++;
            }

            return retorno;
        }
        public bool Chequeo(List<Producto> lista, int codigo, out Producto p)
        {
            bool retorno = false;
            int aux = 0;
            p = default;

            foreach (Producto item in lista)
            {
                if (item == codigo)
                {
                    retorno = true;
                    p = item;
                    break;
                }
                aux++;
            }

            return retorno;
        }
        #endregion

        #endregion
    }
}
