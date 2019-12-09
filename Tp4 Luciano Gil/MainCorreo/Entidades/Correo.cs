using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        #region Atrib y prop

        List<Thread> mockPaquetes;

        private List<Paquete> paquetes;

        public List<Paquete> Paquetes
        {
            get { return paquetes; }
            set { paquetes = value; }
        }
        #endregion

        public Correo()
        {
            this.mockPaquetes = new List<Thread>();
            this.paquetes = new List<Paquete>();
        }

        #region Metodos

        public void FinEntregas()
        {
            foreach (Thread t in this.mockPaquetes)
            {
                t.Abort();
            }
        }

        public string MostrarDatos(IMostrar<List<Paquete>> elemento)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Paquete p in ((Correo)elemento).Paquetes)
            {
               // sb.AppendFormat("{0} Para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString());
                sb.AppendFormat(p.ToString()+"\n");
                
            }

            return sb.ToString();
        }
        #endregion

        public static Correo operator +(Correo c, Paquete p)
        {
            Thread tPaquete = new Thread(p.MockCicloDeVida);
            foreach (Paquete paquete in c.paquetes)
            {
                if (paquete == p)
                {
                    throw new TrackingIdRepetidoException("El TrackingID ya existe.");
                }
            }
            c.paquetes.Add(p);
            c.mockPaquetes.Add(tPaquete);
            tPaquete.Start();
            return c;
        }
    }
}
