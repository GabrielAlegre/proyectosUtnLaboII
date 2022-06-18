using NameGenerator.Generators;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BcHilosSimuladorDeAtencionAClientes
{
    public class Negocio
    {
        static RealNameGenerator nameGenerator;
        private ConcurrentQueue<string> clientes;
        private List<Caja> cajas;
        static Negocio()
        {
            nameGenerator = new RealNameGenerator();
        }

        public Negocio(List<Caja> listaDeCaja)
        {
            clientes = new ConcurrentQueue<string>();
            cajas = listaDeCaja;

        }

        public List<Task> ComenzarAtencion()
        {
            List<Task> hilos = new List<Task>();

            foreach (Caja unaCaja in cajas)
            {
                unaCaja.IniciarAtencion();
            }

            hilos.Add(Task.Run(tareaSimulacionClientes));
            hilos.Add(Task.Run(tareaAsignacionCajas));


            return hilos;
        }

        private void tareaSimulacionClientes()
        {
            do
            {
                clientes.Enqueue(nameGenerator.Generate());
                Thread.Sleep(1000);

            } while (true);
        }

        private void tareaAsignacionCajas()
        {
            do
            {
                //Primero ordeno de las cajas que menos clientes tienen hasta la que mas clientes tienen,
                //Despues agarro (con el first) la primera caja de la lista, que esta primera caja va a ser la que menos clientes tenga
                Caja cajaConMenosClientes = cajas.OrderBy(c => c.CantidadDeClientesALaEspera).First();

                //De mi lista de clientes agarro el proximo y lo mando a la caja que menos clientes tenga
                clientes.TryDequeue(out string cliente);

                if (!string.IsNullOrWhiteSpace(cliente))
                {
                    cajaConMenosClientes.AgregarCliente(cliente);
                }

            } while (true);
        }

    }
}
