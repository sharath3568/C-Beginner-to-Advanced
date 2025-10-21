using System;
using System.Security.Cryptography.X509Certificates;

namespace C__Programs_Basic_to_Advanced
{
    internal class Area_Perimeter_Rectangle
    {
        public static void Main(String[] args)
        {
            double length, width;
            Console.Write("Enter the Length : ");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out length) && length > 0)
                {
                    break;
                }
                Console.WriteLine("Invalid Length parameter, Please try again");

            }

            Console.Write("Enter the Width : ");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out width) && width > 0)
                {
                    break;
                }
                Console.WriteLine("Invalid Width parameter, Please try again");
            }

            double area = length * width;
            double perimeter = 2 * (length + width);
            Console.WriteLine($"Area of Rectangle = {area} \nPerimeter of Rectangle {perimeter}");

        }
    }
}
