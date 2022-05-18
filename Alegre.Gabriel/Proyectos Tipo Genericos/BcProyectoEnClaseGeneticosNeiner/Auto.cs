using System;

namespace BcProyectoEnClaseGeneticos
{
    public class Auto
    {
        private string color;
        private string marca;

        public Auto(string color, string marca)
        {
            this.color = color;
            this.marca = marca;
        }

        public string Color
        {
            get { return this.color; }
        }

        public string Marca
        {
            get { return this.marca; }
        }

        public static bool operator == (Auto a, Auto b)
        {
            return a.marca == b.marca && a.color == b.color;
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            return obj is not null && obj is Auto && this == (Auto)obj;
        }

        public override string ToString()
        {
            return $"Marca: {this.marca} - Color: {this.color}";
        }
    }
}
