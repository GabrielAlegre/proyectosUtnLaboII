using System;

namespace staticA01CalcularUnFactorialEjer19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorialDeUnNumero(6));
        }

        public static long factorialDeUnNumero(int numero)
        {
            long resultadoFactorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                resultadoFactorial *= i;
            }

            return resultadoFactorial;
        }
    }
}
