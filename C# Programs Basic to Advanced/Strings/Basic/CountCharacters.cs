using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C__Programs_Basic_to_Advanced.Strings.Basic
{
    internal class CountCharacters
    {
        public static void Main(string[] args)
        {
            bool isRepeat = true;
            while (isRepeat)
            {
                Console.Write("Enter the string to count the characters : ");
                string? input = CheckValid();
                int count = Count_Characters(input);
                Console.WriteLine($"Count of Characters in given string {input} : {count}");
                isRepeat = CheckRepeat();
            }
        }

        public static string CheckValid()
        {
            string? input;

            while (true)
            {
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.Write("Input cannot be empty! Please try again : ");
                    continue;
                }
                
                if(Regex.IsMatch(input, @"^[A-Za-z ]+$"))
                {
                    return input;
                }
                else
                {
                    Console.Write("Invalid Input! Please try again : ");
                }
            }
        }

        public static bool CheckRepeat()
        {
            Console.Write("Do you want to repeat the operation? Please input Yes/No : ");
            while (true)
            {
                string? response = Console.ReadLine();
                if (string.Equals(response, "Yes", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else if (string.Equals(response, "No", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Exiting Program..........");
                    Console.WriteLine("\n");
                    return false;
                }
                else
                {
                    Console.Write("Invalid Input! Please try again : ");
                }
            }
        }

        public static int Count_Characters(string? input)
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                char[] charArray = input.ToCharArray();
                //return input.Replace(" ", "").Length;
                return input.Count(char.IsLetter);
            }
            return 0;
        }
    }
}
