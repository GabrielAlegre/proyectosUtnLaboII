using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcParcialPracticaLibreria
{
    public class Biografia : Publicacion
    {
        public override bool HayStock
        {
            get
            {
                bool hayStock = false;
                if (this.stock > 0)
                {
                    hayStock = true;
                }
                return hayStock;
            }
        }

        protected override bool EsColor
        {
            get { return false; }
        }

        public Biografia(string nombre) : base(nombre)
        {
        }

        public Biografia(string nombre, int stock) : base(nombre, stock)
        {
        }

        public Biografia(string nombre, int stock, float importe) : base(nombre, stock, importe)
        {
        }

        /*
        public Biografia(string nombre) : this(nombre,0)
        {
        }

        public Biografia(string nombre, int stock) : this(nombre, stock,0)
        {
        }

        public Biografia(string nombre, int stock, float importe) : base(nombre, stock, importe)
        {
        }
         */


        public static explicit operator Biografia(string nombre)
        {
            return new Biografia(nombre);
        }
    }
}
