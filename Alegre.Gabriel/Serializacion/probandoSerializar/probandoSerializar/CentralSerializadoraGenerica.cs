﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace probandoSerializar
{
    public class CentralSerializadoraGenerica<T> where T : class
    {
        
        public static void GuardarXml(string ruta, T contenido)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(T));
                    xml.Serialize(sw, contenido);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static T LeerXml (string ruta)
        {
           
            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(T));
                    T objeto = xml.Deserialize(sr) as T;
                    return objeto;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrio un problema");
            }
            
            return null;
        }



        public static void GuardarJson(string ruta, T contenido)
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

        public static T LeerJson (string ruta)
        {

            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    string contenidoDelArchivo = sr.ReadToEnd();
                    
                    return JsonSerializer.Deserialize<T>(contenidoDelArchivo);
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
