using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcParcialPracticaEscuela
{
    public class Curso
    {

        List<Alumno> alumnos;
        private short anio;
        Divisiones division;
        Profesor profesor;

        public string AnioDivision
        {
            get
            {
                return $"{this.anio.ToString()}º{this.division.ToString()}";
            }
        }

        private Curso()
        {
            alumnos = new List<Alumno>();
        }

        public Curso(short anio, Divisiones division, Profesor profesor) : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Añio y division: {c.AnioDivision}");
            sb.AppendLine($"profesor:\n{c.profesor.exponerDatos()}");

            foreach (Alumno alumnoDelCurso in c.alumnos)
            {
                sb.AppendLine(alumnoDelCurso.exponerDatos());
            }

            return sb.ToString();
      
        }

        public static bool operator ==(Curso c, Alumno a)
        {
            return c.AnioDivision == a.AnioDivision;
            
        }

        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }

        public static Curso operator +(Curso c, Alumno a)
        {
            if(c==a)
            {
                c.alumnos.Add(a);
            }

            return c;
        }
    }
}
