using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcProyectoEnClaseGeneticos
{
    public class DepositoDeCocinas
    {
        int capacidadMaxima;
        List<Cocina> listaDeCocina;


        public DepositoDeCocinas(int capacidad)
        {
            this.capacidadMaxima = capacidad;
            listaDeCocina = new List<Cocina>();
        }

        public static bool operator +(DepositoDeCocinas d, Cocina a)
        {
            bool seAgrego = false;
            if (d.capacidadMaxima > d.listaDeCocina.Count)
            {
                d.listaDeCocina.Add(a);
                seAgrego = true;

            }
            return seAgrego;
        }

        private int GetIndice(Cocina a)
        {
            for (int i = 0; i < this.listaDeCocina.Count; i++)
            {
                if (listaDeCocina[i].Equals(a))
                {
                    return i;
                }
            }

            return -1;
        }


        public static bool operator -(DepositoDeCocinas d, Cocina a)
        {
            bool seElimino = false;
            int indiceDeLaCocinaQueSeEliminara = d.GetIndice(a)!;
            if (indiceDeLaCocinaQueSeEliminara != -1)
            {
                d.listaDeCocina.RemoveAt(indiceDeLaCocinaQueSeEliminara);
                seElimino = true;

            }
            return seElimino;
        }


        public bool Agregar(Cocina a)
        {
            return this + a;
        }

        public bool Remover(Cocina a)
        {
            return this - a;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Capacidad maxima: {this.capacidadMaxima}\nListado de Cocinas:");
            foreach (Cocina unaCocinaDelDeposito in this.listaDeCocina)
            {
                sb.AppendLine(unaCocinaDelDeposito.ToString());
            }

            return sb.ToString();

        }
    }
}
