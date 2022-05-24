using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcExcepcionGoSpeedRacerGo
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.escuderia = escuderia;
            this.numero = numero;
        }
        public string Escuderia
        {
            get { return this.escuderia; }
            set { this.escuderia = value; }
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

        public short Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad de combustible: {this.cantidadCombustible}");
            sb.AppendLine($"Esta en competencia: {this.enCompetencia}");
            sb.AppendLine($"Escuderia: {this.escuderia}");
            sb.AppendLine($"Numero: {this.numero}");
            sb.Append($"Vueltas restantes: {this.vueltasRestantes}");

            return sb.ToString();
        }

        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return (v1.escuderia == v2.escuderia) && (v1.numero == v2.numero);
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }
    }
}
