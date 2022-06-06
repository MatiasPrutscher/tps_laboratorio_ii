using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesProductos
{
    class Monitores : Producto
    {
        #region Campos
        private string tipoPantalla;
        #endregion

        #region Constructor
        public Monitores(int codigo, string nombre, float precio, int cantidad) : base(codigo, nombre, precio, cantidad, ERubro.Monitores)
        {
            this.tipoPantalla = this.RandomPantalla();
        }
        #endregion

        #region Metodos
        private string RandomPantalla()
        {
            string retorno;
            Random random = new Random();
            if ((random.Next(96)) % 2 == 0)
            {
                retorno = "curvo";
            }
            else
            {
                retorno = "plano";
            }
            return retorno;
        }
        #endregion
        #region Sobrecarga
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}", base.ToString());
            sb.AppendFormat("Tipo de monitor: {0}\n", this.tipoPantalla);

            return sb.ToString();
        }
        #endregion
    }
}
