using System;

namespace BcCartucheraInterfaces
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        float tinta;

        public Boligrafo(float tinta, ConsoleColor colorTinta)
        {
            this.colorTinta = colorTinta;
            this.tinta = tinta;
        }

        public ConsoleColor color 
        { 
            get
            {
                return colorTinta;
            }

            set
            {
                colorTinta = value;
            }
        }
        public float UnidadesDeEscritura 
        {
            get
            {
                return tinta;
            }

            set
            {
                tinta = value;
            }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            if (this.tinta >= 0.3f * texto.Length)
            {
                this.tinta -= 0.3f * texto.Length;

                return new EscrituraWrapper(texto, ((IAcciones)this).color);

            }
            return null;
        }

        public bool Recargar(int unidades)
        {
            bool todoOk = false;
            if(unidades>0)
            {

                tinta += unidades;
                todoOk = true;


            }
            return todoOk;
        }

        public override string ToString()
        {
            return $"Boligrafo:\n-Nivel de tinta: {this.tinta}\n-Color de tinta: {this.colorTinta}";
        }
    }
}
