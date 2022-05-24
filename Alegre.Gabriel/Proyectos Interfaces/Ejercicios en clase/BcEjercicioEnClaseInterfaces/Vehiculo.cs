using System;

namespace BcEjercicioEnClaseInterfaces
{
    public abstract class Vehiculo
    {
        protected double precio;

        public abstract void MostrarPrecio();

        public Vehiculo(double precio)
        {
            this.precio = precio;
        }
    }
}
