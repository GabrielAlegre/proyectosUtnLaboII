using System;
using BcTorneo;

namespace TiposGenericosI01Torneo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Equipos basquet
            EquipoBasquet unEquipoDeBasquetUno = new EquipoBasquet("Celtics", new DateTime(1905, 4, 3));
            EquipoBasquet unEquipoDeBasquetDos = new EquipoBasquet("Golden", new DateTime(1945,6, 19));
            EquipoBasquet unEquipoDeBasquetTres = new EquipoBasquet("Lakers", new DateTime(1899,12, 27));
            //equipos futbol
            EquipoFutbol unEquipoDeFutbolUno = new EquipoFutbol("Boca", new DateTime(1905,4, 3));
            EquipoFutbol unEquipoDeFutbolDos = new EquipoFutbol("Riber", new DateTime(1356,12, 27));
            EquipoFutbol unEquipoDeFutbolTres = new EquipoFutbol("Independiente", new DateTime(1996,8, 12));

            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Los leales");
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Los Charros");

            _= torneoBasquet + unEquipoDeBasquetUno;
            _= torneoBasquet + unEquipoDeBasquetDos;
            _= torneoBasquet + unEquipoDeBasquetTres;

            //Comento estas tres lineas a modo de testing, para probar el codigo correctamente descomentarlas
            //_= torneoFutbol + unEquipoDeFutbolUno;
            //_= torneoFutbol + unEquipoDeFutbolDos;
            //_= torneoFutbol + unEquipoDeFutbolTres;

            Console.WriteLine("///////////////////TORNEO BASQUET/////////////////////\n"+torneoBasquet.Mostrar());
            Console.WriteLine("Resultados de los partidos en el torneo:\n"+torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);


            Console.WriteLine("\n///////////////////TORNEO FUTBOL/////////////////////\n" + torneoFutbol.Mostrar());
            Console.WriteLine("Resultados de los partidos en el torneo:\n"+torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);

        }
    }
}
