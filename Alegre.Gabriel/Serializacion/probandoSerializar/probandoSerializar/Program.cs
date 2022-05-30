using System;
using System.Collections.Generic;

namespace probandoSerializar
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona personaDeMentiraUno = new Estuadiante("Jorge", "Alegre", "28028001", 65, 8, 2);
            Persona personaDeMentiraDos = new Empleado("alba", "rodriguz", "43901903", 35, 56000, 95);

            Persona personaDeMentiraTres = new Estuadiante("Perro", "Callejero", "6464535", 23, 13, 4);
            Persona personaDeMentiraCuatro = new Empleado("juan", "perez", "768686864", 75, 700000, 554);
            Persona personaDeMentiraCinco = new Empleado("mago", "sin pija", "5464356", 21, 150000, 123);

            List<Persona> listaDePersonas = new List<Persona>()
            {
                personaDeMentiraUno,
                personaDeMentiraDos,
                personaDeMentiraTres,
                personaDeMentiraCuatro,
                personaDeMentiraCinco
            };

            Persona unaPersona = new Persona("Perro", "Callejero", "6464535",23);
            Escuela unaEscuela = new Escuela("Velez sarsfiel 280", "Enspa", personaDeMentiraCinco);
            Escuela unaEscuela1 = new Escuela("Mitre 767", "Sacachispa", personaDeMentiraCuatro);
            Escuela unaEscuela2 = new Escuela("Belgrano 1280", "Boca", personaDeMentiraTres);
            Escuela unaEscuela3  = new Escuela("Roca 2860", "Riber", personaDeMentiraDos);
            Escuela unaEscuela4  = new Escuela("Calle falsa 123", "Utn", personaDeMentiraUno);

            List<Escuela> listaDeEscuela = new List<Escuela>();
            listaDeEscuela.Add(unaEscuela);
            listaDeEscuela.Add(unaEscuela1);
            listaDeEscuela.Add(unaEscuela2);
            listaDeEscuela.Add(unaEscuela3);
            listaDeEscuela.Add(unaEscuela4);

            string ruta = $"{ Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\ProbandoGenericoConInterfaces.xml";
            CentralSerializadoraInterfaz<List<Escuela>> xml = new CentralSerializadoraInterfaz<List<Escuela>>();

            xml.GuardarXml(ruta, listaDeEscuela);

            //CentralSerializadoraGenerica<List<Escuela>>.GuardarXml(ruta, listaDeEscuela);
            
            //CentralSerializadora.GuardarJson($"{ Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\ProbandoCliJson.json", unaEscuela);
            //CentralSerializadora.GuardarXml($"{ Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\ProbandoCliXml.xml", listaDeEscuela);
            //CentralSerializadora.GuardarXml($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Probandooooooo.xml", listaDePersonas);
            //List<Persona> listaDesSerializada = CentralSerializadora.LeerXml<List<Persona>>($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Probandooooooo.xml");
            //foreach (Persona unaPersona in listaDesSerializada)
            //{
            //    Console.WriteLine(unaPersona.ToString() + "\n");
            //}


        }
    }
}

                //new Persona("Jorge", "Alegre", "28028001", 65),
                //new Persona("alba", "rodriguz", "43901903", 35),
                //new Persona("Perro", "Callejero", "6464535", 23),
                //new Persona("juan", "perez", "768686864", 75),
                //new Persona("mago", "sin pija", "5464356", 21)