using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Botellas;

namespace Entidades
{
    namespace Establecimiento
    {
        public class Bar
        {

            private List<Botella> botellas;
            private int capacidadMaximaBotella;
            private string nombre;
            private double recaudacion;
            
            public Bar()
            {
                this.botellas = new List<Botella>();
                this.capacidadMaximaBotella = 5;
                this.nombre = "Sin nombre";
            }

            public Bar(int capacidad):this()
            {

                this.capacidadMaximaBotella = capacidad;

            }

            public Bar(int capacidad, string nombre) : this(capacidad)
            {
                this.nombre = nombre;
            }

            public string MostrarBar
            {
                get { return this.Mostrar(); }
            }

            public List<Botella> Botellas
            {
                get { return this.botellas; }
            }

            private string Mostrar()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Nombre: {this.nombre}");
                sb.AppendLine($"Capacidad: {this.capacidadMaximaBotella}");
                sb.AppendLine($"Recaudacion: {this.recaudacion}\n");
                foreach (Botella unaBotellaDelBar in this.botellas)
                {
                    sb.AppendLine(unaBotellaDelBar.ToString());
                }

                return sb.ToString();
            }

            public void OrdenarBotellas(Ordenamiento orderElegido)
            {
                if(orderElegido == Ordenamiento.Ganancia)
                {
                    this.botellas.Sort(OrdenarPorGanancia);
                }

                if (orderElegido == Ordenamiento.Marca)
                {
                    this.botellas.Sort(ordenarPorMarca);

                }

                if (orderElegido == Ordenamiento.PorcentajeContenido)
                {
                    this.botellas.Sort(OrdenarPorContenido);

                }
            }

            public static int OrdenarPorContenido(Botella a, Botella b)
            {
                int retorno = 0;

                if (a.PorcentajeContenido > a.PorcentajeContenido)
                {
                    retorno = 1;
                }

                if (a.PorcentajeContenido < a.PorcentajeContenido)
                {
                    retorno = -1;
                }

                return retorno;
            }


            public int ordenarPorMarca(Botella a, Botella b)
            {
                return String.Compare((string)a, (string)b);
            }


            public int OrdenarPorGanancia(Botella a, Botella b)
            {
                int retorno = 0;

                if (a.Ganancia > a.Ganancia)
                {
                    retorno = 1;
                }

                if (a.Ganancia < a.Ganancia)
                {
                    retorno = -1;
                }

                return retorno;
            }

            public static explicit operator double(Bar b)
            {
                return b.recaudacion;
            }

            //Igualdad, retornará true, si es que la botella de agua o la botella de cerveza ya se encuentra en el bar,
            //false, caso contrario.Reutilizar código.
            public static bool operator ==(Bar b, Botella unaBote)
            {
                bool laBotellaEstaEnElBar = false;
                foreach (Botella unaBotellaDelBar in b.botellas)
                {
                    if(unaBotellaDelBar.Equals(unaBote))
                    {
                        laBotellaEstaEnElBar = true;
                        break;
                    }
                }

                return laBotellaEstaEnElBar;
            }

            public static bool operator !=(Bar b, Botella unaBote)
            {
                return !(b == unaBote);
            }

            public static Bar operator +(Bar b, Botella unaBote)
            {

                if(b.botellas.Count<b.capacidadMaximaBotella)
                {
                    if(b!=unaBote)
                    {
                        b.botellas.Add(unaBote);

                    }
                }
                return b;
            }

            public static Bar operator +(Bar b, double ganancia)
            {
                b.recaudacion += ganancia;
                return b;
            }

//            Sustracción, si la botella se encuentra en el bar, se consumirá una medida de esa botella de agua o
//botella de cerveza.Se acumulará la ganancia correspondiente en el bar y si el porcentaje de contenido
//es cero, se quitará la botella del bar. Reutilizar códig
            public static Bar operator -(Bar b, Botella unaBote)
            {
                if(b==unaBote)
                {
                    unaBote--;
                    b = b + unaBote.Ganancia;
                    if(unaBote.PorcentajeContenido==0)
                    {
                        b.botellas.Remove(unaBote);
                    }
                }

                return b;
            }
        }

    }
}
