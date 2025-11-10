using System;
using System.Text.RegularExpressions;

namespace C__Programs_Basic_to_Advanced.Strings.Advanced
{
    /// <summary>
    /// Program will perform below operation
    /// 1. Longest Word in sentence
    /// 2. check if 2 strings are Anagram
    /// 3. Remove Duplicate characters
    /// 4. Capitalize the first letter of each word
    /// 5. Find all substrings of a given string
    /// </summary>
    static internal class StringOperations
    {
        public static void Main(string[] args)
        {
            bool isRepeat = true;
            while (isRepeat)
            {
                int operation = CheckOperation();
                string input = CheckValid();

                PerformOperation(operation, input);
                isRepeat = CheckRepeat();
            }
        }

        public static int CheckOperation()
        {
            Console.WriteLine("1.Longest word in given sentence");
            Console.WriteLine("2.Check if 2 strings are anagrams");
            Console.WriteLine("3.Remove duplicate characters");
            Console.WriteLine("4.Capitalize the first letter of each word");
            Console.WriteLine("5.Find all substrings of a given string");
            Console.Write("Select the Operation you want to perform : ");

            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out int temp) && (temp >= 1 && temp <= 5))
                {
                    return temp;
                }
                else
                {
                    Console.WriteLine("Invalid Input! Please enter value between 1 and 5");
                }
            }
        }

        public static string CheckValid()
        {
            string? input;
            Console.Write("Provide the input : ");
            while (true)
            {
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.Write("Input cannot be empty! Please try again : ");
                    continue;
                }

                if (Regex.IsMatch(input, @"^[A-Za-z ]+$"))
                {
                    return input.Trim();
                }
                else
                {
                    Console.Write("Invalid Input! Please try again : ");
                }
            }
        }

        public static bool CheckRepeat()
        {
            Console.Write("Do you want to perform another operation? Please input Yes/No : ");
            while (true)
            {
                string? response = Console.ReadLine();

                if (string.Equals(response, "Yes", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else if (string.Equals(response, "No", StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
                else
                {
                    Console.Write("Invalid Input! Please try again : ");
                }
            }
        }

        public static void PerformOperation(int operation, string input)
        {
            switch (operation)
            {
                case 1:
                    LongestWord(input);
                    break;

                case 2:
                    CheckAnagram(input);
                    break;

                case 3:
                    RemoveDuplicate(input);
                    break;

                case 4:
                    CapitalizeFirstLetter(input);
                    break;

                case 5:
                    FindSubstrings(input);
                    break;
            }
        }

        public static void LongestWord(string input)
        {
            string[] words = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string longest = words[0];
            foreach(var word in words)
            {
                if(word.Length > longest.Length)
                {
                    longest = word;
                }
            }

            Console.WriteLine($"Longest Word in {input} : {longest}");
        }

        public static void CheckAnagram(string input)
        {

        }

        public static void RemoveDuplicate(string input)
        {

        }

        public static void CapitalizeFirstLetter(string input)
        {

        }

        public static void FindSubstrings(string input)
        {

        }
    }

}
