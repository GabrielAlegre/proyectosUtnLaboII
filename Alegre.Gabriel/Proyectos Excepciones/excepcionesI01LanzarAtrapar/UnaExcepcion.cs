﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepcionesI01LanzarAtrapar
{
    public class UnaExcepcion:Exception
    {
        public UnaExcepcion(string mensaje, Exception e):base(mensaje,e)
        {

        }
        public UnaExcepcion(string mensaje) : base(mensaje)
        {

        }
    }
}
