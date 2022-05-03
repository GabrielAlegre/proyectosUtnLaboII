using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcParcialPracticaCocina
{
    public class Receta
    {
        private int capacidadDelContenedor;
        private List<Ingrediente> ingredientes;
        private static Tipo preparacion;

        static Receta()
        {
            preparacion = Tipo.Clasica;
        }
        private Receta()
        {
            ingredientes = new List<Ingrediente>();
        }

        public Receta(int capacidad):this()
        {
            this.capacidadDelContenedor = capacidad;
        }

        public static Tipo TipoDePreparacion
        {
            set
            {
                Receta.preparacion = value;
            }
        }

        private int CapacidadLibre()
        {
            int acumDeCantidad = 0;

            foreach (Ingrediente unIngredienteDeLaReceta in this.ingredientes)
            {
                acumDeCantidad += unIngredienteDeLaReceta.Cantidad;
            }

            return capacidadDelContenedor-acumDeCantidad;
        }

        private int CapacidadLibre(Ingrediente unIngrediente)
        {
            return CapacidadLibre()-unIngrediente.Cantidad;
        }

        public static bool operator +(Receta r, Ingrediente i)
        {
            bool seAgrego = false;
            if(r.CapacidadLibre(i)>=0)
            {
                r.ingredientes.Add(i);
                seAgrego = true;
            }

            return seAgrego;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Receta: {Receta.preparacion}");
            sb.AppendLine($"Capacidad libre: {this.CapacidadLibre()} de {this.capacidadDelContenedor}");
            sb.AppendLine($"Capacidad total: {this.capacidadDelContenedor}");
            sb.AppendLine("Lista de ingredientes:");

            foreach (Ingrediente unIngredienteDeLaReceta in this.ingredientes)
            {
                sb.AppendLine(unIngredienteDeLaReceta.Informacion());

            }

            return sb.ToString();
        }
    }
}
