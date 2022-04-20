using System;
using BcEjercicioClaseDeHerencia;

namespace ejercicioEnClaseHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Instrumento unInstrumento = new Instrumento(234, "pepe", Instrumento.EClasificacion.Cuerdas);
            Guitarra unaGuitarra = new Guitarra(Guitarra.ETipoGuitarra.Criolla, Instrumento.EClasificacion.Cuerdas, 4546, "Yamaha", 6);
            Guitarra otraGuitarra = new Guitarra(Guitarra.ETipoGuitarra.Eléctrica, Instrumento.EClasificacion.Cuerdas, 2345, "Gibson", 4);
            Bateria unaBateria = new Bateria(535, "La mas piola", Instrumento.EClasificacion.Percusion, 8);
            Bateria otraBatetia = new Bateria(234, "Mapex", Instrumento.EClasificacion.Percusion, 12);
            Trompeta unaTrompetita = new Trompeta(764, "Nose", Instrumento.EClasificacion.Vientos, "4");
            Bateria unaBateriaRepe = new Bateria(535,"ADD", Instrumento.EClasificacion.Percusion, 5); 
            CasaDeMusica unaCasitaDeMusica = new CasaDeMusica(5);

            //1- Agrego el primer instrumento: una guitarra
            if(unaCasitaDeMusica+unaGuitarra)
            {
                Console.WriteLine("Se agrego con exito");
            }
            else
            {
                Console.WriteLine("Error. No se agrego");
            }

            //2- Agrego el primer instrumento: una bateria
            if (unaCasitaDeMusica + unaBateria)
            {
                Console.WriteLine("Se agrego con exito");
            }
            else
            {
                Console.WriteLine("Error. No se agrego");
            }

            //3- Agrego el primer instrumento: una trompeta
            if (unaCasitaDeMusica + unaTrompetita)
            {
                Console.WriteLine("Se agrego con exito");
            }
            else
            {
                Console.WriteLine("Error. No se agrego");
            }


            //4- Agrego el primer instrumento: un instrumento
            if (unaCasitaDeMusica + unInstrumento)
            {
                Console.WriteLine("Se agrego con exito");
            }
            else
            {
                Console.WriteLine("Error. No se agrego");
            }

            ///Esta bateria no se agrega xq esta repetida
            if (unaCasitaDeMusica + unaBateriaRepe)
            {
                Console.WriteLine("Se agrego con exito");
            }
            else
            {
                Console.WriteLine("Error. No se agrego");
            }


            ////5- agrego otra Guitarra
            if (unaCasitaDeMusica + otraGuitarra)
            {
                Console.WriteLine("Se agrego con exito");
            }
            else
            {
                Console.WriteLine("Error. No se agrego");
            }

            Console.WriteLine(unaCasitaDeMusica.Mostrar());
            Console.WriteLine("-----------------------------------------------------------------------------------------");

            ////5- elimino el instrumento
            if (unaCasitaDeMusica - unInstrumento)
            {
                Console.WriteLine("Se elimino con exito");
            }
            else
            {
                Console.WriteLine("Error. No se elimino");
            }

            //2- Agrego el primer instrumento: una bateria
            if (unaCasitaDeMusica + otraBatetia)
            {
                Console.WriteLine("Se agrego con exito");
            }
            else
            {
                Console.WriteLine("Error. No se agrego");
            }

            Console.WriteLine(unaCasitaDeMusica.Mostrar());
        }
    }
}
