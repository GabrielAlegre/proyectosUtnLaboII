using System;
using System.Collections.Generic;

namespace BcHerenciaDeportivaI02
{
    public class Equipo
    {
        private int cantidadDeJugadores;

        private List<Jugador> listaDeJugadores;

        private string nombre;

        private Equipo()
        {
            listaDeJugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo equipoDondeAgregarJugador, Jugador jugadorParaAgregar)
        {

            if (equipoDondeAgregarJugador.listaDeJugadores.Count < equipoDondeAgregarJugador.cantidadDeJugadores)
            {
                foreach (Jugador unJugador in equipoDondeAgregarJugador.listaDeJugadores)
                {
                    if (unJugador == jugadorParaAgregar)
                    {
                        return false;
                    }
                }
                equipoDondeAgregarJugador.listaDeJugadores.Add(jugadorParaAgregar);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
