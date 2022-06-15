using System;

namespace BcI101MiPrimerCRUD
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public Persona(int id, string nombre, string apellido):this(nombre, apellido)
        {
            this.id = id;
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public override string ToString()
        {
            return $"Id: {this.id}\n | Nombre: {this.nombre}\n | Apellido: {this.apellido}\n   |";
        }
    }
}
