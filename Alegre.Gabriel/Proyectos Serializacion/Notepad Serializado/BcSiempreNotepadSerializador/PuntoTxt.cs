using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BcSiempreQuiseTenerUnNotepadSerializador
{
    public class PuntoTxt : Archivo, IArchivo<string>
    {
        protected override string Extension
        {
            get { return ".txt"; }
        }

        public void Guardar(string ruta, string contenido)
        {
            if (this.ValidarSiExisteElArchivo(ruta) && this.ValidarExtensión(ruta))
            {
                GuardandoAndo(ruta, contenido);
            }
        }

        public void GuardarComo(string ruta, string contenido)
        {
           
            if (this.ValidarExtensión(ruta))
            {
                GuardandoAndo(ruta, contenido);
            }

        }

        public string Leer(string ruta)
        {
            string contenidoDelArchivoTxt=String.Empty;
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtensión(ruta))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(ruta))
                    {
                        contenidoDelArchivoTxt = sr.ReadToEnd();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Excepcion {ex.Message}");
                }
            }

            return contenidoDelArchivoTxt;
        }

        private void GuardandoAndo(string ruta, string contenido)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    sw.WriteLine(contenido);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al guardar el archivo txt\n" + ex.Message);
            }

        }
    }
}
