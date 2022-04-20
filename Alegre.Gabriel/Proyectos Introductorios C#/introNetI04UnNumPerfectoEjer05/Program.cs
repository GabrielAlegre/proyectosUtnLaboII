using System;

namespace introNetI04UnNumPerfectoEjer05
{
    class Program
    {
        static void Main(string[] args)
        {
            long numero = 2;
            long acumulador = 0;
            int contador = 0;

            while (contador < 4)
            {
                for(int i = 1; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        acumulador += i;
                    }
                }

                if(acumulador == numero)
                {
                    Console.WriteLine("{0} Es un numero perfecto", numero);
                    contador++;

                }
                numero++;
                acumulador = 0;
            }
        }
    }
}
