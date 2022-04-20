using System;

namespace coleccionesI01NumerosLocosEjer36
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numeroRandom =  new Random();
            int[] arrayDeNumerosRandom = new int[20];
            for (int i = 0; i < arrayDeNumerosRandom.Length; i++)
            {
                arrayDeNumerosRandom[i] = numeroRandom.Next(-100, 100);
                while (arrayDeNumerosRandom[i] == 0)
                {
                    arrayDeNumerosRandom[i] = numeroRandom.Next(-100, 100);
                }
            }

            //1 imprimir taal cual
            foreach (int numero in arrayDeNumerosRandom)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////\n");
            //2 mostrar positivos de forma decreciente
            Array.Sort(arrayDeNumerosRandom);
            Array.Reverse(arrayDeNumerosRandom);
            foreach (int numero in arrayDeNumerosRandom)
            {
                if(numero>0)
                {
                    Console.WriteLine(numero);
                }
                
            }
            Console.WriteLine("\n/////////////////////////////////////////////////////////////////////////////\n");
            Array.Sort(arrayDeNumerosRandom);
            foreach (int numero in arrayDeNumerosRandom)
            {
                if(numero<0)
                {
                    Console.WriteLine(numero);
                }
                
            }
        }
    }
}
