using System;

namespace staticI07PitagorasEstariaOrgullosoEjer17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"La longitud de la hipotenusa aplicando el teorema de pitágoras es: {HallarlongitudHipotenusa(9, 12)}");
        }

        public static double HallarlongitudHipotenusa(double altura, double basee)
        {
            return Math.Sqrt( Math.Pow(altura, 2) + Math.Pow(basee, 2) );
        }
    }
}
