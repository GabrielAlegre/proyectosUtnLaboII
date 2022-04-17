using System;
using System.Text;

namespace BcLaEstanteria
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public string Marca
        {
            get { return this.marca; }
        }
        public float Precio
        {
            get { return this.precio; }
        }

        public static string MostrarProducto (Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {p.Marca}");
            sb.AppendLine($"Precio: {p.Precio}");
            sb.AppendLine($"Codigo de barra: {(string)p}");

            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto productoUno, Producto productoDos)
        {
            bool sonIguales = false;

            if ((productoUno.Marca == productoDos.Marca) && ((string)productoUno==(string)productoDos))
            {
                sonIguales = true;
            }

            return sonIguales;
        }

        public static bool operator ==(Producto p, string marca)
        {
            bool sonIguales = false;

            if (p.Marca == marca)
            {
                sonIguales = true;
            }

            return sonIguales;
        }

        public static bool operator !=(Producto p, string marca)
        {

            return !(p==marca);
        }

        public static bool operator !=(Producto productoUno, Producto productoDos)
        {
            return !(productoUno==productoDos);
        }




    }
}
