using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcCartucheraInterfaces
{
    public class CartucheraMultiuso
    {
        public List<IAcciones> lista;

        public CartucheraMultiuso()
        {
            this.lista = new List<IAcciones>();
        }

        public bool RecorrerElementos()
        {
            foreach (IAcciones item in this.lista)
            {
                if (item.UnidadesDeEscritura -1 >=0)
                {
                    item.UnidadesDeEscritura -= 1;
                    if(item.UnidadesDeEscritura>=0 && item.UnidadesDeEscritura<1)
                    {
                        item.UnidadesDeEscritura = 20;
                    }
                }
                else
                {
                    return false;
                }

            }

            return true;
        }
    }
}
