using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcEjercicioEnClaseInterfaces
{
    public class Carreta : Vehiculo, IARBA
    {

        public Carreta(double precio):base(precio)
        {

        }
        public override void MostrarPrecio()
        {
            Console.WriteLine($"Precio carreta: {this.precio}");
        }

            
        double IARBA.CalcularImpuesto()
        {
            return this.precio * 0.18;
        }
            

    }
}
