using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Primer.Parcial
{
    public class Televisor:Producto
    {
        public ETipo tipo;

        #region "Constructor"
        public Televisor(string modelo, string marca, EPais pais, ETipo tipo)
            : base(modelo, new Fabricante(marca, pais))
        {
            this.tipo = tipo;
        }
        #endregion

        #region "Metodos"
        public override string ToString()
        {
            return $"{(string)this}TIPO: {this.tipo}\n";
        }

        public override bool Equals(object obj)
        {
            return obj is not null && obj is Televisor && this == (Televisor)obj;
        }
        #endregion

        #region "Sobrecargas de operadores"

        public static bool operator ==(Televisor a, Televisor b)
        {
            return a == (Producto)b && a.tipo == b.tipo;
        }

        public static bool operator !=(Televisor a, Televisor b)
        {
            return !(a == b);
        }

        public static explicit operator double(Televisor tv)
        {
            return tv.Precio;
        }

        #endregion
    }
}
