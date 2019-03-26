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
    public class ProvincialDAO
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        string rutaDeArchivo;

        public string RutaDeArchivo
        {
            get
            {
                return rutaDeArchivo;
            }
            set
            {
                this.rutaDeArchivo = value;
            }
        }
        public ProvincialDAO()
        {
            cn = new SqlConnection(@"Data Source = Onyxia\SQLExpress; Initial Catalog = Centralita; Integrated Security = True");
            //cn = new SqlConnection(@"Data Source = LAB3PC02\SQLExpress; Initial Catalog = Centralita; Integrated Security = True");
        }

        public Provincial Leer(int duracion, string origen, string destino)
        {
            Provincial llamada = null;
            try
            {
                cn.Open();
                cmd = new SqlCommand(String.Format("SELECT * FROM Llamadas WHERE Duracion = {0}, Origen = '{1}', Destino = '{2}', Tipo = 1", duracion, origen, destino), cn);
                dr = cmd.ExecuteReader();
                dr.Read();
                llamada = new Provincial(dr["Origen"].ToString(), int.Parse(dr["Duracion"].ToString()), dr["Destino"].ToString(), (Provincial.Franja)int.Parse(dr["Costo"].ToString()));
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

        public bool Guardar(Provincial llamada)
        {
            bool retorno = false;
            try
            {
                cn.Open();
                cmd = new SqlCommand("INSERT INTO Llamadas(Duracion,Origen,Destino,Tipo) VALUES (" + llamada.Duracion + ", '" + llamada.NroOrigen + "', '" + llamada.NroDestino + "',1)", cn);
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
