using System;
using System.Text;

namespace staticI05AprendeteLasTablasEjer15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HallarTabla(10)); 
        }

        public static string HallarTabla(int numeroDelQueSeHallaTabla)
        {
            StringBuilder tablaDeMultiplicar = new StringBuilder($"La tabla de multiplicar del numero {numeroDelQueSeHallaTabla}: \n");

            for (int i = 1; i <=15; i++)
            {
                tablaDeMultiplicar.AppendLine($"{i} x {numeroDelQueSeHallaTabla} = {i * numeroDelQueSeHallaTabla}");
            }
            return tablaDeMultiplicar.ToString();
        }
    }


}
