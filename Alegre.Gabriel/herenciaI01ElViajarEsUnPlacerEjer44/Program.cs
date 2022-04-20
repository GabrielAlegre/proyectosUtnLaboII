using System;
using System.Collections.Generic;
using BcElViajarEsUnPlacerI01;

namespace herenciaI01ElViajarEsUnPlacerEjer44
{
    class Program
    {
        static void Main(string[] args)
        {
            Moto unaMoto = new Moto(2, 0, VehiculoTerrestre.Colores.Negro, 3);
            Camion unCamion = new Camion(6,2,VehiculoTerrestre.Colores.Rojo,8,500);
            Automovil unAutomovil = new Automovil(4, 4, VehiculoTerrestre.Colores.Azul,6,3);

            List<VehiculoTerrestre> listaDeVehiculos = new List<VehiculoTerrestre>();
            listaDeVehiculos.Add ( unaMoto);
            listaDeVehiculos.Add ( unCamion);
            listaDeVehiculos.Add ( unAutomovil);
  

            foreach (VehiculoTerrestre unVehiculo in listaDeVehiculos)
            {
                Console.WriteLine(unVehiculo.Mostrar());
            }
          
        }
    }
}
