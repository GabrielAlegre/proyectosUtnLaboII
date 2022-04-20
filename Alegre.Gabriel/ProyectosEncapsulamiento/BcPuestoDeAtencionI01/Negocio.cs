using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcPuestoDeAtencionI01
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> colaDeClientes;
        private string nombreNegocio;

        private Negocio()
        {
            colaDeClientes = new Queue<Cliente>();
            caja = new PuestoAtencion(PuestoAtencion.Puesto.caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombreNegocio = nombre;
        }

        public Cliente ClienteProp
        {
            get { return colaDeClientes.Dequeue(); }
            set { _ = this + value; }
        }

        public int ClientesPendientes
        {
            get { return colaDeClientes.Count; }
        }
        public static bool operator ==(Negocio unNegocio, Cliente unCliente)
        {
            bool elClienteEstaEnLaCola = false;
            foreach (Cliente unClienteDelNegocio in unNegocio.colaDeClientes)
            {
                if (unClienteDelNegocio == unCliente)
                {
                    elClienteEstaEnLaCola = true;
                    break;
                }
            }

            return elClienteEstaEnLaCola;
        }

        public static bool operator !=(Negocio unNegocio, Cliente unCliente)
        {
            return !(unNegocio == unCliente);
        }

        public static bool operator +(Negocio unNegocio, Cliente unCliente)
        {
            bool seAgrego = false;
            if(unNegocio==unCliente==false)
            {
                unNegocio.colaDeClientes.Enqueue(unCliente);
                seAgrego = true;
            }

            return seAgrego;
        }

        public static bool operator ~(Negocio unNegocio)
        {
            bool fueAtendido = false;
            if(unNegocio.colaDeClientes.Count>0)
            {
                fueAtendido= unNegocio.caja.Atender(unNegocio.ClienteProp);
            }

            return fueAtendido;
        }
    }
}
