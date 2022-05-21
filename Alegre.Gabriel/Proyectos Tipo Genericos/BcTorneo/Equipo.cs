using System;

namespace BcTorneo
{
    public abstract class Equipo
    {
        protected string nombre;
        protected DateTime fechaCreacion;

        public string Nombre
        {
            get { return this.nombre; }
        }
        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public static bool operator==(Equipo a, Equipo b)
        {
            return a.nombre == b.nombre && a.fechaCreacion == b.fechaCreacion;
        }

        public static bool operator !=(Equipo a, Equipo b)
        {
            return !(a==b);
        }

        public string Ficha()
        {
            return $"Equipo {nombre} Fundado el {fechaCreacion.ToShortDateString()}";
        }
    }
}
