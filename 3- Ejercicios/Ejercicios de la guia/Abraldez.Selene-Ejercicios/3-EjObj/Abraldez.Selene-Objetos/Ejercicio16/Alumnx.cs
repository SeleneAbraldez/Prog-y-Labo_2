using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16 {
    public class Alumnx {
        //campos
        byte nota1;
        byte nota2;
        float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public Alumnx() {
            nombre = "";
            apellido = "";
            legajo = 0;
        }

        //metodos
        public void CalcularFinal() {
            if (nota1 >= 4 && nota2 >= 4) {
                Random variable = new Random();
                notaFinal = variable.Next(0, 10);
            } else {
                notaFinal = -1;
            }
        }
       

        public void Estudiar(byte notaUno, byte notaDos) {
            nota1 = notaUno;
            nota2 = notaDos;
        }

        public string Mostrar() {
            string retorno;
            Console.WriteLine("Nombre: {0}; Apellido: {1}; Legajo: {2}; Nota1: {3}; Nota 2: {4};", nombre, apellido, legajo, nota1, nota2);
            if (notaFinal != -1) {
                retorno = "Nota Final: " +  notaFinal;
            } else {
                retorno = "Alumnx desaprobadx";
            }
            return retorno;
        }
    }
}
