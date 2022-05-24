using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcCartucheraInterfaces
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }

        ConsoleColor IAcciones.color
        {
            get
            {
                return ConsoleColor.Gray;
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }

            set
            {
                this.tamanioMina = value;
            }
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {

            if(this.tamanioMina>= 0.1f * texto.Length)
            {
                this.tamanioMina -= 0.1f * texto.Length;

                return new EscrituraWrapper(texto, ((IAcciones)this).color);

            }
            return null;
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"Lapiz:\n-Tamañio de la mina: {((IAcciones)this).UnidadesDeEscritura}\n-Color de mina: {((IAcciones)this).color}";
        }
    }
}
