using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Programs_Basic_to_Advanced
{
    internal class Temperature_Converter
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Select the conversion type\n 1.Celsius -> Fahrenheit \n 2.Fahrenheit -> Celsius");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.Write("Enter the temperature in celsius : ");
                float celsius = float.Parse(Console.ReadLine());
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{celsius}C = {fahrenheit:F2}F");
            }
            else if (choice == 2)
            {
                Console.Write("Enter the temperature in fahrenheit : ");
                float fahrenheit = float.Parse(Console.ReadLine());
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"{fahrenheit}F = {celsius:F2}C");
            }
            else
            {
                Console.WriteLine("Invalid choice! Please enter 1 or 2.");
            }
        }
    }
}
