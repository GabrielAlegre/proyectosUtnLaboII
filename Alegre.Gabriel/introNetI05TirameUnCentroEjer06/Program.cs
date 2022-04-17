using System;

namespace introNetI05TirameUnCentroEjer06
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;

            int sumaAntesCentro = 0;
            int sumaHastaElCentro = 0;


            Console.Write("Ingrese un numero: ");


            //El try parser es para verificar que me ingrese un numero valido y no un numero con una letra
            while (int.TryParse(Console.ReadLine(), out valor))
            {
                //Voy a verificar si todos los numeros hasta llegar al valor que ingreso el usuario son centros
                for (int centro = 1; centro < valor; centro++)
                {
                    //Sumo todos los numeros desde el 1 hasta el centro, supongamos que el centro es 6, va a sumar 1+2+3+4+5 que da 15
                    sumaAntesCentro = 0;
                    for (int i = 1; i < centro; i++)
                    {
                        sumaAntesCentro += i;
                    }

                    //Verifico si es un centro, sumando todos los numeros apartir del centro hasta el valor ingresado
                    //Supongamos que ingrese el 100 y el centro que estoy verificando es el 6, entonces debo sumar 
                    //apartir del 7 hasta el 100, si alguna de esa suma coincide con la suma antes del centro es xq
                    //se confirma que el numero que estamos analizando es un centro, en este caso sumariamos 7+8 que da 15
                    //y es igual a la suma antes del centro por lo que el 6 (el numero que estamos verificando que sea centro) se confima como centro
                    sumaHastaElCentro = 0;
                    for (int j = centro + 1; j <= valor; j++)
                    {
                        //Cada vez que sumo verifico si las sumas son iguales, de ser asi brekeo xq ya encontre el centro
                        //si la suma supera a la suma antes del centro tambien brekeo xq ya se que no es centro
                        if ((sumaAntesCentro == sumaHastaElCentro) || (sumaHastaElCentro > sumaAntesCentro))
                        {
                            break;
                        }
                        else
                        {
                            sumaHastaElCentro += j;
                        }
                    }

                    //Verifico si el break fue xq encontre el centro y printeo
                    if (sumaAntesCentro == sumaHastaElCentro)
                    {
                        Console.WriteLine("Es un centro este numero {0}", centro);
                    }
                }
            }
            Console.WriteLine("No es numero");
        }
    }
}
