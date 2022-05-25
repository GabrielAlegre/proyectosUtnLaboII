using System;
using BcArchivosC01LanzarAtraparProbarGuardar;
namespace ArchivosC01LanzarAtraparProbarGuardarIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensajesDelInner = "";
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //string ruta = AppDomain.CurrentDomain.BaseDirectory;
            ruta += @$"\{DateTime.Now.ToString("yyyyMMdd")}-{DateTime.Now.ToString("HHmm")}.txt";
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
                ArchivoTexto.Guardar(ruta, mensajesDelInner);
            }

            Console.WriteLine(ArchivoTexto.Leer(ruta));
        }
    }
}
