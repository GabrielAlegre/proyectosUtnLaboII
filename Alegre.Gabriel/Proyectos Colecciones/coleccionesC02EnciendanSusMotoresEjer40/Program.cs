using System;
using BcEnciendanSusMotoresC02;
namespace coleccionesC02EnciendanSusMotoresEjer40
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 a1 = new AutoF1(1, "escu1");
            AutoF1 a2 = new AutoF1(4, "escu2");
            AutoF1 a3 = new AutoF1(5, "escu3");
            AutoF1 a4 = new AutoF1(1, "escu1");
            AutoF1 a5 = new AutoF1(2, "escu4");
            Competencia competencia = new Competencia(5, 10);



            if (competencia + a1)
            {
                Console.WriteLine("SE AGREGO");
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }

            if (competencia + a2)
            {
                Console.WriteLine("SE AGREGO");
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }

            if (competencia + a3)
            {
                Console.WriteLine("SE AGREGO");
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
            if (competencia + a4)
            {
                Console.WriteLine("SE AGREGO");
                
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }

            if (competencia + a5)
            {
                Console.WriteLine("SE AGREGO\n");
                
            }
            else
            {
                Console.WriteLine("NO SE AGREGO\n");
            }

            Console.WriteLine(competencia.MostrarDatos());

            if (competencia - a1)
            {
                Console.WriteLine("SE ELIMINO A1");
            }
            else
            {
                Console.WriteLine("NO SE ELIMINO A1");
            }

            if (competencia - a3)
            {
                Console.WriteLine("SE ELIMINO A3");
            }
            else
            {
                Console.WriteLine("NO SE ELIMINO A3");
            }
            Console.WriteLine(competencia.MostrarDatos());
         
        }
    }
}
