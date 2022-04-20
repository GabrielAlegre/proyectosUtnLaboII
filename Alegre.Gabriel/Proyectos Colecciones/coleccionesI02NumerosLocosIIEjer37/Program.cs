using System;
using System.Collections.Generic;

namespace coleccionesI02NumerosLocosIIEjer37
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> miLista = new List<int>();
            Queue<int> miQueue = new Queue<int>();
            Stack<int> miStack = new Stack<int>();

            for (int i = 0; i < 20; i++)
            {
                miLista.Add(random.Next(-100, 100));
            }

            Console.WriteLine("Muestro la lista\n");

            for (int i = 0; i < miLista.Count; i++)
            {
                Console.WriteLine(miLista[i]);
            }

            Console.WriteLine("\nMuestro la lista de forma Decreciente\n");

            miLista.Sort(OrdenDescendente);

            for (int i = 0; i < miLista.Count; i++)
            {
                if (miLista[i] > 0)
                {
                    miQueue.Enqueue(miLista[i]);
                }
            }

            foreach (int unNumero in miQueue)
            {
                Console.WriteLine(unNumero);
            }

            Console.WriteLine("\nMuestro la lista de forma Creciente\n");


            for (int i = 0; i < miLista.Count; i++)
            {
                if (miLista[i] < 0)
                {
                    miStack.Push(miLista[i]);
                }
            }

            foreach (int unNumero in miStack)
            {
                Console.WriteLine(unNumero);
            }
        }

        public static int OrdenDescendente(int a, int b)
        {
            return b - a;
        }
    }
    
}
