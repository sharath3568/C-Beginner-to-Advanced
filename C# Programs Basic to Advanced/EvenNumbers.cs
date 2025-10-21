using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Programs_Basic_to_Advanced
{
    internal class EvenNumbers
    {
        public static void Main(string[] args)
        {
            EvenNumbers obj = new EvenNumbers();
            Console.WriteLine("Enter the starting and ending numbers (inclusive) to list even numbers.");

            obj.listEvenNumber();
        }

        public int checkValidNumber()
        {
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

        public void listEvenNumber()
        {
            bool isRepeat = true;
            while (isRepeat)
            {
                Console.Write("Starting number: ");
                int start = checkValidNumber();

                Console.Write("Ending number: ");
                int end = checkValidNumber();

                bool valid = start < end ? true : false;
                if (valid)
                {
                    int count = 0;
                    Console.WriteLine($"Even Numbers between {start} and {end} are : ");
                    int firstEven = (start % 2 == 0) ? start : start + 1;
                    for (int i = firstEven; i <= end; i += 2)
                    {
                        count++;
                        Console.Write($"{i} ");
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine($"Total Even Numbers count : {count}");

                    isRepeat = IsRepeat();
                    if (isRepeat)
                    {
                        continue;
                    }
                    else
                    {
                        isRepeat = false;
                    }
                }
                else
                {
                    Console.WriteLine("Starting Number must be Less than Last number! Please try again");
                }
            }
        }

        public bool IsRepeat()
        {
            Console.WriteLine("Do you want to continue the operation? Please input Yes/No : ");
            string? response = Console.ReadLine();
            bool repeat = true;
            while (repeat)
            {
                if (string.Equals(response, "Yes", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else if (string.Equals(response, "No", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Exiting program. Goodbye!");
                    return false;
                }
                else
                {
                    Console.Write("Invalid Input! Please try again : ");
                    return true;
                }
            }
            return false;
        }
    }
}
