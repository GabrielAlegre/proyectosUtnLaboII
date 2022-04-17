using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcFahrenheit
{
    public class Celsius
    {
        double temperatura;

        public Celsius(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public double Temperatura
        {
            get { return this.temperatura; }
        }


        //Implicit para instaciar un objeto.
        //ejemplo: Celsius miCelsius = 40
        public static implicit operator Celsius(double temp)
        {
            return new Celsius(temp);
        }

        //Metodo explicito para convertir grados celcius en Fahrenheit. Formula: F = C* (9/5) + 32
        //ejemplo: Fahrenheit miFahrenheit = (Fahrenheit)miCelsius
        public static explicit operator Fahrenheit(Celsius gradosCelsius)
        {
            return new Fahrenheit(gradosCelsius.temperatura * 9/5 +32);
        }

        //Metodo explicito para convertir grados celcius en kelvin. Formula: K = C + 273.15
        //ejemplo: Kelvin miKelvin = (Kelvin)miCelsius
        public static explicit operator Kelvin(Celsius gradosCelsius)
        {
            return new Kelvin(gradosCelsius.temperatura + 273.15);
        }
    }


}
