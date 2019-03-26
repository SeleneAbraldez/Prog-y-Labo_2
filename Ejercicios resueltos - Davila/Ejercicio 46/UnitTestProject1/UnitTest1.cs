using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_30;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Validar_Si_Lista_Esta_Instanciada()
        {
            Competencia c1 = new Competencia(5, 10, Competencia.TipoCompetencia.F1);
            Assert.IsNotNull(c1.Competidores);
        }

        [TestMethod]
        public void Se_Lance_Competencia_No_Disponible()
        {
            Competencia c1 = new Competencia(15, 3, Competencia.TipoCompetencia.MotoCross);
            AutoF1 a1 = new AutoF1(1, "Mercedes");

            try
            {
                bool aux = c1 + a1;
                Assert.Fail(); //Si llegó a esta linea NO se lanzó la excepción. 
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(CompetenciaNoDisponibleException));
            }
        }

        [TestMethod]
        public void No_Se_Lance_Competencia_No_Disponible()
        {
            Competencia c1 = new Competencia(15, 3, Competencia.TipoCompetencia.MotoCross);
            MotoCross m1 = new MotoCross(4, "escuderia");

            try
            {
                bool aux = c1 + m1;
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(CompetenciaNoDisponibleException));
                Assert.Fail(); //Si llegó a esta línea se lanzó la excepción.  
            }
        }

        [TestMethod]
        public void Se_Cargue_Vehiculo_A_Lista()
        {
            Competencia c1 = new Competencia(15, 3, Competencia.TipoCompetencia.MotoCross);
            MotoCross m1 = new MotoCross(4, "escuderia");
            if (c1 + m1)
            {
                Assert.IsTrue(c1 == m1);
            }
        }

        [TestMethod]
        public void Se_Quite_Vehiculo_De_Lista()
        {
            Competencia c1 = new Competencia(15, 3, Competencia.TipoCompetencia.MotoCross);
            MotoCross m1 = new MotoCross(4, "escuderia");
            bool aux = c1 + m1;
            if(c1 - m1)
            {
                Assert.IsTrue(c1 != m1);
            }
        }


    }
}
