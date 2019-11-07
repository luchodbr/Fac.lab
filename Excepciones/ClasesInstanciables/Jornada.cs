using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
namespace ClasesInstanciables
{
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
            this.alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor)
        {

        }

        public static bool operator ==(Jornada j, Alumno a)
        {
            foreach (Alumno alumno in j.alumnos)
            {
                if (alumno == a)
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
            sb.Append("Clase de " + this.clase);
            sb.AppendFormat("NOMBRE COMPLETO {} ", this.Profesor.ToString());
            foreach (Alumno alumno in this.Alumnos)
            {
                sb.AppendLine(alumno.ToString());
            }
            return sb.ToString();
        }

        public bool Guardar()
        {
            Texto t = new Texto();
            return t.Guardar("Texto de jornada", this.ToString());
            
        }
        public bool Leer()
        {
            Texto t = new Texto();
            return t.Leer("Texto de jornada",out string s);

        }
    }
}
