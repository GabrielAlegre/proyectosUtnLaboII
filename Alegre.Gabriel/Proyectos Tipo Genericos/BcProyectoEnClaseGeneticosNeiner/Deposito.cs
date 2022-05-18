using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcProyectoEnClaseGeneticos
{
    public class Deposito<T>
    {
        int capacidadMaxima;
        List<T> lista;


        public Deposito(int capacidad)
        {
            this.capacidadMaxima = capacidad;
            lista = new List<T>();
        }

        public static bool operator +(Deposito<T> d, T a)
        {
            bool seAgrego = false;
            if (d.capacidadMaxima > d.lista.Count)
            {
                d.lista.Add(a);
                seAgrego = true;

            }
            return seAgrego;
        }

        private int GetIndice(T a)
        {
            for (int i = 0; i < this.lista.Count; i++)
            {
                if (lista[i].Equals(a))
                {
                    return i;
                }
            }

            return -1;
        }


        public static bool operator -(Deposito<T> d, T a)
        {
            bool seElimino = false;
            int indiceDeLaCocinaQueSeEliminara = d.GetIndice(a)!;
            if (indiceDeLaCocinaQueSeEliminara != -1)
            {
                d.lista.RemoveAt(indiceDeLaCocinaQueSeEliminara);
                seElimino = true;

            }
            return seElimino;
        }


        public bool Agregar(T a)
        {
            return this + a;
        }

        public bool Remover(T a)
        {
            return this - a;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"Capacidad maxima: {this.capacidadMaxima}");

            foreach (T algo in this.lista)
            {
                sb.AppendLine(algo.ToString());
            }

            return sb.ToString();

        }
    }
}
