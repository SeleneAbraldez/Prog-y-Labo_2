using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Ejercicio_59
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Conexion()
        {
            try
            {
                cn = new SqlConnection(@"Data Source=ONYXIA\SQLEXPRESS;Initial Catalog=AdventureWorks2016;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar: " + ex.ToString());
            }
        }

        public string Insert(string nombre)
        {
            string auxReturn = "Inserción correcta.";
            try
            {
                cmd = new SqlCommand("INSERT INTO Production.Location (Name) VALUES ('" + nombre + "')", cn);
                cmd.ExecuteNonQuery(); //Hace que se ejecute la secuencia cmd.
            }
            catch (Exception ex)
            {
                auxReturn = "No se conectó: " + ex.ToString();
            }
            return auxReturn;
        }

        public string Eliminar(string nombre)
        {
            string auxReturn = "Eliminación correcta.";
            try
            {
                cmd = new SqlCommand("DELETE FROM Production.Location WHERE Name = '" + nombre + "'", cn);
                cmd.ExecuteNonQuery(); //Hace que se ejecute la secuencia cmd.
            }
            catch (Exception ex)
            {
                auxReturn = "No se conectó: " + ex.ToString();
            }
            return auxReturn;
        }

        public string Modificar(string nombre,string nuevoNombre)
        {
            string auxReturn = "Modificación correcta.";
            try
            {
                cmd = new SqlCommand("UPDATE Production.Location SET Name = '" + nuevoNombre + "' WHERE Name = '" + nombre + "'", cn);
                cmd.ExecuteNonQuery(); //Hace que se ejecute la secuencia cmd.
            }
            catch (Exception ex)
            {
                auxReturn = "No se conectó: " + ex.ToString();
            }
            return auxReturn;
        }

        public int RegisteredPerson(string nombre)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT * FROM Production.Location WHERE Name = '" + nombre + "'",cn);
                dr = cmd.ExecuteReader(); 
                while(dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo hacer la consulta: " + ex.ToString());
            }
            return contador;
        }
    }
}
