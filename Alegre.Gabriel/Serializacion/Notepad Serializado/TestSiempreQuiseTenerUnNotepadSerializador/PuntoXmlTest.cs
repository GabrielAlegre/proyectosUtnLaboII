using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BcSiempreQuiseTenerUnNotepadSerializador;

namespace PruebaUnitariasSiempreQuiseTenerUnNotepadSerializador
{
    [TestClass]
    public class PuntoXmlTest
    {
        [TestMethod]
        public void ValidarExtension_RetornaTrue_CuandoLaExtensionEsXml()
        {
            // Arrange
            PuntoXml<string> puntoXml = new PuntoXml<string>();

            // Act
            bool retorno = puntoXml.ValidarExtensión("archivo.xml");

            // Assert
            Assert.IsTrue(retorno);
        }


        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void ValidarExtension_LanzaArchivoInvalidoException_CuandoLaExtensionNoEsXml()
        {
            // Arrange
            PuntoXml<string> puntoXml = new PuntoXml<string>();

            // Act
            bool retorno = puntoXml.ValidarExtensión("archivo.bin");
        }
    }
}
