using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesProductos
{
    class Parlantes : Producto, IProductos
    {
        #region Campos

        private string estilo;
        private int potencia;

        #endregion

        #region Constructor
        public Parlantes(int codigo, string nombre, float precio, int cantidad) : base(codigo, nombre, precio, cantidad, ERubro.Parlantes)
        {
            this.Potencia = 20;
        }
        
        #endregion

        #region Propiedades
        private string Estilo { get => estilo; set => estilo = value; }
        public int Potencia { get => potencia; set => potencia = value; }
        #endregion

        #region Metodos
        public string Tipo()
        {
            string retorno;
            Random random = new Random();
            if ((random.Next(17)) % 2 == 0)
            {
                retorno = ETipo.inalambrico.ToString();
            }
            else
            {
                retorno = ETipo.alambrico.ToString();
            }
            return retorno;
        }
        #endregion

        #region Sobrecarga
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}", base.ToString());
            sb.AppendFormat("Tipo: {0}\n", this.Estilo);
            sb.AppendFormat("Potencia: {0}W\n", this.Potencia);

            return sb.ToString();
        }
        #endregion
    }
}
