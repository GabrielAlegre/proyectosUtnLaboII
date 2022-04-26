using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcPolimorfismoSobreEscribiendo
{
    public class SobreSobrescrito : Sobrescrito
    {
        public SobreSobrescrito():base()
        {
        }

        public override string MiPropiedad
        {
            get { return base.miAtributo; }
        }
        public override string MiMetodo()
        {
            return MiPropiedad;
        }
    }
}
