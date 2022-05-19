using System;
using BcContabilidadTiposGenericos;
namespace TiposGenericosI02Contabilidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> cont = new Contabilidad<Factura, Recibo>();

            Factura facUno = new Factura(43901903);
            Factura facDos = new Factura(28028001);
            Factura facTres = new Factura(29029002);
            Recibo recUno = new Recibo();
            Recibo recDos = new Recibo(23023003);
            Recibo recTres = new Recibo(21021001);

            cont = cont + facUno;
            cont = cont + facDos;
            cont = cont + facTres;
            cont = cont + recUno;
            cont = cont + recDos;
            cont = cont + recTres;

            Console.WriteLine(cont.MostrarContabilidad());


        }
    }
}
