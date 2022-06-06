using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesProductos
{
    class MouseYTeclados : Producto, IProductos
    {
        #region Campos
        private string estilo;
        #endregion

        #region Constructor
        public MouseYTeclados(int codigo, string nombre, float precio, int cantidad) : base(codigo, nombre, precio, cantidad, ERubro.MouseTeclados)
        {
            this.Estilo = this.Tipo();
        }
        #endregion

        #region Propiedades
        public string Estilo { get => estilo; set => estilo = value; }
        #endregion

        #region Metodos
        public string Tipo()
        {
            string retorno;
            Random random = new Random();
            if ((random.Next(37)) % 2 == 0)
            {
                retorno = ETipo.inalambrico.ToString();
            }
            else
            {
                retorno = ETipo.alambrico.ToString();
            }
            return retorno;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}", base.ToString());
            sb.AppendFormat("Tipo: {0}\n", this.Estilo);

            return sb.ToString();
        }
        #endregion
    }
}
