using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCliente
{
    public class Cliente
    {
        #region Campos

        private double dni;
        private string nombre;
        private EResidencia residencia;

        #endregion

        #region Constructor

        public Cliente()
        {
            this.dni = 0;
            this.nombre = "anonimo";
            this.residencia = EResidencia.X;
        }

        public Cliente(double dni, string nombre, EResidencia residencia) : this()
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Residencia = residencia;
        }

        #endregion

        #region Propiedades

        public double Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public EResidencia Residencia { get => residencia; set => residencia = value; }

        #endregion

        #region Metodos
        public static int buscarCliente(List<Cliente> listaClientes, Cliente cliente)
        {
            int index = 0;
            bool aux = false;
            foreach (Cliente item in listaClientes)
            {
                if (item == cliente)
                {
                    aux = true;
                    break;
                }
                index++;
            }
            if(aux != true)
            {
                index = -1;
            }
            return index;
        }

        public bool buscarCliente(List<Cliente> listaClientes, double dni, out int index)
        {
            int auxIndex = 0;
            bool aux = false;
            index = default;
            foreach (Cliente item in listaClientes)
            {
                if (item == dni)
                {
                    aux = true;
                    index = auxIndex;
                    break;
                }
                auxIndex++;
            }
            return aux;
        }

        #region Sobrecargas

        public static bool operator ==(Cliente a, Cliente b)
        {
            return (a.dni == b.dni);
        }
        public static bool operator !=(Cliente a, Cliente b)
        {
            return !(a == b);
        }

        public static bool operator ==(Cliente a, double n)
        {
            return (a.dni == n);
        }
        public static bool operator !=(Cliente a, double n)
        {
            return !(a == n);
        }

        #endregion

        #endregion
    }
}
