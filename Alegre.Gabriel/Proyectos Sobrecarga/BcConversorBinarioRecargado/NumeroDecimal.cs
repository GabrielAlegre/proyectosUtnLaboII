using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcConversorBinarioRecargado
{
    public class NumeroDecimal
    {
        private double numeroDecimal;

        private NumeroDecimal(double numeroDecimal)
        {
            this.numeroDecimal = numeroDecimal;
        }

        public double NumDecimal
        {
            get { return numeroDecimal; }
        }

        /****************************************************************/
        public static double operator +(NumeroDecimal d, NumeroBinario b)
        {
          
            return d.NumDecimal + ((NumeroDecimal)b).NumDecimal; 
        }

        public static double operator -(NumeroDecimal d, NumeroBinario b)
        {
            return d.NumDecimal - ((NumeroDecimal)b).NumDecimal;
        }

        public static bool operator ==(NumeroDecimal d, NumeroBinario b)
        {
            return d.numeroDecimal == ((NumeroDecimal)b).NumDecimal;
        }

        public static bool operator !=(NumeroDecimal d, NumeroBinario b)
        {
            return (d == b);
        }

        /****************************************************************/
        public static implicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }

        public static explicit operator double (NumeroDecimal objDecimal)
        {
            return objDecimal.numeroDecimal;
        }

        public static explicit operator NumeroBinario(NumeroDecimal objDecimal)
        {
            return (NumeroBinario)Conversor.ConvertirDecimalABinario(objDecimal.NumDecimal);
        }


    }
}
