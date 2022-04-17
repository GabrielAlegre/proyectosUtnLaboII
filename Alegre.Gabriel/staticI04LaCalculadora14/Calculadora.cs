using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticI04LaCalculadora14
{
    class Calculadora
    {
        public static double Calcular(double primerOperando, double segundoOperando, char operando)
        {

            double resultadoOperacion=0;
            switch(operando)
            {
                case '+':
                    resultadoOperacion = primerOperando + segundoOperando;
                    break;

                case '-':
                    resultadoOperacion = primerOperando - segundoOperando;
                    break;

                case '*':
                    resultadoOperacion = primerOperando * segundoOperando;
                    break;

                case '/':
                    if(Validar(segundoOperando))
                    {
                        resultadoOperacion = primerOperando / segundoOperando;
                    }
                    else
                    {
                        resultadoOperacion = -1;
                    }
                    break;

                default:
                    Console.WriteLine("\nOperador invalido, vamos a sumar por default");
                    resultadoOperacion = primerOperando + segundoOperando;
                    break;

            }

            return resultadoOperacion;
        }

        /*
        Validar(privado) : Recibirá como parámetro el segundo operando.
            Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.
            Este método devolverá true si el operando es distinto de cero.*/
        private static bool Validar(double segundoOperando)
        {
            bool sePuedeDividir = false;

            if(segundoOperando!=0)
            {
                sePuedeDividir = true;
            }

            return sePuedeDividir;
        }

        public static bool ValidarRespuesta(string rta)
        {
            bool rtaValida = true;

            if (rta != "s" && rta != "S")
            {
                rtaValida = false;
            }

            return rtaValida;
        }
    }
}
