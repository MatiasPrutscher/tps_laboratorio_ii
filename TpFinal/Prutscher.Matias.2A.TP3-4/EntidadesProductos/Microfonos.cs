using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesProductos
{
    class Microfonos : Producto, IProductos
    {
        #region Campos
        private string estilo;
        private int rangoMax;
        private int rangoMin;
        #endregion
        public Microfonos(int codigo, string nombre, float precio, int cantidad) : base(codigo, nombre, precio, cantidad, ERubro.Microfonos)
        {
            this.Estilo = this.Tipo();
            this.RangoMax = 18000;
            this.RangoMin = 50;
        }

        public string Estilo { get => estilo; set => estilo = value; }
        public int RangoMax { get => rangoMax; set => rangoMax = value; }
        public int RangoMin { get => rangoMin; set => rangoMin = value; }

        public string Tipo()
        {
            string retorno;
            Random random = new Random();
            if ((random.Next(7)) % 2 == 0)
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
            sb.AppendFormat("Respuesta de frecuencia: {0}hz a {1}hz\n", this.RangoMin, this.RangoMax);

            return sb.ToString();
        }
    }
}
