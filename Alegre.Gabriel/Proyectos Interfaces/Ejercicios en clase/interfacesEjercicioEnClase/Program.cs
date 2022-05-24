using System;
using System.Collections.Generic;
using BcEjercicioEnClaseInterfaces;
namespace interfacesEjercicioEnClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Comercial unAvion1= new Comercial(5000, 500,70);// impuesto AFIP: 1650 - impuesto ARBA: 1250
            Privado unAvion2 = new Privado(1500, 500, 10);// impuesto AFIP: 495 - impuesto ARBA: 405
            Avion unAvion3 = new Avion(3600, 500);// impuesto AFIP: 1.188 - impuesto ARBA: 972
            Avion unAvion4 = new Avion(6543, 500);// impuesto AFIP: 2.159.19 - impuesto ARBA: 1.766.61
            Deportivo unAutitoDepo1 = new Deportivo(170000, "AAA 435", 3000);// impuesto AFIP: 47.600 - impuesto ARBA: 39100
            Deportivo unAutitoDepo2 = new Deportivo(60000, "AAA 435", 1500);// impuesto AFIP: 16.800 - impuesto ARBA: 13.800
            Deportivo unAutitoDepo3 = new Deportivo(20000, "AAA 435", 1700);// impuesto AFIP: 5600 - impuesto ARBA: 4.600
            Carreta unaCarreta = new Carreta(10000);//impuesto ARBA: 1.800

            List<Vehiculo> listaDeVehiculos = new List<Vehiculo>();
            listaDeVehiculos.Add(unAvion1);
            listaDeVehiculos.Add(unAvion2);
            listaDeVehiculos.Add(unAvion3);
            listaDeVehiculos.Add(unAvion4);
            listaDeVehiculos.Add(unAutitoDepo1);
            listaDeVehiculos.Add(unAutitoDepo2);
            listaDeVehiculos.Add(unAutitoDepo3);
          

            Console.WriteLine("Impuestos nacionales IAFIP");
            foreach (IAFIP item in listaDeVehiculos)
            {
                Console.WriteLine(Gestion.MostrarImpuestoNacional(item)); 
            }

            Console.WriteLine("\nImpuestos Provinciales IARBA");

            Console.WriteLine(Gestion.MostrarImpuestoProvincial(unaCarreta));
            foreach (IARBA item in listaDeVehiculos)
            {
                Console.WriteLine(Gestion.MostrarImpuestoProvincial(item));
            }
        }
    }
}
