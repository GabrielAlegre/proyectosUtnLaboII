using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probandoSerializar
{
    public class Escuela
    {
        private string direccion;
        private string nombre;
        Persona unaPersona;

        Escuela() { }
        public Escuela(string direccion, string nombre, Persona unaPersona)
        {
            this.direccion = direccion;
            this.nombre = nombre;
            this.unaPersona = unaPersona;
        }

        public string Direccion { get => direccion; set => direccion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Persona UnaPersona { get => unaPersona; set => unaPersona = value; }

        public override string ToString()
        {
            return $"Direccion: {this.direccion}\nNombre de la escuela: {this.nombre}\nDatos de la persona{this.unaPersona.ToString()}"; 
        }
    }
}
