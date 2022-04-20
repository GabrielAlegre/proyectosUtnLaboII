using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcElViajarEsUnPlacerI01
{
    public class Camion : VehiculoTerrestre
    {
        //private short cantidadDeRuedad;
        //private short cantidadDePuertas;
        //private Colores color;
        private short cantidadDeMarchas;
        private int pesoCarga;

        public Camion(short cantidadDeRuedad, short cantidadDePuertas, Colores color, short cantidadDeMarchas, int pesoCarga):base(cantidadDeRuedad,cantidadDePuertas, color)
        {
            this.cantidadDeMarchas = cantidadDeMarchas;
            this.pesoCarga = pesoCarga;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder("Camion\n");


            sb.Append(base.Mostrar());
            sb.AppendLine($"Cantidad de marchas: {this.cantidadDeMarchas}");
            sb.AppendLine($"Peso de carga: {this.pesoCarga}");

            return sb.ToString();
        }

    }
    
}
