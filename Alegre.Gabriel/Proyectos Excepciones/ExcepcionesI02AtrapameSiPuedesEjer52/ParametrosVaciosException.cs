using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesI02AtrapameSiPuedesEjer52
{
    class ParametrosVaciosException:Exception
    {

        public ParametrosVaciosException(string mensaje):base(mensaje)
        {

        }

        public ParametrosVaciosException(string mensaje, Exception e) : base(mensaje, e)
        {

        }
    }
}
