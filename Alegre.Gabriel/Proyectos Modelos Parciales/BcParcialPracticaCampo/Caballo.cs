using System;
using System.Text;

namespace BcParcialPracticaCampo
{
    public class Caballo:Animal
    {
        private bool corredor;

        public Caballo(string nombre, int kilosAlimento, bool corredor) : base(nombre, kilosAlimento)
        {
            this.corredor = corredor;
        }


        public override bool ComeBalanceado
        {
            get
            {
                return false;
            }
        }

        public override bool ComePasto
        {
            get
            {
                return true;
            }
        }

        public override string Datos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Datos());
            if(this.corredor)
            {

                sb.AppendLine($"Es de carreras: Si");
            }
            else
            {
                sb.AppendLine($"Es de carreras: No");

            }
            return sb.ToString();
        }
    }
}
