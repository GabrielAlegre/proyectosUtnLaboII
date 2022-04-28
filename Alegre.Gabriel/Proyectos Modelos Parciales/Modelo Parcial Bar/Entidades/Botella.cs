using System;
using System.Text;

namespace Entidades
{
    namespace Botellas
    {
        public abstract class Botella
        {
            protected int capacidad;
            protected int contenido;
            protected string marca;
            protected double precio;

            public Botella(string marca, double precio, int capacidad)
            {
                this.capacidad = capacidad;
                this.contenido = capacidad;
                this.marca = marca;
                this.precio = precio;
            }

            public Botella(string marca, double precio):this(marca,precio,1000)
            {
            }

            public double PorcentajeContenido
            {
                //Una manera
                //get { return this.contenido * 100 / capacidad; }
                //Otra
                get 
                {
                    double retorno=(this.contenido / (double)this.capacidad) *100;
                    return  retorno ; 
                }
            }

            public abstract double Ganancia { get; }

            protected abstract void ServirMedida();

            public static string ObtenerDatos(Botella b)
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"Capacidad de la botella: {b.capacidad}");
                sb.AppendLine($"Contenido: {b.contenido}");
                sb.AppendLine($"Marca: {b.marca}");
                sb.AppendLine($"Precio: {b.precio}");
                sb.AppendLine($"Ganancia: {b.Ganancia}");

                return sb.ToString();
            }

            public override string ToString()
            {
                return Botella.ObtenerDatos(this);
            }

            public static explicit operator string(Botella b)
            {
                return b.marca;
            }

            public static bool operator == (Botella a, Botella b)
            {
                return (a.marca == b.marca) && (a.capacidad == b.capacidad);
            }

            public static bool operator !=(Botella a, Botella b)
            {
                return !(a==b);
            }

            public static Botella operator --(Botella a)
            {
                a.ServirMedida();

                return a;
            }
        }
    }

}
