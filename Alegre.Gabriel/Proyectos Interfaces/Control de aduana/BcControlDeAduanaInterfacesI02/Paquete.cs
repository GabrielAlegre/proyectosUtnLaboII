using System;
using System.Text;

namespace BcControlDeAduanaInterfacesI02
{
    public abstract class Paquete : IAduana
    {
        private string codigoSeguimiento;
        protected decimal costoEnvio;
        private string destino;
        private string origen;
        private double pesoKg;

        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
        }

        public abstract bool TienePrioridad { get; }

        public decimal Impuestos
        {
            get
            {
                return this.costoEnvio * 0.35M;
            }
        }

        public string ObtenerInformacionDePaquete()
        {
            StringBuilder sb = new StringBuilder();
            string prioridad = this.TienePrioridad ? "Tiene prioridad." : "No tiene prioridad.";

            sb.AppendLine($"Codigo de seguimiento: {this.codigoSeguimiento}");
            sb.AppendLine($"Costo de envio: ${this.costoEnvio}");
            sb.AppendLine($"Origen: {this.origen}");
            sb.AppendLine($"Destino: {this.destino}");
            sb.AppendLine($"Peso: {this.pesoKg} kg");
            sb.AppendLine(prioridad);

            return sb.ToString();
        }

        public virtual decimal AplicarImpuestos()
        {
            return this.costoEnvio + this.Impuestos; ;
        }
    }
}
