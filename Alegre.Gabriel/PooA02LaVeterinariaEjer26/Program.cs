using System;
using BcLaVeterinaria;

namespace PooA02LaVeterinariaEjer26
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primer cliente
            Mascota unaMascota1 = new Mascota("Perro", "pepito", "12/6/5");
            Cliente unCliente = new Cliente("Gabriel", "Alegre", "Av. mitre 750", "113410280");
            unCliente.CantidadDeMascotas(1);
            unCliente.AsociarMascotas(unaMascota1);

            //Segundo cliente
            Mascota unaMascota2 = new Mascota("Gato", "Tronco", "12/6/5");
            unaMascota2.AgregarVacuna("Triple felina");
            Cliente unCliente2 = new Cliente("Juan", "Perez", "Av. Belgrano 450", "1224564");
            unCliente2.CantidadDeMascotas(1);
            unCliente2.AsociarMascotas(unaMascota2);

            //Tercer cliente
            Mascota unaMascota3 = new Mascota("Perro", "Cholo", "12/6/5");
            Mascota unaMascota4 = new Mascota("Gato", "Chola", "12/6/5");
            unaMascota3.AgregarVacuna("Vacuna contra rabia");
            unaMascota3.AgregarVacuna("Vacuna contra fenfgeig");
            unaMascota3.AgregarVacuna("Vacuna contra 65757");
            unaMascota3.AgregarVacuna("Vacuna contra ******");
            Cliente unCliente3 = new Cliente("Leandro", "Avalos", "Av. Corrienetes 23", "356467");
            unCliente3.CantidadDeMascotas(2);
            unCliente3.AsociarMascotas(unaMascota3);
            unCliente3.AsociarMascotas(unaMascota4);


            Console.WriteLine(unCliente.Mostrar());
            Console.WriteLine(unCliente2.Mostrar());
            Console.WriteLine(unCliente3.Mostrar());
        }
    }
}
