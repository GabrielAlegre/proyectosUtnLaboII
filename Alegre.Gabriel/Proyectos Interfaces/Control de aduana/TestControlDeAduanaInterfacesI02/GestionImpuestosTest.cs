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
    public class GestionImpuestosTest
    {
        [TestMethod]
        public void CalcularTotalImpuestosAduana_DeberiaRetornarLaSumaDeLosImpuestosDeAduana()
        {
            // Arrange
            PaqueteFragil unPaqueteFragil = new PaqueteFragil("", 100M, "", "", 0);//Si el envio vale 100 el impuesto de aduana es 35
            PaqueteFragil unPaqueteFragil2 = new PaqueteFragil("", 200M, "", "", 0);//Si el envio vale 200 el impuesto de aduana es 70
            PaquetePesado unPaquetePesado = new PaquetePesado("", 300M, "", "", 0);//Si el envio vale 300 el impuesto de aduana es 105
            PaquetePesado unPaquetePesado2 = new PaquetePesado("", 400M, "", "", 0);//Si el envio vale 400 el impuesto de aduana es 140

            //35 + 70 + 105 + 140
            decimal expected = 350;

            GestionImpuestos gestion = new GestionImpuestos();
            gestion.RegistrarImpuestos(unPaqueteFragil);
            gestion.RegistrarImpuestos(unPaqueteFragil2);
            gestion.RegistrarImpuestos(unPaquetePesado);
            gestion.RegistrarImpuestos(unPaquetePesado2);
 

            // Act
            decimal retorno = gestion.CalcularTotalImpuestosAduana();

            // Assert
            Assert.AreEqual(retorno, expected);
        }


        [TestMethod]
        public void CalcularTotalImpuestosAfip_DeberiaRetornarLaSumaDeLosImpuestosDeAfip()
        {
            // Arrange

            List<Paquete> listaDePaquetesParaRegistrar = new List<Paquete>();
            listaDePaquetesParaRegistrar.Add(new PaqueteFragil("", 100M, "", "", 0));//No tiene impuesto afip
            listaDePaquetesParaRegistrar.Add(new PaqueteFragil("", 100M, "", "", 0));//No tiene impuesto afip
            listaDePaquetesParaRegistrar.Add(new PaquetePesado("", 300M, "", "", 0));//Si el envio vale 300 el impuesto de afip es 75
            listaDePaquetesParaRegistrar.Add(new PaquetePesado("", 400M, "", "", 0));//Si el envio vale 400 el impuesto de aduana es 100
            decimal expected = 175;

            GestionImpuestos gestion = new GestionImpuestos();
            gestion.RegistrarImpuestos(listaDePaquetesParaRegistrar);

            // Act
            decimal retorno = gestion.CalcularTotalImpuestosAfip();

            // Assert
            Assert.AreEqual(retorno, expected);
        }

  
        
    }
}
