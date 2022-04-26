using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcHerenciaLaCentralitaEP1
{
    public class Provincial:Llamada
    {

        protected Franja franjaHoraria;

        public Provincial(Franja unaFranja, Llamada unLlam) : base(unLlam.Duracion, unLlam.NroDestino, unLlam.NroOrigen)
        {
            this.franjaHoraria = unaFranja;
        }
        public Provincial(string nroOrigen, Franja unaFranja, float duracion, string nroDestino) : this(unaFranja, new Llamada(duracion, nroDestino, nroOrigen))
        {
        }

        public float CostoLlamada
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

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo: {this.CostoLlamada}");
            sb.AppendLine($"Franja horaria: {this.franjaHoraria}");

            return sb.ToString();
        }
    }
}
