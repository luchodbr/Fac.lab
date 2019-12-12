using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using EntidadesAbstractas;
using Excepciones;

namespace ClasesInstanciables
{   
    [Serializable]
    public class Universidad
    {
        #region Atributos y prop

        List<Alumno> alumnos;
        List<Profesor> profesores;
         List<Jornada> jornadas;

        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }

        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornadas;
            }
            set
            {
                this.jornadas = value;
            }
        }
        public Jornada this[int i]
        {
            get
            {
                return this.jornadas[i];
            }
            set
            {
                this.jornadas[i] = value;
            }
        }
        #endregion

        #region Constructores
        public Universidad()
        {
            this.Alumnos = new List<Alumno>();
            this.Instructores = new List<Profesor>();
            this.Jornadas = new List<Jornada>();
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Guarda en el archivo XML
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        public static bool Guardar(Universidad uni)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Xml.xml";
            Xml<Universidad> xml = new Xml<Universidad>();
            return xml.Guardar(path, uni);
        }

        /// <summary>
        /// Lee el archivo 
        /// </summary>
        /// <returns></returns>
        public Universidad Leer()
        {
            Universidad rtn;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Xml.xml";
            Xml<Universidad> xml = new Xml<Universidad>();
            if (xml.Leer(path, out rtn))
            {
                return rtn;
            }
            return null;
        }
        /// <summary>
        /// Muestra los datos de cada Jornada dentro de la universidad
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        private string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Jornada: ");
            foreach (Jornada jornada in uni.Jornadas)
            {
                sb.AppendLine(jornada.ToString());
            }
            return sb.ToString();
        }
        #endregion

        #region Sobrecargas
        public override string ToString()
        {
            return MostrarDatos(this);
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
            foreach (Profesor profesor in u.Instructores)
            {
                if (profesor.Equals(p))
                return u;
            }
                    u.Instructores.Add(p);
            return u;
        }

        public static Profesor operator ==(Universidad u, EClases ec)
        {
            foreach (Profesor profesor in u.Instructores)
            {
                if (profesor == ec)
                    return profesor;
            }
            throw new Excepciones.SinProfesorException();
        }
        public static Profesor operator !=(Universidad u, EClases ec)
        {
            foreach (Profesor profesor in u.Instructores)
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
