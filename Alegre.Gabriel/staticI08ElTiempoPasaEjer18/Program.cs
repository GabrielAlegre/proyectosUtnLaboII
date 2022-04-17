using System;

namespace staticI08ElTiempoPasaEjer18
{
    class Program
    {
        static void Main(string[] args)
        {
            string fechaIngresada;
            Console.Write("Ingrese fecha dd/MM/yyyy: ");
            fechaIngresada= Console.ReadLine();

            Console.WriteLine($"La cantidad de dias pasaron desde {fechaIngresada} hasta {DateTime.Now,0:dd/MM/yyyy} es: {calcularDias(DateTime.ParseExact(fechaIngresada, "dd/MM/yyyy", null))}");
            
        }

        public static int calcularDias(DateTime fechaReferencia)
        {
            int diasQuePasaron = 0;
            DateTime fechaActual = DateTime.Now;
            int flag = 0;
            TimeSpan difFechas = fechaActual - fechaReferencia;


            diasQuePasaron = difFechas.Days;
            for (int i = fechaReferencia.Year+1; i <= fechaActual.Year; i++)
            {
                //Hay dos opciones para que un anio se bisiesto
                //1-Si el anio es multiplo de 4 pero tambien de 100, por obligacion el anio tambien debe ser multiplo de 400: (i % 4 == 0 && i % 100 == 0 && i % 400 == 0)
                //2-Si el anio es es multiplo de 4 pero NO de 100 no hay que verificar nada mas y ya se confirma que es bisiesto: (i % 4 == 0 && i % 100 != 0)

                //aca verificamos solamente el anio de referencia ya que si naciste antes de marzo se suma el dia vivido sino no 
                if(flag==0 && fechaReferencia.Month < 3)
                {
                    diasQuePasaron++;
                    
                }
                flag = 1;

                //aca verificamos todos los anios a partir del anio de la referencia, es decir si el anio de referencia es 1996, aca verifica apartir de 1997
                if (DateTime.IsLeapYear(i) && flag==1 )
                {
                    diasQuePasaron++;
                }


                /*
                if ((i % 4 == 0 && i % 100 == 0 && i % 400 == 0) || (i % 4 == 0 && i % 100 != 0))
                {
                    diasQuePasaron++;
                }
                */


            }

            return diasQuePasaron;
        }
    }


}
