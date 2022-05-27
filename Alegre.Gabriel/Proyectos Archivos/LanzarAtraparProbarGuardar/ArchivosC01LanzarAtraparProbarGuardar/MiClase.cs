using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcArchivosC01LanzarAtraparProbarGuardar
{
    public class MiClase
    {

        private static void UnMetodoEstatico()
        {
            throw new DivideByZeroException();
        }
   
        public MiClase()
        {
            try
            {
                MiClase.UnMetodoEstatico();
            }
            catch(DivideByZeroException )
            {

                throw;
            }
        }

        public MiClase(string algo)
        {
            try
            {
                MiClase unaClase = new MiClase();
            }
            catch(DivideByZeroException e)
            {
                throw new UnaExcepcion($"exepcion propia desde mi clase", e);
            }
        }
    }
}
