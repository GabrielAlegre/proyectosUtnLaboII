using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcLaCentralitaEP7Serializacion
{
    public interface IGuardar<T>
    {
        string RutaDeArchivo { get; }

        bool Guardar(T contenido);
        T Leer();
    }
}
