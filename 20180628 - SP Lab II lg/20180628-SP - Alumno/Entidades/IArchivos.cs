using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public interface IArchivos<T>
  {
    T Leer(string RutaArchivo);

    bool Guardar(string RutaArchivo, T objeto);
  
  }
}
