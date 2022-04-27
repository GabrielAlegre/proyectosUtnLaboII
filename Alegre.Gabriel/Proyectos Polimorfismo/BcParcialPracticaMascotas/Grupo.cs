using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcParcialPracticaMascotas
{
    public class Grupo
    {
        private List<Mascota> manada;
        private string nombre;
        private static ETipoManada tipo;

        static Grupo()
        {
            Grupo.tipo = ETipoManada.Unica;
        }

        private Grupo()
        {
            manada = new List<Mascota>();
        }

        public Grupo(string nombre) :this()
        {
            this.nombre = nombre;
        }

        public Grupo (string nombre, ETipoManada tipo):this(nombre)
        {
            Grupo.tipo = tipo;
        }


        public ETipoManada Tipo
        {
            set { Grupo.tipo = value; }
        }

        public static implicit operator string (Grupo g)
        {
            StringBuilder sb = new StringBuilder($"Grupo: {g.nombre} - Tipo {Grupo.tipo}\nIntegrantes({g.manada.Count}):\n");
            foreach (Mascota item in g.manada)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public static bool operator == (Grupo g, Mascota m)
        {
            bool mascotaEstaEnElgrupo = false;

            foreach (Mascota item in g.manada)
            {
                if(item==m)
                {
                    mascotaEstaEnElgrupo = true;
                    break;
                }
            }

            return mascotaEstaEnElgrupo;
        }
        public static bool operator != (Grupo g, Mascota m)
        {
            return !(g == m);
        }
        public static Grupo operator + (Grupo g, Mascota m)
        {
            if(g!=m)
            {
                g.manada.Add(m);
            }
            else
            {
                Console.WriteLine($"Ya esta '{m.ToString()}' en el grupo");
            }

            return g;
        }
        public static Grupo operator - (Grupo g, Mascota m)
        {
            if (g == m)
            {
                g.manada.Remove(m);
            }
            else
            {
                Console.WriteLine($"No esta {m.ToString()} en el grupo");
            }

            return g;
        }

    }
}
