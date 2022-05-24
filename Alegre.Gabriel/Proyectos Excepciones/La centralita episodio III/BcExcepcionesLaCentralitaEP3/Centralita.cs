using System;
using System.Collections.Generic;
using System.Text;

namespace BcExcepcionesLaCentralitaEP3
{
    public class Centralita
    {
        private List<Llamada> listaDeLLamadas;
        protected string razonSocial;

        #region "Constructores"
        private Centralita()
        {
            listaDeLLamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region "Propiedades"
        public List<Llamada> Llamadas
        {
            get { return listaDeLLamadas; }
        }
        public float GananciasPorLocal
        {
            get { return this.CalcularGanancias(TipoLlamada.Local); }
        }

        public float GananciasPorProvincial
        {
            get { return this.CalcularGanancias(TipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get { return this.CalcularGanancias(TipoLlamada.Todas); }
        }
        #endregion

        #region "Metodos"
        public void OrdenarLlamadas()
        {
            listaDeLLamadas.Sort(Llamada.ordenarPorDuracion);
        }

        private float CalcularGanancias(TipoLlamada tipo)
        {
            float recaudado = 0;

            foreach (Llamada unaLlamada in this.listaDeLLamadas)
            {
                if (tipo is TipoLlamada.Provincial && unaLlamada is Provincial)
                {
                    recaudado += unaLlamada.CostoLlamada;
                }
                else if (tipo is TipoLlamada.Local && unaLlamada is Local)
                {
                    recaudado += unaLlamada.CostoLlamada;
                }
                else if (tipo is TipoLlamada.Todas)
                {
                    recaudado += unaLlamada.CostoLlamada;
                }
            }
            return recaudado;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder("Detalles de la centralita\n");

            sb.AppendLine($"Razon social: {this.razonSocial}");
            sb.AppendLine($"Ganancias totales: {this.GananciasPorTotal}");
            sb.AppendLine($"Ganancias Provinciales: {this.GananciasPorProvincial}");
            sb.AppendLine($"Ganancias Locales: {this.GananciasPorLocal}");
            sb.AppendLine($"Detalles de las Llamadas:\n");
            foreach (Llamada llamada in listaDeLLamadas)
            {
                sb.AppendLine(llamada.ToString());
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return Mostrar();

        }


        //El método AgregarLlamada es privado.Recibe una instancia de Llamada y
        //la agrega a la lista de llamadas.
        private void AgregarLlamada(Llamada unaNuevaLlamada)
        {
            this.listaDeLLamadas.Add(unaNuevaLlamada);
        }

        #endregion

        #region "Sobrecargas"

        public static bool operator == (Centralita c1, Llamada l1)
        {
            bool laLlamadaEstaEnLaCentral = false;

            foreach (Llamada unaLlamadaDeLaCentral in c1.listaDeLLamadas)
            {
                if(unaLlamadaDeLaCentral.Equals(l1))
                {
                    laLlamadaEstaEnLaCentral = true;
                    break;
                }
            }

            return laLlamadaEstaEnLaCentral;
        }

        public static bool operator !=(Centralita c1, Llamada l1)
        {
            return !(c1 == l1);
        }


        //El operador + invocará al método AgregarLlamada sólo si la llamada no está 
        //registrada en la Centralita.Utilizar la sobrecarga del operador == de Centralita.

        public static Centralita operator +(Centralita c1, Llamada l1)
        {
            if(c1!=l1)
            {
                c1.AgregarLlamada(l1);
            }
            else
            {
                throw new CentralitaException("Excepcion, ya esta la llamada en la centralita",
                    "Excepcion ocurrida en la clase: Centralita",
                    "Excepcion ocurrida en el metodo: Sobrecarga del operador +");
            }
            return c1;
        }
        #endregion
    }
}
