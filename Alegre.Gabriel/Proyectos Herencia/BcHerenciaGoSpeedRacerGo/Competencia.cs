using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcHerenciaGoSpeedRacerGo
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        TipoCompetencia tipo;
        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas, TipoCompetencia tipoCom) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipo = tipoCom;
        }

        public VehiculoDeCarrera this[int i]
        {
            get
            {
                if (i > -1 && i < competidores.Count)
                {

                    return competidores[i];

                }
                else
                {
                    return null;
                }
            }
        }
        public short CantidadDeCompetidores
        {
            get { return this.cantidadCompetidores; }
            set { this.cantidadCompetidores = value; }
        }

        public short CantidadVueltas
        {
            get { return this.cantidadVueltas; }
            set { this.cantidadVueltas = value; }
        }
        public TipoCompetencia Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }


        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder("Detalles de la competencia loca\n");

            sb.AppendLine($"Cantidad competidores: {this.cantidadCompetidores}");
            sb.AppendLine($"Cantidad vueltas: {this.cantidadVueltas}");
            sb.AppendLine($"Informacion de los Vehiculos en competencia:\n");
            foreach (VehiculoDeCarrera unVehiculo in competidores)
            {
                switch (unVehiculo)
                {
                    case MotoCross:
                        sb.Append(((MotoCross)unVehiculo).MostrarDatosMotoCross());
                        break;

                    case AutoF1:
                        sb.Append(((AutoF1)unVehiculo).MostrarDatosF1());
                        break;

                    default:
                        sb.Append(unVehiculo.MostrarDatos());
                        break;
                }
            }

            return sb.ToString();
        }

        public static bool operator ==(Competencia unaCompetencia, VehiculoDeCarrera unVehiculo)
        {

            if ((unaCompetencia.tipo is TipoCompetencia.F1 && unVehiculo is AutoF1) || (unaCompetencia.tipo is TipoCompetencia.MotoCross && unVehiculo is MotoCross))
            {
                foreach (VehiculoDeCarrera unVehiculoDeLaLista in unaCompetencia.competidores)
                {
                    if (unVehiculoDeLaLista == unVehiculo)
                    {
                        return true;
                    }
                }
            }
            else
            {
                return true;
            }


            return false;

        }

        public static bool operator !=(Competencia compe, VehiculoDeCarrera unVehiculo)
        {
            return !(compe == unVehiculo);
        }

        public static bool operator +(Competencia compe, VehiculoDeCarrera unVehiculo)
        {
            Random cantCombus = new Random();
            bool seAgrego = false;

            if (compe.competidores.Count < compe.cantidadCompetidores)
            {
                if (compe != unVehiculo)
                {
                    compe.competidores.Add(unVehiculo);
                    unVehiculo.EnCompetencia = true;
                    unVehiculo.VueltasRestantes = compe.cantidadVueltas;
                    unVehiculo.CantidadCombustible = (short)cantCombus.Next(15, 100);
                    seAgrego = true;
                }
            }

            return seAgrego;
        }

        public static bool operator -(Competencia compe, VehiculoDeCarrera unVehiculo)
        {
            bool seElimino = false;

            if (compe == unVehiculo)
            {
                compe.competidores.Remove(unVehiculo);
                seElimino = true;
            }

            return seElimino;
        }
    }
}
