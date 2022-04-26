using System;
using BcHerenciaLaCentralitaEP1;
namespace herenciaIC03HerenciaCentralitaEP1Ejer47
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("Fede Center");

            // Mis 4 llamadas
            Local l1 = new Local( 30, "Rosario", "Bernal", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local( 45, "San Rafael", "Lanús", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            c.Llamadas.Add(l1);
            Console.WriteLine(c.Mostrar());
            Console.WriteLine("///////////////////////////AGREGO UNA LLAMADA NUEVA Y MUESTRO LA CENTRALITA////////////////////////////////////");
            c.Llamadas.Add(l2);
            Console.WriteLine(c.Mostrar());
            Console.WriteLine("///////////////////////////AGREGO UNA LLAMADA NUEVA Y MUESTRO LA CENTRALITA////////////////////////////////////");
            c.Llamadas.Add(l3);
            Console.WriteLine(c.Mostrar());
            Console.WriteLine("///////////////////////////AGREGO UNA LLAMADA NUEVA Y MUESTRO LA CENTRALITA////////////////////////////////////");
            c.Llamadas.Add(l4);
            Console.WriteLine(c.Mostrar());

            Console.WriteLine("//////////////////////////ORDENADAS POR DURACION///////////////////////////////////");

            c.OrdenarLlamadas();
            Console.WriteLine(c.Mostrar());

            Console.ReadKey();
        }
    }
}
