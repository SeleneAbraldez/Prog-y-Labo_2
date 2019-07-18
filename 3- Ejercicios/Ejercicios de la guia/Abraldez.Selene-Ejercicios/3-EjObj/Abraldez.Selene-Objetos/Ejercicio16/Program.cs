using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16 {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Ejercio_16";

            Alumnx alumnx1 = new Alumnx();
            Alumnx alumnx2 = new Alumnx();
            Alumnx alumnx3 = new Alumnx();

            alumnx1.nombre = "Agus";
            alumnx1.apellido = "Fulan";
            alumnx1.legajo = 300;
            alumnx1.Estudiar(2, 7);
            alumnx1.CalcularFinal();
            Console.WriteLine(alumnx1.Mostrar());

            alumnx2.nombre = "Coqui";
            alumnx2.apellido = "Codi";
            alumnx2.legajo = 301;
            alumnx2.Estudiar(9, 6);
            alumnx2.CalcularFinal();
            Console.WriteLine(alumnx2.Mostrar());

            alumnx3.nombre = "Maria";
            alumnx3.apellido = "Flauta";
            alumnx3.legajo = 302;
            alumnx3.Estudiar(4, 6);
            alumnx3.CalcularFinal();
            Console.WriteLine(alumnx3.Mostrar());

            Console.ReadKey();
        }
    }
}
