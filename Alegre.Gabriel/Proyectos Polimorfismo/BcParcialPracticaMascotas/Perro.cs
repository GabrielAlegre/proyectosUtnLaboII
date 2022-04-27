using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcParcialPracticaMascotas
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        public Perro(string nombre, string raza) : base(nombre, raza)
        {
            this.edad = 0;
            this.esAlfa = false;
        }
        public Perro(string nombre, string raza, int edad, bool esAlfa) :this(nombre,raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }

        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder($"perro - {this.DatosCompletos()}, ");

            if(this.esAlfa)
            {
                sb.Append($"alfa de la manada, edad {this.edad}");
            }
            else
            {
                sb.Append($"edad {this.edad}");
            }

            return sb.ToString();
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            return ((Mascota)p1) == ((Mascota)p2) && p1.edad == p2.edad;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1==p2);
        }

        public override bool Equals(object obj)
        {
            
            return obj is not null && obj is Perro && (this == (Perro)obj);
        }
        public override string ToString()
        {
            return this.Ficha();
        }

    }
}
