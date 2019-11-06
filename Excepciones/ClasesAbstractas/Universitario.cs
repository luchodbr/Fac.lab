using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public abstract class Universitario : Persona
    {
        int legajo;
        public Universitario() : base()
        {
        }
        public Universitario(int legajo, string nombre, string apellido,string dni
            ,ENacionalidad nacionalidad): base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }

        protected abstract string ParticiparEnClase();
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendFormat("Legajo {0}",this.legajo.ToString());
            return sb.ToString();
        }

        public static bool operator ==(Universitario u1, Universitario u2)
        {
            if ((u1.Nacionalidad == u2.Nacionalidad) && ((u1.legajo == u2.legajo)|| (u1.DNI == u2.DNI)))
                return true;
            return false;
        }
        public static bool operator !=(Universitario u1, Universitario u2)
        {
            return !(u1 == u2);
        }
    }
}
