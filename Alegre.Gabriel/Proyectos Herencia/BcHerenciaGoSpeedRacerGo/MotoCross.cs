using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcHerenciaGoSpeedRacerGo
{
    public class MotoCross : VehiculoDeCarrera
    {
        private string cilindrada;

        public string Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }

        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {
        }

        public MotoCross(short numero, string escuderia, string cilin) : base(numero, escuderia)
        {
            this.cilindrada = cilin;
        }



        public string MostrarDatosMotoCross()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Cilindrada: {this.cilindrada}\n");


            return sb.ToString();
        }

        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            return m1.cilindrada == m2.cilindrada;
        }

        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }
    }
}
