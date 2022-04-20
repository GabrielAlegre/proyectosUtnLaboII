using System;

namespace BcConversorBinarioWindForms
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(double numeroRecibidoEnParam)
        {
            string numeroBinario = "";

            int numeroEntero = (int)numeroRecibidoEnParam;

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

        public static double ConvertirBinarioADecimal(double valorRecibido)
        {
            double resultado = 0; //Valor a retornar, lo inicializamos en cero dado que si la cadena recibida no corresponde a un binario restamos 0
            string valorRecibidoString = string.Empty + valorRecibido; //Convert.ToString(valorRecibido)
            int cantidadCaracteres = valorRecibidoString.Length; // guardamos la longitud de la cadena para saber hasta donde tenemos que ir calculando

            foreach (char caracter in valorRecibidoString)
            {
                cantidadCaracteres--;
                if (caracter == '1')
                {
                    resultado += Math.Pow(2, cantidadCaracteres);
                }
            }
            return resultado;
        }
    }
}
