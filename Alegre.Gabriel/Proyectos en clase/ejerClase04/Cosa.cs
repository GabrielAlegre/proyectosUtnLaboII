using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerClase04
{
    class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;

        public Cosa()
        {
            this.entero = 10;
            this.cadena = "sin valor";
            this.fecha = DateTime.Now;
        }
        public Cosa(string cadena) : this()
        {
            this.cadena = cadena;
        }

        public Cosa(int numero, string cadena) : this(cadena)
        {
            this.entero = numero;
        }

        public Cosa(int numero, string cadena, DateTime fecha) : this(numero, cadena)
        {
            this.fecha = fecha;
        }

        public void EstablecerValor (int numero)
        {
            this.entero = numero;
        }

        public void EstablecerValor(string unString)
        {
            this.cadena = unString;
        }

        public void EstablecerValor(DateTime unaFecha)
        {
            this.fecha = unaFecha;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El entero es: {this.entero}");
            sb.AppendLine($"La cadena es: {this.cadena}");
            sb.AppendLine($"La fecha es: {this.fecha.ToShortDateString()}");

            return sb.ToString();
        }

        public string Mostrar(Cosa unObjetoCosa)
        {
            return unObjetoCosa.Mostrar();
        }
    }
}
