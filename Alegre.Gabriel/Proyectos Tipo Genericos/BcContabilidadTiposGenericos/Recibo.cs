using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcContabilidadTiposGenericos
{
    public class Recibo:Documento
    {
        public Recibo():this(0)
        {
          
        }
        public Recibo(int documento):base(documento)
        {

        }

        public override string ToString()
        {
            return $"Ingreso: {this.ValorDocumento}";
        }
    }
}
