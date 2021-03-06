using System;
using BcJugadoresEncapsuladosC01;

namespace encapsulamientoC01JugadoresEncapsuladosEjer42
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo unEquipo = new Equipo(2, "Los uras");
            Jugador primerJugador = new Jugador(28028001, "Juan Carlos", 1114, 810);
            Jugador segundoJugador = new Jugador(28028001, "Agustin Riquelme", 530, 805);
            Jugador tercerJugador = new Jugador(29020304, "Marin Juarez", 1003, 779);
            Jugador cuartoJugador = new Jugador(245935835, "Marcos Ayala", 100, 90);


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

            //este jugador no se va a agregar xq es igual al primero (mismo dni)
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
                Console.WriteLine("\nNo hay mas espacio en el equipo");
            }

            //No agrega xq no hay espacio
            if (unEquipo + cuartoJugador)
            {
                Console.WriteLine("\nFicho este jugador en su equipo");
                Console.WriteLine(cuartoJugador.MostrarDatos());
            }
            else
            {
                Console.WriteLine("\nNo hay mas espacio en el equipo");
            }
        }
    }
}
