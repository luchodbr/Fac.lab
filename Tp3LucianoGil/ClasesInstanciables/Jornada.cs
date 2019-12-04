using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
namespace ClasesInstanciables
{
    [Serializable]
    public class Jornada
    {
        private List<Alumno> alumnos;

        public List<Alumno> Alumnos
        {
            get { return alumnos; }
            set { alumnos = value; }
        }

        private Universidad.EClases clase;

        public Universidad.EClases Clase
        {
            get { return clase; }
            set { clase = value; }
        }

        private Profesor profesor;

        public Profesor Profesor
        {
            get { return profesor; }
            set { profesor = value; }
        }

        private Jornada()
        {
        }

        public Jornada(Universidad.EClases clase, Profesor instructor)
        {
            this.alumnos = new List<Alumno>();
            this.Clase = clase;
            this.Profesor = instructor;
        }

        public static bool operator ==(Jornada j, Alumno a)
        {
            foreach (Alumno alumno in j.Alumnos)
            {
                if (alumno.Equals(a))
                    return true;
            }
            return false;
        }
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.alumnos.Add(a);
                return j;
            }
            return j;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("CLASE DE " +this.clase+" POR ");
            sb.Append(this.Profesor.ToString());
            sb.AppendLine("ALUMNOS: ");
            foreach (Alumno alumno in this.Alumnos)
            {
                sb.AppendLine(alumno.ToString());
            }
            return sb.ToString();
        }

        public static bool Guardar(Jornada jornada)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Jornada.txt";
            Texto texto = new Texto();
            return texto.Guardar(path, jornada.ToString());

        }
        public bool Leer()
        {
            Texto t = new Texto();
            return t.Leer("Jornada.txt", out string s);

        }
    }
}
