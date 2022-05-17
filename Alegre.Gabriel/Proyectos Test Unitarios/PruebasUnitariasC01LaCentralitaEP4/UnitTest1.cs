using Microsoft.VisualStudio.TestTools.UnitTesting;
using BcExcepcionesLaCentralitaEP3;
namespace PruebasUnitariasC01LaCentralitaEP4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidaQueLaListaEsteInstanciada()
        {
            //Arranger
            bool resultadoEsperado = true;
            Centralita centralita = new Centralita("Pepito");

            //Act
            bool resultado = centralita.Llamadas != null;


            //Assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void validarExcepcionFuncioneProvincial()
        {
            //Arranger
            Centralita c = new Centralita("Pepito");
            Provincial l2 = new Provincial("Morón", Franja.Franja_1, 21, "Bernal");
            Provincial l4 = new Provincial(Franja.Franja_3, l2);

            //Act
            c += l2;
            //No se agerga xq esta repetida
            c += l4;

        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void validarExcepcionFuncioneLocal()
        {
            //Arranger
            Centralita c = new Centralita("Pepito");
            Local l1 = new Local(30, "Rosario", "Bernal", 2.65f);
            Local l3 = new Local(45, "Rosario", "Bernal", 1.99f);

            //Act
            c += l1;
            //No se agerga xq esta repetida
            c += l3;

        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void validacionFalopa()
        {
            //Arranger
            Centralita c = new Centralita("Pepito");
            Local l1 = new Local(30, "Rosario", "Bernal", 2.65f);
            Local l3 = new Local(45, "Rosario", "Bernal", 1.99f);
            Provincial l2 = new Provincial("Rosario", Franja.Franja_1, 21, "Bernal");
            Provincial l4 = new Provincial("Rosario", Franja.Franja_3, 45, "Bernal");
            bool locales = false;
            bool provinciales = false;

            Llamada[] llamadas = { l1, l2, l3, l4 };

            if(l1.Equals(l2))
            {
                locales = false;
            }
            if (l1.Equals(l3))
            {
                locales = true;

            }
            if (l1.Equals(l4))
            {
                locales = false;

            }
            //
            if (l2.Equals(l1))
            {
                provinciales = false;
            }
            if (l2.Equals(l3))
            {
                provinciales = false;

            }
            if (l2.Equals(l4))
            {
                provinciales = true;

            }
            Assert.AreEqual(provinciales, true);
        }
    }
}
