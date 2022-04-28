using System;
using Entidades.Establecimiento;
using Entidades.Botellas;

namespace ConsoleAppBar
{
    class Program
    {
        static void Main(string[] args)
        {
            Agua a1 = new Agua("Glaciar", 75, TipoAgua.Mineral);
            Agua a2 = new Agua("Glaciar", 75, 500, TipoAgua.Mineral);
            Agua a3 = new Agua("Glaciar", 75, 750, TipoAgua.Mineral);
            Agua a4 = new Agua("Villa del sur", 90, TipoAgua.ConGas);
            Agua a5 = new Agua("Villa Vicencio", 200, 500, TipoAgua.SinGas);

            Cerveza c1 = new Cerveza("Quilmes", 175, 910, TipoCerveza.Rubia);
            Cerveza c2 = new Cerveza("Schneider", 250, 710, TipoCerveza.Lager, 710);
            Cerveza c3 = new Cerveza("Quilmes", 175, 910, TipoCerveza.Negra);
            Cerveza c4 = new Cerveza("Villa Vicencio", 200, 500, TipoCerveza.Lager, 500);
            Cerveza c5 = new Cerveza("Algo", 200, 434, TipoCerveza.Lager, 100);//Las agrego para verificar el ordenamiento
            Cerveza c6 = new Cerveza("Kilo Vicencio", 100, 1356, TipoCerveza.Lager, 486);//Las agrego para verificar el ordenamiento

            if ( ! (a5 == c4))
            {
                Console.WriteLine("Son distintos");
            }

            if ( ! a5.Equals(c4))
            {
                Console.WriteLine("Son distintos");
            }

            Bar b = new Bar(12, "Lo de Carlo");

            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine(b.MostrarBar);

            b += a1;
            b += a2; // repetida.
            b += a3;
            b += a4;
            b += a5;

            b += c1;
            b += c5;
            b += c2;
            b += c3;
            b += c6;
            b += c4;
            Console.WriteLine("///////////////////////////////tERMINO DE AGREGAR///////////////////////////////////////////////////");
            Console.WriteLine(b.MostrarBar);

            b -= a1;
            b -= a2;//No esta
            b -= a3;
            b -= a4;
            b -= a5;

            Console.WriteLine("///////////////////////////////////TERMINO DE CONSUMIR AGUS///////////////////////////////////////////////");
            Console.WriteLine(b.MostrarBar);

            b -= c1;
            b -= c1;
            b -= c1;
            b -= c1;//no hay más

            //C2 Y C4 Lo elimina porque la medida la hardcodeo en 510 y la capacidad tambien es 510 por lo que cuando llame
            //a servir medida me va a servir todo el contenido, por ende el contedifo queda en 0 y en el -- de bar
            //si habia una botella con contenido 0 la eliminaba
            b -= c2;
            b -= c3;
            b -= c4;

            Console.WriteLine("/////////////////////////////////Muestro sin order TERMINO DE CONSUMIR CERVEZA/////////////////////////////////////////////////");
            Console.WriteLine(b.MostrarBar);
            Console.WriteLine("/////////////////////////////////Muestro por contenido///////////////////////////////////////////////");
            b.OrdenarBotellas(Ordenamiento.PorcentajeContenido);
            Console.WriteLine(b.MostrarBar);

            Console.WriteLine("/////////////////////////////////Muestro por ganancia////////////////////////////////////////////////");
            b.OrdenarBotellas(Ordenamiento.Ganancia);
            Console.WriteLine(b.MostrarBar);

            Console.WriteLine("/////////////////////////////////Muestro por marca///////////////////////////////////////////////");
            b.OrdenarBotellas(Ordenamiento.Marca);
            Console.WriteLine(b.MostrarBar);



            Console.ReadLine();


        }
    }
}
