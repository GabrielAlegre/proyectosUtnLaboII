using System;

namespace introNetI09TrianguloEquilateroEjer10
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;

            Console.Write("Ingrese la altura del trinagulo rectangulo: ");
            altura = int.Parse(Console.ReadLine());



            for (int i = 1; i < altura+1; i++)
            {
                for (int x = 1; x <=altura - i; x++)
                {
                    Console.Write(" ");
                }

                for (int x = 1; x < i *2; x++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }
        }
    }
}
