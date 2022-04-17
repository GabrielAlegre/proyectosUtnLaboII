using System;
using CalculadoraAreas;

namespace staticI06CalculadoraDeAreasEjer16
{
    class Program
    {
        static void Main(string[] args)
        {
            double longitudDeUnLado;
            double basee;
            double altura;
            double radio;

            //CUADRADO
            Console.Write("ingrese la longutid de los lados de un cuadrado: ");
            longitudDeUnLado = double.Parse(Console.ReadLine());

            Console.WriteLine($"El area del cuadrado es: {CalculadoraDeArea.CalcularAreaCuadrado(longitudDeUnLado)}\n");

            //TRIANGULO
            Console.Write("ingrese la base de un triangulo: ");
            basee = double.Parse(Console.ReadLine());

            Console.Write("ingrese la altura de un triangulo: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"El area del triangulo es: {CalculadoraDeArea.CalcularAreaTriangulo(basee, altura)}\n");

            //CIRCULO
            Console.Write("ingrese El radio del circulo: ");
            radio = double.Parse(Console.ReadLine());

            Console.WriteLine($"El area del circulo es: {CalculadoraDeArea.CalcularAreaCirculo(radio) : #.#,000}\n");
        }
    }
}
