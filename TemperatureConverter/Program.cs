using System;

namespace TemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Temperature Converter");
                Console.WriteLine("1. Celsius to Fahrenheit");
                Console.WriteLine("2. Fahrenheit to Celsius");
                Console.WriteLine("3. Exit");

                Console.Write("Enter choice (1/2/3): ");
                string choice = Console.ReadLine();

                if (choice == "3")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                double temperature;
                string inputUnit, outputUnit;

                if (choice == "1")
                {
                    Console.Write("Enter temperature in Celsius: ");
                    temperature = Convert.ToDouble(Console.ReadLine());
                    inputUnit = "Celsius";
                    outputUnit = "Fahrenheit";
                    Console.WriteLine($"{temperature}°C is {CelsiusToFahrenheit(temperature)}°F");
                    Console.WriteLine("");
                }
                else if (choice == "2")
                {
                    Console.Write("Enter temperature in Fahrenheit: ");
                    temperature = Convert.ToDouble(Console.ReadLine());
                    inputUnit = "Fahrenheit";
                    outputUnit = "Celsius";
                    Console.WriteLine($"{temperature}°F is {FahrenheitToCelsius(temperature)}°C");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("");
                    continue;
                }
            }
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
