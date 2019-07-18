using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_42;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMetodoEstatico()
        {
            try
            {
                Excepcion.MetodoEstatico();
                Assert.Fail(); //Si llega acá no lanzò la excepción y està mal.              
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DivideByZeroException)); //Debe ser divide by zero. 
            }
        }

        [TestMethod]
        public void TestConstructorExcepcion1()
        {
            try
            {
                Excepcion objeto = new Excepcion();
                Assert.Fail(); //Si llega acá no lanzò la excepción y està mal.              
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DivideByZeroException)); //Debe ser divide by zero. 
            }
        }

        [TestMethod]
        public void TestConstructorExcepcion2()
        {
            try
            {
                Excepcion objeto = new Excepcion(0);
                Assert.Fail(); //Si llega acá no lanzò la excepción y està mal.              
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(UnaException)); //Debe ser UnaException 
                Assert.IsInstanceOfType(e.InnerException, typeof(DivideByZeroException)); //Debe tener como innerException DivideByZero
            }
        }

        [TestMethod]
        public void MetodoInstanciaOtraClase()
        {
            OtraClase objeto = new OtraClase();
            try
            {
                objeto.MetodoInstancia();
                Assert.Fail(); //Si llega acá no lanzò la excepción y està mal.              
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(MiException)); //Debe ser MiException
                Assert.IsInstanceOfType(e.InnerException, typeof(UnaException)); //Primer InnerException Debe ser UnaException 
                Assert.IsInstanceOfType(e.InnerException.InnerException, typeof(DivideByZeroException)); //Segundo innerException DivideByZero
            }
        }


    }
}
