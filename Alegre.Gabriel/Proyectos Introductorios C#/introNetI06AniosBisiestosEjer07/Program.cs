using System;

namespace introNetI06AniosBisiestosEjer07
{
    class Program
    {
        static void Main(string[] args)
        {
            int anioInicio;
            int anioFinal;

            //Ingreso el primer anio
            Console.Write("Ingrese un año de inicio: ");
            anioInicio = int.Parse(Console.ReadLine());

            //Ingreso el segundo anio
            Console.Write("Ingrese un año de final: ");
            anioFinal = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nLos años bisiestos desde {anioInicio} hasta {anioFinal} inclusive son:");
            //Verificamos todas los anios desde el anio de inicio que ingreso el usuario hasta el anio de final que ingreso el usuario
            for (int i = anioInicio; i <= anioFinal; i++)
            {
                //Hay dos opciones para que un anio se bisiesto
                //1-Si el anio es multiplo de 4 pero tambien de 100, por obligacion el anio tambien debe ser multiplo de 400: (i % 4 == 0 && i % 100 == 0 && i % 400 == 0)
                //2-Si el anio es es multiplo de 4 pero NO de 100 no hay que verificar nada mas y ya se confirma que es bisiesto: (i % 4 == 0 && i % 100 != 0)
                if ((i % 4 == 0 && i % 100 == 0 && i % 400 == 0) || (i % 4 == 0 && i % 100 != 0))
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
