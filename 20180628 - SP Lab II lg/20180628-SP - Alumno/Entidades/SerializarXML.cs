using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
namespace Entidades
{
  public class SerializarXML<T> : IArchivos<T>
  {
    public T Leer(string RutaArchivo)
    {
      try
      {
        using (XmlTextReader reader = new XmlTextReader(RutaArchivo))
        {
          XmlSerializer ser = new XmlSerializer((typeof(T)));

          return (T)ser.Deserialize(reader);
        }


      }
      catch (Exception e)
      {
        //throw new ErrorArchivoException(e)
        throw e;
      }
    }
    public bool Guardar(string RutaArchivo, T vot)
    {
      try
      {
        using (XmlTextWriter Escritor = new XmlTextWriter(RutaArchivo, System.Text.Encoding.UTF8))
        {
          XmlSerializer ser = new XmlSerializer((typeof(T)));
          ser.Serialize(Escritor, vot);
          return true;
        }
      }
      catch (Exception e)
      {
        //throw new ErrorArchivoException(e)
        throw e;
      }

    }
  }
}
