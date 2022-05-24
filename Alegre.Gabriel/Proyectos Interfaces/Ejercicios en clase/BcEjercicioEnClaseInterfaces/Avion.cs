using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcEjercicioEnClaseInterfaces
{
    public class Avion : Vehiculo, IAFIP, IARBA
    {
        protected double velocidadMaxima;
        public Avion(double precio, double velMax):base(precio)
        {
            this.velocidadMaxima = velMax;
        }
        public override void MostrarPrecio()
        {
            Console.WriteLine($"Precio del avion: {this.precio}");
        }

        double IAFIP.CalcularImpuesto()
        {
            return this.precio * 0.33;
        }

        double IARBA.CalcularImpuesto()
        {
            if(this is Comercial)
            {
                return this.precio * 0.25;
            }
            else
            {
                return this.precio * 0.27;
            }
        }
    }
}
