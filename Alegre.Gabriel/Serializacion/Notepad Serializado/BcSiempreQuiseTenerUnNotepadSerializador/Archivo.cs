using System;
using System.IO;

namespace BcSiempreQuiseTenerUnNotepadSerializador
{
    public abstract class Archivo
    {
        protected abstract string Extension
        {
            get;
        }

        public bool ValidarSiExisteElArchivo(string ruta)
        {
            if(File.Exists(ruta))
            {
                return true;
            }
            else
            {
                throw new ArchivoIncorrectoException("El archivo no se encontro");
            }
        }

        public bool ValidarExtensión(string ruta)
        {
            if (Path.GetExtension(ruta) == Extension)
            {
                return true;
            }
            else
            {
                throw new ArchivoIncorrectoException($"El archivo no tiene la extensión {Extension}.");
            }
        }
    }
}
