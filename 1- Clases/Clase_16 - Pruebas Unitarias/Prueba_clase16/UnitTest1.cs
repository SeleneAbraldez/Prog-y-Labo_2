using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades.Estacionamientos.starter;

namespace Prueba_clase16
{
    [TestClass] //atributos de la clase, para generar testeos unitarios
    public class UnitTest1
    {
        //[TestMethod] //metodos unitarios
        //public void TestMethod1()
        //{
        //    //Assert clase que posee metodos estaticos que permite hacer distintos tipos de evaluaciones
        //    Estacionamiento est1 = new Estacionamiento(1);
        //    Assert.IsNotNull(est1.Autos);  //se fija que no sea nulo 
        //}

        [TestMethod]
        public void espacioEstacionamientoIncorrecto()
        {
            Estacionamiento est1 = new Estacionamiento(101);
            if (est1.EspacioDisponible != 101)
            {
                Assert.Fail("El espacio es incorrecto {0}", est1.EspacioDisponible);
            }

            Estacionamiento est2 = new Estacionamiento(0);
            //si se hace con 0 y con 1 puede pasar igual, pero eso no significa que sea correcto
            //Assert.AreNotEqual(est2.EspacioDisponible, 1);
            if (est2.EspacioDisponible != 0)
            {
                Assert.Fail("El espacio es incorrecto {0}", est2.EspacioDisponible);
            }
        }

        [TestMethod]
        public void agregarAutosAEstacionamiento()
        {//errores agregando autos y comprobando mensaje de error
            Estacionamiento est3 = new Estacionamiento(2);
            Auto au1 = new Auto("ASD 123", ConsoleColor.Black);
            Auto au2 = new Auto("SDF 234", ConsoleColor.Magenta);
            Auto au3 = new Auto("DFG 345", ConsoleColor.DarkRed);

            try
            {
                est3 += au1;
                est3 += au2;
                est3 += au3;
                Assert.Fail("Se pudo agregar 3 autos aunque solo admite dos");
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(EstacionamientoLlenoException));
            }
        }

        [TestMethod]
        public void agregarAutoEspacioDisponible()
        {//se fija los espacios disponibles en el estacionamiento agregando autos
            Estacionamiento est4 = new Estacionamiento(2);
            Auto au1 = new Auto("HJK 903", ConsoleColor.Black);
            Auto au2 = new Auto("POU 679", ConsoleColor.DarkMagenta);

            est4 += au1;
            Assert.AreEqual(est4.EspacioDisponible, 1);

            est4 += au2;
            Assert.AreEqual(est4.EspacioDisponible, 0);
        }

    }
}

//pestaña prueba, ejectar todas las pruebas