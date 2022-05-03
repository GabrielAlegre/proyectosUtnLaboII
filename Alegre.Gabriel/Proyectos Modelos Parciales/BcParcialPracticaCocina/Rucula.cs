using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcParcialPracticaCocina
{
    public class Rucula:Ingrediente
    {

        public Rucula(string descripcion, int cantidad) : base(cantidad, descripcion)
        {
        }


        public override string UnidadDeMedida
        {
            get { return "Hojas"; }
        }
        public override string Proceso
        {
            get { return "Cortar"; }
        }
    }
}
