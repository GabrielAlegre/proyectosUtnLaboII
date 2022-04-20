using System;
using System.Collections.Generic;

namespace BcConsultasteIndiceI02
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            paginas = new List<string>();
        }

        public int CantidadPaginas
        {
            get { return paginas.Count; }
        }

        
        public string this[int i]
        {
            get
            {
                if (i > 0 || i < paginas.Count)
                {
                    return this.paginas[i];
                }
                else
                {
                    return "";
                }
            }

            set
            {
                if (i >= 0 && i < paginas.Count)
                {
                    this.paginas[i] = value;
                }
                else if (i == paginas.Count)
                {
                    this.paginas.Add(value);
                }
                else
                {
                    Console.WriteLine("Indice invalido, no se pudo agregar");
                }
            }
        }

        /*
        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < this.paginas.Count)
                {
                    return paginas[i];
                }
                return "Pagina no valida";
            }

            set
            {
                if (i > this.paginas.Count)
                {
                    this.paginas.Add(value);
                }
                else if (i >= 0)
                {
                    this.paginas.Insert(i, value);
                }
            }
        }
        */

    }
    
}
