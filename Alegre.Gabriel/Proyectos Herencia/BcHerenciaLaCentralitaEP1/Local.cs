using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcHerenciaLaCentralitaEP1
{
    public class Local :  Llamada
    {
        protected float costo;

        public Local(Llamada unLlam, float costo):base(unLlam.Duracion, unLlam.NroDestino, unLlam.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(float duracion, string nroDestino, string nroOrigen, float costo):this(new Llamada( duracion,  nroDestino,  nroOrigen), costo)
        {
        }

        //public Local(float duracion, string nroDestino, string nroOrigen, float costo):base( duracion,  nroDestino,  nroOrigen)
        //{
        //    this.costo = costo;
        //}  


        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            return base.Duracion * costo;
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo: {this.CostoLlamada}");


            return sb.ToString();
        }
    }
}
