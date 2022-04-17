using System;
using System.Text;

namespace BcVieneConSistemaDeAutoNavegacion
{
    public class Conductores
    {
        private int[] kilometros = new int[7];
        private string nombre;

        public int []Kilometros
        {
            get { return this.kilometros; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public Conductores (string nombre, int [] kilometros)
        {
            this.kilometros = kilometros;
            this.nombre = nombre;
        }

        public string Mostrar()
        {
            int contador = 1;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre del conductor: {Nombre}");
            foreach(int kmDeUnDia in kilometros)
            {
                sb.AppendLine($"Km del dia {contador}: {kmDeUnDia}");
                contador++;
            }

            return sb.ToString();
        }

        public int CantidadDeKilometrosEnLaSemana()
        {
            int SumaDeKmEnUnaSemana = 0;

            foreach (int kmDeUnDia in Kilometros)
            {
                SumaDeKmEnUnaSemana += kmDeUnDia;
            }
            
            return SumaDeKmEnUnaSemana;
        }

        public static string ConductorConMasKmSemana(Conductores[] arrayDeConductores)
        {
            int kmDelConductorEnLaSemana = 0;
            int maximosKmEnUnaSemana = 0;
            string nombreMasKmUnaSemana = "";
            int flag = 0;

            foreach (Conductores unConductorDelArray in arrayDeConductores)
            {
                kmDelConductorEnLaSemana = unConductorDelArray.CantidadDeKilometrosEnLaSemana();
                if (flag == 0 || kmDelConductorEnLaSemana > maximosKmEnUnaSemana)
                {
                    maximosKmEnUnaSemana = kmDelConductorEnLaSemana;
                    nombreMasKmUnaSemana = unConductorDelArray.Nombre;
                    flag = 1;
                }
            }

            return nombreMasKmUnaSemana;
        }

        public static string ConductorConMasKmDiaTres(Conductores[] arrayDeConductores)
        {
            int KmEnElDiaTres = 0;
            int maximosKmEnElDiaTres = 0;
            string nombreMasKmEnElDiaTres = "";
            int flag = 0;
            

            foreach (Conductores unConductorDelArray in arrayDeConductores)
            {
                KmEnElDiaTres = unConductorDelArray.Kilometros[2];

                if (flag == 0 || KmEnElDiaTres > maximosKmEnElDiaTres)
                {
                    maximosKmEnElDiaTres = KmEnElDiaTres;
                    nombreMasKmEnElDiaTres = unConductorDelArray.Nombre;
                    flag = 1;
                }

                KmEnElDiaTres = 0;
            }

            return nombreMasKmEnElDiaTres;
        }

        public static string ConductorConMasKmDiaCinco(Conductores[] arrayDeConductores)
        {
            int KmEnElDiaCinco = 0;
            int maximosKmEnElDiaCinco = 0;
            string nombreMasKmEnElDiaCinco = "";
            
            int flag = 0;


            foreach (Conductores unConductorDelArray in arrayDeConductores)
            {
                KmEnElDiaCinco = unConductorDelArray.Kilometros[4];

                if (flag == 0 || KmEnElDiaCinco > maximosKmEnElDiaCinco)
                {
                    maximosKmEnElDiaCinco = KmEnElDiaCinco;
                    nombreMasKmEnElDiaCinco = unConductorDelArray.Nombre;
                    flag = 1;
                }

                KmEnElDiaCinco = 0;
            }

            return nombreMasKmEnElDiaCinco;
        }

    }
}
