using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcHerenciaLaCentralitaEP1
{
    public class Centralita
    {
        private List<Llamada> listaDeLLamadas;
        protected string razonSocial;

        private Centralita()
        {
            listaDeLLamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public List<Llamada> Llamadas
        {
            get { return listaDeLLamadas; }
        }
        public float GananciasPorLocal
        {
            get { return this.CalcularGanancias(Llamada.TipoLlamada.Local); }
        }

        public float GananciasPorProvincial
        {
            get { return this.CalcularGanancias(Llamada.TipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get { return this.CalcularGanancias(Llamada.TipoLlamada.Todas); }
        }
        public void OrdenarLlamadas()
        {
            listaDeLLamadas.Sort(Llamada.ordenarPorDuracion);
        }
        private float CalcularGanancias(Llamada.TipoLlamada tipo)
        {
            float recaudado=0;

            foreach (Llamada unaLlamada in this.listaDeLLamadas)
            {
                if(tipo is Llamada.TipoLlamada.Provincial && unaLlamada is Provincial)
                {
                    recaudado += ((Provincial)unaLlamada).CostoLlamada;
                }
                else if (tipo is Llamada.TipoLlamada.Local && unaLlamada is Local)
                {
                    recaudado += ((Local)unaLlamada).CostoLlamada;
                }
                else if(tipo is Llamada.TipoLlamada.Todas)
                {
                    switch (unaLlamada)
                    {
                        case Local:
                            recaudado += ((Local)unaLlamada).CostoLlamada;
                            break;

                        case Provincial:
                            recaudado += ((Provincial)unaLlamada).CostoLlamada;
                            break;

                    }
                }

            }
            return recaudado;

        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder("Detalles de la centralita\n");

            sb.AppendLine($"Razon social: {this.razonSocial}");
            sb.AppendLine($"Ganancias totales: {this.GananciasPorTotal}");
            sb.AppendLine($"Ganancias Provinciales: {this.GananciasPorProvincial}");
            sb.AppendLine($"Ganancias Locales: {this.GananciasPorLocal}");
            sb.AppendLine($"Detalles de las Llamadas:\n");
            foreach (Llamada llamada in listaDeLLamadas)
            {
                switch(llamada)
                {
                    case Local:
                        sb.AppendLine(((Local)llamada).Mostrar());
                        break;

                    case Provincial:
                        sb.AppendLine(((Provincial)llamada).Mostrar());
                        break;

                    default:
                        sb.AppendLine(llamada.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
    }
}
