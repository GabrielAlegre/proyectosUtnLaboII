using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;

namespace BcHilosSimuladorDeAtencionAClientes
{
    public class Caja
    {
        private static Random atributoRandom;
        private Queue<string> clientesALaEspera;
        private string nombreCaja;
        public delegate void DelegadoClienteAtendido(Caja unaCaja, string unCliente);
        private DelegadoClienteAtendido delegadoCliente;

        static Caja()
        {
            atributoRandom = new Random();
        }

        public Caja (string nombreDeLaCaja, DelegadoClienteAtendido referenciaMetodo)
        {
            this.clientesALaEspera = new Queue<string>();
            this.nombreCaja = nombreDeLaCaja;
            this.delegadoCliente = referenciaMetodo;
        }
        public string NombreCaja { get => nombreCaja;}
        public int CantidadDeClientesALaEspera { get => clientesALaEspera.Count;}

        internal  void AgregarCliente(string cliente)
        {
            clientesALaEspera.Enqueue(cliente);
        }

        internal Task IniciarAtencion()
        {
            return Task.Run(() =>
            {
                do
                {
                    if (clientesALaEspera.Any())
                    {
                        if (this.delegadoCliente is not null)
                        {
                            delegadoCliente.Invoke(this, clientesALaEspera.Dequeue());
                        }

                        Thread.Sleep(atributoRandom.Next(1000, 5000));
                    }

                } while (true);
            });

            /*
            Task tarea = new Task(tareaAtencionAlCliente);
            tarea.Start();
            return tarea;
            */

        }

        /*
        private void tareaAtencionAlCliente()
        {
            do
            {
                if(clientesALaEspera.Any())
                {
                    if(this.delegadoCliente is not null)
                    {
                        delegadoCliente.Invoke(this, clientesALaEspera.Dequeue());
                    }

                    Thread.Sleep(atributoRandom.Next(1000,5000));
                }

            } while (true);
        }
        */
    }
}
