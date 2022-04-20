using System;
using System.Text;

namespace BcEjercicioClaseDeHerencia
{
    public class Instrumento
    {
        protected int codigo;
        protected string marca;

        public Instrumento(int codigo, string marca)
        {
            this.codigo = codigo;
            this.marca = marca;
        }

        public Instrumento(int codigo, string marca, EClasificacion clasificacion) : this(codigo,marca)
        {
            this.Clasificacion = clasificacion;
        }

        public enum EClasificacion
        {
            Cuerdas,
            Vientos,
            Percusion
        }

        protected EClasificacion Clasificacion { get; set; }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Codigo: {codigo}");
            sb.AppendLine($"Marca: {marca}");
            sb.AppendLine($"Clasificacion: {Clasificacion}");

            return sb.ToString();
        }

        public static bool operator == (Instrumento unInstrumento, Instrumento otroInstrumento)
        {
            return unInstrumento.codigo == otroInstrumento.codigo;
        } 
        
        public static bool operator != (Instrumento unInstrumento, Instrumento otroInstrumento)
        {
            return !(unInstrumento.codigo == otroInstrumento.codigo);
        }

    }
}
