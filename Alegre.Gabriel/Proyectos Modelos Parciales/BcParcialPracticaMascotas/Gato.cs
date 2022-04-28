using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcParcialPracticaMascotas
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string edad):base(nombre, edad)
        {

        }

        protected override string Ficha()
        {
            return $"gato - {base.DatosCompletos()}";
        }
        public override bool Equals(object obj)
        {
            return obj is not null && obj is Gato && (this == (Gato)obj);
        }
        public override string ToString()
        {
            return this.Ficha();
        }


        public static bool operator ==(Gato g1, Gato g2)
        {
            return ((Mascota)g1) == ((Mascota)g2);
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }
    }
}
