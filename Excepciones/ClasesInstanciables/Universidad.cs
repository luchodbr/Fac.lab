using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public class Universidad
    {
        
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
        /*
        List<Jornada> jornadas;
    
        public List<Jornada> Jornadas
        {
            get { return this.jornadas; }
            set { this.jornadas = value; }
        }*/



        public enum EClases
        {
            Programacion,Laboratorio,Legislacion,SPD
        }
    }
}
