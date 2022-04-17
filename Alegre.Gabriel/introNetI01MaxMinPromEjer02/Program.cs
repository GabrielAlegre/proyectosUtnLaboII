using System;

namespace introNetI01MaxMinPromEjer02
{
    class Program
    {
        static void Main(string[] args)
        {
            double maximo = 0;
            double minimo = 0;
            double numeroIngresado;
            double acumNum = 0;
            double promedio;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un numero: ");
                numeroIngresado = double.Parse(Console.ReadLine());

                if (i == 0 || numeroIngresado > maximo)
                {
                    maximo = numeroIngresado;
                }

                if (i == 0 || numeroIngresado < minimo)
                {
                    minimo = numeroIngresado;
                }

                acumNum += numeroIngresado;
            }

            promedio = acumNum / 5;

            Console.WriteLine("\nEl maximo es: {0}", maximo);
            Console.WriteLine("El minimo es: {0}", minimo);
            //Para reducir la cantidad de decimale
            Console.WriteLine("El promedio es: {0}", Math.Round(promedio, 2));
            Console.ReadKey();
        }
    }
}
