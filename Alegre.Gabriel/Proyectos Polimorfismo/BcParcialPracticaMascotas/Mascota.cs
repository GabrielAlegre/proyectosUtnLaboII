using System;
using System.Text;

namespace BcParcialPracticaMascotas
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;

        protected Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public string Raza
        {
            get { return this.raza; }
        }


        protected abstract string Ficha();

        protected virtual string DatosCompletos()
        {
            return $"{this.Nombre} - {this.raza}";
        }

        public static bool operator ==(Mascota m1, Mascota m2)
        {
            
            return (m1.raza == m2.raza) && (m1.nombre == m2.nombre) && m1.GetType() == m2.GetType();
        }

        public static bool operator !=(Mascota m1, Mascota m2)
        {
            return !(m1!=m2);
        }
    }
}
