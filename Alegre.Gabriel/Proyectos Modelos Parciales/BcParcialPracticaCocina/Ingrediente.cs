using System;
using System.Text;

namespace BcParcialPracticaCocina
{
    public abstract class Ingrediente
    {
        private int cantidad;
        private string descripcion;

        protected Ingrediente(int cantidad, string descripcion)
        {
            this.cantidad = cantidad;
            this.descripcion = descripcion;
        }

        public int Cantidad
        {
            get { return this.cantidad; }
        }

        public abstract string Proceso { get; }
        public abstract string UnidadDeMedida { get; }
        public virtual string Informacion()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.descripcion} en una cantidad de {this.Cantidad} {this.UnidadDeMedida} ");
            sb.AppendLine($"Procesar {this.Proceso}");

            return sb.ToString();

        }
    }
}
