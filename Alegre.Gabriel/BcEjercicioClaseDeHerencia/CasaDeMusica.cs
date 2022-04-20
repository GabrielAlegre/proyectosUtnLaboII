using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcEjercicioClaseDeHerencia
{
    public class CasaDeMusica
    {
        private List<Instrumento> listaDeInstrumentos;
        private int cantidadMaxima;

        public CasaDeMusica()
        {
            listaDeInstrumentos = new List<Instrumento>();
        }

        public CasaDeMusica(int cantidadMaxima):this()
        {
            this.cantidadMaxima = cantidadMaxima;
        }

        public List<Instrumento> ListaInstrumentos
        {
            get { return this.listaDeInstrumentos; }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder("Instrumentos de la casa de musica\n");

            sb.AppendLine($"Cantidad de instrumentos: {cantidadMaxima}\n");
            foreach (Instrumento unInstrumento in listaDeInstrumentos)
            {
                switch(unInstrumento)
                {
                    case Guitarra:
                        sb.AppendLine(((Guitarra)unInstrumento).MostrarGuitarra());
                        break;

                    case Trompeta:
                        sb.AppendLine(((Trompeta)unInstrumento).MostrarTrompeta());
                        break;

                    case Bateria:
                        sb.AppendLine(((Bateria)unInstrumento).MostrarBateria());
                        break;

                    default:
                        sb.AppendLine(unInstrumento.Mostrar());
                        break;
                }
            }


            return sb.ToString();
        }

        public static bool operator ==(CasaDeMusica casitaMusical, Instrumento unInstrumento)
        {
            bool estaEnLaLista = false;

            foreach (Instrumento unInstrumentoDeLaLista in casitaMusical.ListaInstrumentos)
            {
                if(unInstrumento == unInstrumentoDeLaLista)
                {
                    estaEnLaLista = true;
                    break;
                }
            }

            return estaEnLaLista;
          
        }

        public static bool operator !=(CasaDeMusica casitaMusical, Instrumento unInstrumento)
        {
            return !(casitaMusical==unInstrumento);

        }

        public static bool operator +(CasaDeMusica casitaMusical, Instrumento unInstrumento)
        {
            bool seAgrego = false;
            if(casitaMusical.ListaInstrumentos.Count < casitaMusical.cantidadMaxima)
            {
                if(casitaMusical!=unInstrumento)
                {
                    casitaMusical.ListaInstrumentos.Add(unInstrumento);
                    seAgrego = true;
                }
            }
            return seAgrego;

        }

        public static bool operator -(CasaDeMusica casitaMusical, Instrumento unInstrumento)
        {
            bool seElimino = false;

            for (int i = 0; i < casitaMusical.ListaInstrumentos.Count; i++)
            {
                if (casitaMusical.listaDeInstrumentos[i] == unInstrumento)
                {
                    casitaMusical.ListaInstrumentos.RemoveAt(i);
                    seElimino = true;
                }
            }
            return seElimino;

        }



    }
}
