using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcCompetenciaGenerica
{
    public class Competencia<T>where T:VehiculoDeCarrera
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<T> competidores;

        public List<T> Competidores
        {
            get { return this.competidores; }
        }
        private Competencia()
        {
            competidores = new List<T>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
           // this.tipo = tipoCom;
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

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder("Detalles de la competencia loca\n");

            sb.AppendLine($"Cantidad competidores: {this.cantidadCompetidores}");
            sb.AppendLine($"Cantidad vueltas: {this.cantidadVueltas}");
            sb.AppendLine($"Informacion de los Vehiculos en competencia:\n");
            foreach (T unVehiculo in competidores)
            {
                sb.AppendLine(unVehiculo.MostrarDatos());
            }

            return sb.ToString();
        }

        public static bool operator ==(Competencia<T> unaCompetencia, T unVehiculo)
        {
            foreach (T unVehiculoDeLaLista in unaCompetencia.competidores)
            {
                if (unVehiculoDeLaLista == unVehiculo)
                {
                    return true;
                }
            }
            return false;

        }

        public static bool operator !=(Competencia<T> compe, T unVehiculo)
        {
            return !(compe == unVehiculo);
        }

        public static bool operator +(Competencia<T> compe, T unVehiculo)
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
                else
                {
                    throw new CompetenciaNoDisponibleException("Excepcion. Ya esta el auto en la competencia", "Competencia", "Sobrecarga operador +");
                }
            }
            return seAgrego;
        }

        public static bool operator -(Competencia<T> compe, T unVehiculo)
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
