using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Ejercicio_37;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Valida si la lista de llamadas de la centralita
        /// está instanciada al crear un nuevo objeto centralita
        /// </summary>
        [TestMethod]
        public void ListaDeLlamadasEstaInstanciada()
        {
            Centralita c = new Centralita("Centralita");

            Assert.IsNotNull(c.Llamadas);
        }


        /// <summary>
        /// Controla que la excepción CentralitaException se lance al intentar cargar una segunda llamada con 
        /// solamente los mismos datos de origen y destino de una llamada LOCAL ya existente. 
        /// </summary>
        [TestMethod]
        public void CentralitaExceptionLocal()
        {
            Centralita c = new Centralita("Centralita");
            Llamada l1 = new Local("Origen",23,"Destino",23);
            Llamada l2 = new Local("Origen",53,"Destino",43);

            try
            {
                c+=l1;
                c+=l2;               
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(CentralitaException));
            }            
        }

        /// <summary>
        /// Controla que la excepción CentralitaException se lance al intentar cargar una segunda llamada con 
        /// solamente los mismos datos de origen y destino de una llamada PROVINCIAL ya existente. 
        /// </summary>
        [TestMethod]
        public void CentralitaExceptionProvincial()
        {
            Centralita c = new Centralita("Centralita");
            Llamada l1 = new Provincial("Origen", 23, "Destino",Provincial.Franja.Franja_1);
            Llamada l2 = new Provincial("Origen", 53, "Destino",Provincial.Franja.Franja_3);

            try
            {
                c += l1;
                c += l2;
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(CentralitaException));
            }
        }

        /// <summary>
        /// Crear dos llamadas Local y dos Provincial, todos con los mismos datos de origen y destino.
        /// Luego comparar cada uno de estos cuatro objetos contra los demás, debiendo ser iguales solamente las instancias 
        /// de Local y Provincial entre si. 
        /// </summary>
        [TestMethod]
        public void LlamadasDistintas()
        {
            Centralita c = new Centralita("Centralita");
            Llamada l1 = new Provincial("Origen", 23, "Destino", Provincial.Franja.Franja_1);
            Llamada l2 = new Provincial("Origen", 53, "Destino", Provincial.Franja.Franja_3);
            Llamada l3 = new Local("Origen", 23, "Destino", 23);
            Llamada l4 = new Local("Origen", 53, "Destino", 43);

            Assert.IsTrue(l1 == l2);
            Assert.IsFalse(l1 == l3);
            Assert.IsFalse(l1 == l4);
            Assert.IsFalse(l2 == l3);
            Assert.IsFalse(l2 == l4);
            Assert.IsTrue(l3 == l4);
        }
    }
}
