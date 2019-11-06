using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace ClasesAbstractas
{
    public abstract class Persona
    {
        #region Atributos y prop

        string apellido;
        int dni;
        ENacionalidad nacionalidad;
        string nombre;

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public int DNI
        {
            get { return this.dni; }
            set
            {
                this.dni = value;
            }
        }
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string StringToDNI
        {
            set { this.dni = 1/*value;*/ ; }
        }

        #endregion

        public Persona()
        {
        }
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
        }
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
        {
        }
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre {0}",this.Nombre);
            sb.AppendFormat("Apellido {0}",this.Apellido);
            sb.AppendFormat("Dni {0}",this.DNI.ToString());
            return sb.ToString();
        }

        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (dato > 1 && dato < 99999999)
                if (nacionalidad == ENacionalidad.Argentino)
                {
                    if (dato > 89999999)
                    {
                        throw new NacionalidadInvalidaException();
                    }
                    else { this.DNI = dato; }
                }
                else
                {
                    if (dato > 89999999)
                    { this.DNI = dato; }
                    else
                    {
                    throw new NacionalidadInvalidaException();
                    }
                }
            else
            {
                throw new DniInvalidoException();
            }


            return 1;
        }
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            try
            {
                this.ValidarDni(nacionalidad, int.Parse(dato));

            }
            catch (Exception e)
            {

                throw new DniInvalidoException(e,"Error al parsear el dni, no es un numero");
            }
            return 1;
        }
        private string ValidarNombreApellido(string dato)
        {
            return "";
        }
        public enum ENacionalidad
        {
            Argentino, Extranjero
        }

        
    }
}
