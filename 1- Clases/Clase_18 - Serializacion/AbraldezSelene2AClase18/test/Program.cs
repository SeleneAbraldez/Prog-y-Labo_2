using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Entidades;

namespace test
{
    class Program
    {
        //public static bool SerializarAlumnx(Alumnx a)
        //{
        //    bool retorno = false;
        //    try
        //    {
        //        XmlSerializer serializer = new XmlSerializer(typeof(Alumnx));
        //        using (StreamWriter streamWriter = new StreamWriter(@"E:\Segundo cuatri\Prog y Labo II\1-Clases\Clase_18 -\alumno.xml", true))
        //        {
        //            serializer.Serialize(streamWriter, a);
        //            retorno = true;
        //        }  
        //    }
        //    catch (Exception)
        //    {
        //        retorno = false;
        //    }
        //    return retorno;
        //}

        //public static Alumnx DeserializarAlumnx()
        //{
        //    Alumnx retorno = new Alumnx();
        //    try
        //    {
        //        XmlSerializer deserializer = new XmlSerializer(typeof(Alumnx));                
        //        using(StreamReader streamreader = new StreamReader(@"E:\Segundo cuatri\Prog y Labo II\1-Clases\Clase_18 -\alumno.xml", true)){
        //            retorno = (Alumnx)deserializer.Deserialize(streamreader);
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        retorno = null;
        //    }
        //    return retorno;
        //}

        static void Main(string[] args)
        {
            Humanx h1 = new Humanx();
            Persona pe1 = new Persona("Juana", "De Arco");
            Alumnx a1 = new Alumnx();
            Profesorx p1 = new Profesorx();

            h1.Dni = 41654123;
            Console.WriteLine(h1);

            pe1.Dni = 32456789;
            Console.WriteLine(pe1);

            a1.Dni = 532163162;
            a1.nombre = "Jaime";
            a1.apellido = "Fulano";
            a1.Legajo = 1234;
            Console.WriteLine(a1);

            p1.Dni = 57789323;
            p1.nombre = "Muche";
            p1.apellido = "Laicpo";
            p1.Titulo = "Historia";
            Console.WriteLine(p1);

            if (Humanx.SerializarHumanx(h1))
            {
                Console.WriteLine("Se ha podido serializar Humanx!");
            }
            else
            {
                Console.WriteLine("No se pudo serializar Humanx.");
            }

            h1 = Humanx.DeserializarHumanx();
            if (h1 == null)
            {
                Console.WriteLine("Se ha podido deserializar Humanx!");
            }
            else
            {
                Console.WriteLine("No se pudo deserializar Humanx.");
            }

            Console.ReadKey();

            ///alumnx
            if (Humanx.SerializarHumanx(a1))
            {
                Console.WriteLine("Se ha podido serializar Alumnx!");
            }
            else
            {
                Console.WriteLine("No se pudo serializar Alumnx.");
            }

            a1 = (Alumnx)Humanx.DeserializarHumanx();
            if (a1 == null)
            {
                Console.WriteLine("Se ha podido deserializar Alumnx!");
            }
            else
            {
                Console.WriteLine("No se pudo deserializar Alumnx.");
            }

            Console.ReadKey();

            ///prof
            if (Humanx.SerializarHumanx(p1))
            {
                Console.WriteLine("Se ha podido serializar Profesorx!");
            }
            else
            {
                Console.WriteLine("No se pudo serializar Profesorx");
            }

            p1 = (Profesorx)Humanx.DeserializarHumanx();
            if (p1 == null)
            {
                Console.WriteLine("Se ha podido deserializar Profesorx!");
            }
            else
            {
                Console.WriteLine("No se pudo deserializar Profesorx.");
            }

            Console.ReadKey();
        }
    }
}

