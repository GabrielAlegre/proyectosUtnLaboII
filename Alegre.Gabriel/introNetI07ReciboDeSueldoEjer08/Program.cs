using System;

namespace introNetI07ReciboDeSueldoEjer08
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorHora;
            string nombre;
            int antiguedadAnios;
            int cantHorasTrabMes;
            string seguir = "si";
            double importeValorHoraPorCantHoras;
            double bonusPorAntiguedad;
            double totalSinDescuento;
            double descuento;
            double totalDespuesDeDescuento;

            do
            {
                Console.Write("Ingrese el nombre del empreado: ");
                nombre = Console.ReadLine();

                Console.Write("Ingrese el valor de la hora del empleado {0}: ", nombre);
                while (double.TryParse(Console.ReadLine(), out valorHora) == false)
                {
                    Console.Write("Error. Ingrese el valor de la hora del empleado {0}: ", nombre);
                }

                Console.Write("Ingrese la antiguedad del empleado {0}: ", nombre);
                while (int.TryParse(Console.ReadLine(), out antiguedadAnios) == false)
                {
                    Console.Write("Error. Ingrese el valor de la hora del empleado {0}: ", nombre);
                }

                Console.Write("Ingrese la cantidad de horas trabajadas en el mes del empleado {0}: ", nombre);
                while (int.TryParse(Console.ReadLine(), out cantHorasTrabMes) == false)
                {
                    Console.Write("Error. Ingrese el valor de la hora del empleado {0}: ", nombre);
                }
                /*
                 Se pide calcular el importe a cobrar teniendo en cuenta que el total 
                (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas),
                hay que sumarle la cantidad de años trabajados multiplicados por $150, 
                y al total de todas esas operaciones restarle el 13% en concepto de descuentos.*/
                importeValorHoraPorCantHoras = valorHora * cantHorasTrabMes;
                bonusPorAntiguedad = 150 * antiguedadAnios;
                totalSinDescuento = importeValorHoraPorCantHoras + bonusPorAntiguedad;
                descuento = totalSinDescuento * 0.13;
                totalDespuesDeDescuento = totalSinDescuento - descuento;

                Console.WriteLine("\nRecibo del empleado");
                Console.WriteLine("El nombre del empleado es: {0}", nombre);
                Console.WriteLine("La antiguedad del empleado es: {0}", antiguedadAnios);
                Console.WriteLine("El valor de la hora del empleado es: {0}", valorHora);
                Console.WriteLine("Total a cobrar bruto: {0}", totalSinDescuento);
                Console.WriteLine("Total a cobrar neto: {0}", totalDespuesDeDescuento);

                Console.Write("Desea ingresar otro empleado (si/no): ");
                seguir = Console.ReadLine();


            } while (seguir != "no");
        }
    }
}
