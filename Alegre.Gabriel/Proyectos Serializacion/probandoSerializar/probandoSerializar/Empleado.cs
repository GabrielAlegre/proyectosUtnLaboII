using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probandoSerializar
{
    public class Empleado :Persona
    {
        private int sueldo;
        private int horasTrabajadas;

        public Empleado() { }
        public Empleado(string nombre, string apellido, string dni, int edad, int sueldo, int horasTrabj) : base(nombre, apellido, dni, edad)
        {
            this.sueldo = sueldo;
            this.horasTrabajadas = horasTrabj;
        }

        public int Sueldo { get => sueldo; set => sueldo = value; }
        public int HorasTrabajadas { get => horasTrabajadas; set => horasTrabajadas = value; }

        public override string ToString()
        {
            return $"{base.ToString()}\nSueldo: {this.sueldo}\nHoras trabajadas: {this.horasTrabajadas}";
        }
    }
}
