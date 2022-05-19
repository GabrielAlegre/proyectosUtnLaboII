using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcCompetenciaGenerica
{
    public class CompetenciaNoDisponibleException:Exception
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

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo) : this(mensaje, clase, metodo, null)
        {
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception inner) : base(mensaje, inner)
        {
            this.nombreMetodo = metodo;
            this.nombreClase = clase;
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder($"Excepción en el método: ({this.NombreMetodo}) de la clase: ({this.NombreClase})\n{this.Message}\n");
            CompetenciaNoDisponibleException e = this;
            while (e.InnerException != null)
            {
                e = (CompetenciaNoDisponibleException)e.InnerException;
                sb.AppendLine($"Excepción en el método: ({e.NombreMetodo}) de la clase: ({ e.NombreClase})\n{ e.Message}\n");
            }

            return sb.ToString();

        }
    }
}
