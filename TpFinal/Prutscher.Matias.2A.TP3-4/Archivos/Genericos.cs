using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Archivos
{
    public class Genericos<T>
    {
        /// <summary>
        /// Guarda los datos en la ruta marcada, en caso de no de error marca exception y devuelve false
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="lista"></param>
        public bool GuardarDatos(string ruta, List<T> lista)
        {
            bool retorno = false;
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                using (StreamWriter streamWriter = new StreamWriter(ruta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(lista.GetType());
                    xmlSerializer.Serialize(streamWriter, lista);
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return retorno;
        }

        /// <summary>
        /// Lee los datos de la ruta marcada, en caso de no de error marca exception y devuelve false
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns></returns>
        public bool RecuperarDatos(string ruta, out T lista)
        {
            bool retorno = false;
            lista = default;
            try
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(lista.GetType());
                    lista = (T)xmlSerializer.Deserialize(streamReader);
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return retorno;
        }
    }
}
