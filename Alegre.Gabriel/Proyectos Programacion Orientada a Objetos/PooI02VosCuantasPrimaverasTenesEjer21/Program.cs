using System;
using BcVosCuantasPrimaverasTenes;

namespace PooI02VosCuantasPrimaverasTenesEjer21
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona personaUno = new Persona("Jose Luis", 28028001, new DateTime(1978, 2, 23));
            Persona personaDos = new Persona("Emiliano", 23088909, new DateTime(1991, 12, 27));
            Persona personaTres = new Persona();
            personaTres.SetDni(43901903);
            personaTres.SetNombre("Gabriel");
            personaTres.SetFechaNacimiento(new DateTime(2004, 11, 30));

            Console.WriteLine(personaUno.Mostrar());
            Console.WriteLine(personaDos.Mostrar());
            Console.WriteLine(personaTres.Mostrar());
        }
    }
}
