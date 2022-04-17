using System;
using Geometria;

namespace PooI05PruebaDeGeometriaEjer24
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo unRectangulo = new Rectangulo(new Punto(5,9), new Punto(7, 4));

            Console.WriteLine($"Vertice 1:({unRectangulo.vertice1.GetX()},{unRectangulo.vertice1.GetY()})\n");
            Console.WriteLine($"Vertice 2:({unRectangulo.vertice2.GetX()},{unRectangulo.vertice2.GetY()})\n");
            Console.WriteLine($"Vertice 3:({unRectangulo.vertice3.GetX()},{unRectangulo.vertice3.GetY()})\n");
            Console.WriteLine($"Vertice 4:({unRectangulo.vertice4.GetX()},{unRectangulo.vertice4.GetY()})\n");
            Mostrar(unRectangulo);


        }


        public static void Mostrar(Rectangulo unRectangulo)
        {
            Console.WriteLine("\nPerimetro del rectangulo: "+unRectangulo.GetPerimetro());
            Console.WriteLine("\nArea del rectangulo: "+unRectangulo.GetArea() ); 
        }
    }
}
