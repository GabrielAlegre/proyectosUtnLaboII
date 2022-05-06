using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcParcialPracticaCampo
{
    public class Vaca:Animal
    {
        private Clasificacion clasificacion;

        public Vaca(string nombre, int kilosAlimento) : base(nombre, kilosAlimento)
        {
        }

        public Vaca(string nombre, int kilosAlimento, Clasificacion clasi) : this(nombre, kilosAlimento)
        {
            this.clasificacion = clasi;
        }


        public override bool ComeBalanceado
        {
            get
            {
                return true;
            }
        }

        public override bool ComePasto
        {
            get
            {
                return true;
            }
        }

        public override string Datos()
        {
            StringBuilder sb=new StringBuilder();

            sb.Append(base.Datos());
            sb.AppendLine($"Clasificada como {clasificacion}");
            return sb.ToString();
        }
    }
}
