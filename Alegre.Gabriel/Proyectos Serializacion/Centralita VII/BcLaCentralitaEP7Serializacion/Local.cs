using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BcLaCentralitaEP7Serializacion
{
    public class Local :  Llamada, IGuardar<List<Local>>
    {
        private float costo;
        private string ruta= $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{"llamadas.xml"}";

        public Local():base()
        {

        }
        public Local(float duracion, string nroDestino, string nroOrigen, float costo):base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }
        public Local(Llamada unLlam, float costo):this(unLlam.Duracion, unLlam.NroDestino, unLlam.NroOrigen, costo)
        {
        }


        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
            set
            {
                this.Costo= this.CalcularCosto();
            }
        }

        public string RutaDeArchivo
        {
            get
            {
                return this.ruta;
            }
            set
            {
                this.ruta = value;
            }
        }

        protected float Costo { get => costo; set => costo = value; }

        private float CalcularCosto()
        {
            return base.Duracion * costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo: {this.CostoLlamada}");


            return sb.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is Local && this==(Local)obj;
        }

        public bool Guardar(List<Local> contenido)
        {
            bool seSerializo = false;
            try
            {
                using (StreamWriter sw = new StreamWriter($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{"llamadas.xml"}"))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<Local>));

                    xml.Serialize(sw, contenido);
                    seSerializo = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo leer");
            }

            return seSerializo;
        }

        public List<Local> Leer()
        {
            try
            {
                using (StreamReader sr = new StreamReader($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{"llamadas.xml"}"))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<Local>));
                    List<Local> llamada = xml.Deserialize(sr) as List<Local>;
                    if(llamada is null)
                    {
                        throw new InvalidCastException("Excepcion en leer. Clase local, metodo leer");
                    }
                    else
                    {
                        return llamada;
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Fallo leer");
            }
            return null;
        }
    }
}
