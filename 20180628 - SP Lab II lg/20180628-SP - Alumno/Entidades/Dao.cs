using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class Dao : IArchivos<Votacion>
    {
        public Votacion Leer(string s)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(string RutaArchivo, Votacion obj)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("INSERT INTO Votaciones(nombreLey,afirmativos,negativos,abstenciones,nombreAlumno)" +
                                "VALUES ('{0}',{1},{2},{3},'{4}')",
                                obj.NombreLey, obj.ContadorAfirmativo, obj.ContadorNegativo
                                , obj.ContadorAbstencion,"LucianoGil");
                FuncionCallSql(sb.ToString());
                return true;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        void FuncionCallSql(string DatosAInsertar)
        {
            //String connectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog =votacion-sp-2018; Integrated Security = True";
            //SqlConnection conexion = new SqlConnection(connectionStr);
            //SqlCommand comando = new SqlCommand();
            //comando.CommandType = System.Data.CommandType.Text;

            //comando.Connection = conexion;
            SqlCommand comando = RetornaComand("votacion-sp-2018");
            SqlConnection conexion = comando.Connection;
            String consulta;
            consulta = DatosAInsertar;
            comando.CommandText = consulta;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        SqlCommand RetornaComand(string NombreBaseDatos)
        {
            String connectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog =" + NombreBaseDatos + "; Integrated Security = True";
            SqlConnection conexion = new SqlConnection(connectionStr);
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            return comando;

        }

    }
}
