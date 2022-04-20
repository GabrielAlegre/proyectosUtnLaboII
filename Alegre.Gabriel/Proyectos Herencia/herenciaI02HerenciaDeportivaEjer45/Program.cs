using System;
using System.Collections.Generic;
using System.Text;
using BcHerenciaDeportivaI02;

namespace herenciaI02HerenciaDeportivaEjer45
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectorTecnico unDt = new DirectorTecnico("Jorge", DateTime.ParseExact("24/06/2001", "dd/MM/yyyy", null));
            DirectorTecnico unDt2 = new DirectorTecnico("Jorge", DateTime.ParseExact("24/06/2001", "dd/MM/yyyy", null));
            Persona unaPersona = new Persona(64538364, "Luisito comunica");

            Equipo unEquipo = new Equipo(3, "Los uras");
            Jugador primerJugador = new Jugador(28028001, "Juan Carlos", 804, 1109);
            Jugador segundoJugador = new Jugador(28028001, "Agustin Riquelme", 805, 530);
            Jugador tercerJugador = new Jugador(29020304, "Marin Juarez", 772, 961);

            List<Persona> listaPersonas = new List<Persona>();



            // unDt.Dni = 23040504;

            //Agrego el primer jugador
            if (unEquipo + primerJugador)
            {
                Console.WriteLine("Ficho este jugador en su equipo");
                Console.WriteLine(primerJugador.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No hay mas espacio en el equipo");
            }

            //Agrego el segundo jugador (este no se va agregar xq tiene el mismo dni que el primer jugador, por lo tanto, son iguales y no puede aver dos jugadores iguales en el mismo equipo) 
            if (unEquipo + segundoJugador)
            {
                Console.WriteLine("\nFicho este jugador en su equipo");
                Console.WriteLine(segundoJugador.MostrarDatos());
            }
            else
            {
                Console.WriteLine("\nNo hay mas espacio en el equipo");
            }

            //Agrego el tercer jugador 
            if (unEquipo + tercerJugador)
            {
                Console.WriteLine("\nFicho este jugador en su equipo");
                Console.WriteLine(tercerJugador.MostrarDatos());
            }
            else
            {
                Console.WriteLine("\nNo hay mas espacio en el equipoooooooo");
            }

            Console.WriteLine("\n" + unaPersona.MostrarDatos());

            Console.WriteLine(unDt.MostrarDatos());

            Console.WriteLine($"Los dt son iguales: {unDt == unDt2}");
        }
    }
}
