using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using System.Threading;
namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        #region Atributos y prop

        public Queue<Universidad.EClases> clasesDelDia;
        static Random random;

        #endregion

        #region Constructores

        static Profesor()
        {
            Profesor.random = new Random();

        }
        public Profesor()
        {

        }
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nac):base(id,nombre,apellido,dni,nac)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            _randomClases();
            _randomClases();

        }
        #endregion
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
        private void _randomClases()
        {
            this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(0, 3));
            Thread.Sleep(300);
        }
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
        
        public static bool operator ==(Profesor p, Universidad.EClases e1)
        {
            foreach (Universidad.EClases ec in p.clasesDelDia)
            {
                if(ec == e1)
                {
                    return true;
                }
            }
                return false;
        }
        public static bool operator !=(Profesor p, Universidad.EClases e1)
        {
            return !(p == e1);
        }

    }
}
