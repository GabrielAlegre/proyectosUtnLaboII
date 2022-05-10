using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Primer.Parcial
{
    public class Deposito
    {
        private int capacidad;
        private List<Producto> productos;

        #region "Propiedades"
        public double PrecioDeCelulares
        {
            get { return this.ObtenerPrecio(EProducto.PrecioDeCelulares);}
        }

        public double PrecioDeTelevisores
        {
            get { return this.ObtenerPrecio(EProducto.PrecioDeTelevisores);}
        }

        public double PrecioTotal
        {
            get { return this.ObtenerPrecio(EProducto.PrecioTotal);}
        }
        #endregion

        #region "constructores"
        private Deposito()
        {
            this.productos = new List<Producto>();
        }

        private Deposito(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }
        #endregion

        #region "Metodos"
        public static string Mostrar(Deposito d)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"\nCapacidad: {d.capacidad} ({d.productos.Count})");
            sb.AppendLine($"Total por televisores: {d.PrecioDeTelevisores}");
            sb.AppendLine($"Total por celulares: {d.PrecioDeCelulares}");
            sb.AppendLine($"Total: {d.PrecioTotal}");
            sb.AppendLine($"*******************************************************");
            sb.AppendLine($"Listado de productos");
            sb.AppendLine($"*******************************************************");
            foreach (Producto unProductoDelDeposito in d.productos)
            {
                sb.AppendLine(unProductoDelDeposito.ToString());
            }

            return sb.ToString();
        }
        private double ObtenerPrecio(EProducto tipoProducto)
        {
            double acumuladorDePrecio = 0;

            foreach (Producto producto in this.productos)
            {
                if ((EProducto.PrecioDeTelevisores == tipoProducto || EProducto.PrecioTotal == tipoProducto) && producto is Televisor)
                {
                    //Uso la conversion explicita que me retorna el precio del televisor
                    acumuladorDePrecio += (double)(Televisor)producto;
                }

                if ((EProducto.PrecioDeCelulares == tipoProducto || EProducto.PrecioTotal == tipoProducto) && producto is Celular)
                {
                    //Uso la conversion implicita que me retorna el precio del celu
                    acumuladorDePrecio += (Celular)producto;
                }
            }
            return acumuladorDePrecio;
        }
        #endregion

        #region "Sobrecargas de operadores"
        public static implicit operator Deposito(int capacidad)
        {
            return new Deposito(capacidad);
        }

        public static bool operator ==(Deposito d, Producto p)
        {
            bool estaEnElDeposito = false;

            foreach (Producto unProductoDelDeposito in d.productos)
            {
                if (unProductoDelDeposito.Equals(p))
                {
                    estaEnElDeposito = true;
                    break;
                }
            }
            return estaEnElDeposito;
        }

        public static bool operator !=(Deposito d, Producto p)
        {
            return !(d == p);
        }

        public static Deposito operator +(Deposito d, Producto p)
        {
            if (d.capacidad > d.productos.Count)
            {
                if (d != p)
                {
                    d.productos.Add(p);
                }
                else
                {
                    Console.WriteLine("El producto ya se encuentra en el deposito!!!!");
                }
            }
            else
            {
                Console.WriteLine("No hay mas lugar en el deposito!!!!");
            }
            return d;
        }
        #endregion
    }
}
