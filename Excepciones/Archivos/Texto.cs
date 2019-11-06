using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.WriteLine(datos);
                    return true;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Leer(string archivo, out string datos)
        {
            try
            {
                using (StreamReader reader = new StreamReader(archivo))
                {
                    while ((datos = reader.ReadLine()) != null)
                    {
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }




    }
}


