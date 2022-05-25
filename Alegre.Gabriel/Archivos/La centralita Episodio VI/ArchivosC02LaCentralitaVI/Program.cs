using System;
using System.Collections.Generic;
using BcCentralitaEp6Archivos;

namespace ArchivosC02LaCentralitaVI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("Fede Center");

            // Mis 6 llamadas
            Local l1 = new Local(30, "Rosario", "Bernal", 2.65f);
            Provincial l2 = new Provincial("Morón", Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local(45, "San Rafael", "Lanús", 1.99f);
            Provincial l4 = new Provincial(Franja.Franja_3, l2);
            Provincial l5 = new Provincial("Santa cruz", Franja.Franja_2, 54, "Santa fe");
            Local l6 = new Local(17, "Quilmes", "Avellaneda", 2.92f);
            Local l7 = new Local(17, "Quilmes", "Avellaneda", 2.92f);
            //Creo lista y agrego las llamadas
            List<Llamada> listaDeLlamadas = new List<Llamada>();
            listaDeLlamadas.Add(l1);
            listaDeLlamadas.Add(l2);
            listaDeLlamadas.Add(l3);
            listaDeLlamadas.Add(l4);
            listaDeLlamadas.Add(l5);
            listaDeLlamadas.Add(l6);
            listaDeLlamadas.Add(l7);

            //La llamada 4 y 7 no se van a agragar xq estan repetidas
            for (int i = 0; i < listaDeLlamadas.Count; i++)
            {
                try
                {
                    c += listaDeLlamadas[i];
                    Console.WriteLine("Se agrego la llamada a la central");
                   
                }
                catch (CentralitaException ex)
                {

                    Console.WriteLine($"{ex.Message} {ex.NombreClase} {ex.NombreMetodo}");
                }
            }

            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());
            try
            {
                Console.WriteLine("Bitacora:\n"+c.Leer());
            }
            catch (Exception)
            {
                Console.WriteLine("Error al leer el archivo");
            }

            Console.ReadKey();
        }
    }
}
