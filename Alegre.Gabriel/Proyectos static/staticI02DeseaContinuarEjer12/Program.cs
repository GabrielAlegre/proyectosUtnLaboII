using System;

namespace staticI02DeseaContinuarEjer12
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            int numeroIngresado;
            int acumNumeros=0;
            do
            {
                Console.Write("Ingrese numero: ");
                numeroIngresado = int.Parse(Console.ReadLine());

                acumNumeros += numeroIngresado;

                Console.Write("Desea ingresar otro numero?: ");
                respuesta = Console.ReadLine();

            }while(Validador.ValidarRespuesta(respuesta));

            Console.WriteLine($"\nLa suma de todos los numeros que ingreso es: {acumNumeros}");
        }
    }
}
