using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcParcialPracticaCampo
{
    public abstract class Animal
    {
        private string nombre;
        private int kilosAlimento;

        protected Animal(string nombre, int kilosAlimento)
        {
            this.nombre = nombre;
            this.kilosAlimento = kilosAlimento;
        }

        public abstract bool ComeBalanceado { get; }
        public abstract bool ComePasto { get; }
        public int KilosAlimentos
        {
            get
            {
                return this.kilosAlimento;
            }
        }

        public virtual string Datos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.nombre} come {this.kilosAlimento}kg");
            if(this.ComeBalanceado)
            {
                sb.AppendLine($"Consume balanceado: Si");
            }
            else
            {
                sb.AppendLine($"Consume balanceado No");

            }

            if (this.ComePasto)
            {
                sb.AppendLine($"Consume balanceado: Si");
            }
            else
            {
                sb.AppendLine($"Consume balanceado No");

            }

            return sb.ToString();
        }
    }

}
