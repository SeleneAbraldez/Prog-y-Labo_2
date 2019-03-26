using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Ejercicio_37
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("Fede Center");
            //// Mis 4 llamadas
            //Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            //Provincial l2 = new Provincial("Morón", 21, "Bernal", Provincial.Franja.Franja_1);
            //Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            //Provincial l4 = new Provincial(l2, Provincial.Franja.Franja_3);
            //// Las llamadas se irán registrando en la Centralita.
            //// La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            //try
            //{
            //    c += l1;
            //    Console.WriteLine(c.ToString());
            //}
            //catch(CentralitaException error) {
            //    Console.WriteLine(error.Message);
            //}

            //try
            //{
            //    c += l2;
            //    Console.WriteLine(c.ToString());
            //}
            //catch (CentralitaException error)
            //{
            //    Console.WriteLine(error.Message);
            //} 

            //try
            //{
            //    c += l3;
            //    Console.WriteLine(c.ToString());
            //}
            //catch (CentralitaException error)
            //{
            //    Console.WriteLine(error.Message);
            //}

            //try
            //{
            //    c += l4;
            //    Console.WriteLine(c.ToString());
            //}
            //catch (CentralitaException error)
            //{
            //    Console.WriteLine(error.Message);
            //}
            //c.OrdenarLlamadas();
            //Console.WriteLine(c.ToString());
            //Console.ReadKey();

            ////Muestro el log
            //Console.Clear();
            //Console.WriteLine(c.Leer());
            //Console.ReadKey();

            Thread thread = new Thread(() => LlamadaRandom(c));
            thread.Start();

            bool continuar;
            do
            {
                continuar = true;
                char eleccion;
                Console.Clear();
                Console.WriteLine("Menú:");
                Console.WriteLine("1) Mostrar llamadas");
                Console.WriteLine("2) Salir");

                eleccion = Console.ReadKey().KeyChar;

                switch (eleccion)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine(c.ToString());
                        Console.WriteLine("¿Desea ver el menú? (Y/N)");
                        char respuesta = Console.ReadKey().KeyChar;
                        if (!(respuesta == 'Y' || respuesta == 'y'))
                            continuar = false;
                        break;
                    case '2':
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("\nElección incorrecta");
                        break;
                }
            } while (continuar);

            thread.Abort();
        }
    

        public static Llamada LlamadaRandom(Centralita c)
        {
            while (true)
            {
                Random r = new Random();
                Llamada llamada = null;
                Llamada.TipoLlamada tipo = (Llamada.TipoLlamada)r.Next(0, 2);
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        llamada = new Local(RandomString(), r.Next(0, 100), RandomString(), r.Next(1, 10));
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        llamada = new Provincial(RandomString(), r.Next(0, 100), RandomString(), (Provincial.Franja)r.Next(0, 3));
                        break;
                }
                try
                {
                    c += llamada;
                }
                catch (Exception)
                {
                    Console.WriteLine("No se pudo cargar la llamada");
                }
                
                Thread.Sleep(r.Next(2000, 10000));
            }

        }

        private static string RandomString()
        {
            Random r = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            string retorno = "";
            for (int i = 0; i < r.Next(5,16); i++) //Crea palabras entre 5 y 15 letras.
            {
                retorno += chars[r.Next(chars.Length)]; //Va tomando letras aleatoriamente del string chars.
            }
            return retorno;
        }
    }
}
