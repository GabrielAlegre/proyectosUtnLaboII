using System;
using System.Text;

namespace BcEstadisticaDeportivaC01
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles) : this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        public float GetPromedioGoles ()
        {
            return (float)totalGoles / partidosJugados;
        }

        public string MostrarDatos()
        {
            StringBuilder datosDelJugador = new StringBuilder("Informacion del jugador\n");

            datosDelJugador.AppendLine($"Nombre del jugador: {this.nombre}");
            datosDelJugador.AppendLine($"Dni del jugador: {this.dni}");
            datosDelJugador.AppendLine($"Partidos jugados del jugador: {this.partidosJugados}");
            datosDelJugador.AppendLine($"Total de goles marcados: {this.totalGoles}");
            datosDelJugador.AppendLine($"Promedio de goles: {GetPromedioGoles()}");

            return datosDelJugador.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }      
        
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.dni == j2.dni);
        }


    }
}
