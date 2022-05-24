using Microsoft.VisualStudio.TestTools.UnitTesting;
using BcControlDeAduanaInterfacesI02;

namespace TestControlDeAduanaInterfacesI02
{
    [TestClass]
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {
            // Arrange
            PaqueteFragil unPaqueteDeTest = new PaqueteFragil("2352022", 100, "Lanus", "Avellaneda", 89);
            const decimal valorEsperado = 135;


            // Act
            decimal valorRetornado = unPaqueteDeTest.AplicarImpuestos();

            // Assert
            Assert.AreEqual(valorRetornado, valorEsperado);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {
            //aranger
            PaqueteFragil unPaqueteDeTest = new PaqueteFragil("2352022", 100, "Lanus", "Avellaneda", 89);
            decimal expected = 35;
            decimal impuestoDeRetorno;
            // act
            impuestoDeRetorno = unPaqueteDeTest.Impuestos;

            //assert
            Assert.AreEqual(expected,impuestoDeRetorno);
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            //aranger
            PaqueteFragil unPaqueteDeTest = new PaqueteFragil("2352022", 700, "Lanus", "Avellaneda", 89);
            bool retornoDeberiaSerTrue;

            // act
            retornoDeberiaSerTrue = unPaqueteDeTest.TienePrioridad;

            //assert
            Assert.IsTrue(retornoDeberiaSerTrue );
        }
    }
}
