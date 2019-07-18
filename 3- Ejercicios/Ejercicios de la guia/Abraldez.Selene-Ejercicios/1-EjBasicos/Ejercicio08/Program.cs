using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08 {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Ejercicio_08";

            int valorHora;
            string nombre;
            int antiguedad;
            int horasTrabajadas;
            string seguir = "s";
            int porcentaje;
            int total;

            while (seguir == "s") {
                Console.Write("Ingrese el valor de la hora: ");
                valorHora = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese la antiguedad: ");
                antiguedad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese las horas trabajadas: ");
                horasTrabajadas = int.Parse(Console.ReadLine());

                total = ((valorHora * horasTrabajadas) + (antiguedad * 150));
                porcentaje = 13 * 100 / total;
                total = total - porcentaje;

                Console.WriteLine("\n {0} cobrara el total de {1}", nombre, total);

                Console.Write("Desea ingresar otrx empleadx? s/n: ");
                seguir = Console.ReadLine();
            }
        }
    }
}
