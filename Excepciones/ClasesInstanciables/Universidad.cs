using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using EntidadesAbstractas;
namespace ClasesInstanciables
{
    public class Universidad
    {
        #region Atributos y prop

        List<Alumno> alumnos;

        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }
        List<Profesor> profesores;

        public List<Profesor> Profesores
        {
            get { return this.profesores; }
            set { this.profesores = value; }
        }

        List<Jornada> jornadas;

        public List<Jornada> Jornadas
        {
            get { return this.jornadas; }
            set { this.jornadas = value; }
        }
        #endregion
        #region Constructores
        public Universidad()
        {
            this.Alumnos = new List<Alumno>();
            this.Profesores = new List<Profesor>();
            this.Jornadas = new List<Jornada>();
        }
        #endregion
        public Jornada this[int x]
        {
            get
            {
                if (x > 0 && x < this.Jornadas.Count)
                    return this.Jornadas[x];
                return null;
            }
        }
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            xml.Guardar("xml uni", uni);
            return true;
        }

        public Universidad Leer()
        {
            Universidad u = new Universidad();
            Xml<Universidad> xml = new Xml<Universidad>();
            xml.Leer("xml uni", out u);
            return u;
        }
        private string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Jornada jornada in this.Jornadas)
            {
                sb.AppendLine(jornada.ToString());
            }
            return sb.ToString();
        }
        #region Sobrecargas
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        public static bool operator ==(Universidad u, Alumno a1)
        {
            foreach (Alumno alumno in u.Alumnos)
            {
                if (alumno == a1)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Universidad u, Alumno a1)
        {
            return !(u == a1);
        }
        public static bool operator ==(Universidad u, Profesor p)
        {
            foreach (Jornada jornada in u.Jornadas) //como la consigna dice "profesores que estan dando clases, compare
            {                                       //los que dan alguna clase en una jornada, y no con la lista de prof
                if (p == jornada.Clase)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Universidad u, Profesor p)
        {
            return !(u == p);
        }
        public static Universidad operator +(Universidad u, EClases clase)
        {
            Profesor p =(u == clase); 
            
            Jornada j = new Jornada(clase, p);
            foreach (Alumno alumno in u.Alumnos)
            {
                if (j != alumno && alumno == clase)
                {
                    j.Alumnos.Add(alumno);
                }
            }
            u.Jornadas.Add(j);
            return u;
        }
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a)
            {
                    u.Alumnos.Add(a);
                return u;
            }
            
            throw new Excepciones.AlumnoRepetidoException();
        }
        public static Universidad operator +(Universidad u, Profesor p)
        {
            foreach (Profesor profesor in u.Profesores)
            {
                if (profesor.Equals(p))
                return u;
            }
                    u.Profesores.Add(p);
            return u;
        }

        public static Profesor operator ==(Universidad u, EClases ec)
        {
            foreach (Profesor profesor in u.Profesores)
            {
                if (profesor == ec)
                    return profesor;
            }
            throw new Excepciones.SinProfesorException();
        }
        public static Profesor operator !=(Universidad u, EClases ec)
        {
            foreach (Profesor profesor in u.Profesores)
            {
                if (profesor != ec)
                    return profesor;
            }
            Profesor p = null;

            return p;
        }

        #endregion
        public enum EClases
        {
            Programacion, Laboratorio, Legislacion, SPD
        }
    }
}
