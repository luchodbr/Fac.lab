using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Excepciones;
using Archivos;
using ClasesInstanciables;

namespace ClasesInstanciables
{
    public class Alumno : Universitario
    {

        Universidad.EClases clasesQueToma;
        EEstadoCuenta estadoCuenta;
        public Alumno()
        {

        }
        public Alumno(int id, string nombre, string apellido, string dni,
            ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            :this(id,nombre,apellido,dni,nacionalidad,claseQueToma,EEstadoCuenta.AlDia)
        {

        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad
        nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) 
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesQueToma = claseQueToma;
            this.estadoCuenta = estadoCuenta;
        }

        protected override string ParticiparEnClase()
        {
            return "Toma clase de: " + this.clasesQueToma.ToString();
        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendFormat("Clase que toma {0}\n", this.clasesQueToma.ToString());
            sb.AppendFormat("Estado de cuenta {0}\n", this.estadoCuenta.ToString());
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        public static bool operator ==(Alumno a1, Universidad.EClases c1)
        {
            if (a1.clasesQueToma == c1 && a1.estadoCuenta != EEstadoCuenta.Deudor)
                return true;
            else
                return false;
        }
        public static bool operator !=(Alumno a1, Universidad.EClases c1)
        {
            if (a1.clasesQueToma != c1)
                return true;
            else
                return false;
        }


        public enum EEstadoCuenta
        {
            AlDia, Deudor, Becado
        }

    }
}
