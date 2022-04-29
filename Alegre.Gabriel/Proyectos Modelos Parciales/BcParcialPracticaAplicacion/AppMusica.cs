using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcParcialPracticaAplicacion
{
    public class AppMusica : Aplicacion
    {
        List<string> listaCanciones;

        public AppMusica(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial) 
            : this(nombre, sistemaOperativo, tamanioInicial, new List<string>())
        {
            
        }

        public AppMusica(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb, List<string>lista) 
            : base(nombre, sistemaOperativo, tamanioMb)
        {
            if(lista is not null)
            {
                this.listaCanciones = lista;

            }
            else
            {
                this.listaCanciones = new List<string>();
            }
        }

        protected override int Tamanio
        {
            get { return this.tamanioMb + (this.listaCanciones.Count * 2); }
        }

        public override string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder($"{base.ObtenerInformacionApp()}\nLista de canciones\n");
            foreach (string canciones in this.listaCanciones)
            {
                sb.AppendLine(canciones);
            }

            return sb.ToString();

        }
    }
}
