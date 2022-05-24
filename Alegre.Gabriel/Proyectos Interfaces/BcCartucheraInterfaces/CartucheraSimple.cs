using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcCartucheraInterfaces
{
    public class CartucheraSimple
    {
        public List<Boligrafo> listaDeBolis;
        public List<Lapiz> listaDeLapices;

        public CartucheraSimple()
        {
            listaDeBolis = new List<Boligrafo>();
            listaDeLapices = new List<Lapiz>();
        }
        public bool RecorrerElementos()
        {
            foreach (Lapiz item in this.listaDeLapices)
            {
                if (((IAcciones)item).UnidadesDeEscritura - 1 >=0)
                {
                    ((IAcciones)item).UnidadesDeEscritura -= 1;
                    if (((IAcciones)item).UnidadesDeEscritura >= 0 && ((IAcciones)item).UnidadesDeEscritura < 1)
                    {
                        ((IAcciones)item).UnidadesDeEscritura = 20;
                    }

                }
                else
                {
                    //((IAcciones)item).UnidadesDeEscritura = 20;
                    return false;
                }
            }

            foreach (Boligrafo item in this.listaDeBolis)
            {
                if (item.UnidadesDeEscritura - 1 >=0)
                {
                    item.UnidadesDeEscritura -= 1;
                    if (item.UnidadesDeEscritura >= 0 && item.UnidadesDeEscritura < 1)
                    {
                        item.UnidadesDeEscritura = 20;
                    }
                }
                else
                {
                    //item.UnidadesDeEscritura = 20;
                    return false;
                }
            }

            return true;
        }
    }
}
