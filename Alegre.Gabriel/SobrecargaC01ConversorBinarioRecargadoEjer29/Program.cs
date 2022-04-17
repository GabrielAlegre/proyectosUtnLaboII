using System;
using BcConversorBinarioRecargado;
namespace SobrecargaC01ConversorBinarioRecargadoEjer29
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario numeroBinario = "1000";
            NumeroDecimal numeroDecimal = 10;

            Console.WriteLine($"El numero binario es {(string)numeroBinario} sumado con el numero decimal {numeroDecimal.NumDecimal} da un total de: {numeroBinario + numeroDecimal}");
            Console.WriteLine($"El numero decimal es {(double)numeroDecimal} sumado con el numero binario {numeroBinario.NumBinario} da un total de: {numeroDecimal + numeroBinario}");
            Console.WriteLine($"El numero binario es {(string)numeroBinario} restado con el numero decimal {numeroDecimal.NumDecimal} da un total de: {numeroBinario - numeroDecimal}");
            Console.WriteLine($"El numero decimal es {(double)numeroDecimal} restado con el numero binario {numeroBinario.NumBinario} da un total de: {numeroDecimal - numeroBinario}");
            Console.WriteLine($"Son iguales? {numeroBinario==numeroDecimal}");
        }
    }
}
