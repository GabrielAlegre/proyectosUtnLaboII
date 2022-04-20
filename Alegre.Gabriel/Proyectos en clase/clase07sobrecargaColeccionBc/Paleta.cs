using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase07sobrecargaColeccionBc
{
    public class Paleta
    {

        List<Tempera> listaDeTemperas;
        int cantidadDeColoresMaximos;

        private Paleta()
        {
            this.listaDeTemperas = new List<Tempera>();
        }

        private Paleta(int cantidadDeColoresMaximos):this()
        {
            this.cantidadDeColoresMaximos = cantidadDeColoresMaximos;
        }

        public static implicit operator Paleta(int cantidad)
        {
            return new Paleta(cantidad);
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de temperas en la palera: {this.cantidadDeColoresMaximos}");
            foreach (Tempera unaTemperaDeLaPaleta in this.listaDeTemperas)
            {
                sb.AppendLine(Tempera.Mostrar(unaTemperaDeLaPaleta));
            }

            return sb.ToString();
        }

        private int obtenerIndice(Tempera unaTemp)
        {
            int tam = listaDeTemperas.Count;
            int index = -1;
            for (int i = 0; i < tam; i++)
            {
                if(listaDeTemperas[i]==unaTemp)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public static explicit operator string(Paleta unaPaleta)
        {
            return unaPaleta.Mostrar();
        }

        /*
        public static bool operator ==(Paleta unaPaleta, Tempera unaTempera)
        {
            bool estaLaTemperaEnLaPaleta = false;
            if(unaPaleta.listaDeTemperas.Contains(unaTempera))
            {
                estaLaTemperaEnLaPaleta = true;
            }

            return estaLaTemperaEnLaPaleta;
        }  
        */
       
        public static bool operator ==(Paleta unaPaleta, Tempera unaTempera)
        {
            bool estaLaTemperaEnLaPaleta = false;
            foreach (Tempera unaTemperaDeLaPaleta in unaPaleta.listaDeTemperas)
            {
                if(unaTemperaDeLaPaleta==unaTempera)
                {
                    estaLaTemperaEnLaPaleta = true;
                    break;
                }
            }

            return estaLaTemperaEnLaPaleta;
        }
       
        public static bool operator != (Paleta unaPaleta, Tempera unaTempera)
        {
            return !(unaPaleta == unaTempera);
        }

        //        +(Paleta, Tempera) : Paleta
        //*->si tempera está en paleta --> incrementa la cantidad en la tempera.
        //*->si no está --> agrega la tempera en la paleta, siempre y cuando, no supere la cantidad máxima de colores.

        public static Paleta operator +(Paleta unaPaleta, Tempera unaTempera)
        {
            int indice;
            if(unaPaleta==unaTempera)
            {
                indice = unaPaleta.obtenerIndice(unaTempera);
                
                unaPaleta.listaDeTemperas[indice] = unaPaleta.listaDeTemperas[indice] + unaTempera;
            }
            else
            {
                if(unaPaleta.listaDeTemperas.Count < unaPaleta.cantidadDeColoresMaximos)
                {
                    unaPaleta.listaDeTemperas.Add(unaTempera);
                }
                
            }

            return unaPaleta;
        }

        //-(Paleta, Tempera) : Paleta
        //*->si tempera está en paleta -> decrementa la cantidad en la tempera.
        //*)si la cantidad es menor o igual a cero, elimina la tempera(RemoveAt)

        public static Paleta operator -(Paleta unaPaleta, Tempera unaTempera)
        {
            int indice;
            int cantidadDeTemperaDeTemList=0;
            int cantidadDeTemperaParam= 0;

            if (unaPaleta == unaTempera)
            {
                indice = unaPaleta.obtenerIndice(unaTempera);

                cantidadDeTemperaDeTemList = unaPaleta.listaDeTemperas[indice];
                cantidadDeTemperaParam = unaTempera;

                if(cantidadDeTemperaDeTemList-cantidadDeTemperaParam<=0)
                {
                    unaPaleta.listaDeTemperas.Remove(unaPaleta.listaDeTemperas[indice]);
                }
                else
                {
                    unaPaleta.listaDeTemperas[indice] = unaPaleta.listaDeTemperas[indice] + -(unaTempera);
                }


            }

            return unaPaleta;
        }

        //+(Paleta, Paleta) : Paleta
        //*->genera una paleta con los colores de ambas paletas.
        //*)si temperas son iguales-->suma cantidades

        public static Paleta operator +(Paleta unaPaleta, Paleta otraPaleta)
        {
            
            int tamDeLaPaleta = otraPaleta.cantidadDeColoresMaximos + unaPaleta.cantidadDeColoresMaximos;

            Paleta paletaPro = tamDeLaPaleta;

            foreach (Tempera unaTem in unaPaleta.listaDeTemperas)
            {
                paletaPro = paletaPro + unaTem;
            }

            foreach (Tempera unaTem in otraPaleta.listaDeTemperas)
            {
                paletaPro = paletaPro + unaTem;
                
            }

            return paletaPro;
        }

    }
}
