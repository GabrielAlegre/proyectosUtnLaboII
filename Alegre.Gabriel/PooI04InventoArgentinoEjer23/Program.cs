using System;
using BcInventoArgentino;
namespace PooI04InventoArgentinoEjer23
{
    class Program
    {
        static void Main(string[] args)
        {
            string dibujo;
            Boligrafo primerBoligrafo = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo segundoBoligrafo = new Boligrafo(50, ConsoleColor.Red);

            //primer boli
            Console.WriteLine($"Color elegido: {primerBoligrafo.GetColor()}");
            primerBoligrafo.Pintar(75, out dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine($"Tinta disponible: {primerBoligrafo.GetTinta()}");

            //segundo boli
            Console.WriteLine($"Color elegido: {segundoBoligrafo.GetColor()}");
            segundoBoligrafo.Pintar(100, out dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine($"Tinta disponible: {segundoBoligrafo.GetTinta()}");

            //recargo
            segundoBoligrafo.Recargar();
            segundoBoligrafo.Pintar(25, out dibujo);
            Console.WriteLine(dibujo);
            segundoBoligrafo.Pintar(85, out dibujo);
            Console.WriteLine(dibujo);

            Console.ResetColor();

            Console.WriteLine("holas");
        }
    }
}
