using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcEjercicioEnClaseInterfaces
{
    public class Privado:Avion
    {
        protected int valoracionServicioDeAbordo;

        public Privado(double precio, double velocidad, int valoracion):base(precio, velocidad)
        {
            this.valoracionServicioDeAbordo = valoracion;
        }
    }
}
