using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcCartucheraInterfaces
{
    public interface IAcciones
    {
        public ConsoleColor color { get; set; }

        public float UnidadesDeEscritura { get; set; }

        public EscrituraWrapper Escribir(string texto);

        bool Recargar(int unidades);
    }
}
