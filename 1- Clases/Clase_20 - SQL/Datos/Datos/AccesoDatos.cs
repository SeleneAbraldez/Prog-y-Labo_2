using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class AccesoDatos
    {
        private SqlConnection _conexion;
        private SqlCommand _comando;


        public AccesoDatos()
        {
            this._conexion = new SqlConnection(Properties.Settings.Default.conexion_bd);

        }

        public List<Persona> TraerTodos()
        {
            List<Persona> listaP = new List<Persona>();
            SqlDataReader sqlReader;

            try
            {
                this._comando = new SqlCommand();
                this._comando.Connection = this._conexion;
                this._comando.CommandType = CommandType.Text;
                this._comando.CommandText = "SELECT * FROM Padron.dbo.Personas";
                this._conexion.Open();
                sqlReader = this._comando.ExecuteReader();
                while (sqlReader.Read())
                {
                    Persona per = new Persona((int)sqlReader["id"], sqlReader["nombre"].ToString(), sqlReader["apellido"].ToString(), (int)sqlReader["edad"]);
                    listaP.Add(per);
                }
                this._conexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return listaP;
        }
        
        public bool AgregarPersona(Persona p)
        {
            bool retorno = false;
            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = "INSERT INTO Padron.dbo.Personas (nombre, apellido, edad) values ('"+ p.nombre +"', '" + p.apellido +"', "+ p.edad.ToString()+")";
            this._conexion.Open();

            if (this._comando.ExecuteNonQuery() > 0)
            {
                retorno = true;
            }

            this._conexion.Close();

            return retorno;
        }

        public bool ModificarPersona(Persona p)
        {
            bool retorno = false;

            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = "UPDATE Padron.dbo.Personas SET (nombre, apellido, edad) values ('" + p.nombre + "', '" + p.apellido + "', " + p.edad.ToString() + ") WHERE id = "+p.id+";";
            this._conexion.Open();

            if (this._comando.ExecuteNonQuery() > 0)
            {
                retorno = true;
            }

            this._conexion.Close();

            return retorno;
        }
    }
}
