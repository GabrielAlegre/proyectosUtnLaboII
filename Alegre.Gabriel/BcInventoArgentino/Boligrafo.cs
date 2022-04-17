using System;

namespace BcInventoArgentino
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima=100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo (short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return tinta;
        }

        private void SetTinta(short tinta)
        {
            short auxTinta =(short) (this.tinta + tinta);

            if(auxTinta>=0 && auxTinta<=cantidadTintaMaxima)
            {
                this.tinta = auxTinta;
            }

        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

         

        public bool Pintar(short gasto, out string dibujo)
        {
            bool pudoPintar = false;
            dibujo = "";


            if(this.tinta>=gasto)
            {
                Console.ForegroundColor = color;
                for (int i = 0; i < gasto; i++)
                {
                    dibujo += $"{i+1} *\n";
                }
                SetTinta((short)(gasto * -1));
                pudoPintar = true;
            }
            else if(this.tinta < gasto)
            {
                Console.ForegroundColor = color;
                for (int i = 0; i < this.tinta; i++)
                {
                    dibujo += $"{i + 1} *\n";
                }
                SetTinta((short)(this.tinta*-1));
                pudoPintar = true;
            }

            return pudoPintar;
        }
    }
}
