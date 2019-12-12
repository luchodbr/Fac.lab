using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Text.RegularExpressions;

namespace EntidadesAbstractas
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
            set { this.apellido = this.ValidarNombreApellido(value); }
        }
        public int DNI
        {
            get { return this.dni; }
            set
            {
                this.dni = this.ValidarDni(this.Nacionalidad, value);
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
            set { this.nombre = this.ValidarNombreApellido(value); }
        }

        public string StringToDNI
        {
            set { this.dni = this.ValidarDni(this.Nacionalidad, value); }
        }

        #endregion

        public Persona()
        {
        }
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            :this(nombre, apellido, nacionalidad)
        {
           
            this.DNI = dni;

        }
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :this(nombre,apellido,nacionalidad)
        {
            this.StringToDNI= dni;
        }
        private string ValidarNombreApellido(string dato)
        {

            if (Regex.IsMatch(dato, "^[a-zA-ZñÑ]+$"))
            {

                return dato;
            }
            else
            {
                return null;
            }
        }
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE COMPLETO: " +this.apellido +" " + this.nombre);
            sb.AppendLine("NACIONALIDAD: " +this.nacionalidad);
            return sb.ToString();
        }

        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (dato >= 1 && dato <= 99999999)
            {
                if (nacionalidad == ENacionalidad.Argentino)
                {
                    if (dato > 89999999)
                    {
                        throw new NacionalidadInvalidaException("la nacionalidad no se condice con el dni");
                    }
                }
                else
                {
                    if (dato > 89999999)
                    { }
                    else
                    {
                        throw new NacionalidadInvalidaException("la nacionalidad no se condice con el dni");
                    }
                }
            }
            else
            {
                throw new DniInvalidoException();
            }


            return dato;
        }
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int salida;
            try
            {
               salida=this.ValidarDni(nacionalidad, int.Parse(dato));

            }
            catch (NacionalidadInvalidaException e)
            {

                throw e;
            }
            catch(Exception e)
            {

            throw new DniInvalidoException(e, "Error al parsear el dni, no es un numero");
            }

            return salida;
        }
        
     
        public enum ENacionalidad
        {
            Argentino, Extranjero
        }

        
    }
}
