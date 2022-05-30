using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BcLaCentralitaEP7Serializacion
{
    public class Provincial:Llamada, IGuardar<List<Provincial>>
    {

        private Franja franjaHoraria;
        private string ruta = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{"llamadas.xml"}";

        public Provincial() : base()
        {

        }
        public Provincial(string nroOrigen, Franja unaFranja, float duracion, string nroDestino) : base(duracion, nroDestino, nroOrigen)
        {
            franjaHoraria = unaFranja;
        }

        public Provincial(Franja unaFranja, Llamada unLlam) : this(unLlam.NroOrigen, unaFranja, unLlam.Duracion, unLlam.NroDestino)
        {
        }

        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
            set
            {
                
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
                this.ruta=value;
            }
        }

        protected Franja FranjaHoraria { get => franjaHoraria; set => franjaHoraria = value; }

        private float CalcularCosto()
        {
            double costo= 0.66;
            switch(franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = 0.99;
                    break;         
                case Franja.Franja_2:
                    costo = 1.25;
                    break;               
            }

            return (float) (base.Duracion * costo);
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Costo: {this.CostoLlamada}");
            sb.AppendLine($"Franja horaria: {this.franjaHoraria}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }

        public override bool Equals(object obj)
        {
            return obj is not null && obj is Provincial && this==(Provincial)obj;
        }

        public bool Guardar(List<Provincial> contenido)
        {
            bool seSerializo = false;
            try
            {
                using (StreamWriter sw = new StreamWriter($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{"llamada.xml"}", true))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<Provincial>));

                    xml.Serialize(sw, contenido);
                    seSerializo = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo guardar"+ex.Message);
            }

            return seSerializo;
        }

        public List<Provincial> Leer()
        {
            try
            {
                using (StreamReader sr = new StreamReader($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{"llamada.xml"}"))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(List<Provincial>));
                    List<Provincial> llamada = xml.Deserialize(sr) as List<Provincial>;
                    if (llamada is null)
                    {
                        throw new InvalidCastException("Excepcion en leer. Clase local, metodo leer");
                    }
                    else
                    {
                        return llamada;
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Fallo leer provincial"+e.Message);
            }
            return null;
        }
    }
}
