using System;
using BcEjemploUniversal;

namespace PooI03EjemploUniversalEjer22
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Gabriel", "Alegre", "1234");
            Estudiante estudiante2 = new Estudiante("Leandro", "Avalos", "4567");
            Estudiante estudiante3 = new Estudiante("Maia", "Anzor", "7893");

            estudiante1.SetNotaPrimerParcial(7);
            estudiante1.SetNotaSegundoParcial(8);

            estudiante2.SetNotaPrimerParcial(9);
            estudiante2.SetNotaSegundoParcial(10);

            estudiante3.SetNotaPrimerParcial(2);
            estudiante3.SetNotaSegundoParcial(3);

            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());
        }
    }
}
