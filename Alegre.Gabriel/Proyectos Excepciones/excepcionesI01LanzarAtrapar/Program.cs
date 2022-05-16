using System;
using System.Text;
namespace excepcionesI01LanzarAtrapar
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensajesDelInner="";
            try
            {
                OtraClase otraClase = new OtraClase();
                otraClase.unMetodoInstancia();
            }
            catch (Exception e)
            {
                mensajesDelInner += $"{e.Message}\n";
                while (e.InnerException != null)
                {
                    e = e.InnerException;
                    mensajesDelInner += $"{e.Message}\n";

                }
                Console.WriteLine(mensajesDelInner);
            }
        }
    }
}
