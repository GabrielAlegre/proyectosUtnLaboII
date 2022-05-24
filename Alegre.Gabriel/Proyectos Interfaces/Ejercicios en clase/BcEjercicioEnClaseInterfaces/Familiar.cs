using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcEjercicioEnClaseInterfaces
{
    public class Familiar:Auto
    {
        protected int cantAsientos;

        public Familiar(double precio, string patente, int cantidadDeAsientos) : base(precio, patente)
        {
            this.cantAsientos = cantidadDeAsientos;
        }
        public override void MostrarPatente()
        {
            Console.WriteLine($"Patente del auto familiar: {this.patente}");
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine($"Precio del auto familiar: {this.precio}");
        }
    }
}
