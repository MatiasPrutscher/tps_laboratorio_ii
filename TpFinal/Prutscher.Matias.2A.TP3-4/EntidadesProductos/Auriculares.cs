using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesProductos
{
    class Auriculares : Producto, IProductos
    {
        #region Campos

        private string estilo;
        private int rangoMax;
        private int rangoMin;

        #endregion

        #region Constructor

        public Auriculares(int codigo, string nombre, float precio, int cantidad) : base(codigo, nombre, precio, cantidad, ERubro.Auriculares)
        {
            this.Estilo = this.Tipo();
            this.RangoMax = 20000;
            this.rangoMin = 20;
        }

        
        #endregion

        #region Propiedades
        private string Estilo { get => estilo; set => estilo = value; }
        public int RangoMax { get => rangoMax; set => rangoMax = value; }
        public int RangoMin { get => rangoMin; set => rangoMin = value; }
        #endregion

        #region Metodos
        public string Tipo()
        {
            string retorno;
            Random random = new Random();
            if ((random.Next(50)) % 2 == 0)
            {
                retorno = ETipo.inalambrico.ToString();
            }
            else
            {
                retorno = ETipo.alambrico.ToString();
            }
            return retorno;
        }

        #region Sobrecarga

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}", base.ToString());
            sb.AppendFormat("Tipo: {0}\n", this.Estilo);
            sb.AppendFormat("Rango de frecuencia: {0}hz a {1}hz\n", this.RangoMin, this.RangoMax);

            return sb.ToString();
        }

        #endregion

        #endregion



    }
}
