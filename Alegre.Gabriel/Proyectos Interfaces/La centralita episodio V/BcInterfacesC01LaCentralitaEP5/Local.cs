using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcInterfacesC01LaCentralitaEP5
{
    public class Local :  Llamada, IGuardar<Local>
    {
        protected float costo;

        public Local(float duracion, string nroDestino, string nroOrigen, float costo):base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }
        public Local(Llamada unLlam, float costo):this(unLlam.Duracion, unLlam.NroDestino, unLlam.NroOrigen, costo)
        {
        }


        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        public string RutaDeArchivo
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {

            }
        }

        private float CalcularCosto()
        {
            return base.Duracion * costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo: {this.CostoLlamada}");


            return sb.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is Local && this==(Local)obj;
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public Local Leer()
        {
            throw new NotImplementedException();
        }
    }
}
