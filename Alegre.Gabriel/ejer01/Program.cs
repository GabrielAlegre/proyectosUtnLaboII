using System;
using System.Collections.Generic;
using System.Text;

namespace ejer01
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arrayDePalabras = { "Hola", "como", "estas", "como", "malvado" };
            Dictionary<string, int> diccionarioDePalabras = new Dictionary<string, int>();

            foreach (string unaPalabra in arrayDePalabras)
            {
                if (!diccionarioDePalabras.ContainsKey(unaPalabra))
                {
                    diccionarioDePalabras.Add(unaPalabra, 1);
                }
                else
                {
                    diccionarioDePalabras[unaPalabra]++;
                }
            }

            foreach (int item in diccionarioDePalabras.Values)
            {
                Console.WriteLine(item);
            }


     
            //int[] a = new int[5];
            //a[0] = 1;

            //foreach (int item in a)
            //{
            //    Console.WriteLine(item);
            //}



            //Console.WriteLine(Math.Abs(-56));



            //StringBuilder sb = new StringBuilder("Informacion personal\n");
            //string nombre = "Gabriel";
            //int edad = 16;
            //int dni = 43901903;


            //for (int i = 0; i < 10; i++)
            //{
            //    sb.AppendLine($"Nombre: {nombre}");
            //}

            //sb.AppendLine($"Edad: {edad}");
            //sb.AppendLine($"Dni: {dni}");



            //Console.WriteLine(sb.ToString());
























            /*
            int numero = 101010;

            string numeroEntero="";

            numeroEntero += numero;
            */
            //string strBinario = "10101010";
            //int resultadoEntero = 0;
            //string resultadoString = "";
            //int cantidadCaracteres = strBinario.Length;

            //foreach (char caracter in strBinario)
            //{
            //    cantidadCaracteres--;
            //    if (caracter == '1')
            //    {
            //        resultadoEntero += (int)Math.Pow(2, cantidadCaracteres);
            //    }
            //}
            //resultadoString = resultadoEntero.ToString();

            /*
            //Console.WriteLine(resultadoEntero);
            double numero=85.9;
            string numeroBinario = "";
            int numeroEntero = (int)numero;
            Console.WriteLine(numeroEntero);
            if (numeroEntero > 0)
            {
                while (numeroEntero != 0)
                {
                    if (numeroEntero % 2 == 0)
                    {
                        numeroBinario = 0 + numeroBinario;

                    }
                    else
                    {
                        numeroBinario = 1 + numeroBinario;
                    }

                    numeroEntero = numeroEntero / 2;
                }
            }

            Console.WriteLine(numeroBinario);
            */
            /*
            string numero = "85";
            int numeroInt = int.Parse(numero);
            string numeroBinario = "Valor Invalido";

            if (numeroInt > 0)
            {
                while (numeroInt != 0)
                {

                    if (numeroInt % 2 == 0)
                    {
                        numeroBinario = 0 + numeroBinario;

                    }
                    else
                    {
                        numeroBinario = 1 + numeroBinario;
                    }
                    numeroInt = numeroInt / 2;
                }
            }
            Console.WriteLine(numeroBinario);

            string binario = "1010101";
            int resultado = 0;
            int cantidadCaracteres = binario.Length;
            string resultadoBinario = "";
       
            
                foreach (char caracter in binario)
                {
                    cantidadCaracteres--;
                    if (caracter == '1')
                    {
                        resultado += (int)Math.Pow(2, cantidadCaracteres);
                    }
                }
                resultadoBinario += resultado;
            
  
            Console.WriteLine(resultadoBinario);
            */

            /*
            Console.WriteLine("Justificando a derecha (valor positivo) y a izquierda (valor negativo):");
            Console.WriteLine("---------- ----------");

            string MyString = "*";
            int t = 3;
            Console.WriteLine(MyString.PadLeft(t, ' '));

            MyString += '*';
            Console.WriteLine(MyString.PadLeft(t, ' '));
            */
            // Console.WriteLine($"{0, 10} {1,-10} {2}", '*', 15, 23);
            /*
            string nombre = "Carlos Alberto";
            int edad = 5;
            Console.Title = "Ejer01";
            Console.WriteLine("Hello World!");
            Console.WriteLine("Nombre: " + nombre + " y edad: " + edad);
            Console.ReadKey();
            */
        }
    }
}
