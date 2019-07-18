using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07 {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Ejercicio 07";

            DateTime fechaActual;
            DateTime fechaNacimiento;
            TimeSpan diferencia;

            Console.Write("Ingrese fecha de nacimiento (dd/mm/yyyy): ");
            fechaNacimiento = DateTime.Parse(Console.ReadLine());
     
            fechaActual = DateTime.Now;
         
            diferencia = fechaActual - fechaNacimiento;
            Console.WriteLine("Diferencia de dias entre {0:dd/MM/yyyy} y {1:dd/MM/yyyy}: {2}", fechaNacimiento, fechaActual, diferencia.Days);

            System.Console.ReadKey();
        }
    }
}
