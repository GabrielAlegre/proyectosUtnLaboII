using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using excepcionesI01LanzarAtrapar;
namespace PruebasUnitariasLanzarAtraparProbar
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void ConstructorMiclase_SinParametros_DevuelveDivideByZeroException()
        {
            //Arranger y act
            MiClase miClase = new MiClase();
           
        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void ConstructorMiclase_ConUnParametrosString_DevuelveUnaExcepcion()
        {
            //Arranger y act
            MiClase miClase = new MiClase("probando ando");
        }

        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void MetodoOtraClaseUnMetodoInstancia_SinParametros_DevuelveMiExcepcion()
        {
            //Arranger
            OtraClase otraClass = new OtraClase();

            //Act
            otraClass.unMetodoInstancia();
        }
    }
}
