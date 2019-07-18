using System;
using Entidades;

namespace testClase18
{
    public class test
    {
        static void Main(string[] args)
        {
            Humanx h1 = new Humanx();
            Persona pe1 = new Persona("Juana", "De Arco");
            Alumnx a1 = new Alumnx();
            Profesorx p1 = new Profesorx();

            Console.WriteLine(h1);
        }
    }
}
