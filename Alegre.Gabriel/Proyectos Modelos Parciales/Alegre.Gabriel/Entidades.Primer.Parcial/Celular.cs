using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Primer.Parcial
{
    public class Celular:Producto
    {
        public EGama gama;

        #region "Constructor"
        public Celular(string modelo, Fabricante fabricante, EGama gama)
            :base(modelo, fabricante)
        {
            this.gama = gama;
        }
        #endregion

        #region "Metodos"
        public override string ToString()
        {
            return $"{(string)this}GAMA: {this.gama}\n";
        }

        public override bool Equals(object obj)
        {
            return obj is not null && obj is Celular && this == (Celular)obj;
        }
        #endregion

        #region "Sobrecargas de operadores"

        public static bool operator ==(Celular a, Celular b)
        {
            return a == (Producto)b && a.gama == b.gama;
        }
        public static bool operator !=(Celular a, Celular b)
        {
            return !(a == b);
        }

        public static implicit operator double(Celular celu)
        {
            return celu.Precio;
        }
        #endregion

    }
}
