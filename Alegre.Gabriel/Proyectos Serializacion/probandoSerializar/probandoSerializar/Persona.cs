using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace probandoSerializar
{
    [XmlInclude(typeof(Empleado))]
    [XmlInclude(typeof(Estuadiante))]
    public class Persona
    {
        private string nombre;
        private string apellido;
        private string dni;
        private int edad;

        public Persona() { }
        public Persona(string nombre, string apellido, string dni, int edad):this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        public int Edad { get => edad; set => edad = value; }

        public override string ToString()
        {
            return $"Nombre: {this.nombre}\nApellido: {this.apellido}\nEdad: {this.edad}\nDNI: {this.dni}";
        }
    }
}
