using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probandoSerializar
{
    public class Estuadiante: Persona
    {
        private int materiasCursadas;
        private int anioCurso;
        public Estuadiante() { }

        public Estuadiante(string nombre, string apellido, string dni, int edad, int materias, int anio) 
            :base(nombre, apellido, dni, edad)
        {
            this.materiasCursadas = materias;
            this.anioCurso = anio;
        }
       
        public int MateriasCursadas { get => materiasCursadas; set => materiasCursadas = value; }
        public int AnioCurso { get => anioCurso; set => anioCurso = value; }
        public override string ToString()
        {
            
            return $"{base.ToString()}\nMaterias cursadas: {this.materiasCursadas}\nAnio: {this.anioCurso}";
        }
    }
}
