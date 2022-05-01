using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcParcialPracticaLibreria
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;

        public Vendedor()
        {
            this.ventas = new List<Publicacion>();
        }

        public Vendedor(string nombre):this()
        {
            this.nombre = nombre;
        }

        public static bool operator +(Vendedor vendedor, Publicacion publicacion)
        {
            bool seAgrego = false;
            if(publicacion.HayStock)
            {
                vendedor.ventas.Add(publicacion);
                publicacion.Stock = publicacion.Stock - 1;
                seAgrego = true;
            }

            return seAgrego;
        }

        public static string ObtenerInformacionDeVentas(Vendedor vendedor)
        {
            float acumuladorDeGanancia = 0;
            StringBuilder sb = new StringBuilder($"Nombre: {vendedor.nombre}\n");

            sb.AppendLine("---------------------------------------------------------------");
            foreach (Publicacion unaPubli in vendedor.ventas)
            {
                sb.AppendLine(unaPubli.ObtenerInformacion());
                acumuladorDeGanancia += unaPubli.Importe;
            }
            sb.AppendLine($"Ganancia total: "+ acumuladorDeGanancia);

            return sb.ToString();
        }

    }
}
