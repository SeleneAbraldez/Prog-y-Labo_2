using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado emp1 = new Empleado();
            Program p = new Program();
            emp1._limiteSueldo += new DelegadoSueldo(GuardarLoad);
            emp1._limiteSueldo += new DelegadoSueldo(LimiteSueldoEmpleado);
            emp1.Nombre = "Pepe";
            emp1.Legajo = 43;
            emp1.Sueldo = 22100;

            //EmpleadoMejorado empM1 = new EmpleadoMejorado();
            //empM1._delLimiteSueldo += new DelSueldo(LimiteSueldoEmpleado);


            Console.WriteLine(emp1);

            Console.ReadKey();
        }

        private static void LimiteSueldoEmpleado(Empleado e, float s)
        {
            //Console.Write(e);
            Console.WriteLine("A empleadx " + e.Nombre + " legajo " + e.Legajo + " se le quiso asignar un sueldo de " + s.ToString());
        }

        public static void GuardarLoad(Empleado e, float s)
        {
            StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"Archivos.log", true);

            try
            {
                writer.WriteLine(DateTime.Now);
                writer.WriteLine("Nombre: {0} Legajo: {1} Sueldo: {2}", e.Nombre, e.Legajo, e.Sueldo);
            }
            catch
            {
                Console.WriteLine("!-Error al guardar.");
            }
            finally
            {
                writer.Close();
            }
        }
    }
}
