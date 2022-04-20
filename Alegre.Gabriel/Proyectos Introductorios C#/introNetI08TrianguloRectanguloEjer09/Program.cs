using System;

namespace introNetI08TrianguloRectanguloEjer09
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;
            string trianguloRectangulo = "";

            Console.Write("Ingrese la altura del trinagulo rectangulo: ");
            altura = int.Parse(Console.ReadLine());

            for (int i = 0; i < altura; i++)
            {
                if (i == 0)
                {
                    trianguloRectangulo += '*';
                    Console.WriteLine(trianguloRectangulo);
                }
                else
                {
                    trianguloRectangulo += "**";
                    Console.WriteLine(trianguloRectangulo);
                }

            }
        }
    }
}
