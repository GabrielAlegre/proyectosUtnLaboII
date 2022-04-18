using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcJugadoresEncapsuladosC01
{

    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
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
        public float PromedioGoles
        {
            get { return (float)TotalGoles / PartidosJugados; ; }
        }

        public int PartidosJugados
        {
            get { return this.partidosJugados; }//siiiiiiiiiiiiiiiiiiiii se borra
        }

        public int TotalGoles
        {
            get { return this.totalGoles; }//siiiiiiiiiiiiiiiiiiiii se borra
        }


        public string Nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { this.dni = value; }
        }
     

        public string MostrarDatos()
        {
            StringBuilder datosDelJugador = new StringBuilder("Informacion del jugador\n");

            datosDelJugador.AppendLine($"Nombre del jugador: {this.nombre}");
            datosDelJugador.AppendLine($"Dni del jugador: {this.dni}");
            datosDelJugador.AppendLine($"Partidos jugados del jugador: {this.partidosJugados}");
            datosDelJugador.AppendLine($"Total de goles marcados: {this.totalGoles}");
            datosDelJugador.AppendLine($"Promedio de goles: {Math.Round (this.PromedioGoles,2)}");

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
