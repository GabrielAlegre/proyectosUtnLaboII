using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcSiempreQuiseTenerUnNotepadSerializador
{
    public class ArchivoIncorrectoException : Exception
    {
        public ArchivoIncorrectoException(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
        public ArchivoIncorrectoException(string mensaje) : this(mensaje, null)
        {
        }

    }
}
