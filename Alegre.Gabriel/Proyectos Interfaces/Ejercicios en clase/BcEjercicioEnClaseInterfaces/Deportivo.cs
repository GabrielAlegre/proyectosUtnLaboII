using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcEjercicioEnClaseInterfaces
{
    public class Deportivo : Auto, IAFIP, IARBA
    {
        protected int caballosFuerzas;

        public Deportivo(double precio, string patente, int caballosDeFuerza):base(precio, patente)
        {
            this.caballosFuerzas = caballosDeFuerza;
        }
        public override void MostrarPatente()
        {
            Console.WriteLine($"Patente del auto deportivo: {this.patente}"); 
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine($"Precio del auto deportivo: {this.precio}"); 
        }

        double IAFIP.CalcularImpuesto()
        {
            return this.precio * 0.28;
        }

        double IARBA.CalcularImpuesto()
        {
            return this.precio * 0.23;
        }
    }
}
