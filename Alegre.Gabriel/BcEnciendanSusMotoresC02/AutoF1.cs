using System;
using System.Text;

namespace BcEnciendanSusMotoresC02
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.escuderia = escuderia;
            this.numero = numero;
        }

        public short CantidadCombustible
        {
            get { return this.cantidadCombustible; }
            set { this.cantidadCombustible = value; }
        }    
        public bool EnCompetencia
        {
            get { return this.enCompetencia; }
            set { this.enCompetencia = value; }
        }       
        
        public short VueltasRestantes
        {
            get { return this.vueltasRestantes; }
            set { this.vueltasRestantes = value; }
        }

        public string MostrarDatos ()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad de combustible: {this.cantidadCombustible}");
            sb.AppendLine($"Esta en competencia: {this.enCompetencia}");
            sb.AppendLine($"Escuderia: {this.escuderia}");
            sb.AppendLine($"Numero: {this.numero}");
            sb.AppendLine($"Vueltas restantes: {this.vueltasRestantes}");

            return sb.ToString();
        }

        public static bool operator == (AutoF1 a1, AutoF1 a2)
        {
            return (a1.escuderia == a2.escuderia) && (a1.numero == a2.numero);
        }    
        
        public static bool operator != (AutoF1 a1, AutoF1 a2)
        {
            return !(a1==a2);
        }
    }
}
