using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcEjercicioClasePolimorfismoCasaMusical
{
    public class Guitarra : Instrumento
    {
        private int cantidadDeCuerdas;

        public Guitarra(int cantidadDeCuerdas, string marca, int codigo, EClasificacion clasificacion, ETipoGuitarra tipoGuitarra)
            : base(codigo, marca, clasificacion)
        {
            this.cantidadDeCuerdas = cantidadDeCuerdas;
            this.TipoGuitarra = tipoGuitarra;
        }

        public Guitarra(ETipoGuitarra tipoGuitarra, EClasificacion clasificacion, int codigo, string marca, int cantidadDeCuerdas)
            : this(cantidadDeCuerdas, marca, codigo, clasificacion, tipoGuitarra)
        {
        }



        public enum ETipoGuitarra
        {
            Criolla,
            Electroacústica,
            Eléctrica
        }

        public ETipoGuitarra TipoGuitarra { get; set; }

        protected override string PrecioProducto()
        {
            return "El precio de la guitarra es: 1300";
        }

        public override string Precio
        {
            get { return PrecioProducto(); }
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder("Instrumento: Guitarra\n");

            sb.Append(base.Mostrar());
            sb.AppendLine($"Cantidad de cuerdas: {this.cantidadDeCuerdas}");
            sb.AppendLine($"Tipo de guitarra: {this.TipoGuitarra}");
            sb.AppendLine(this.Precio);

            return sb.ToString();
        }

    }
}
