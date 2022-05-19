using System;
using BcCompetenciaGenerica;

namespace TiposGenericosCompetenciaGenerica
{
    class Program
    {
        static void Main(string[] args)
        {

            Competencia<AutoF1> competenciaCopaPiston = new Competencia<AutoF1>(10, 5);
            AutoF1 primerAuto = new AutoF1(6, "Audi", 400);
            AutoF1 segundoAuto = new AutoF1(3, "Bmw", 545);
            AutoF1 tercerAuto = new AutoF1(19, "Bausito", 868);

            AutoF1 cuartoAuto = new AutoF1(8, "Ferrari", 123);
            AutoF1 cuartoAutoRepetidoParaTirarExcepcion = new AutoF1(8, "Ferrari", 123);
 
            MotoCross unaMoto = new MotoCross(77, "nNOSE", "4566");
            MotoCross OtraMoto = new MotoCross(32, "Otra", "3535");
            MotoCross UltimaMoto = new MotoCross(88, "Ultima", "8685");

            _=competenciaCopaPiston + segundoAuto;

            MotoCross[] arrayVehiculos = {unaMoto, OtraMoto, UltimaMoto};
            AutoF1[] arrayVehiculosAuto = {primerAuto, segundoAuto, tercerAuto,cuartoAuto, cuartoAutoRepetidoParaTirarExcepcion };


            //Va a tirar 2 excepciones xq cuando dos vehiculos son iguales en el + tiro excepcion, en este caso el segundo auto va a estar
            //repetido xq ya lo agrego en la linea 25 y el cuartoAutoRepetidoParaTirarExcepcion es la copia del cuarto
            foreach (AutoF1 item in arrayVehiculosAuto)
            {
                try
                {
                    if (competenciaCopaPiston + item)
                    {
                        Console.WriteLine("Se agrego exitosamente el auto a la competencia\n");
                    }

                }
                catch (CompetenciaNoDisponibleException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            Console.WriteLine("\n"+competenciaCopaPiston.MostrarDatos());
        }
    }
}
