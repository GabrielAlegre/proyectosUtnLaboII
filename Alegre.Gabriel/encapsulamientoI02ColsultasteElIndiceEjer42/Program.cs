using System;
using BcConsultasteIndiceI02;
namespace encapsulamientoI02ColsultasteElIndiceEjer42
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            libro[0] = "Jon I";
            libro[1] = "Daenerys II";
            libro[2] = "Casper II";
            libro[6] = "hola";
            libro[-31] = "caca II";
            for (int i = 0; i < libro.CantidadPaginas; i++)
            {
                Console.WriteLine(libro[i]);
            }
            libro[1] = "Tyrion III";

            for (int i = 0; i < libro.CantidadPaginas; i++)
            {
                Console.WriteLine(libro[i]);
            }
        }
    }
}
