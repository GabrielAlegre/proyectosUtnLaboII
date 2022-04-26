using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcCalculadoraDeFormas
{
    public abstract class Figura
    {
        //Agregar el método Dibujar que tendrá una implementación por defecto en la clase base y retornará el texto
        //"Dibujando forma...". Las clases derivadas directas invalidarán dicha implementación y
        //la cambiarán por "Dibujando círculo", "Dibujando rectángulo", según corresponda.

        public virtual string Dibujar()
        {
            return "Dibujando forma...";
        }

        // Agregar el método CalcularSuperficie que deberá ser implementado de manera obligatoria por las clases derivadas.
        // Debe retornar un double con el resultado del cálculo de superficie(área) para la figura correspondiente.
        public abstract double CalcularSuperficie();

        public abstract double CalcularPerimetro();
    }
}
