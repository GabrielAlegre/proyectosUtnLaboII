using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcParcialPracticaJardin
{
    public class Jardin
    {
        private List<Planta> plantas;
        private int espacioTotal;
        private static Tipo suelo;

        static Jardin()
        {
            suelo = Tipo.Terrozo;
        }

        private Jardin()
        {
            plantas = new List<Planta>();
        }


        public Jardin(int espacioTotal) : this()
        {
            this.espacioTotal = espacioTotal;
        }

        public Tipo Suelo
        {
            set
            {
                Jardin.suelo = value;
            }
        }

        public static bool operator +(Jardin j, Planta p)
        {
            bool seAgrego = false;
            if(j.espacioTotal>=j.EspacioOcupado(p))
            {
                j.plantas.Add(p);
                seAgrego = true;
            }

            return seAgrego;
        }

        private int EspacioOcupado(Planta p)
        {
            return EspacioOcupado()+p.Tamanio;
        }
        private int EspacioOcupado()
        {
            int acumDeEspacio = 0;

            foreach (Planta plantaDelJardin in this.plantas)
            {
                acumDeEspacio += plantaDelJardin.Tamanio;
            }

            return acumDeEspacio;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Composicion del Jardín: {Jardin.suelo}");
            sb.AppendLine($"Espacio ocupado: {this.EspacioOcupado()} de {this.espacioTotal}");
            sb.AppendLine("Lista de plantas:");
            foreach (Planta planta in this.plantas)
            {
                sb.AppendLine(planta.ResumenDeDatos());
            }

            return sb.ToString();
        }
    }
}
