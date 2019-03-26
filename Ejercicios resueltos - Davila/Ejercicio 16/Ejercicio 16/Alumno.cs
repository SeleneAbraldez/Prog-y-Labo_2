using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    public class Alumno
    {
        public string nombre;
        public string apellido;
        public int legajo;
        private int _nota1;
        private int _nota2;
        private int _notaFinal;

        public Alumno() {
            this.nombre = "";
            this.apellido = "";
            this.legajo = 0;        
        }
        
        public void Estudiar(byte nota1, byte nota2){
            this._nota1 = nota1;
            this._nota2 = nota2;
        }

        public void CalcularFinal()
        {
            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                Random variable = new Random();
                this._notaFinal = variable.Next(0,10);
            }
            else
            {
                this._notaFinal= -1;

            }
        }

        public void Mostrar() {
            Console.WriteLine("Nombre: {0}; Apellido: {1}; Legajo: {2}; Nota1: {3}; Nota 2: {4};", this.nombre, this.apellido, this.legajo, this._nota1, this._nota2); 
            if(this._notaFinal > -1){
                Console.WriteLine("Nota Final: {0}\n", this._notaFinal);
            }
        }




    }
}
