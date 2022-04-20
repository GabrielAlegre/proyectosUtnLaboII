using System;

namespace staticI01ValidadorRangosEjer11
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximo = 0;
            int minimo = 0;
            int numeroIngresado;
            int acumNum = 0;
            int contadorNumValidos=0;
            double promedio;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un numero: ");
                numeroIngresado = int.Parse(Console.ReadLine());

                if (Validador.Validar(numeroIngresado, -100, 100))
                {
                    if (i == 0 || numeroIngresado > maximo)
                    {
                        maximo = numeroIngresado;
                    }

                    if (i == 0 || numeroIngresado < minimo)
                    {
                        minimo = numeroIngresado;
                    }

                    acumNum += numeroIngresado;
                    contadorNumValidos++;
                } 
            }

            promedio =(double) acumNum / contadorNumValidos;

            Console.WriteLine("\nEl maximo es: {0}", maximo);
            Console.WriteLine("El minimo es: {0}", minimo);
            //Para reducir la cantidad de decimale
            Console.WriteLine($"El promedio es:{promedio : #,#.00}");
        }
    }
}
