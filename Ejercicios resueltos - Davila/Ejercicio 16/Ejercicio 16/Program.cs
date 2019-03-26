using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            alumno1.nombre = "juan";
            alumno1.apellido = "perez";
            alumno1.legajo = 1000;
            alumno1.Estudiar(9, 10);
            alumno1.CalcularFinal();

            alumno2.nombre = "Jose";
            alumno2.apellido = "Gomez";
            alumno2.legajo = 1001;
            alumno2.Estudiar(8, 6);
            alumno2.CalcularFinal();

            alumno3.nombre = "Laura";
            alumno3.apellido = "Gonzales";
            alumno3.legajo = 1002;
            alumno3.Estudiar(3, 7);
            alumno3.CalcularFinal();

            alumno1.Mostrar();
            alumno2.Mostrar();
            alumno3.Mostrar();

            Console.ReadKey();



        }
    }
}
