using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase05Bc
{
    public class Pluma
    {
        private string marca;
        private Tinta tinta;
        private int cantidad;

        public Pluma()
        {
            this.marca = "Sin marca";
            tinta = null;
            this.cantidad = 1;
        }

        public Pluma(string marca) : this()
        {
            this.marca = marca;
        }

        public Pluma(string marca, Tinta tinta) : this(marca)
        {
            this.tinta = tinta;
        }

        public Pluma(string marca, Tinta tinta, int cantidad) : this(marca, tinta)
        {
            this.cantidad = cantidad;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder("Informacion de la pluma");

            sb.AppendLine($"\nLa marca de la pluma es: {this.marca}");
            sb.AppendLine($"La cantidad de cartucho/s es: {this.cantidad}");
            sb.AppendLine((string)tinta); // o sb.AppendLine(Tinta.Mostrar(tinta));


            return sb.ToString();
        }

        //Retorna true cuando el objeto pluma que recibo como parametro coincida con la tinta que le paso 
        //Como segundo parametro
        public static bool operator ==(Pluma p1, Tinta t2)
        { 
            return p1.tinta == t2;
        }

        
        public static bool operator !=(Pluma p1, Tinta t2)
        {

            return !(p1 == t2);

        }

        //Va a sumar tinta solo si la tinta de la pluma que me pasan por parametro es igual
        //a al tinta que recibo como segundo parametro
        public static Pluma operator +(Pluma p1, Tinta t2)
        {
            if (p1.tinta == t2)
            {
                p1.cantidad++;
            }

            return p1;
        }

        public static Pluma operator -(Pluma p1, Tinta t2)
        {
            
            if (p1.tinta == t2)
            {
                p1.cantidad--;
               
            }

            return p1;
        }

        //El implicit lo que hace es "trasformar" un objeto de tipo pluma en string 
        public static implicit operator string(Pluma p)
        {
            return p.Mostrar();
        }
    }
}
