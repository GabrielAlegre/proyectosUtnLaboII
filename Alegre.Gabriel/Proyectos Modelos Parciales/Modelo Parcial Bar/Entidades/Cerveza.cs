using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    namespace Botellas
    {
        public class Cerveza : Botella
        {
            public int medida;
            public TipoCerveza tipo;


            public Cerveza(string marca, double precio,int capacidad, TipoCerveza tipo) : this(marca, precio, capacidad, tipo, (capacidad / 3))
            {
                
            }

            public Cerveza(string marca, double precio, int capacidad, TipoCerveza tipo, int medida) : base(marca, precio, capacidad)
            {
                this.tipo = tipo;
                this.medida = medida;
            }

            public override double Ganancia
            {
                get { return base.precio + (base.precio * 0.50); }
            }

            protected override void ServirMedida()
            {
                int auxContenido = base.contenido;
                auxContenido -= this.medida;

                if(auxContenido < medida)
                {
                    base.contenido = 0;
                }
                else
                {
                    base.contenido = auxContenido;
                }
            }
            public override string ToString()
            {
                return $"Tipo de Cerveza: {tipo}\nMedida: {this.medida}\n{base.ToString()}";
            }
            public override bool Equals(object obj)
            {
                bool retorno = false;
                if (obj is not null && obj is Cerveza)
                {
                    if (this == (Cerveza)obj)
                    {
                        retorno = true;
                    }
                }

                return retorno;
                //return obj is not null && obj is Agua && (this == (Agua)obj);
            }

            public static bool operator ==(Cerveza a, Cerveza b)
            {
                return ((Botella)a) == b && (a.tipo == b.tipo);
            }

            public static bool operator !=(Cerveza a, Cerveza b)
            {
                return !(a == b);
            }
        }

    }
}
