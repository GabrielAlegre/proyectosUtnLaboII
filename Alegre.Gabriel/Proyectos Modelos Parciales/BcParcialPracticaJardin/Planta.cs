using System;
using System.Text;

namespace BcParcialPracticaJardin
{
    public abstract class Planta
    {
        private string nombre;
        private int tamanio;

        public Planta(string nombre, int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }

        public abstract bool TieneFlores { get; }
        public abstract bool TieneFrutos { get; }

        public int Tamanio
        {
            get { return this.tamanio; }
        }

        public virtual string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder($"{this.nombre} tiene una tamaño de {this.tamanio}\n");

            string tieneFlores = this.TieneFlores ? "Si" : "No";
            string tieneFrutos = this.TieneFrutos ? "Si" : "No";

            sb.AppendLine($"Tiene flores: {tieneFlores}");
            sb.AppendLine($"Tiene frutos: {tieneFrutos}");

            return sb.ToString();
        }
    }
}
