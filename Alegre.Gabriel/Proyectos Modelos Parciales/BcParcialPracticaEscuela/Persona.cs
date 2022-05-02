using System;
using System.Text;

namespace BcParcialPracticaEscuela
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string documento;

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Documento = documento;
        }

        public string Apellido
        {
            get { return this.apellido;}
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public string Documento
        {
            get { return this.documento; }

            set 
            {
                if(ValidarDocumentacion(value))
                {
                    this.documento = value;
                }
            }
        }

        protected abstract bool ValidarDocumentacion(string doc);

        public virtual string exponerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Documentacion: {this.Documento}");

            return sb.ToString();
        }
    }
}
