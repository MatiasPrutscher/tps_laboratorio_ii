using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Cliente
    {
        #region Campos

        private double dni;
        private string nombre;
        private EResidencia residencia;

        #endregion

        #region Constructor

        public Cliente(double dni, string nombre, EResidencia residencia)
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

        #region Sobrecargas

        public static bool operator ==(Cliente a, Cliente b)
        {
            return (a.dni == b.dni);
        }
        public static bool operator !=(Cliente a, Cliente b)
        {
            return !(a == b);
        }

        #endregion
    }
}
