﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcControlDeAduanaInterfacesI02
{
    public interface IAfip
    {
        public decimal Impuestos { get; }
        public decimal AplicarImpuestos();
    }
}
