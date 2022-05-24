using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcControlDeAduanaInterfacesI02
{
    public class PaquetePesado:Paquete, IAfip
    {
        public PaquetePesado(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
    : base(codigoSeguimiento, costoEnvio, destino, origen, pesoKg)
        {
        }

        public override bool TienePrioridad
        {
            get
            {
                return false;
            }
        }

        decimal IAfip.Impuestos
        {
            get
            {
                return this.costoEnvio * 0.25M;
            }
        }

        public override decimal AplicarImpuestos()
        {
            decimal costoDeEnvioMasImpuestoAduana= base.AplicarImpuestos();

            return costoDeEnvioMasImpuestoAduana + ((IAfip)this).Impuestos;
        }
    }
}
