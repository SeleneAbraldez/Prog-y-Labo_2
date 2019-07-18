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
        static void Main(string[] args)
        {
            Humanx h1 = new Humanx();
            Persona pe1 = new Persona("Juana", "De Arco");
            Alumnx a1 = new Alumnx();
            Profesorx p1 = new Profesorx();
            Profesorx p2 = new Profesorx();

            #region Pruebas 1 (Ini c/u)
            h1.Dni = 41654123;
            //Console.WriteLine(h1);

            pe1.Dni = 32456789;
            //Console.WriteLine(pe1);

            a1.Dni = 532163162;
            a1.nombre = "Jaime";
            a1.apellido = "Fulano";
            a1.Legajo = 1234;
            //Console.WriteLine(a1);

            p1.Dni = 57789323;
            p1.nombre = "Muche";
            p1.apellido = "Laicpo";
            p1.Titulo = "Historia";
            //Console.WriteLine(p1);

            p2.Dni = 57789323;
            p2.nombre = "Lore";
            p2.apellido = "Fulan";
            p2.Titulo = "Matematicas";
            #endregion

            #region Prueba 2 (Individual)
            //if (Humanx.SerializarHumanx(h1))
            //{
            //    Console.WriteLine("Se ha podido serializar Humanx!");
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo serializar Humanx.");
            //}

            //h1 = (Humanx)Humanx.DeserializarHumanx();
            //if (h1 == null)
            //{
            //    Console.WriteLine("Se ha podido deserializar Humanx!");
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo deserializar Humanx.");
            //}

            //Console.ReadKey();

            /////alumnx
            //if (Humanx.SerializarHumanx(a1))
            //{
            //    Console.WriteLine("Se ha podido serializar Alumnx!");
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo serializar Alumnx.");
            //}

            //a1 = (Alumnx)Humanx.DeserializarHumanx();
            //if (a1 == null)
            //{
            //    Console.WriteLine("Se ha podido deserializar Alumnx!");
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo deserializar Alumnx.");
            //}

            //Console.ReadKey();

            /////prof
            //if (Humanx.SerializarHumanx(p1))
            //{
            //    Console.WriteLine("Se ha podido serializar Profesorx!");
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo serializar Profesorx");
            //}

            //p1 = (Profesorx)Humanx.DeserializarHumanx();
            //if (p1 == null)
            //{
            //    Console.WriteLine("Se ha podido deserializar Profesorx!");
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo deserializar Profesorx.");
            //}
            #endregion

            #region Prueba 3 (Lista)
            List<Humanx> lh1 = new List<Humanx>();
            lh1.Add(a1);
            lh1.Add(p1);
            lh1.Add(p2);

            if (Humanx.SerializarLista(lh1))
            {
                Console.WriteLine("Se ha podido serializar Lista Humanx!");
            }
            else
            {
                Console.WriteLine("No se pudo serializar Lista Humanx.");
            }

            lh1 = Humanx.DeserializarLista();
            if (lh1 == null)
            {
                Console.WriteLine("Se ha podido deserializar Lista Humanx!");
            }
            else
            {
                Console.WriteLine("No se pudo deserializar Lista Humanx.");
            }

            Console.ReadKey();
            #endregion

            Console.ReadKey();
        }
    }
}

