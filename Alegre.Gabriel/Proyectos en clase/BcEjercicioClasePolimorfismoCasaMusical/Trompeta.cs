using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcEjercicioClasePolimorfismoCasaMusical
{
    public class Trompeta : Instrumento
    {
        private string clave;

        public Trompeta(int codigo, string marca, EClasificacion clasi, string clave) : base(codigo, marca, clasi)
        {
            this.clave = clave;
        }

        protected override string PrecioProducto()
        {
            return "El precio de la trompeta es: 700";
        }

        public override string Precio
        {
            get { return PrecioProducto(); }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder("Instrumento: Trompeta\n");

            sb.Append(base.Mostrar());
            sb.AppendLine($"Clave: {this.clave}");
            sb.AppendLine(this.Precio);

            return sb.ToString();
        }
    }
}
