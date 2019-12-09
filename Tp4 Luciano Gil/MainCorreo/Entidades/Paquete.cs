using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.DireccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
        }
        #region Atributos y Propiedades

        private string direccionEntrega;

        public string DireccionEntrega
        {
            get { return direccionEntrega; }
            set { direccionEntrega = value; }
        }
        private EEstado estado;

        public EEstado Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private string trackingID;

        public string TrackingID
        {
            get { return trackingID; }
            set { trackingID = value; }
        }

        #endregion


        #region Metodos

        /// <summary>
        /// Hace que el paquete pase por los 3 estados. Con el tiempo que esto implica
        /// </summary>
        public void MockCicloDeVida()
        {
            for (int i = 0; i < 3; i++)
            {
                if (this.estado == EEstado.Entregado)
                    break;
                this.estado = (EEstado)i;
                this.InformaEstado.Invoke(this, null);
                System.Threading.Thread.Sleep(4000);
            }
            PaqueteDAO.Insertar(this);
        }
        /// <summary>
        /// Devuelve el ID del paquete y su direccion de entrega
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>
       public string MostrarDatos(IMostrar<Paquete>elemento)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} Para {1},",((Paquete)elemento).TrackingID, ((Paquete)elemento).DireccionEntrega);
            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} Estado: {1},", this.MostrarDatos(this), this.estado);
            return sb.ToString();
        }

        

        #endregion
        public static bool operator ==(Paquete p1, Paquete p2)
        {
            if (p1.trackingID == p2.trackingID)
                return true;
            return false;
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Evento que informara el estado del paquete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public event DelegadoEstado InformaEstado;

        #region TiposAnidados
        public delegate void DelegadoEstado(object sender, EventArgs e);

        public enum EEstado
        {
            Ingresado,EnViaje,Entregado

        }
        #endregion
    }
}
