using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcEnciendanSusMotoresC02
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;
        private Competencia ()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas):this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder("Detalles de la competencia loca\n");

            sb.AppendLine($"Cantidad competidores: {this.cantidadCompetidores}");
            sb.AppendLine($"Cantidad vueltas: {this.cantidadVueltas}");
            sb.AppendLine($"Informacion de los autos en competencia:\n");
            foreach (AutoF1 unAutoDeLaCompetencia in competidores)
            {
                sb.AppendLine($"{unAutoDeLaCompetencia.MostrarDatos()}");
            }

            return sb.ToString();
        }

        public static bool operator == (Competencia compe, AutoF1 unAuto)
        {
            bool elAutoEstaEnCompetencia = false;

            foreach (AutoF1 unAutoDeLaCompetencia in compe.competidores)
            {
                if(unAutoDeLaCompetencia==unAuto)
                {
                    elAutoEstaEnCompetencia = true;
                    break;
                }
            }

            return elAutoEstaEnCompetencia;
        }

        public static bool operator !=(Competencia compe, AutoF1 unAuto)
        {
            return !(compe == unAuto);
        }

        public static bool operator +(Competencia compe, AutoF1 unAuto)
        {
            Random cantCombus = new Random();
            bool seAgrego = false;

            if(compe.competidores.Count <  compe.cantidadCompetidores)
            {
                if(compe!=unAuto)
                {
                    compe.competidores.Add(unAuto);
                    unAuto.EnCompetencia = true;
                    unAuto.VueltasRestantes = compe.cantidadVueltas;
                    unAuto.CantidadCombustible = (short)cantCombus.Next(15, 100);
                    seAgrego = true;
                }
            }

            return seAgrego;
        }

        public static bool operator -(Competencia compe, AutoF1 unAuto)
        {
            bool seElimino = false;

            if (compe == unAuto)
            {
                compe.competidores.Remove(unAuto);
                seElimino = true;
            }

            return seElimino;
        }

    }
}
