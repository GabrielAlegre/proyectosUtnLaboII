using Microsoft.VisualStudio.TestTools.UnitTesting;
using BcCompetenciaGenerica;
namespace TestCompetenciaGenerica
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Lista_Instanciada_Valida()
        {
            //Arranger

            //Act
            Competencia<VehiculoDeCarrera> competenciaCopaPiston = new Competencia<VehiculoDeCarrera>(5, 2);

            //assert
            Assert.IsNotNull(competenciaCopaPiston.Competidores);
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

        /*
        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void Cargar_Auto_EnCompetenciaMoto_DevuelveExcepcion()
        {
            //Arranger
            Competencia<MotoCross> competenciaCopaPiston = new Competencia<MotoCross>(5, 2, Competencia<MotoCross>.TipoCompetencia.MotoCross);
            AutoF1 primerAuto = new AutoF1(6, "Audi", 400);
            //Act y assert

            _ = competenciaCopaPiston + primerAuto;
        }
        */

        [TestMethod]
        public void Cargar_Moto_EnCompetenciaMoto_Valido_NoExcepcion()
        {
            //Arranger
            Competencia<MotoCross> competenciaCopaPiston = new Competencia<MotoCross>(5, 2);
            MotoCross unaMoto = new MotoCross(77, "nNOSE", "4566");
            bool anda;
            //Act 

            anda = competenciaCopaPiston + unaMoto;

            //assert
            Assert.IsTrue(anda);
        }

        [TestMethod]
        public void CargarFigura_Vehiculo_EnLista_Valido()
        {
            //Arranger
            Competencia<MotoCross> competenciaCopaPiston = new Competencia<MotoCross>(5, 2);
            MotoCross unaMoto = new MotoCross(77, "nNOSE", "4566");
            bool seAgregoEnLaLista = false;
            //Act 


            if (competenciaCopaPiston + unaMoto)
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
            Competencia<MotoCross> competenciaCopaPiston = new Competencia<MotoCross>(5, 2);
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
