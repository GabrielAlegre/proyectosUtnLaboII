using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BcControlDeAduanaInterfacesI02;

namespace TestControlDeAduanaInterfacesI02
{
    [TestClass]
    public class PaquetePesadoTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAfipYAduana()
        {
            // Arrange
            const decimal costoEnvio = 100;
            const decimal valorEsperado = 160;

            PaquetePesado paquetePesado = new PaquetePesado("test", costoEnvio, "test", "test", 1);

            // Act
            decimal valorRetornado = paquetePesado.AplicarImpuestos();

            // Assert
            Assert.AreEqual(valorRetornado, valorEsperado);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitaAfip()
        {
            //aranger
            PaquetePesado unPaqueteDeTest = new PaquetePesado("2352022", 100, "Lanus", "Avellaneda", 89);
            decimal expected = 25;
            decimal impuestoDeRetorno;
            // act
            impuestoDeRetorno = ((IAfip)unPaqueteDeTest).Impuestos;

            //assert
            Assert.AreEqual(expected, impuestoDeRetorno);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {
            //aranger
            PaquetePesado unPaqueteDeTest = new PaquetePesado("2352022", 100, "Lanus", "Avellaneda", 89);
            decimal expected = 35;
            decimal impuestoDeRetorno;
            // act
            impuestoDeRetorno = unPaqueteDeTest.Impuestos;

            //assert
            Assert.AreEqual(expected, impuestoDeRetorno);
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse()
        {
            //aranger
            PaquetePesado unPaqueteDeTest = new PaquetePesado("2352022", 700, "Lanus", "Avellaneda", 89);
            bool retornoDeberiaSerFalse;

            // act
            retornoDeberiaSerFalse = unPaqueteDeTest.TienePrioridad;

            //assert
            Assert.IsFalse(retornoDeberiaSerFalse);
        }
    }
}

