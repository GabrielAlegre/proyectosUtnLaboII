using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcCentralitaEp6Archivos
{
    public interface IGuardar<T>
    {
        string RutaDeArchivo { get; }

        bool Guardar();
        T Leer();
    }
}
