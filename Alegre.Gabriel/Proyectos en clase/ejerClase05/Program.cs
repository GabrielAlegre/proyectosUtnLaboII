using System;
using clase05Bc;
namespace ejerClase05
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta unaTinta = new Tinta(ConsoleColor.Yellow, ETipoTinta.China);

            Tinta unaTinta2 = new Tinta(ConsoleColor.Blue, ETipoTinta.ConBrillito);

            Pluma unaPluma = new Pluma("Jesus", unaTinta, 3);
            Pluma unaPluma2 = new Pluma("Pepe", unaTinta2, 3);
            string infoDeLaPluma = unaPluma;
            string infoDeLaPluma2 = unaPluma2;

            Console.WriteLine(infoDeLaPluma);

            //Uso la sobrecarga del operador + de la clase pluma
            unaPluma = unaPluma + unaTinta;
            infoDeLaPluma = unaPluma;

            Console.WriteLine(infoDeLaPluma);

            
            //Uso la sobrecarga del operador - de la clase pluma
            unaPluma = unaPluma - unaTinta;
            unaPluma = unaPluma - unaTinta;
            infoDeLaPluma = unaPluma;


            //Uso la sobrecarga implicita de la clase pluma

            Console.WriteLine(infoDeLaPluma);
            Console.WriteLine(infoDeLaPluma2);
        }
    }
}
