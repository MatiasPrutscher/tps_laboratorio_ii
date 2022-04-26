using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        #region CONSTRUCTORES
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }
        #endregion

        #region METODOS
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendFormat(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
