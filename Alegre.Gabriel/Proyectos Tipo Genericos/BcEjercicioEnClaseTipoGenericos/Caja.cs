using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcEjercicioEnClaseTipoGenericos
{
    public static class Caja<T> where T: Juguete
    {
        public static List<T> lista;

        static Caja()
        {
            lista = new List<T>();
        }

        public static List<T> Agregar <G>(G param) where G:T
        {
            Caja<T>.lista.Add(param);
            return Caja<T>.lista;
        }

        public static string Mostrar<X>() where X : T
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in Caja<T>.lista)
            {
                sb.AppendLine($"///////////////////////////////\n{item.ToString()}\n//////////////////////////////\n");
            }

            return sb.ToString();
        }

    }
}
