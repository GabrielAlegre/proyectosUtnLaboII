using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcEjercicioClaseDeHerencia
{
    public class Trompeta : Instrumento
    {
        private string clave;

        public Trompeta(int codigo, string marca, EClasificacion clasi, string clave) : base(codigo, marca, clasi)
        {
            this.clave = clave;
        }

        public string MostrarTrompeta()
        {
            StringBuilder sb = new StringBuilder("Instrumento: Trompeta\n");

            sb.Append(base.Mostrar());
            sb.AppendLine($"Clave: {this.clave}");

            return sb.ToString();
        }
    }
}
