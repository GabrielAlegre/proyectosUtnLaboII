using System;
using BcCreoQueNecesitoUnPrestamo;

namespace PooI01CreoQueNecesitoUnPrestamoEjer20
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta miCuenta = new Cuenta("Pepe", 1500);
            Console.WriteLine(miCuenta.Mostrar());

            miCuenta.Ingresar(700);
            Console.WriteLine(miCuenta.Mostrar());

            miCuenta.Retirar(1000);
            Console.WriteLine(miCuenta.Mostrar());

            miCuenta.Retirar(500);
            Console.WriteLine(miCuenta.Mostrar());

            miCuenta.Retirar(800);
            Console.WriteLine(miCuenta.Mostrar());
        }
    }
}
