using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcHerenciaDeportivaI02
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaDeNacimiento;

        public DirectorTecnico(string nombre):base(nombre)
        {

        }

        public DirectorTecnico(string nombre, DateTime fechaNac) : this(nombre)
        {
            this.fechaDeNacimiento = fechaNac;
        }

        public DateTime FechaNacimiento
        {
            get { return fechaDeNacimiento; }
        }
        public new string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder("Informacion del Dt\n");

            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Fecha de nacimiento: {fechaDeNacimiento.ToString("dd/MM/yyyy")}");

            return sb.ToString();
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return dt1.fechaDeNacimiento == dt2.fechaDeNacimiento && dt1.Nombre == dt2.Nombre;
        }

        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1.fechaDeNacimiento == dt2.fechaDeNacimiento && dt1.Nombre == dt2.Nombre);
        }
    }
}
