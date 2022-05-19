using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcContabilidadTiposGenericos
{
    public class Contabilidad<T,U> where T:Documento where U:Documento, new ()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            egresos = new List<T>();
            ingresos = new List<U>();
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, T egreso)
        {
            c.egresos.Add(egreso);
            return c;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            c.ingresos.Add(ingreso);
            return c;
        }

        public string MostrarContabilidad()
        {
            StringBuilder sb = new StringBuilder();

            if(this.egresos.Count>0)
            {
                sb.AppendLine("Listado de egresos:");
                foreach (T unEgreso in this.egresos)
                {
                    sb.AppendLine($"{unEgreso.ToString()}");
                }
            }
            else
            {
                sb.AppendLine("No hubo ningun egreso");
            }

            if (this.ingresos.Count > 0)
            {
                sb.AppendLine("Listado de ingresos:");
                foreach (U unIngreseso in this.ingresos)
                {
                    sb.AppendLine($"{unIngreseso.ToString()}");
                }
            }
            else
            {
                sb.AppendLine("No hubo ningun ingreso");
            }

            return sb.ToString();
        }
    }
}
