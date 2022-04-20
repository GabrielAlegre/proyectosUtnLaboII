using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticI03ConversorBinarioEjer013
{
    class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string numeroBinario = "";

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

            return numeroBinario;
        }

        public static int ConvertirBinarioADecimal(int valorRecibido)
        {
            int resultado = 0; //Valor a retornar, lo inicializamos en cero dado que si la cadena recibida no corresponde a un binario restamos 0
            string valorRecibidoString = string.Empty + valorRecibido; //Convert.ToString(valorRecibido)
            int cantidadCaracteres = valorRecibidoString.Length; // guardamos la longitud de la cadena para saber hasta donde tenemos que ir calculando

            foreach (char caracter in valorRecibidoString)
            {
                cantidadCaracteres--;
                if (caracter == '1')
                {
                    resultado += (int)Math.Pow(2, cantidadCaracteres);
                }
            }
            return resultado;
        }
    }
}
