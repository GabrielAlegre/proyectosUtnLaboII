using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcLaEstanteria
{
    public class Estante
    {
        Producto[] arrayDeProductos;
        int ubicacionEstante;

        public Estante(int capacidad, int ubicacionEstante) : this(capacidad)
        {
            this.ubicacionEstante = ubicacionEstante;
        }

        private Estante (int capacidad)
        {
            arrayDeProductos = new Producto [capacidad];
        }

        public Producto[] GetArrayProductos
        {
            get { return this.arrayDeProductos; }
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Ubicacion: {e.ubicacionEstante}");
            foreach (Producto unProductoDelArray in e.GetArrayProductos)
            {
                sb.AppendLine(Producto.MostrarProducto(unProductoDelArray));
            }

            return sb.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool estaEnElEstante = false;

            foreach (Producto unProductoDelEstante in e.GetArrayProductos)
            {
                if (unProductoDelEstante is not null)
                {
                    if (unProductoDelEstante == p)
                    {
                        estaEnElEstante = true;
                        break;
                    }
                }
            }

            return estaEnElEstante;
        }


        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool seAgrego = false;

            if (e != p)
            {
                for (int i = 0; i < e.arrayDeProductos.Length; i++)
                {
                    if(e.GetArrayProductos[i] is null)
                    {
                        e.GetArrayProductos[i] = p;
                        seAgrego = true;
                        break;
                    }
                }
            }

       

            return seAgrego;
        }

        public static bool operator -(Estante e, Producto p)
        {
            bool seQuito = false;
      
            if (e==p)
            {
                
                for (int i = 0; i < e.GetArrayProductos.Length; i++)
                {
                    if(e.GetArrayProductos[i]==p)
                    {
                        e.GetArrayProductos[i] = null;
                        seQuito = true;
                    }
                }
                
            }
            return seQuito;
        }

    }
}
