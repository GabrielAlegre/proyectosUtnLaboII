using System;
using BcSumador;
namespace SobrecargaI01SumadorEjer27
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador unSumador = new Sumador();
            Sumador otroSumador = new Sumador(3);

            Console.WriteLine(unSumador.Sumar("Hola", "Amigo"));
            Console.WriteLine(unSumador.Sumar(4, 2));
            Console.WriteLine(unSumador.Sumar(6, 2));

            int a = (int)unSumador;
            int b = (int)otroSumador;
            Console.WriteLine($"cantidad sumas del primer sumador {a}\ncantidad sumas del segundo sumador {b}");

            Console.WriteLine(unSumador+otroSumador);
            Console.WriteLine(unSumador | otroSumador);
        }
    }
}
