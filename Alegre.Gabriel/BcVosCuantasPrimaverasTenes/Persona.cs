using System;
using System.Text;

namespace BcVosCuantasPrimaverasTenes
{
    public class Persona
    {
        private string nombre;
        DateTime fechaDeNacimiento;
        private int dni;

        public Persona()
        {
            this.nombre = "";
            this.dni = 0;
            this.fechaDeNacimiento = DateTime.Now;

        }

        public Persona (string unNombre, int unDni, DateTime unaFecha)
        {
            this.nombre = unNombre;
            this.dni = unDni;
            this.fechaDeNacimiento = unaFecha;

        }

        public string GetNombre ()
        {
            return this.nombre;
        }

        public void SetNombre(string unNombre)
        {
            this.nombre=unNombre;
        }

        public int GetDni()
        {
            return this.dni;
        }

        public void SetDni(int dni)
        {
            this.dni = dni;
        }

        public DateTime GetFechaNacimiento()
        {
            return this.fechaDeNacimiento;
        }

        public void SetFechaNacimiento(DateTime unaFecha)
        {
            this.fechaDeNacimiento = unaFecha;
        }

        private int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Now;

            int edad = fechaActual.Year  - this.GetFechaNacimiento().Year;

            if (fechaDeNacimiento.Month>fechaActual.Month)
            {
                edad--;
            }

            return edad;
        }

        public string EsMayorDeEdad ()
        {
            string cadena = "Es mayor de edad";
            if(CalcularEdad()<18)
            {
                cadena = "Es menor";
            }
            return cadena;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder("Informacion de la persona:\n");
            sb.AppendLine($"Nombre: {GetNombre()}");
            sb.AppendLine($"Dni: {GetDni()}");
            sb.AppendLine($"Fecha de nacimiento: {GetFechaNacimiento().ToShortDateString()}");
            sb.AppendLine($"Edad: {CalcularEdad()}");
            sb.AppendLine($"{EsMayorDeEdad()}");

            return sb.ToString();

        }
    }


}
