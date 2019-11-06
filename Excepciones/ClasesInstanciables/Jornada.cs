using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private Universidad.EClases clases;

        public Universidad.EClases Clases
        {
            get { return clases; }
            set { clases = value; }
        }

        private Profesor profesor;

        public Profesor Profesor
        {
            get { return profesor; }
            set { profesor = value; }
        }

        private Jornada()
        { }

        public Jornada(Universidad.EClases clase, Profesor instructor)
        {

        }



    }
}
