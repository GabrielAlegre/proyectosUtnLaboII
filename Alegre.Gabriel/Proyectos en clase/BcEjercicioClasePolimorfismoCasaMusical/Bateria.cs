using System;
using System.Text;

namespace BcEjercicioClasePolimorfismoCasaMusical
{
    public class Bateria : Instrumento
    {
        private int cuerpos;

        public Bateria(int codigo, string marca, EClasificacion clasi, int cuerpo) : base(codigo, marca, clasi)
        {
            this.cuerpos = cuerpo;
        }

        protected override string PrecioProducto()
        {
            return "El precio de la bateria es: 3569";
        }

        public override string Precio
        {
            get { return PrecioProducto(); }
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder("Instrumento: Bateria\n");

            sb.Append(base.Mostrar());
            sb.AppendLine($"Cuerpos: {cuerpos}");
            sb.AppendLine(this.Precio);

            return sb.ToString();
        }
    }
}
