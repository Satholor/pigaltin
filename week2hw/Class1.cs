using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2hw
{
    class Class1
    {
        // Initializing Variables
        double farenheit;
        double celsius;

        // Getting input to initialize Farenheit value
        Console.Write("Enter a number to convert to Celsius: ");
            farenheit = Int32.Parse(Console.ReadLine());

        // Perform conversion using formula
            celsius = Math.Round(5 * (farenheit - 32) / 9, 1);

        // Display results to user
            Console.WriteLine("{0}°F = {1}°C", farenheit, celsius);
    }
}
