using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace C__Programs_Basic_to_Advanced.Arrays
{
    internal class IsPrime
    {
        public static void Main(string[] args)
        {
            IsPrime obj = new IsPrime();
            bool isRepeat = true;
            while (isRepeat)
            {
                int value = CheckValid();
                bool result = CheckPrime(value);
                Console.WriteLine(result ? $"{value} is a Prime number" : $"{value} is not a Prime Number");
                isRepeat = Repeat();
            }
        }

        public static int CheckValid()
        {
            Console.Write("Enter the Number to Check if its prime number : ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int temp) && temp > 0)
                {
                    return temp;
                }
                else
                {
                    Console.Write("Invalid Input! Please try again : ");
                }
            }
        }

        public static bool CheckPrime(int value)
        {
            if (value <= 1)
            {
                return false;
            }
            for(int i = 2; i <= Math.Sqrt(value); i++)
            {
                if( value % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool Repeat()
        {
            Console.Write("Do you want to repeat the operation! Please provide Yes/No : ");
            while (true)
            {
                string? response = Console.ReadLine();
                if (string.Equals(response, "Yes", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else if (string.Equals(response, "No", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Exiting Program.....");
                    return false;
                }
                else
                {
                    Console.Write("Invalid Input! Please try again : ");
                }
            }
        }
    }
}
