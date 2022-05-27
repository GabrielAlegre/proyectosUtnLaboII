using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcCentralitaEp6Archivos
{
    class FallaLogException : Exception
    {
        string nombreClase;
        string nombreMetodo;

        public string NombreMetodo
        {
            get { return nombreMetodo; }
        }

        public string NombreClase
        {
            get { return nombreClase; }
        }

        public FallaLogException(string mensaje, string clase, string metodo) : this(mensaje, clase, metodo, null)
        {
        }

        public FallaLogException(string mensaje, string clase, string metodo, Exception inner) : base(mensaje, inner)
        {
            this.nombreMetodo = metodo;
            this.nombreClase = clase;

        }
    }
}
