using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcParcialPracticaCocina
{
    public class QuesoAzul:Ingrediente
    {
        private Procedencia procedencia;

        public QuesoAzul(string descripcion, int cantidad) : base(cantidad, descripcion)
        {
        }

        public QuesoAzul(string descripcion, int cantidad, Procedencia procedencia) : this(descripcion, cantidad)
        {
            this.procedencia = procedencia;
        }


        public override string UnidadDeMedida
        {
            get { return "Gramos"; }
        }
        public override string Proceso
        {
            get { return "Desgranar"; }
        }
        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Informacion());
            sb.AppendLine($"Procedente: {this.procedencia}");

            return sb.ToString();
        }
    }
}
