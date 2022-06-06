using System;

namespace ListaGenerica
{
    public class Lista<T>
    {
        #region Campos
        private T[] lista;
        private int indice = 0;
        private int total;

        #endregion

        #region Propiedades
        public int Total { get => total; set => total = value; }
        #endregion

        #region Metodos
        /// <summary>
        /// Inicializa la lista generica
        /// </summary>
        /// <param name="total"></param>
        public Lista(int total)
        {
            this.lista = new T[total];
            this.Total = total;
        }

        /// <summary>
        /// Agrega un nuevo item a la lista generica
        /// </summary>
        /// <param name="t"></param>
        public bool Agregar(T t)
        {
            bool aux = false;
            if (this.libre())
            {
                this.lista[indice] = t;
                this.indice++;
                aux = true;
            }
            return aux;
        }

        /// <summary>
        /// Devuelve el item en la posicion solicitada
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public T GetItem(int i)
        {
            return this.lista[i];
        }

        /// <summary>
        /// chequea que haya lugares libres en la lista
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private bool libre()
        {
            bool aux = false;
            if (this.Total > this.indice)
            {
                aux = true;
            }
            return aux;
        }

        /// <summary>
        /// borra un item a la lista generica
        /// </summary>
        /// <param name="t"></param>
        public bool Borrar(int index)
        {
            bool aux = false;
            aux = true;
            return aux;
        }

        #endregion
    }
}
