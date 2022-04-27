using System;
using BcPolimorfismoLaCentralitaEP2;
namespace PolimorfismoC0lLaCentralitaEP2Ejer50
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("Fede Center");

            // Mis 4 llamadas
            Local l1 = new Local(30, "Rosario", "Bernal", 2.65f);
            Provincial l2 = new Provincial("Morón", Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local(45, "San Rafael", "Lanús", 1.99f);
            Provincial l4 = new Provincial(Franja.Franja_3, l2);

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.

            c += l1;
            c += l2;
            c += l3;
            //No se agerga xq esta repetida
            c += l4;
           

            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());

            Console.ReadKey();

        }
    }
}
