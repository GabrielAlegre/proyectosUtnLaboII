using System;

namespace Entidades.Primer.Parcial
{
    public class Fabricante
    {
        private string marca;
        private EPais pais;

        #region "Constructor"
        public Fabricante(string marca, EPais pais)
        {
            this.marca = marca;
            this.pais = pais;
        }
        #endregion

        #region "Sobrecargas de operadores"
        public static bool operator ==(Fabricante a, Fabricante b)
        {
            return a.marca == b.marca && a.pais == b.pais;
        }

        public static bool operator !=(Fabricante a, Fabricante b)
        {
            return !(a == b);
        }

        public static implicit operator String(Fabricante f)
        {
            return $"{f.marca} - {f.pais}";
        }
        #endregion
    }
}
