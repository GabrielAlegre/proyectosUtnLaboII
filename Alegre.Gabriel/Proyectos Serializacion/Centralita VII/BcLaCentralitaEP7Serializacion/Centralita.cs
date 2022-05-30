using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BcLaCentralitaEP7Serializacion
{
    public class Centralita : IGuardar<string>
    {
        private List<Llamada> listaDeLLamadas;
        protected string razonSocial;
        private string ruta = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{"bitácora.txt"}";

        #region "Constructores"
        private Centralita()
        {
            listaDeLLamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region "Propiedades"
        public List<Llamada> Llamadas
        {
            get { return listaDeLLamadas; }
        }
        public float GananciasPorLocal
        {
            get { return this.CalcularGanancias(TipoLlamada.Local); }
        }

        public float GananciasPorProvincial
        {
            get { return this.CalcularGanancias(TipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get { return this.CalcularGanancias(TipoLlamada.Todas); }
        }

        public string RutaDeArchivo
        {
            get
            {
                return ruta;
            }
            set
            {
                ruta = value;
            }
        }
        #endregion

        #region "Metodos"
        public void OrdenarLlamadas()
        {
            listaDeLLamadas.Sort(Llamada.ordenarPorDuracion);
        }

        private float CalcularGanancias(TipoLlamada tipo)
        {
            float recaudado = 0;

            foreach (Llamada unaLlamada in this.listaDeLLamadas)
            {
                if (tipo is TipoLlamada.Provincial && unaLlamada is Provincial)
                {
                    recaudado += unaLlamada.CostoLlamada;
                }
                else if (tipo is TipoLlamada.Local && unaLlamada is Local)
                {
                    recaudado += unaLlamada.CostoLlamada;
                }
                else if (tipo is TipoLlamada.Todas)
                {
                    recaudado += unaLlamada.CostoLlamada;
                }
            }
            return recaudado;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder("\nDetalles de la centralita\n");

            sb.AppendLine($"Razon social: {this.razonSocial}");
            sb.AppendLine($"Ganancias totales: {this.GananciasPorTotal}");
            sb.AppendLine($"Ganancias Provinciales: {this.GananciasPorProvincial}");
            sb.AppendLine($"Ganancias Locales: {this.GananciasPorLocal}");
            sb.AppendLine($"Detalles de las Llamadas:\n");
            foreach (Llamada llamada in listaDeLLamadas)
            {
                sb.AppendLine(llamada.ToString());
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }

        //El método AgregarLlamada es privado.Recibe una instancia de Llamada y
        //la agrega a la lista de llamadas.
        private void AgregarLlamada(Llamada unaNuevaLlamada)
        {
            this.listaDeLLamadas.Add(unaNuevaLlamada);
        }

        public bool Guardar(string contenido)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta, true))
                {
                    sw.WriteLine($"{DateTime.Now:f}hs - Se realizo una llamada");
                }
            }
            catch (Exception ex)
            {
                throw new FallaLogException("Excepcion al guardar archivo", "en la clase: Centralita", "y en el metodo: guardar +", ex);
            }
            return true;
        }

        public string Leer()
        {
            string contenidoDelArchivo = string.Empty;
            try
            {
                using (StreamReader sw = new StreamReader(ruta))
                {
                    contenidoDelArchivo= sw.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                throw new NotImplementedException("Excepcion al guardar archivo", ex);
            }
            return contenidoDelArchivo;
        }

        #endregion

        #region "Sobrecargas"

        public static bool operator == (Centralita c1, Llamada l1)
        {
            bool laLlamadaEstaEnLaCentral = false;

            foreach (Llamada unaLlamadaDeLaCentral in c1.listaDeLLamadas)
            {
                if (unaLlamadaDeLaCentral.Equals(l1))
                {
                    laLlamadaEstaEnLaCentral = true;
                    break;
                }
            }
            return laLlamadaEstaEnLaCentral;
        }

        public static bool operator !=(Centralita c1, Llamada l1)
        {
            return !(c1 == l1);
        }

        //El operador + invocará al método AgregarLlamada sólo si la llamada no está 
        //registrada en la Centralita.Utilizar la sobrecarga del operador == de Centralita.
        public static Centralita operator +(Centralita c1, Llamada l1)
        {
            if (c1 != l1)
            {
                c1.AgregarLlamada(l1);
                try
                {
                    c1.Guardar("g");
                }
                catch (FallaLogException ex)
                {
                    Console.WriteLine($"{ex.Message} {ex.NombreClase} {ex.NombreMetodo}");
                }
            }
            else
            {
                throw new CentralitaException("Excepcion centralita", "en la clase: Centralita", "y en el metodo: Sobrecarga del operador +");
            }
            return c1;
        }
        #endregion
    }
}
