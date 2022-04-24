using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        #region CAMPOS
        private double numero;
        #endregion

        #region PROPIEDADES
        private string Numero
        {
            set
            {
                this.numero = this.ValidarOperando(value);
            }
        }
        #endregion

        #region METODOS

        #region CONSTRUCTORES
        public Operando() : this(0)
        {
        }
        public Operando(double numero) : this(numero.ToString())
        {

        }
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }
        #endregion

        private double ValidarOperando(string strNumero)
        {
            double numero;
            if(!double.TryParse(strNumero, out numero))
            {
                numero = 0;
            }
            return numero;
        }

        /// <summary>
        /// El método privado EsBinario validará que la cadena de caracteres esté compuesta
        ///SOLAMENTE por caracteres '0' o '1'.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private bool EsBinario(string binario)
        {
            bool retorno = true;

            for (int i = 0; i < binario.Length; i++)
            {
                if(binario[i] != '1'&& binario[i] != '0')
                {
                    retorno = false;
                    break;
                }    
            }
            return retorno;
        }

        /// <summary>
        /// Convierte un numero binario en decimal, si no es binario devuelve "Valor invalido"
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor invalido";

            if (this.EsBinario(binario) && !string.IsNullOrEmpty(binario))
            {
                retorno = Convert.ToInt32(binario, 2).ToString();
            }

            return retorno;
        }

        /// <summary>
        /// Convierte un numero decimal en binario, si no se puede devuelve "Valor invalido"
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
            if (numero != "Valor invalido")
            {
                numero = DecimalBinario(double.Parse(numero));
            }
            return numero;
        }

        /// <summary>
        /// Convierte un numero decimal en binario, si no se puede devuelve "Valor invalido"
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            string retorno = "Valor invalido";
            int aux;

            if (numero > -1)
            {
                aux = Convert.ToInt32(numero);
                retorno = Convert.ToString(aux, 2);
            }

            return retorno;

        }

        #region SOBRECARGAS
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Operando n1, Operando n2)
        {
            double resultado;
            if (n2.numero == 0)
            {
                resultado = double.MinValue;
            }
            else
            {
                resultado = n1.numero / n2.numero;
            }
            return resultado;
        }
        #endregion
        #endregion
    }
}
