using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace BcSiempreQuiseTenerUnNotepadSerializador
{
    public class PuntoJson<T> : Archivo, IArchivo<T> where T : class
    {
        protected override string Extension
        {
            get { return ".json"; }
        }

        public void Guardar(string ruta, T contenido)
        {
            if (this.ValidarSiExisteElArchivo(ruta) && this.ValidarExtensión(ruta))
            {
                SerializandoAndo(ruta, contenido);
            }
        }

        public void GuardarComo(string ruta, T contenido)
        {
            if (this.ValidarExtensión(ruta))
            {
                SerializandoAndo(ruta, contenido);
            }
        }

        public T Leer(string ruta)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtensión(ruta))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(ruta))
                    {
                        string contenidoJson = sr.ReadToEnd();
                        return JsonSerializer.Deserialize<T>(contenidoJson);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Excepcion {ex.Message}");
                }
            }

            return null;
        }

        private void SerializandoAndo(string ruta, T contenido)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    JsonSerializerOptions opciones = new JsonSerializerOptions();
                    opciones.WriteIndented = true;
                    string cont = JsonSerializer.Serialize(contenido, opciones);
                    sw.WriteLine(cont);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepcion {ex.Message}");
            }
        }
    }
}
