using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace probandoSerializar
{
    public class CentralSerializadoraInterfaz <X> : IGuardar<X> where X :class
    {
        public CentralSerializadoraInterfaz() { }
        public virtual void GuardarXml(string ruta, X contenido)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(X));
                    xml.Serialize(sw, contenido);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public virtual X LeerXml(string ruta)
        {
           
            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(X));
                    X objeto = xml.Deserialize(sr) as X;
                    return objeto;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrio un problema");
            }
            
            return null;
        }



        public virtual void GuardarJson(string ruta, X contenido)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    JsonSerializerOptions opciones = new JsonSerializerOptions();
                    opciones.WriteIndented = true;
                    string json = JsonSerializer.Serialize(contenido, opciones);
                    sw.WriteLine(json);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public virtual X LeerJson(string ruta) 
        {

            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    string contenidoDelArchivo = sr.ReadToEnd();
                    
                    return JsonSerializer.Deserialize<X>(contenidoDelArchivo);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrio un problema");
            }

            return null;
        }
    }
}
