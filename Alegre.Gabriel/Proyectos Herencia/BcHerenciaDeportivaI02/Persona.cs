using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcHerenciaDeportivaI02
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public Persona(long dni, string nombre):this(nombre)
        {
            this.dni = dni;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public long Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.Append($"Dni: {this.dni}");

            return sb.ToString();
        }
    }
}
