using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcConversorBinarioRecargado
{
    public class NumeroBinario
    {
        private string numeroBinario;

        private NumeroBinario(string numeroBinario)
        {
            this.numeroBinario = numeroBinario;
        }

        public string NumBinario
        {
            get { return numeroBinario; }
        }

        public static string operator + (NumeroBinario b, NumeroDecimal d)
        {
            double numero = d.NumDecimal + ((NumeroDecimal)b).NumDecimal;
            return Conversor.ConvertirDecimalABinario(Convert.ToInt32(numero));
        }

        public static string operator -(NumeroBinario b, NumeroDecimal d)
        {
            double numero = d.NumDecimal - ((NumeroDecimal)b).NumDecimal;
            return Conversor.ConvertirDecimalABinario(Convert.ToInt32(numero));
        }

        public static bool operator ==(NumeroBinario b, NumeroDecimal d)
        {
            return b.numeroBinario == ((NumeroBinario)d).NumBinario;
        }

        public static bool operator !=(NumeroBinario b, NumeroDecimal d)
        {
            return (b==d);
        }

        public static implicit operator NumeroBinario(string binario)
        {
            return new NumeroBinario(binario);
        }

        public static explicit operator string(NumeroBinario objBinario)
        {
            return objBinario.numeroBinario;
        }

        public static explicit operator NumeroDecimal(NumeroBinario objBin)
        {
            NumeroDecimal retorno = Conversor.ConvertirBinarioADecimal(Convert.ToDouble( objBin.NumBinario));
            return retorno;
        }

    }
}
