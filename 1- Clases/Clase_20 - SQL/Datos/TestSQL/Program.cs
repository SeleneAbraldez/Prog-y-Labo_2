using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace TestSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            AccesoDatos accseDatos = new AccesoDatos();
            List<Persona> listaPer = new List<Persona>();
            //Persona pers1 = new Persona(10, "Juana", "Franalo", 56);

            listaPer = accseDatos.TraerTodos();

            foreach(Persona per in listaPer)
            {
                Console.WriteLine(per);
            }

            //accseDatos.AgregarPersona(pers1);

            //Console.WriteLine("---");
            //listaPer = accseDatos.TraerTodos();

            //foreach (Persona per in listaPer)
            //{
            //    Console.WriteLine(per);
            //}
            //Console.ReadKey();
        }
    }
}
