using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Programs_Basic_to_Advanced
{
    internal class Factorial
    {
        public static void Main(String[] args)
        {
            Factorial obj = new Factorial();
            obj.run();

        }

        public void run()
        {
            bool continueProgress = true;
            while (continueProgress)
            {
                int input = GetValidNumber();
                Factorial_Logic(input);

                Console.Write("Do you want to Continue, Please enter Yes/No : ");
                string? response = Console.ReadLine();

                if (string.Equals(response, "Yes", StringComparison.OrdinalIgnoreCase))
                {
                    continueProgress = true;
                }
                else if(string.Equals(response, "No", StringComparison.OrdinalIgnoreCase))
                {
                    continueProgress = false;
                    Console.WriteLine("Program ended! Thank you for using Factorial calculator");
                }
                else
                {
                    Console.Write("Invalid Input! Please try again : ");
                }
            }
        }

        public int GetValidNumber()
        {
            Console.Write("Enter the number to find the factorial : ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int temp))
                {
                    if (temp <= 0)
                    {
                        Console.WriteLine("Factorial is not defined for negative numbers! Please try again");
                    }
                    else
                    {
                        return temp;
                    }
                }
                else
                {
                    Console.Write("Invalid input! Please try again : ");
                }
            }
        }

        public void Factorial_Logic(int number)
        {
            long result = 1;
            for(int i = 1; i <= number; i++)
            {
                result = result * i;
            }
            Console.WriteLine($"Factorial of {number} is = {result}");
        }
    }
}
