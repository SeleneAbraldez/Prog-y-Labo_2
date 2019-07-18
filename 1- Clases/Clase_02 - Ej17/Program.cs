using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Clase 02, ej 1- imprimir mensaje y cambiarlo. ej 2- cambiar color de mensaje. ej 3- realizar borde **.

namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Ej1
            /* 
            Sello.mensaje = "Mensaje"; //define mensaje
            Console.WriteLine(Sello.Imprimir()); //imprime la linea 
            Console.ReadKey();
            Sello.Borrar();
            Console.WriteLine(Sello.Imprimir());
            Console.ReadKey(); 
            */

            ///Ej2
            /*
            Sello.mensaje = "Sin color";
            Console.WriteLine(Sello.Imprimir()); 
            Sello.color = ConsoleColor.DarkMagenta; //defino el color
            Sello.mensaje = "Con color";
            Sello.ImprimirEnColor(); //imprimo en color
            Console.ReadKey();
            */

            ///Ej3

            Sello.mensaje = "Mensaje"; 
            Console.WriteLine(Sello.Imprimir());
            Console.ReadKey();

            Console.WriteLine(" ");
            Sello.mensaje = "Sellito";
            Console.WriteLine(Sello.ArmarFormatoMensaje());
            Console.ReadKey();

            Console.WriteLine(" ");
            Sello.mensaje = "Sellito violeta";
            Sello.color = ConsoleColor.DarkMagenta;
            Sello.mensaje = Sello.ArmarFormatoMensaje();
            Sello.ImprimirEnColor();
            Console.ReadKey();

            Console.WriteLine(" ");
            Sello.mensaje = "Sellito verde";
            Sello.color = ConsoleColor.DarkGreen;
            Sello.mensaje = Sello.ArmarFormatoMensaje();
            Sello.ImprimirEnColor();
            Console.ReadKey();

            Console.WriteLine(" ");
            Sello.mensaje = "Sellito normal";
            Console.WriteLine(Sello.ArmarFormatoMensaje());
            Console.ReadKey();
        }
    }
}
