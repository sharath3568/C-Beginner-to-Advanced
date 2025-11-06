using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C__Programs_Basic_to_Advanced.Strings
{
    internal class ReverseandPalindrome
    {
        public static void Main(string[] args)
        {
            bool isRepeat = true;
            while (isRepeat)
            {
                int operation = CheckOperation();
                string? input = CheckValidInput();
                if (operation == 1)
                {
                    string? result = Reverse(input);
                    Console.WriteLine($"Reverse of the given string : {result}");
                }
                else
                {
                    bool result = Palindrome(input);
                    if (result)
                    {
                        Console.WriteLine($"Given string '{input}' is a Palindrome");
                    }
                    else
                    {
                        Console.WriteLine($"Given string '{input}' is not a palindrome");
                    }
                }
                isRepeat = CheckRepeat();
            }
        }

        public static int CheckOperation()
        {
            Console.WriteLine("1.Reverse \n2.Check Palindrome");
            Console.Write("Select the operation you want to perform : ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int temp) && (temp == 1 || temp == 2))
                {
                    return temp;
                }
                else
                {
                    Console.Write("Invalid Input! Please select the operation : ");
                }
            }
        }

        public static string CheckValidInput()
        {
            Console.Write("Provide a single word with no spaces : ");
            while (true)
            {
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input) || string.IsNullOrEmpty(input))
                {
                    Console.Write("Input cannot be Empty! Please try again : ");
                    continue;
                }

                if (!Regex.IsMatch(input, @"^[A-Za-z]+$"))
                {
                    Console.Write("Invalid input! Only Alphabets are allowed, Please try again : ");
                    continue;
                }

                return input;
            }
        }

        public static bool CheckRepeat()
        {
            Console.Write("Do you want to perform another operation! Please enter Yes/No : ");
            while (true)
            {
                string? response = Console.ReadLine();
                if (string.Equals(response, "Yes", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else if (string.Equals(response, "No", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Exiting Program............");
                    return false;
                }
                else
                {
                    Console.Write("Invalid Input! Please try again : ");
                }
            }
        }

        public static string Reverse(string input)
        {
            //string[] reverse = Array.Empty<string>(); //Declaring Empty string
            char[] reverse = input.ToCharArray();
            for (int i = input.Length - 1, j = 0; i >= 0; i--, j++)
            {
                reverse[j] = input[i];
            }
            return new string(reverse);
        }

        public static bool Palindrome(string input)
        {
            input = input.ToLower();
            string reverse = Reverse(input);
            bool result = string.Equals(reverse, input);
            return result;
        }
    }
}
