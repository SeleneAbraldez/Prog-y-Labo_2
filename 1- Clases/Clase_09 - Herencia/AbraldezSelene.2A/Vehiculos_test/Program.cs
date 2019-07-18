using System;
using Vehiculos;

namespace Vehiculos_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto aut1 = new Auto("ASD 012", EMarca.Renault, 4, 4);
            Moto mot1 = new Moto("FGH 666", EMarca.Scania, 2, 25);
            Camion cam1 = new Camion("JKL 765", EMarca.Zanella, 6, 23);

            //aut1.patente = "ASD 012";
            //aut1.marca = EMarca.Renault;
            //aut1.cantRuedas = 4;
            //aut1.cantAsientos = 4;
            Console.WriteLine(aut1.MostrarAuto());

            Console.WriteLine(mot1.MostrarMoto());

            Console.WriteLine(cam1.MostrarCamion());

            Console.ReadKey();
        }
    }
}
