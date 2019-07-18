using System;
using System.Collections.Generic;
using Vehiculos;

namespace Vehiculos_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto aut1 = new Auto("ZSD 012", EMarca.Zanella, 4, 4);
            Moto mot1 = new Moto("AGH 666", EMarca.Ford, 2, 25);
            Camion cam1 = new Camion("JKL 765", EMarca.Honda, 6, 23);
            Auto aut2 = new Auto("FGH 819", EMarca.Fiat, 4, 2);

            Lavadero elLav = new Lavadero(15000, 20000, 30000);

            elLav += aut1;
            elLav += mot1;
            elLav += cam1;
            ////prueba de + y -
            elLav += aut2;
            elLav -= aut2;

            //mostrar vehiculos 
            foreach (Vehiculo v in elLav.MisVehiculos)
            {
                Console.WriteLine(v);
            }

            ////prueba de sort MARCA
            //Console.WriteLine("\n#Ordenando xMarca: ");
            //elLav.MisVehiculos.Sort(Lavadero.OrdenarVehiculosPorMarca);
            //foreach (Vehiculo v in elLav.MisVehiculos)
            //{
            //    Console.WriteLine(v);
            //}

            ////prueba de sort PATENTE
            //Console.WriteLine("\n#Ordenando xPatente:");
            //elLav.MisVehiculos.Sort(Lavadero.OrdenarVehiculosPorPatentes);
            //foreach (Vehiculo v in elLav.MisVehiculos)
            //{
            //    Console.WriteLine(v);
            //}

            ////prueba totalFact
            //Console.WriteLine();
            //Console.WriteLine(elLav.MostrarTotalFacturado(EVehiculos.Auto));

            ////prueba IVA
            //aut1.Precio = 10000;
            //double precioIva = aut1.CalcularPrecioConIVA();
            //Console.WriteLine(precioIva);

            Console.ReadKey();
        }
    }
}
