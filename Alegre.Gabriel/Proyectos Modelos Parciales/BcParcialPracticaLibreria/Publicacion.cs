using System;
using System.Text;

namespace BcParcialPracticaLibreria
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;

     
        protected abstract bool EsColor { get; }
        public virtual bool HayStock
        {
            get
            {
                bool hayStock = false;
                if(this.Stock>0 && this.importe>0)
                {
                    hayStock = true;
                }
                return hayStock;
            }


        }
        public float Importe
        {
            get
            {
                return importe;
            }
        }
        public int Stock
        {
            get
            {
                return this.stock;
            }

            set
            {
                if(value>=0)
                {
                    this.stock = value;
                }
            }
        }
            
        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }

        public Publicacion(string nombre, int stock) : this(nombre)
        {
            this.stock = stock;

        }

        public Publicacion(string nombre, int stock, float importe) : this(nombre, stock)
        {
            this.importe = importe;
        }

        public string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();
            //EsColor representa lo que quiero analizar, es decir, lo que iria dentro del () de un if normal
            //El ? representa a true
            //y el : representa no
            string color = EsColor ? "Si" : "No";

            sb.Append($"Nombre: {nombre}\n");
            sb.AppendFormat("Stock: {0}\n", Stock);
            sb.AppendLine("Color: "+color);
            //if (EsColor)
            //{
            //    sb.AppendLine("Es color: Si");
            //}
            //else
            //{
            //    sb.AppendLine("Es color: No");
            //}
            sb.AppendLine($"Valor {this.importe}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.nombre;
        }
    } 
    
}
