using System;
using BcFahrenheit;

namespace PooA01Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrenheit miFahrenheit = 100;
            Celsius miCelsius = 18;
            Kelvin miKelvin = 373.12;

            //De Fahrenheit a celsius y kelvin
            Console.WriteLine($"Mis {miFahrenheit.Temperatura} grados Fahrenheit son: {((Celsius)miFahrenheit).Temperatura} grados Celcius");
            Console.WriteLine($"Mis {miFahrenheit.Temperatura} grados Fahrenheit son: {((Kelvin)miFahrenheit).Temperatura} grados Kelvin");

            //De Celsius a Fahrenheit y kelvin
            Console.WriteLine($"\nMis {miCelsius.Temperatura} grados Celsius son: {((Fahrenheit)miCelsius).Temperatura} grados Fahrenheit");
            Console.WriteLine($"Mis {miCelsius.Temperatura} grados Celsius son: {((Kelvin)miCelsius).Temperatura} grados Kelvin");

            //De Kelvin a Fahrenheit y Celsius
            Console.WriteLine($"\nMis {miKelvin.Temperatura} grados kelvin son: {((Celsius)miKelvin).Temperatura} grados Celcius");
            Console.WriteLine($"Mis {miKelvin.Temperatura} grados kelvin son: {((Fahrenheit)miKelvin).Temperatura} grados Fahrenheit");
            
        }
    }
}
