using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcElViajarEsUnPlacerI01
{
    public class Moto : VehiculoTerrestre
    {
        //private short cantidadDeRuedad;
        //private short cantidadDePuertas;
        //private Colores color;
        private short cilindrada;

        public Moto(short cantidadDeRuedad, short cantidadDePuertas, Colores color, short cilindrada) :  base(cantidadDeRuedad, cantidadDePuertas, color)
        {
            this.cilindrada = cilindrada;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder("Moto\n");

            sb.Append(base.Mostrar());
            sb.AppendLine($"Cilindrado: {this.cilindrada}");
      

            return sb.ToString();
        }
    }
}
