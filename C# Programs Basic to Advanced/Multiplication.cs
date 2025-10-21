using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Programs_Basic_to_Advanced
{
    internal class Multiplication
    {
        public static void Main(String[] args)
        {
            Multiplication obj = new Multiplication();
            obj.run();
        }

        public void run()
        {
            bool continueProgram = true;
            while (continueProgram)
            {
                int number = GetValidNumber();
                Multiplication_Logic(number);
                Console.Write("Do you want another table Please answer Yes/No : ");
                string? response = Console.ReadLine();

                if(string.Equals(response, "yes", StringComparison.OrdinalIgnoreCase)) 
                {
                    continueProgram = true;
                }
                else if(string.Equals(response, "No", StringComparison.OrdinalIgnoreCase))
                {
                    continueProgram = false;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please try again");
                }
            }
        }

        public int GetValidNumber()
        {
            while (true)
            {
                Console.Write("Enter the Number to get the Multiplication table : ");
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    return input;
                }
                Console.WriteLine("Invalid Input! Please try again");
            }

        }

        public void Multiplication_Logic(int value)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{value} X {i} = {value * i}");
            }
        }
    }
}
