using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BcPuestoDeAtencionI01
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public static int NumeroActual
        {
            
            get 
            {
                PuestoAtencion.numeroActual++;
                return numeroActual; 
            }
        }

        public enum Puesto
        {
            caja1,
            caja2
        }

        public bool Atender (Cliente unCliente)
        {
            if (unCliente is not null)
            {
                Thread.Sleep(2000);
                return true;

            }

            return false;
        }
    }
}
