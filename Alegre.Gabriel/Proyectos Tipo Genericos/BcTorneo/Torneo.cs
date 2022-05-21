using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcTorneo
{
    public class Torneo<T> where T:Equipo
    {
        private List<T> equipos;
        private string nombre;
        public Torneo(string nombre)
        {
            equipos = new List<T>();
            this.nombre = nombre;
        }
        public static bool operator == (Torneo<T> t, T e)
        {
            bool estaEnElTorneo = false;
            foreach (T unEquipo in t.equipos)
            {
                if(unEquipo == e)
                {
                    estaEnElTorneo = true;
                    break;
                }
            }

            return estaEnElTorneo;
        }

        public static bool operator !=(Torneo<T> t, T e)
        {
            return !(t == e);
        }

        public static bool operator +(Torneo<T> t, T e)
        {
            bool seAgrego = false;
            if(t!=e)
            {
                t.equipos.Add(e);
            }

            return seAgrego;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre del torneo: '{this.nombre}'");
            if (this.equipos.Count > 0)
            {
                if (this is Torneo<EquipoBasquet>)
                {
                    sb.AppendLine($"El torneo es de basquet y los equipos que lo conforman son:");
                }
                else
                {
                    sb.AppendLine($"El torneo es de futbol y los equipos que lo conforman son:");
                }
            }
            else
            {
                sb.AppendLine($"No hay equipos en el torneo");
            }

            foreach (T algo in this.equipos)
            {
                sb.AppendLine(algo.Ficha());
            }

            return sb.ToString();
        }


        private string CalcularPartido(T a, T b) 
        {
            Random calculadorDeResultado = new Random();
            string retorno="No entro a ningun if";
            if(a is EquipoFutbol && b is EquipoFutbol)
            {
                retorno = $"{a.Nombre}: {calculadorDeResultado.Next(0,7)} - {b.Nombre}: {calculadorDeResultado.Next(0, 7)}";
            }
            else if (a is EquipoBasquet && b is EquipoBasquet)
            {
                retorno = $"{a.Nombre}: {calculadorDeResultado.Next(60, 157)} - {b.Nombre}: {calculadorDeResultado.Next(60, 157)}";
            }

            return retorno;
        }

        public string JugarPartido
        {
            get
            {
                string retorno = "Resultado del partido: no se puede jugar el partido debiado a que no hay los suficientes equipos";
                if(this.equipos.Count>1)
                {
                    Random r = new Random();
                    int indiceEquipoUno = r.Next(0, this.equipos.Count);
                    int indiceEquipoDos;
                    do
                    {
                        indiceEquipoDos = r.Next(0, this.equipos.Count);

                    } while (indiceEquipoUno == indiceEquipoDos);

                    retorno= "Resultado del partido: " + this.CalcularPartido(this.equipos[indiceEquipoUno], this.equipos[indiceEquipoDos]);
                }


                return retorno;
            }
        }

    }
}
