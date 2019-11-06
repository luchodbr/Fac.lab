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
    public class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            try
            {
            using (XmlTextWriter writer = new XmlTextWriter(archivo, System.Text.Encoding.UTF8))
            {
                XmlSerializer ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer,datos );
                return true;
            }

            }
            catch (Exception ex)
            {
              //  throw new
                return false;
                throw ex;
            }
        }


        public bool Leer(string archivo, out T datos)
        {
            try
            {
            using (XmlTextReader reader = new XmlTextReader(archivo))
            {
                XmlSerializer ser = new XmlSerializer(typeof(T));

                object aux =  new object();

                aux = (T)ser.Deserialize(reader);

                    datos = (T)aux;
                    return true;

            }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
