using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcParcialPracticaJardin
{
    public class Banano:Planta
    {
        private string codigo;

        public Banano(string nombre, int tamanio, string codigo) : base(nombre, tamanio)
        {
            this.codigo = codigo;
        }

        public override bool TieneFrutos
        {
            get { return true; }
        }

        public override bool TieneFlores
        {
            get { return true; }
        }

        public override string ResumenDeDatos()
        {
            return $"{base.ResumenDeDatos()}Codigo internacional: {this.codigo}\n";
        }
    }
}
