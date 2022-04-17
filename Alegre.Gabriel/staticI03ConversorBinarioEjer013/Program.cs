using System;

namespace staticI03ConversorBinarioEjer013
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 123;

            Console.WriteLine(Conversor.ConvertirDecimalABinario(numero));


            Console.WriteLine(Conversor.ConvertirBinarioADecimal(1111011));
        }
    }
}
