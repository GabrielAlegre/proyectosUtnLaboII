using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probandoSerializar
{
    public interface IGuardar<T>
    {
        void GuardarXml(string ruta, T contenido);
        T LeerXml(string ruta);


        void GuardarJson(string ruta, T contenido);
        T LeerJson(string ruta);
    }
}
