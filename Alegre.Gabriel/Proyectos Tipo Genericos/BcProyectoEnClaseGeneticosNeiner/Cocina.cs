using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcProyectoEnClaseGeneticos
{
    public class Cocina
    {
        private int codigo;
        private bool esIndustrial;
        private double precio;
        public Cocina(int codigo, double precio, bool industrial)
        {
            this.codigo = codigo;
            this.precio = precio;
            this.esIndustrial = industrial;
        }

        public int Codigo
        {
            get { return this.codigo; }
        }

        public bool EsIndustrial
        {
            get { return this.esIndustrial; }
        }

        public double Precio
        {
            get { return this.precio; }
        }

        public static bool operator ==(Cocina a, Cocina b)
        {
            return a.codigo == b.codigo && a.esIndustrial == b.esIndustrial;
        }

        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            return obj is not null && obj is Cocina && this == (Cocina)obj;
        }

        public override string ToString()
        {
            string esIndustrial = this.esIndustrial ? "Si" : "No";
            return $"Codigo: {this.codigo} - Precio: {this.precio} - Es industrial?: {esIndustrial}";
        }
    }
}
