using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcEjercicioClaseDeHerencia
{
    public class Bateria : Instrumento
    {
        private int cuerpos;

        public Bateria(int codigo, string marca, EClasificacion clasi, int cuerpo) : base(codigo, marca, clasi)
        {
            this.cuerpos = cuerpo;
        } 

        public string MostrarBateria()
        {
            StringBuilder sb = new StringBuilder("Instrumento: Bateria\n");

            sb.Append(base.Mostrar());
            sb.AppendLine($"Cuerpos: {cuerpos}");

            return sb.ToString();
        }
    }
}
