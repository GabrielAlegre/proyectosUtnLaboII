using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BcLaCentralitaEP7Serializacion
{
    [XmlInclude(typeof(Provincial))]
    [XmlInclude(typeof(Local))]
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada()
        { }

        public Llamada(float duracion, string nroDestino, string nroOrigen) : this()
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public abstract float CostoLlamada { get; set; }


        public string NroOrigen
        {
            get { return this.nroOrigen; }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this.nroOrigen = value;
                }
            }
        }

        public string NroDestino
        {
            get { return this.nroDestino; }
            set
            {

                if (!String.IsNullOrWhiteSpace(value))
                {
                    this.nroDestino = value;
                }

            }
        }

        public float Duracion
        {
            get { return this.duracion; }
            set
            {
                if (value>0)
                {
                    this.duracion = value;
                }
            }
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion: {this.duracion}");
            sb.AppendLine($"Numero de destino: {this.nroDestino}");
            sb.AppendLine($"Numero de origen: {this.nroOrigen}");

            return sb.ToString();
        }


        //Si la duracion de la llamadas son iguales el orden va a ser 0
        //Si la duracion de la primera llamada es mayor a la duracion de la segunda llamada retorna 1
        //Si la duracion de la primera llamada es menor a la duracion de la segunda llamada retorna -1
        public static int ordenarPorDuracion(Llamada primeraLlamada, Llamada segundaLLamada)
        {
            return ((int)(primeraLlamada.duracion - segundaLLamada.duracion));
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool lasLlamadasSonIguales = false;


            if(l1.nroOrigen == l2.nroOrigen && l1.nroDestino==l2.nroDestino)
            {
                lasLlamadasSonIguales = true;
            }

            return lasLlamadasSonIguales;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

    }
}
