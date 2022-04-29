using System;
using System.Collections.Generic;
using System.Text;

namespace BcParcialPracticaAplicacion
{
    public abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;

        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
        }

        public SistemaOperativo SistemaOperativo
        {
            get {return this.sistemaOperativo; }
        }

        protected abstract int Tamanio { get; }

        public virtual string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Sistema operativo: {this.sistemaOperativo}");
            sb.AppendLine($"Tamaño ocupado {this.Tamanio}");

            return sb.ToString();
        }

        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            int maximo = 0;
            Aplicacion aplicacionTamMax=null;

            foreach (Aplicacion unaAppDeLaLista in listaApp)
            {
                if(unaAppDeLaLista.Tamanio > maximo)
                {
                    maximo = unaAppDeLaLista.Tamanio;
                    aplicacionTamMax = unaAppDeLaLista;
                }
            }

            return aplicacionTamMax;
        }


        public override string ToString()
        {
            return this.nombre;
        }

        public static bool operator == (List<Aplicacion> listaApp, Aplicacion app)
        {
            bool laAplicacionYaEsta = false;
            foreach (Aplicacion unaAppDeLalista in listaApp)
            {
                if(unaAppDeLalista.nombre==app.nombre)
                {
                    laAplicacionYaEsta = true;
                    break;
                }
            }

            return laAplicacionYaEsta;
        }

        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }

        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            bool seAgrego = false;
            if(listaApp!=app)
            {
                listaApp.Add(app);
                seAgrego = true;
            }

            return seAgrego;
        }
    }
}
