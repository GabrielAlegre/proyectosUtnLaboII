using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcParcialPracticaEscuela
{
    public class Profesor:Persona
    {

        private DateTime fechaIngreso;

        public Profesor(string nombre, string apellido, string documento) : base(nombre, apellido, documento)
        {
        }  
        
        public Profesor(string nombre, string apellido, string documento, DateTime fechaDeIngreso) : this(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaDeIngreso;
        }


        public int Antiguedad
        {
            get
            {
                TimeSpan diasAntiguedad = DateTime.Now.Subtract(this.fechaIngreso);

                return diasAntiguedad.Days;
            }
        }
   
        

        protected override bool ValidarDocumentacion(string doc)
        {
            bool docValido = false;

            if (doc.Length == 8)
            {
                docValido = true;
            }

            return docValido;
        }

        public override string exponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.exponerDatos()}");
            sb.AppendLine($"Fecha de ingreso: {this.fechaIngreso.ToShortDateString()}");
            sb.AppendLine($"Antiguedad (En dias): {this.Antiguedad}");

            return sb.ToString();
        }
    }
}
