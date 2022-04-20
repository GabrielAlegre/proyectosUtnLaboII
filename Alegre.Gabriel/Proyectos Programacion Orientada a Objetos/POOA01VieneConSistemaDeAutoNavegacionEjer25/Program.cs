using System;
using BcVieneConSistemaDeAutoNavegacion;
namespace POOA01VieneConSistemaDeAutoNavegacionEjer25
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] kmPrimerConductor = { 7, 4, 68, 3, 5, 7, 6 };
            Conductores primerConductor = new Conductores("jorge", kmPrimerConductor);

            int[] kmSegundoConductor = { 2, 4, 7, 9, 120, 7, 7 };
            Conductores segundoConductor = new Conductores("luis", kmSegundoConductor);

            int[] kmTercerConductor = { 91, 42, 28, 33, 54, 39, 122 };
            Conductores tercerConductor = new Conductores( "julian", kmTercerConductor);

            Conductores[] arrayDeConductores = { primerConductor, segundoConductor, tercerConductor };

            foreach (Conductores unConductor in arrayDeConductores)
            {
                Console.WriteLine(unConductor.Mostrar()); 
            }

            Console.WriteLine($"\nEl conductor con mas kilometros en la semana es: {Conductores.ConductorConMasKmSemana(arrayDeConductores)}");

            Console.WriteLine($"\nEl conductor con mas kilometros el dia tres es: {Conductores.ConductorConMasKmDiaTres(arrayDeConductores)}");

            Console.WriteLine($"\nEl conductor con mas kilometros en el dia cinco es: {Conductores.ConductorConMasKmDiaCinco(arrayDeConductores)}");
        }
    }
}
