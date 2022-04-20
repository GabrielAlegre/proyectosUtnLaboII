using System;
using System.Text;

namespace clase07sobrecargaColeccionBc
{
    public class Tempera
    {
        ConsoleColor color;
        string marca;
        int cantidad;

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Color de la tempera: {this.color}");
            sb.AppendLine($"Marca de la tempera: {this.marca}");
            sb.AppendLine($"Cantidad de la tempera: {this.cantidad}");

            return sb.ToString();
        }
        public static string Mostrar(Tempera unaTempera)
        {
            return unaTempera.Mostrar();
        }

        public static bool operator ==(Tempera t1, Tempera t2)
        {
            bool sonIguales = false;

            if (t1 is not null && t2 is not null)
            {
                if ((t1.color == t2.color) && (t1.marca == t2.marca))
                {
                    sonIguales = true;
                }
            }

            return sonIguales;
        }

        public static bool operator !=(Tempera t1, Tempera t2)
        {
            return !(t1==t2);
        }

        public static implicit operator int(Tempera unaTempera)
        {
            return unaTempera.cantidad;
        }

        public static Tempera operator +(Tempera t1, Tempera t2)
        {
            if(t1==t2)
            {
                return new Tempera(t1.color, t1.marca, (t1.cantidad + t2.cantidad));
            }

            return t1;

        }
        //public static Tempera operator -(Tempera t1, Tempera t2)
        //{
        //    if (t1 == t2)
        //    {
        //        return new Tempera(t1.color, t1.marca, (t1.cantidad - t2.cantidad));
        //    }

        //    return t1;

        //}


        public static Tempera operator +(Tempera t1, int cantidadAgregada)
        {
            t1.cantidad += cantidadAgregada;
            return t1;
        }




    }
}
