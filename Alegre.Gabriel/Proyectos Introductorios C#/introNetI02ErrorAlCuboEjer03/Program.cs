using System;

namespace introNetI02ErrorAlCuboEjer03
{
    class Program
    {
        static void Main(string[] args)
        {
            float numeroIngresado;

            Console.Write("Ingrese un numero: ");
            numeroIngresado = float.Parse(Console.ReadLine());



            if (numeroIngresado > 0)
            {
                Console.WriteLine("El numero ingresado al cuadrado es: {0}", Math.Pow(numeroIngresado, 2));
                Console.WriteLine("El numero ingresado al cubo es: {0}", Math.Pow(numeroIngresado, 3));
            }
            else
            {
                do
                {
                    Console.Write("ERROR. ¡Reingresar número!: ");
                    numeroIngresado = float.Parse(Console.ReadLine());

                } while (numeroIngresado < 1);

                Console.WriteLine("El numero ingresado al cuadrado es: {0}", Math.Pow(numeroIngresado, 2));
                Console.WriteLine("El numero ingresado al cubo es: {0}", Math.Pow(numeroIngresado, 3));
            }
        }
    }
}
