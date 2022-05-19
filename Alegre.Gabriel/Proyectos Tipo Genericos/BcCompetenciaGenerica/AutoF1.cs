using System;
using System.Text;

namespace BcCompetenciaGenerica
{
    public class AutoF1 :  VehiculoDeCarrera
    {
        private int caballosDeFuerza;

        public int CaballosDeFuerza
        {
            get { return this.caballosDeFuerza; }
            set { this.caballosDeFuerza = value; }
        }

        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        {
        }

        public AutoF1(short numero, string escuderia, int cabFuerza) : base(numero, escuderia)
        {
            this.caballosDeFuerza = cabFuerza;
        }



        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Caballos de fuerza: {this.caballosDeFuerza}\n");


            return sb.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.caballosDeFuerza == a2.caballosDeFuerza;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
