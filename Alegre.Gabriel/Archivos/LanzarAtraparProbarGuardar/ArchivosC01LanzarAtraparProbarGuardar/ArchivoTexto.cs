using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcArchivosC01LanzarAtraparProbarGuardar
{
    public static class ArchivoTexto
    {
        public static void Guardar(string ruta, string mensaje)
        {

            File.WriteAllText(ruta, mensaje);
        }

        public static string Leer(string ruta)
        {
            if(File.Exists(ruta))
            {
                return File.ReadAllText(ruta);

            }
            else
            {
                throw new FileNotFoundException("Ruta invalida");
            }
        }
    }
}
