using Microsoft.VisualStudio.TestTools.UnitTesting;
using BcSiempreQuiseTenerUnNotepadSerializador;

namespace PruebaUnitariasSiempreQuiseTenerUnNotepadSerializador
{
    [TestClass]
    public class PuntoJsonTest
    {
        [TestMethod]
        public void ValidarExtension_RetornaTrue_CuandoLaExtensionEsJson()
        {
            // Arrange
            PuntoJson<string> puntoJson = new PuntoJson<string>();

            // Act
            bool retorno = puntoJson.ValidarExtensión("archivo.json");

            // Assert
            Assert.IsTrue(retorno);
        }


        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void ValidarExtension_LanzaArchivoInvalidoException_CuandoLaExtensionNoEsJson()
        {
            // Arrange
            PuntoJson<string> puntoJson = new PuntoJson<string>();

            // Act
            bool retorno = puntoJson.ValidarExtensión("archivo.bin");
        }
    }
}
