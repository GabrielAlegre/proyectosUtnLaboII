using System;

namespace introNetI03LosPrimosEjer04
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            string n = "";
            int numero = 2;
            int divisible = 0;
            bool esValido;


            do
            {
                Console.Write("Ingrese Valor Entero (salir para salir xD): ");
                n = Console.ReadLine();
                esValido = int.TryParse(n, out valor);

                if (esValido)
                {
                    Console.WriteLine("Lista de todos los numeros primos antes del {0}", valor);
                    while (numero <= valor)
                    {
                        for (int i = 1; i <= numero; i++)
                        {
                            if (numero % i == 0)
                            {
                                divisible++;
                            }
                            if (divisible > 2)
                            {
                                break;
                            }
                        }
                        if (divisible == 2)
                        {
                            Console.WriteLine(numero);
                        }
                        divisible = 0;
                        numero++;
                    }

                }
                else if (n != "salir")
                {

                    do
                    {
                        Console.Write("\nERROR, Ingrese Valor Entero o si desea salir ponga salir: ");
                        n = Console.ReadLine();
                        esValido = int.TryParse(n, out valor);

                        if (n != "salir" && esValido == true)
                        {
                            Console.WriteLine("Lista de todos los numeros primos antes del {0}", valor);
                            while (numero <= valor)
                            {
                                for (int i = 1; i <= numero; i++)
                                {
                                    if (numero % i == 0)
                                    {
                                        divisible++;
                                    }
                                    if (divisible > 2)
                                    {
                                        break;
                                    }
                                }
                                if (divisible == 2)
                                {
                                    Console.WriteLine(numero);
                                }
                                divisible = 0;
                                numero++;
                            }
                        }

                    } while (n != "salir");
                }
                numero = 2;
            } while (n != "salir");
        }
    }
}
