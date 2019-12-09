using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PaqueteDAO
    {
        static SqlConnection conexion;
        static SqlCommand comando;

        public delegate void DelegadoDAOError(string mensaje);
        public static event DelegadoDAOError EventDAOError;

        static PaqueteDAO()
        {
            IniciarConexion();
        }

        /// <summary>
        /// Método estático que guarda el paquete P en la base de datos.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool Insertar(Paquete p)
        {
            if (p is null)
            {
                EventDAOError.Invoke("El paquete es null");
                return false;
            }
            DatosAInsertar(p);
            try
            {
                PaqueteDAO.conexion.Open();
                PaqueteDAO.comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                EventDAOError.Invoke(e.Message);
                return false;
            }
            finally
            {
                PaqueteDAO.conexion.Close();
            }
            return true;
        }

        /// <summary>
        /// Metodo que inicializa la coneccion a la base de datos
        /// </summary>
        static void IniciarConexion()
        {
            try
            {
            PaqueteDAO.conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog =correo-sp-2017; Integrated Security = True");
            PaqueteDAO.comando = new SqlCommand();
            PaqueteDAO.comando.CommandType = System.Data.CommandType.Text;
            PaqueteDAO.comando.Connection = PaqueteDAO.conexion;

            }
            catch (Exception e)
            {
                EventDAOError.Invoke(e.Message);
            }
        }

        static void DatosAInsertar(Paquete p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("INSERT INTO dbo.Paquetes(direccionEntrega, trackingID, alumno) VALUES('{0}', '{1}', 'Luciano Gil')", p.DireccionEntrega, p.TrackingID);
            PaqueteDAO.comando.CommandText = sb.ToString();

        }
    }
}
