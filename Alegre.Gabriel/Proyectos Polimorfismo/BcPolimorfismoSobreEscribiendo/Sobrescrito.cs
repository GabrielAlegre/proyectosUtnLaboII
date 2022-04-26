using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcPolimorfismoSobreEscribiendo
{
    public abstract class Sobrescrito
    {
        protected string miAtributo;

        public Sobrescrito()
        {
            this.miAtributo = "Probar abstractos";
        }

        //Agregará propiedad abstracta MiPropiedad de sólo lectura.Una vez implementada, retornará el valor de miAtributo.
        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo();

        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }
        public override bool Equals(object obj)
        {
            return this==obj;
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }
    }

}
