using System;
using BcCartucheraInterfaces;
namespace InterfacesI01Cartuchera
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;

            Lapiz miLapiz = new Lapiz(10);
            Lapiz miLapiz1 = new Lapiz(23);
            Lapiz miLapiz2= new Lapiz(75);
            Lapiz miLapiz3 = new Lapiz(32);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);
            Boligrafo miBoligrafo2 = new Boligrafo(32, ConsoleColor.Yellow);
            Boligrafo miBoligrafo3 = new Boligrafo(0, ConsoleColor.Blue);
            Boligrafo miBoligrafo4 = new Boligrafo(23, ConsoleColor.DarkMagenta);

            CartucheraMultiuso cartuMulti = new CartucheraMultiuso();
            cartuMulti.lista.Add(miLapiz);
            cartuMulti.lista.Add(miBoligrafo2);
            cartuMulti.lista.Add(miLapiz1);
            cartuMulti.lista.Add(miLapiz2);
            cartuMulti.lista.Add(miBoligrafo4);
            cartuMulti.lista.Add(miBoligrafo3);
            cartuMulti.lista.Add(miLapiz3);

            Console.WriteLine("Llamo metodo de catuchera multiuso\n" + cartuMulti.RecorrerElementos());

            CartucheraSimple cartuSimple = new CartucheraSimple();
            cartuSimple.listaDeLapices.Add(miLapiz);
            cartuSimple.listaDeBolis.Add(miBoligrafo2);
            cartuSimple.listaDeLapices.Add(miLapiz1);
            cartuSimple.listaDeBolis.Add(miBoligrafo3);
            cartuSimple.listaDeLapices.Add(miLapiz2);
            cartuSimple.listaDeBolis.Add(miBoligrafo4);
            cartuSimple.listaDeLapices.Add(miLapiz3);

            Console.WriteLine("Llamo metodo de catuchera simple\n" + cartuSimple.RecorrerElementos());
            /*
            EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);

            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);
            */
            Console.ReadKey();
        }
    }
}
