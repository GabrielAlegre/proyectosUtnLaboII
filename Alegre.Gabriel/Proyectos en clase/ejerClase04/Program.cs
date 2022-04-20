using System;

namespace ejerClase04
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa c1 = new Cosa();
            Console.WriteLine($"Mostramos con valores predeterminado\n{c1.Mostrar(c1)}");

            Cosa c2 = new Cosa("Hola mundo");
            Console.WriteLine($"Mostramos solo pasando cadena en el constructor\n{c2.Mostrar(c2)}");

            Cosa c3 = new Cosa(12, "Hola mundo");
            Console.WriteLine($"Mostramos solo pasando cadena y entero en el constructor\n{c3.Mostrar(c3)}");

            Cosa c4 =  new Cosa(12, "Hola mundo", new DateTime(2011, 6, 26));
            Console.WriteLine($"Mostramos pasandole todos los parametros en el constructor\n{c4.Mostrar(c4)}"); 
        }
    }
}
