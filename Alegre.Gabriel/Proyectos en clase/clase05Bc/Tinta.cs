using System;
using System.Text;

namespace clase05Bc
{
    public class Tinta
    {
        private ConsoleColor color;
        private ETipoTinta tipo;

        public Tinta()
        {
            color = ConsoleColor.Black;
            tipo = ETipoTinta.Comun;
        }

        public Tinta(ConsoleColor unColor):this()
        {
            this.color = unColor;
        }

        public Tinta(ConsoleColor color, ETipoTinta tipo):this(color)
        {
            this.tipo = tipo;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder("Informacion de la tinta");

            sb.AppendLine($"\nEl color de la tinta es: {this.color}");
            sb.AppendLine($"El tipo de la tinta es: {this.tipo}");

            return sb.ToString();
        }

        public static string Mostrar(Tinta unObjTinta)
        {
            return unObjTinta.Mostrar();
        }

        public static bool operator == (Tinta t1, Tinta t2)
        {
            bool sonIguales = false;

            if((t1.color==t2.color) && (t1.tipo==t2.tipo))
            {
                sonIguales = true;
            }

            return sonIguales;
        }

        public static bool operator !=(Tinta t1, Tinta t2)
        {
            return !(t1==t2);
        }

        public static explicit operator string(Tinta t1)
        {
            return t1.Mostrar();
        }
    }
}
