using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcParcialPracticaEscuela
{
    public class Alumno : Persona
    {

        private short anio;
        private Divisiones division;

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division)
            : base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }

        public string AnioDivision
        {
            get 
            {
                return $"{this.anio.ToString()}º{this.division.ToString()}";
            }
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            bool docValido = false;

            if(doc.Length==9 && doc[2]=='-'&&doc[7]=='-')
            {
                docValido = true;
            }

            return docValido;
        }

        public override string exponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.exponerDatos()}");
            sb.AppendLine($"Añio y division: {this.AnioDivision}");

            return sb.ToString();
        }
    }
}
