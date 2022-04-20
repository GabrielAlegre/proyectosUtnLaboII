using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerClase02
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir ()
        {
            string auxString;

            Sello.TryParser(Sello.mensaje, out auxString);
       
            return auxString;
        }
        public static void Borrar()
        {
            Sello.mensaje="";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ResetColor();
        }

        private static string ArmarFormatoMensaje()
        {
            string auxString="";
            for (int i = 0; i <= Sello.mensaje.Length+1; i++)
            {
                auxString += "*";
            }
            auxString += "\n*" + mensaje + "*\n"+auxString;

            return auxString;
        }

        private static bool TryParser(string cadenaParaValidar, out string cadenaValidada)
        {
            cadenaValidada = "";
            bool esValida = false;
            if(cadenaParaValidar.Length>0)
            {
                cadenaValidada = Sello.ArmarFormatoMensaje();
                esValida = true;
            }

            return esValida;
        }
    }
}
