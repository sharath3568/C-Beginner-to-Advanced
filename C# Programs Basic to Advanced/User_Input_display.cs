using System;

namespace C__Programs_Basic_to_Advanced
{
    internal class User_Input_display
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your name : ");
            string? name = Console.ReadLine();
            Console.Write("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your salary : ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Hello {name}! You are {age} years old and earn ${salary:F2} per month.");
        }
    }
}
