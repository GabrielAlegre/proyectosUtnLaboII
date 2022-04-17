using System;
using System.Collections.Generic;
using clase07sobrecargaColeccionBc;

/*
 * 
Crear 4 temperas:
1) Red-Alba-50
2) Blue-Alba-50
3) Red-Alba-25
4) Black-Pinturita-50
5) Green-Temperita-50
Comparar (temperas):
1) == 2)
1) == 3)
1) == 4)
1) == null
null == 1)
Sumar (temperas):
1) + 2)
1) + 3)
1) + 4)
1) + null
Sumar (temperas):
1) + 20
2) + 30
NOTA: luego de cada comparación, suma o resta, mostrar el contenido completo de la tempera.

 */

namespace ejer07SobrecargaColecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempera primerTempera = new Tempera(ConsoleColor.Red, "Alba", 50);
            Tempera segundaTempera = new Tempera(ConsoleColor.Blue, "Alba", 50);
            Tempera tercerTempera = new Tempera(ConsoleColor.Red, "Alba", 25);
            Tempera cuartaTempera = new Tempera(ConsoleColor.Black, "Pinturita", 50);
            Tempera quintaTempera = new Tempera(ConsoleColor.Green, "Temperita", 50);

            //Crear paleta:
            //Máximo 3 temperas
            Paleta paleta = 3;

            //Comparar (paleta - tempera)
            Console.WriteLine(paleta == primerTempera);

            //Sumar (paleta - tempera)
            Console.WriteLine("Suma");
            Console.WriteLine("------------------------------------------");
            paleta = paleta + primerTempera;
            paleta = paleta + segundaTempera;
            paleta = paleta + tercerTempera;
            paleta = paleta + cuartaTempera;
            paleta = paleta + quintaTempera;

            Console.WriteLine((string)paleta);

            //Restar(paleta - tempera)
            Console.WriteLine("Resta");
            Console.WriteLine("------------------------------------------");
            paleta = paleta - primerTempera;
            paleta = paleta - segundaTempera;
            paleta = paleta - quintaTempera;

            Console.WriteLine((string)paleta);

            //Crear otra paleta:
            //Máximo 2 temperas
            Console.WriteLine("------------------------------------------");
            Paleta paletaDos = 2;

            //Sumar(paleta - tempera)
            Console.WriteLine("Suma");
            Console.WriteLine("------------------------------------------");
            paletaDos = paletaDos + quintaTempera;
            paletaDos = paletaDos + cuartaTempera;
            paletaDos = paletaDos + tercerTempera;
            paletaDos = paletaDos + segundaTempera;

            Console.WriteLine((string)paleta);

            //Sumar (paleta - paleta)
            Console.WriteLine("Suma");
            Console.WriteLine("------------------------------------------");

            paletaDos = paletaDos + paleta;
            Console.WriteLine((string)paletaDos);
            /*
            Paleta unaPaleta = 3;
            
            unaPaleta =  unaPaleta + primerTempera;
            unaPaleta = unaPaleta + segundaTempera;
            unaPaleta = unaPaleta + cuartaTempera;

            Paleta otraPaleta = 2;
            otraPaleta = otraPaleta + tercerTempera;
            otraPaleta = otraPaleta + quintaTempera;

            Paleta paletaFusionada=unaPaleta+otraPaleta;
            Console.WriteLine((string)paletaFusionada);
            */

            /*List < Tempera > listaDeTempera= new List<Tempera>();
            listaDeTempera.Add(primerTempera);
            listaDeTempera.Add(segundaTempera);
            listaDeTempera.Add(tercerTempera);
            listaDeTempera.Add(cuartaTempera);*/


            //Console.WriteLine(listaDeTempera.IndexOf(quintaTempera));

            /*primera parte
            //1) == 2)
            //1) == 3)
            //1) == 4)
            //1) == null
            //null == 1)
            Console.WriteLine(primerTempera==segundaTempera);
            Console.WriteLine(primerTempera==tercerTempera);
            Console.WriteLine(primerTempera==cuartaTempera);
            Console.WriteLine(primerTempera==null);
            Console.WriteLine(null==primerTempera);

            //Sumar(temperas):
            //1) +2)
            //1) +3)
            //1) +4)
            //1) +null
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(primerTempera + segundaTempera);
            Console.WriteLine(primerTempera + tercerTempera);
            Console.WriteLine(primerTempera + cuartaTempera);
            Console.WriteLine(primerTempera + null);

            //Sumar(temperas):
            //1) +20
            //2) +30
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(primerTempera + 20);
            Console.WriteLine(segundaTempera + 30);

            Console.WriteLine(Tempera.Mostrar(primerTempera));
            Console.WriteLine(Tempera.Mostrar(segundaTempera));
            Console.WriteLine(Tempera.Mostrar(tercerTempera));
            Console.WriteLine(Tempera.Mostrar(cuartaTempera));
            Console.WriteLine(Tempera.Mostrar(quintaTempera));
            */

        }

    }
}
