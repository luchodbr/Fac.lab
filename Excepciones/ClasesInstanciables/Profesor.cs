using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;
namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        Queue<Universidad.EClases> clasesDelDia;
        static Random random;

        private void _randomClases()
        {
            Profesor.random.Next(1, 4);
        }
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASES DEL DIA");
            foreach (Universidad.EClases c in this.clasesDelDia)
            {
                sb.AppendLine(c.ToString()); 
            }
            return sb.ToString();

        }
        static Profesor()
        {
            Profesor.random = new Random();
        }
        private Profesor()
        { }
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nac)
        { }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendFormat("Clase que da {0} ", this.ParticiparEnClase());
            return sb.ToString();
        }
    }
}
