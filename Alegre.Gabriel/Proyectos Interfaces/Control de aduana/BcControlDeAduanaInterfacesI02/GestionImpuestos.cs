using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcControlDeAduanaInterfacesI02
{
    public class GestionImpuestos
    {
        private List<IAduana> impuestosAduana;
        private List<IAfip> impuestosAfip;

        public GestionImpuestos()
        {
            impuestosAduana = new List<IAduana>();
            impuestosAfip = new List<IAfip>();
        }

        public void RegistrarImpuestos(Paquete paquete)
        {
            this.impuestosAduana.Add(paquete);
            if(paquete is PaquetePesado)
            {
                this.impuestosAfip.Add((PaquetePesado)paquete);
            }
        }

        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes)
        {
            foreach (Paquete unPaquete in paquetes)
            {
                RegistrarImpuestos(unPaquete);
            }
        }

        public decimal CalcularTotalImpuestosAduana()
        {
            decimal totalAduana=0;
            foreach (IAduana item in this.impuestosAduana)
            {
                totalAduana += item.Impuestos;
            }

            return totalAduana;
        }

        public decimal CalcularTotalImpuestosAfip()
        {
            decimal totalAfip = 0;
            foreach (IAfip item in this.impuestosAfip)
            { 
                totalAfip += item.Impuestos;
            }

            return totalAfip;
        }
    }
}
