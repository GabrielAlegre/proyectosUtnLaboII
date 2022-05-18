using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcProyectoEnClaseGeneticos
{
    public class DepositoDeAutos
    {
        int capacidadMaxima;
        List<Auto> listaDeAutos;


        public DepositoDeAutos(int capacidad)
        {
            this.capacidadMaxima = capacidad;
            listaDeAutos = new List<Auto>();
        }

        public static bool operator + (DepositoDeAutos d, Auto a)
        {
            bool seAgrego = false;
            if(d.capacidadMaxima>d.listaDeAutos.Count)
            {
                d.listaDeAutos.Add(a);
                seAgrego = true;

            }
            return seAgrego;
        }

        private int GetIndice(Auto a)
        {
            for (int i = 0; i < this.listaDeAutos.Count; i++)
            {
                if(listaDeAutos[i].Equals(a))
                {
                    return i;
                }
            }
            return -1;
        }


        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool seElimino = false;
            int indiceDelAutoQueSeEliminara = d.GetIndice(a)!;
            if (indiceDelAutoQueSeEliminara != -1)
            {
                d.listaDeAutos.RemoveAt(indiceDelAutoQueSeEliminara);
                seElimino = true;

            }
            return seElimino;
        }


        public bool Agregar(Auto a)
        {
            return this + a;
        }

        public bool Remover(Auto a)
        {
            return this - a;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Capacidad del deposito de autos: {this.capacidadMaxima}\nListado de autos:");
            foreach (Auto unAutoDelDeposito in this.listaDeAutos)
            {
                sb.AppendLine(unAutoDelDeposito.ToString());
            }

            return sb.ToString();

        }

    }
}
