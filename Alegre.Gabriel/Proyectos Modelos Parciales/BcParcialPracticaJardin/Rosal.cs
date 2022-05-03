using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcParcialPracticaJardin
{
    public class Rosal : Planta
    {

        private Color colorFlor;
        public Rosal(string nombre, int tamanio) : base(nombre, tamanio)
        {
        }

        public Rosal(string nombre, int tamanio, Color colorFlorcita) : this(nombre, tamanio)
        {
            this.colorFlor = colorFlorcita;
        }

        public override bool TieneFrutos
        {
            get { return false; }
        }

        public override bool TieneFlores
        {
            get { return true; }
        }

        public override string ResumenDeDatos()
        {
            return $"{base.ResumenDeDatos()} Flores de color: {this.colorFlor}\n";
        }
    }
}
