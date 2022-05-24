using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesI02AtrapameSiPuedesEjer52
{
    public static class Calculadora
    {
        static public double Calcular(int kilometro, int litro)
        {
            /*
            try
            {
                return kilometro / litro;
            }
            catch(DivideByZeroException)
            {
                throw new DivideByZeroException("Excepcion: No se pudo realizar la division, ya que litro vale 0");
            }*/

            //Cualquiera de las dos formas funcionan, en la primera es mas larga y se entiende mas y en la segunda retorno
            //directo el resulrado, si la divicion se pudo realizar retornara el resultado, sino retorna la excepcion que 
            //luego va a ser capturada en el form en el evento calcular linea 51
            return kilometro / litro;

        }
    }
}
