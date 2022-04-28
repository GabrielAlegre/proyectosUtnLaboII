using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    namespace Botellas
    {
        public class Agua:Botella
        {
            public TipoAgua tipo;

            public override double Ganancia
            {
                get 
                {
                    return base.precio + (base.precio * 0.25); 
                }
            }

            public Agua(string marca, double precio, TipoAgua tipo): this(marca, precio, 500, tipo)
            {
            }

            public Agua(string marca, double precio, int capacidad, TipoAgua tipo) : base(marca, precio, capacidad)
            {
                this.tipo = tipo;
            }

            protected override void ServirMedida()
            {
                base.contenido = 0;
            }

            public override string ToString()
            {
                return $"Tipo de agua: {tipo}\n{base.ToString()}";
            }

            public override bool Equals(object obj)
            {
                bool retorno = false;
                if(obj is not null && obj is Agua)
                {
                    if(this == (Agua)obj)
                    {
                        retorno = true;
                    }
                }

                return retorno;
                //return obj is not null && obj is Agua && (this == (Agua)obj);
            }

            public static bool operator == (Agua a, Agua b)
            {
                return ((Botella)a) == b && (a.tipo == b.tipo);
            }

            public static bool operator !=(Agua a, Agua b)
            {
                return !(a == b);
            }
        }

    }
}
