using Microsoft.VisualStudio.TestTools.UnitTesting;
using BcTestDrivenDevelopment;
namespace PruebasUnitariasI01TestDrivenDevelopment
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arranger
            string numeros = ",6";
            int resultadoEsperado = 6;

            //Act
            int resultado=CalculadoraAddString.Add(numeros);

            //Assert
            Assert.AreEqual(resultado, resultadoEsperado);
        }
    }
}
