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
    public class PuntoTxtTest
    {
        [TestMethod]
        public void ValidarExtension_RetornaTrue_CuandoLaExtensionEsTxt()
        {
            // Arrange
            PuntoTxt puntoTxt = new PuntoTxt();

            // Act
            bool retorno = puntoTxt.ValidarExtensión("archivo.txt");

            // Assert
            Assert.IsTrue(retorno);
        }


        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void ValidarExtension_LanzaArchivoInvalidoException_CuandoLaExtensionNoEsTxt()
        {
            // Arrange
            PuntoTxt puntoTxt = new PuntoTxt();

            // Act
            bool retorno = puntoTxt.ValidarExtensión("archivo.bin");
        }
    }
}
