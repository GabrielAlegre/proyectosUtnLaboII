using System;
using BcExcepcionGoSpeedRacerGo;
namespace excepcionesC02SeguiParticipando
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia competenciaCopaPiston = new Competencia(10, 2, Competencia.TipoCompetencia.MotoCross);
            AutoF1 primerAuto = new AutoF1(6, "Audi", 400);
            AutoF1 segundoAuto = new AutoF1(3, "Bmw", 545);
            AutoF1 tercerAuto = new AutoF1(19, "Bausito", 868);

            AutoF1 cuartoAuto = new AutoF1(8, "Ferrari", 123);

            MotoCross unaMoto = new MotoCross(77, "nNOSE", "4566");




            VehiculoDeCarrera[] arrayVehiculos = { primerAuto,segundoAuto, tercerAuto,cuartoAuto, unaMoto };


            for (int i = 0; i < arrayVehiculos.Length; i++)
            {
                try
                {
                    if (competenciaCopaPiston + arrayVehiculos[i])
                    {
                        Console.WriteLine("Se agrego exitosamente el auto a la competencia");
                    }

                }
                catch (CompetenciaNoDisponibleException e )
                {
                    Console.WriteLine(e.ToString());
                }

            }


            Console.WriteLine("\n"+competenciaCopaPiston.MostrarDatos());
        }
    }
}
