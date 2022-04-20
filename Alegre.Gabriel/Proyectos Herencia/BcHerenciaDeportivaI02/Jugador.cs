using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcHerenciaDeportivaI02
{

    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public Jugador(int dni, string nombre) : base(dni,nombre)
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles) : this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }
        public float PromedioGoles
        {
            get { return (float)TotalGoles / PartidosJugados; ; }
        }

        public int PartidosJugados
        {
            get { return this.partidosJugados; }
        }

        public int TotalGoles
        {
            get { return this.totalGoles; }
        }


        public new string MostrarDatos()
        {
            StringBuilder datosDelJugador = new StringBuilder("Informacion del jugador\n");

            datosDelJugador.AppendLine(base.MostrarDatos());
            datosDelJugador.AppendLine($"Partidos jugados del jugador: {this.partidosJugados}");
            datosDelJugador.AppendLine($"Total de goles marcados: {this.totalGoles}");
            datosDelJugador.AppendLine($"Promedio de goles: {Math.Round (this.PromedioGoles,2)}");

            return datosDelJugador.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.Dni == j2.Dni);
        }
    }
    
}
