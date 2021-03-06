using System;

namespace BcPuestoDeAtencionI01
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(string nombre, int numero):this(numero)
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int Numero
        {
            get { return this.numero; }
        }

        public static bool operator == (Cliente c1, Cliente c2)
        {
            return c1.numero == c2.numero;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1.numero == c2.numero);
        }

    }
}
