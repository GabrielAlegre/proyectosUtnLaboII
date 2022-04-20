using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcElViajarEsUnPlacerI01
{
    public class VehiculoTerrestre
    {
        private short cantidadDeRuedad;
        private short cantidadDePuertas;
        private Colores color;

        public VehiculoTerrestre(short cantidadDeRuedad, short cantidadDePuertas, Colores color)
        {
            this.cantidadDeRuedad = cantidadDeRuedad;
            this.cantidadDePuertas = cantidadDePuertas;
            this.color = color;
        }

        public enum Colores
        {
            Rojo,
            Blanco,
            Azul,
            Gris,
            Negro
        }

        public short CantidadDeRuedas
        {
            get { return this.cantidadDeRuedad; }
        }

        public short CantidadDePuertas
        {
            get { return this.cantidadDePuertas; }
        }

        public Colores Color
        {
            get { return color; }
        }


        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de ruedas: {this.cantidadDeRuedad}");
            sb.AppendLine($"Cantidad de puertas: {this.cantidadDePuertas}");
            sb.AppendLine($"Color: {color}");


            return sb.ToString();
        }
    }
}
