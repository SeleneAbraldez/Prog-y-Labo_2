using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorHora = 0;
            String nombre = "";
            int antiguedad = 0;
            int horasTrabajadas = 0;
            int totalBruto = 0;
            int porcentajeDescuento = 13;
            int descuento = 0;
            int totalNeto = 0;
            bool continuar;
            char respuesta;
            Console.Title = "Ejercicio 08";
            do
            {
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Valor hora: ");
                int.TryParse(Console.ReadLine(), out valorHora);
                Console.Write("Antiguedad: ");
                int.TryParse(Console.ReadLine(), out antiguedad);
                Console.Write("Horas Trabajadas: ");
                int.TryParse(Console.ReadLine(), out horasTrabajadas);

                totalBruto = valorHora * horasTrabajadas + antiguedad * 150;
                descuento = totalBruto * 13 / 100;
                totalNeto = totalBruto - descuento;


                Console.WriteLine("\n-------------RECIBO----------------\n" +
                                    "Nombre: {0}\n" +
                                    "Antiguedad: {1} años\n" +
                                    "Valor Hora: ${2}\n" +
                                    "Total Bruto: ${3}\n" +
                                    "Descuento: {4}% (${5})\n" +
                                    "Total Neto: ${6}\n" +
                                    "---------------------------------"
                                    ,nombre,antiguedad,valorHora,totalBruto,porcentajeDescuento,descuento,totalNeto);


                continuar = false;
                Console.Write("¿Desea ingresar otro empleado? (S/N): ");
                respuesta = Console.ReadKey().KeyChar;
                if (respuesta == 's' || respuesta == 'S')
                {
                    continuar = true;
                }
            } while (continuar);


            Console.ReadKey();
        }
    }
}
