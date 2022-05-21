using Microsoft.VisualStudio.TestTools.UnitTesting;
using BcParadaEnBoxesTest;
using System;

namespace TestUnitariosC03ParadaEnBoxes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Lista_Instanciada_Valida()
        {
            //Arranger

            //Act
            Competencia compe = new Competencia(5, 2, Competencia.TipoCompetencia.MotoCross);

            //assert
            Assert.IsNotNull(compe.Competidores);
        }

        /*
        [TestMethod]
        public void Cargar_Auto_EnCompetenciaMoto_DevuelveExcepcion()
        {
            //Arranger
            Competencia competenciaCopaPiston = new Competencia(10, 2, Competencia.TipoCompetencia.MotoCross);
            AutoF1 primerAuto = new AutoF1(6, "Audi", 400);
            //Act y assert
            try
            {
                _=competenciaCopaPiston + primerAuto;
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(CompetenciaNoDisponibleException));
            }
        }*/

        //De otra manera

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void Cargar_Auto_EnCompetenciaMoto_DevuelveExcepcion()
        {
            //Arranger
            Competencia competenciaCopaPiston = new Competencia(10, 2, Competencia.TipoCompetencia.MotoCross);
            AutoF1 primerAuto = new AutoF1(6, "Audi", 400);
            //Act y assert
      
            _=competenciaCopaPiston + primerAuto;
        }

        
        [TestMethod]
        public void Cargar_Moto_EnCompetenciaMoto_Valido_NoExcepcion()
        {
            //Arranger
            Competencia competenciaCopaPiston = new Competencia(10, 2, Competencia.TipoCompetencia.MotoCross);
            MotoCross unaMoto = new MotoCross(77, "nNOSE", "4566");
            bool anda;
            //Act 

            anda=competenciaCopaPiston + unaMoto;

            //assert
            Assert.IsTrue(anda);
        }

        [TestMethod]
        public void CargarFigura_Vehiculo_EnLista_Valido()
        {
            //Arranger
            Competencia competenciaCopaPiston = new Competencia(10, 2, Competencia.TipoCompetencia.MotoCross);
            MotoCross unaMoto = new MotoCross(77, "nNOSE", "4566");
            bool seAgregoEnLaLista=false;
            //Act 


            if(competenciaCopaPiston + unaMoto)
            {
                seAgregoEnLaLista = competenciaCopaPiston == unaMoto;
            }
           
            //assert
            Assert.IsTrue(seAgregoEnLaLista);
        }

        [TestMethod]
        public void EliminaNoFiguraEnLaLista_Vahiculo_Valido()
        {
            //Arranger
            Competencia competenciaCopaPiston = new Competencia(10, 2, Competencia.TipoCompetencia.MotoCross);
            MotoCross unaMoto = new MotoCross(77, "nNOSE", "4566");
            bool seAgregoEnLaLista = false;
            //Act 

            _ = competenciaCopaPiston + unaMoto;
            if (competenciaCopaPiston - unaMoto)
            {
                seAgregoEnLaLista = competenciaCopaPiston != unaMoto;
            }

            //assert
            Assert.IsTrue(seAgregoEnLaLista);
        }


    }
}
