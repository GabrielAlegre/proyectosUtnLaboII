using System;

namespace BcContabilidadTiposGenericos
{
    public class Documento
    {
        private int documento;

        public Documento(int docu)
        {
            this.documento = docu;
        }

        public int ValorDocumento
        {
            get { return this.documento; }
        }
    }
}
