using System;

namespace staticI04LaCalculadora14
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            double primerOperando;
            double segundoOperando;
            double resultadoOperacion;
            char operacionMatematica;
            do
            {
                Console.Write("Ingrese numero primer operando: ");
                primerOperando = double.Parse(Console.ReadLine());

                Console.Write("Ingrese numero primer operando: ");
                segundoOperando = double.Parse(Console.ReadLine());

                Console.Write("Ingrese la operacion matematica que desea realizar: ");
                operacionMatematica = char.Parse(Console.ReadLine());

                resultadoOperacion = Calculadora.Calcular(primerOperando, segundoOperando, operacionMatematica);

                if(resultadoOperacion<0 && operacionMatematica=='/')
                {
                    Console.WriteLine("\nError, no se puede dividir por 0 (cero), por lo que no se pudo realizar la operacion matematica");
                }
                else if(operacionMatematica!='*' && operacionMatematica!='/' && operacionMatematica!='+' && operacionMatematica!='-')
                {
                    Console.WriteLine($"\nEl resultado de {primerOperando} + {segundoOperando} es: {resultadoOperacion}");
                }
                else
                {
                    Console.WriteLine($"\nEl resultado de {primerOperando} {operacionMatematica} {segundoOperando} es: {resultadoOperacion}");
                }

                Console.Write("\nDesea ingresar otro numero?: ");
                respuesta = Console.ReadLine();

            } while (Calculadora.ValidarRespuesta(respuesta));

            
        }
    }
}
