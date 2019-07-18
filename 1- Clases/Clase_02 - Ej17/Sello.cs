using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    class Sello
    {
        //atributo mensaje string
        public static string mensaje;
        //
        public static ConsoleColor color;

        //metodo imprimir string
        public static string Imprimir()
        {
            return Sello.mensaje;
        }
        //metodo borrar void
        public static void Borrar()
        {
            Sello.mensaje = ""; //fucniona igualmente sin Sello pero recomendable 
        }
        //metodo imrpimirnecolor void
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = color;
            Console.WriteLine(Sello.Imprimir());
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        //metodo string (-)ArmarFormatoMensaje():string
        public static string ArmarFormatoMensaje()
        {
            int tam;
            string borde = "";
            string mensaje;
            string sellito;

            tam = Sello.mensaje.Length;
            for (int i = 0; i<tam+2; i++)
            {
                borde += "*";
            }

            mensaje = "\n*" + Sello.mensaje + "*\n";
            sellito = borde + mensaje + borde;

            return sellito;
        }
    }
}
