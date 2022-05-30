using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BcSiempreQuiseTenerUnNotepadSerializador
{
    public class PuntoXml<T> : Archivo, IArchivo<T> where T : class
    {
        protected override string Extension
        {
            get {return ".xml"; }
        }

        public void Guardar(string ruta, T contenido)
        {
            if (this.ValidarSiExisteElArchivo(ruta) && this.ValidarExtensión(ruta))
            {
                serializador(ruta, contenido);
            }
        }

        public void GuardarComo(string ruta, T contenido)
        {
            if(this.ValidarExtensión(ruta))
            {
                serializador(ruta, contenido);
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
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                        T contenido = xmlSerializer.Deserialize(sr) as T;
                        return contenido;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Excepcion {ex.Message}");
                }
            }

            return null;
        }

        private void serializador(string ruta, T contenido)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(T));
                    xml.Serialize(sw, contenido);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepcion {ex.Message}");
            }
        }
    }
}
