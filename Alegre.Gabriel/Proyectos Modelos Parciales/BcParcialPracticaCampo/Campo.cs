using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcParcialPracticaCampo
{
    public class Campo
    {
        private int alimentosDisponible;
        private List<Animal> animales;
        private static Tipo servicio;

        static Campo()
        {
            servicio = Tipo.Engorde;
        }

        private Campo()
        {
            animales = new List<Animal>();
        }

        public Campo(int alimento):this()
        {
            this.alimentosDisponible = alimento;
        }

        public static Tipo TipoServicio
        {
            set
            {
                Campo.servicio = value;
            }
        }

        public static bool operator +(Campo c, Animal a)
        {
            bool seAgrego = false;
            if (c.alimentosDisponible >= c.AlimentoComprometido(a))
            {
                c.animales.Add(a);
                seAgrego = true;
            }

            return seAgrego;
        }
        public int AlimentoComprometido(Animal a)
        { 
            return AlimentoComprometido()+a.KilosAlimentos;
        }
        public int AlimentoComprometido()
        {
            int acumDeAlimento = 0;

            foreach (Animal unAnimalDelCampo in this.animales)
            {
                acumDeAlimento += unAnimalDelCampo.KilosAlimentos;
            }

            return acumDeAlimento;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Servicio del campo: {Campo.servicio}");
            sb.AppendLine($"Alimento comprometido {AlimentoComprometido()} de {alimentosDisponible}");
            foreach (Animal item in this.animales)
            {
                sb.AppendLine(item.Datos());
            }

            return sb.ToString();
        }
    }
}
