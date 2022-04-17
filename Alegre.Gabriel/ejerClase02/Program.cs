using System;

namespace ejerClase02
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "";
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();
            Console.WriteLine(Sello.Imprimir());

            Sello.Borrar();
            Sello.mensaje = "Boca locura, que tenemos aguante no hay duda";
            Console.WriteLine(Sello.Imprimir());
























            /*
            Sello.mensaje = "Hola mundo";

            Console.WriteLine(Sello.Imprimir()); //retorna string

            Sello.Borrar();

            Console.WriteLine(Sello.Imprimir());//retorna string

            Sello.mensaje = "hola mundo C#";
            //Asigno el color que quiero que tenga mi letra
            Sello.color = ConsoleColor.Red;
            //Imprimo el mensaje con el color asignado (La misma funcion se encarga de hacer el reset al color original)
            Sello.ImprimirEnColor();

            //Imprimo mensaje con el color default
            Console.WriteLine(Sello.Imprimir());
            */

        }
    }
}
