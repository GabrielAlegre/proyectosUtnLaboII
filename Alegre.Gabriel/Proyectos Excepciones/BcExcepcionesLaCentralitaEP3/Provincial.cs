using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcExcepcionesLaCentralitaEP3
{
    public class Provincial:Llamada
    {

        protected Franja franjaHoraria;
        public Provincial(string nroOrigen, Franja unaFranja, float duracion, string nroDestino) : base(duracion, nroDestino, nroOrigen)
        {
            franjaHoraria = unaFranja;
        }

        public Provincial(Franja unaFranja, Llamada unLlam) : this(unLlam.NroOrigen, unaFranja, unLlam.Duracion, unLlam.NroDestino)
        {
        }

        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            double costo= 0.66;
            switch(franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = 0.99;
                    break;         
                case Franja.Franja_2:
                    costo = 1.25;
                    break;               
            }

            return (float) (base.Duracion * costo);
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo: {this.CostoLlamada}");
            sb.AppendLine($"Franja horaria: {this.franjaHoraria}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }

        public override bool Equals(object obj)
        {
            return obj is not null && obj is Provincial && this==(Provincial)obj;
        }
    }
}
