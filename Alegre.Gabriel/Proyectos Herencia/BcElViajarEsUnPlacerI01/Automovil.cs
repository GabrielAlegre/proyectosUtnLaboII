using System;
using System.Text;

namespace BcElViajarEsUnPlacerI01
{
    public class Automovil :  VehiculoTerrestre
    {
        //private short cantidadDeRuedad;
        //private short cantidadDePuertas;
        //private Colores color;
        private short cantidadDeMarchas;
        private int cantidadDePasajeros;

        public Automovil(short cantidadDeRuedad, short cantidadDePuertas, Colores color, short cantidadDeMarchas, int cantidadDePasajeros):base(cantidadDeRuedad, cantidadDePuertas, color)
        {
            this.cantidadDeMarchas = cantidadDeMarchas;
            this.cantidadDePasajeros = cantidadDePasajeros;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder("Automovil\n");

            sb.Append(base.Mostrar());
            sb.AppendLine($"Cantidad de marchas: {this.cantidadDeMarchas}");
            sb.AppendLine($"Peso de pasajeros: {this.cantidadDePasajeros}");

            return sb.ToString();
        }
    }
}
