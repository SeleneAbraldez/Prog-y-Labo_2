using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Ejercicio_56
{
    [Serializable]
    class Persona
    {
        private string nombre;
        private string apellido;

        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static void Guardar(Persona p)
        {
            FileStream file = null;
            BinaryFormatter ser = new BinaryFormatter();
            try
            {
                file = new FileStream("Persona.bin", FileMode.Create);
                ser.Serialize(file, p);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (!object.ReferenceEquals(file, null))
                {
                    file.Close();
                }
            }                      
        }

        public static Persona Leer()
        {
            Persona dato;
            BinaryFormatter ser = new BinaryFormatter();
            FileStream file = null;
            try
            {
                file = new FileStream("Persona.bin", FileMode.Open);
                dato = (Persona)ser.Deserialize(file);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if(!object.ReferenceEquals(file,null))
                {
                    file.Close();
                }
            }           
            
            return dato;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", this.nombre, this.apellido);
        }

    }
}
