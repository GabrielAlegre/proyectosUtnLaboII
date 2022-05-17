using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcExcepcionesLaCentralitaEP3
{
    public class CentralitaException:Exception
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

        public CentralitaException(string mensaje, string clase, string metodo):this(mensaje, clase, metodo, null)
        {
        }

        public CentralitaException(string mensaje, string clase, string metodo, Exception inner) : base(mensaje, inner)
        {
            this.nombreMetodo = metodo;
            this.nombreClase = clase;

        }
    }
}
