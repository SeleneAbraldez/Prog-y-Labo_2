using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Ejercicio_60
{
    class PersonaDAO
    {
        static SqlConnection cn;
        static SqlCommand cmd;
        static SqlDataReader dr;

        static PersonaDAO()
        {
            //cn = new SqlConnection(@"Data Source=LAB3PC02\SQLEXPRESS;Initial Catalog=Persona;Integrated Security=True");
            cn = new SqlConnection(@"Data Source = ONYXIA\SQLEXPRESS; Initial Catalog = Persona; Integrated Security = True");            
        }

        public static bool Guardar(Persona persona)
        {
            bool retorno = false;
            try
            {
                cn.Open();
                cmd = new SqlCommand("INSERT INTO Persona(Nombre,Apellido) VALUES ('" + persona.Nombre + "','" + persona.Apellido + "')", cn);
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
                {
                    cn.Close();
                }
            }

            return retorno;        
        }

        public static List<Persona> Leer()
        {
            List<Persona> lista = new List<Persona>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("SELECT Nombre, Apellido, ID FROM Persona", cn);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    Persona p = new Persona(dr["Nombre"].ToString(), dr["Apellido"].ToString(),dr["ID"].ToString());
                    lista.Add(p);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return lista;
        }

        public static Persona LeerPorID(string ID)
        {
            Persona persona = null;
            try
            {
                cn.Open();
                cmd = new SqlCommand("SELECT (Nombre, Apellido) FROM Persona WHERE ID = " + ID, cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                { 
                    persona = new Persona(dr["Nombre"].ToString(), dr["Apellido"].ToString(),dr["ID"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return persona;        
        }

        public static bool Modificar(string ID, string nombre, string apellido)
        {
            bool retorno = false;
            try
            {
                cn.Open();
                cmd = new SqlCommand("UPDATE Persona SET Nombre = '" + nombre + "',Apellido = '" + apellido + "' WHERE ID = " + ID, cn);
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
                {
                    cn.Close();
                }
            }

            return retorno;
        }

        public static bool Borrar(string ID)
        {
            bool retorno = false;
            try
            {
                cn.Open();
                cmd = new SqlCommand("DELETE FROM Persona WHERE ID = " + ID, cn);
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
                {
                    cn.Close();
                }
            }
            return retorno;        
        }
    }
}
