using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticI02DeseaContinuarEjer12
{
    class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool valorValido = true;
            if(valor>max || valor<min)
            {
                valorValido = false;
            }

            return valorValido;
        }

        public static bool ValidarRespuesta(string rta)
        {
            bool rtaValida = true;

            if (rta!="s" && rta!="S")
            {
                rtaValida = false;
            }

            return rtaValida;
        }
    }
}
