using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcEstadisticaDeportivaC01
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> listaDeJugadores;
        private string nombreDelEquipo;

        private Equipo()
        {
            this.listaDeJugadores = new List<Jugador>();
        }

        public Equipo(short cantidadDeJugadores, string nombreDelEquipo) :this()
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombreDelEquipo = nombreDelEquipo;
        }

        public static bool operator + (Equipo unEquipo, Jugador unJugador)
        {
            bool elJugadorEstaEnElEquipo = false;
            bool seAgrego = false;

            foreach (Jugador unJugadorDelEquipo in unEquipo.listaDeJugadores)
            {
                if(unJugadorDelEquipo==unJugador)
                {
                    elJugadorEstaEnElEquipo = true;
                    break;
                }
            }

            if (elJugadorEstaEnElEquipo == false && unEquipo.listaDeJugadores.Count < unEquipo.cantidadDeJugadores)
            {
                unEquipo.listaDeJugadores.Add(unJugador);
                seAgrego = true;
            }
            return seAgrego;
        }
    }
}
