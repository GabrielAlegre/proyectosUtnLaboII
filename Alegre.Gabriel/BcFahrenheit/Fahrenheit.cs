using System;

namespace BcFahrenheit
{
    public class Fahrenheit
    {
        double temperatura;

        public Fahrenheit(double temperatura)
        {
            //TODO: 1- HACER
            this.temperatura = temperatura;
        }

        public double Temperatura
        {
            get { return this.temperatura; }
            set { temperatura = value; }
        }


        public static implicit operator Fahrenheit(double temp)
        {
            return new Fahrenheit(temp);
        }

        //Formula: ( °F − 32) × 5/9 + 273.15 =  K
       
        public static explicit operator Kelvin(Fahrenheit gradosKelvin)
        {
            return new Kelvin((gradosKelvin.temperatura -32)* 5/9 +273.15);
        }

        //C = (F-32) * 5/9
        public static explicit operator Celsius(Fahrenheit gradosKelvin)
        {
            return new Celsius((gradosKelvin.temperatura - 32) * 5 / 9);
        }
    }
}
