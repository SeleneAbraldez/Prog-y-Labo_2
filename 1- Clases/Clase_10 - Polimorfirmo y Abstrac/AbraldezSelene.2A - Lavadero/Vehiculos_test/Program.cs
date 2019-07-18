using System;
using System.Collections.Generic;
using Vehiculos;

namespace Vehiculos_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto aut1 = new Auto("ASD 012", EMarca.Zanella, 4, 4);
            Moto mot1 = new Moto("FGH 666", EMarca.Scania, 2, 25);
            Camion cam1 = new Camion("JKL 765", EMarca.Zanella, 6, 23);
            Auto aut2 = new Auto("FGH 819", EMarca.Fiat, 4, 2);

            List<Vehiculo> lav1 = new List<Vehiculo>();
            Lavadero elLav = new Lavadero(lav1, 1, 2, 3);
            
            lav1.Add(aut1);
            lav1.Add(mot1);
            lav1.Add(cam1);
            lav1.Add(aut2);

            foreach(Vehiculo v in lav1)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine(elLav.MostrarTotalFacturado(EVehiculos.Auto));


            
            Console.ReadKey();
        }
    }
}
