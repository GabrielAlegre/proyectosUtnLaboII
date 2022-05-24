using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcEjercicioEnClaseInterfaces
{
    public class Comercial : Avion
    {
        private int capacidadPasajeros;

        public Comercial(double precio, double velocidad, int pasajeros):base(precio, velocidad)
        {
            this.capacidadPasajeros = pasajeros;
        }
    }
}
