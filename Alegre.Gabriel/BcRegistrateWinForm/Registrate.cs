using System;
using System.Text;

namespace BcRegistrateWinForm
{
    public class Registrate
    {
        string[] cursos;
        string direccion;
        int edad;
        string genero;
        string nombre;
        string pais;

        public Registrate(string[] cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string mostrar ()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Direccion: {this.direccion}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"Genero: {this.genero}");
            sb.AppendLine($"Pais: {this.pais}");
            sb.AppendLine($"Curso/s:");
            for (int i = 0; i < cursos.Length; i++)
            {

                if(!string.IsNullOrEmpty(cursos[i]))
                {
                    sb.AppendLine($"{cursos[i]}");
                }
                
                
            }
            return sb.ToString();
        }
    }
}
