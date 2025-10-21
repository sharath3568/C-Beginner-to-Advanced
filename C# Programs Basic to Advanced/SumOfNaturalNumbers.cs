using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Programs_Basic_to_Advanced
{
    internal class SumOfNaturalNumbers
    {
        public static void Main()
        {
            SumOfNaturalNumbers obj = new SumOfNaturalNumbers();
            obj.CheckValidNumber();
        }
        public void CheckValidNumber()
        {
            Console.Write("Enter any positive number : ");
            while (true)
            {
                bool value = int.TryParse(Console.ReadLine(), out int temp) && temp > 0;
                if (value)
                {
                    NaturalNumbers(temp);
                    break;
                }
                else
                {
                    Console.Write("Enter any positive number : ");
                }
            }
        }

        public void NaturalNumbers(int value)
        {
            //for (int i = 1; i <= value; i++)
            //{
            //    sum = sum + i;
            //}
            //Can replace for loop with this formula
            int sum = (value * (value + 1)) / 2;
            Console.WriteLine($"Sum of first {value} natural numbers = {sum}");
            IsRepeat();
        }

        public void IsRepeat()
        {
            Console.Write("Do you want to continue? Please Provide Input as Yes/No : ");
            bool repeat = true;
            while (repeat)
            {
                string? response = Console.ReadLine();
                if (string.Equals(response, "Yes", StringComparison.OrdinalIgnoreCase))
                {
                    CheckValidNumber();
                }
                else if (string.Equals(response, "No", StringComparison.OrdinalIgnoreCase))
                {
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input! Please try again");
                }
            }
        }
    }
}
