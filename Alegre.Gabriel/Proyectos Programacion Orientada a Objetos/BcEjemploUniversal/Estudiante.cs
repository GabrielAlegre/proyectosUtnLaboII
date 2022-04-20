using System;
using System.Text;

namespace BcEjemploUniversal
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random unNumeroRandom;

        static Estudiante()
        {
            unNumeroRandom = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;

        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        private float calcularPromedio ()
        {
            return (float)(this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }


        public double CalcularNotaFinal ()
        {
            double notaFinal=-1;
            if(notaPrimerParcial> 4 && notaSegundoParcial>4)
            {
                notaFinal = unNumeroRandom.Next(6, 10);

            }

            return notaFinal;
        }

        public string Mostrar()
        {
            double notaFinal = CalcularNotaFinal();
            StringBuilder sb = new StringBuilder("Informacion del alumno:\n");

            sb.AppendLine($"Nombre: {this.nombre}\nApellido: {apellido}\nLegajo: {legajo}");
            sb.AppendLine($"Nota primer parcial: {notaPrimerParcial}");
            sb.AppendLine($"Nota segundo parcial: {notaSegundoParcial}");
            sb.AppendLine($"Promedio: {calcularPromedio()}");
            if(notaFinal!=-1)
            {
                sb.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                sb.AppendLine($"Alumno desaprobado");
            }
            

            return sb.ToString();

        }

    }
}
