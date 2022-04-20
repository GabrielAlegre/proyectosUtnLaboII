using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcVulcano
{
    public class Kelvin
    {
        double temperatura;

        public Kelvin(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public double Temperatura
        {
            get { return this.temperatura; }
        }


        public static implicit operator Kelvin(double temp)
        {
            return new Kelvin(temp);
        }

        //Formula: K * 9/5 – 459.67
        public static explicit operator Fahrenheit(Kelvin gradosKelvin)
        {
            return new Fahrenheit(gradosKelvin.temperatura * 9 / 5 - 459.67);
        }

        //65 K − 273.15 = -208,1 °C

        public static explicit operator Celsius(Kelvin gradosKelvin)
        {
            return new Celsius(gradosKelvin.temperatura - 273.15);
        }
    }
}
