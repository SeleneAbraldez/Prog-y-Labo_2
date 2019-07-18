using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Ejercicio_37;

namespace EntidadesDAO
{
    public class LocalDAO
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public LocalDAO()
        {
            cn = new SqlConnection(@"Data Source = Onyxia\SQLExpress; Initial Catalog = Centralita; Integrated Security = True");
            //cn = new SqlConnection(@"Data Source = LAB3PC02\SQLExpress; Initial Catalog = Centralita; Integrated Security = True");
        }

        public Local Leer(int duracion, string origen, string destino)
        {
            Local llamada = null;
            try
            {
                cn.Open();
                cmd = new SqlCommand(String.Format("SELECT * FROM Llamadas WHERE Duracion = {0}, Origen = '{1}', Destino = '{2}', Tipo = 0", duracion, origen, destino), cn);
                dr = cmd.ExecuteReader();
                dr.Read();
                llamada = new Local(dr["Origen"].ToString(), int.Parse(dr["Duracion"].ToString()), dr["Destino"].ToString(), float.Parse(dr["Costo"].ToString()));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }

            return llamada;
        }

        public bool Guardar(Local llamada)
        {
            bool retorno = false;
            try
            {
                cn.Open();
                cmd = new SqlCommand("INSERT INTO Llamadas(Duracion,Origen,Destino,Tipo) VALUES (" + llamada.Duracion + ", '" + llamada.NroOrigen + "', '" + llamada.NroDestino + "',0)", cn);
                cmd.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
            return retorno;
        }




    }
}
