using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticI01ValidadorRangosEjer11
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
    }
}
