using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Programs_Basic_to_Advanced.Strings.Intermediate
{
    /// <summary>
    /// Program will Perform below operation
    /// 1.Count occurrences of a given character
    /// 2.Replace all spaces with hyphens
    /// 3.Remove all white spaces from a string
    /// 4.Find the number of words in a string
    /// 5.Find frequency of each character
    /// </summary>
    internal class StringOperations
    {
        public static void Main(string[] args)
        {
            bool isRepeat = true;
            while (isRepeat)
            {
                int operation = CheckOperation();
                Console.Write("Provide the input : ");
                string? input = CheckStringInput();
                PerformOperation(operation, input);
                Console.Write("Do you want to Perform Another operation! Please provide Yes/No : ");
                isRepeat = CheckRepeat();
            }
        }

        public static int CheckOperation()
        {
            Console.WriteLine("1.Count occurences of a given character");
            Console.WriteLine("2.Replace all spaces with hyphens");
            Console.WriteLine("3.Remove all white spaces from a string");
            Console.WriteLine("4.Find the number of words in a string");
            Console.WriteLine("5.Find frequency of each character\n");
            Console.Write("Select the operation you want to perform : ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int temp) && (temp >= 1 && temp <= 5))
                {
                    return temp;
                }
                else
                {
                    Console.Write("Invalid Input! Please provide input between 1 & 5 : ");
                }
            }
        }

        public static string CheckStringInput()
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

                if (Regex.IsMatch(input, @"^[A-Za-z ]+$"))
                {
                    return input;
                }
                else
                {
                    Console.Write("Invalid Input! please try again : ");
                }
            }
        }

        public static char CheckCharInput()
        {
            Console.Write("Enter the character to count : ");

            while (true)
            {
                string? input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.Write("Provide input Cannot be empty! Please try again : ");
                    continue;
                }

                if(input.Length != 1)
                {
                    Console.Write("Input cannot be more than one character! Please try again : ");
                    continue;
                }

                if (char.IsLetter(input[0]))
                {
                    return input[0];
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
                    CountOccurences(input);
                    break;

                case 2:
                    ReplaceSpaceHyphens(input);
                    break;

                case 3:
                    RemoveWhiteSpace(input);
                    break;

                case 4:
                    CountWords(input);
                    break;

                case 5:
                    FrequencyOfCharacter(input);
                    break;
            }
        }
        public static bool CheckRepeat()
        {
            while (true)
            {
                string? response = Console.ReadLine();
                if (string.Equals(response, "Yes", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else if (string.Equals(response, "No", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Exiting Program..................");
                    return false;
                }
                else
                {
                    Console.Write("Invalid Input! Please try again : ");
                }
            }
        }

        //Operation to find the Occurrences of the Given character in the string
        public static void CountOccurences(string input)
        {
            char character = char.ToLower(CheckCharInput());
            input = input.ToLower();

            int count = 0;
            foreach(char c in input)
            {
                if(c == character)
                {
                    count++;
                }
            }

            Console.WriteLine($"\nProvided character '{character}' repeated '{count}' times in this '{input}'\n");
        }

        //Operation to replace the whitespace with hyphens in the given string
        public static void ReplaceSpaceHyphens(string input)//sharath kumar
        {
            input = input.Trim();

            while (true)
            {
                if (!input.Contains(" "))
                {
                    Console.Write("Provide input with spaces! Please try again : ");
                    input = CheckStringInput();
                }

                string result = input.Replace(" ", "-");
                Console.WriteLine($"Original Input '{input}' \nModified Input '{result}'");
                break;
            }
        }

        //Operation to remove whitespace in the given string
        public static void RemoveWhiteSpace(string input)
        {
            input = input.Trim();

            while (true) {
                if (!input.Contains(" "))
                {
                    Console.WriteLine("Input doesnt have the Whitespace");
                    Console.Write("Do you want to provide another input? Please provide Yes/No : ");
                    if (CheckRepeat())
                    {
                        input = CheckStringInput();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                //string result = Regex.Replace(input, @"\s+", ""); -- This will remove multiple whitespaces, tabs, New lines
                string result = input.Replace(" ", ""); //This only removes single whitespace

                Console.WriteLine($"Original Input '{input}' \nModified Input '{result}'");
                break;
            }
        }

        public static void CountWords(string input)
        {
            int count = 0;
            //input = input.Trim(); //will remove the whitespaces at the start and end of the string

            //Trim the input that will remove extra whitespaces
            string[] words = Regex.Split(input.Trim(), @"\s+");

            //same as normal way but it will remove values from arrray which has empty string
            //string[] output = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //Normal way to get the result
            //string[] result = input.Split(" ");
            //foreach(var c in result)
            //{
            //    if( c != "")
            //    {
            //        count++;
            //    }
            //}
            count = words.Length;
            Console.WriteLine($"Words present in {input} : {count} ");
        }

        public static void FrequencyOfCharacter(string input)
         {
            input = (Regex.Replace(input, @"\s+","")).ToLower();
            string unique = new string(input.Distinct().ToArray());
            Console.WriteLine($"Frequency of each character in the given {input} : ");
            for (int i = 0; i < unique.Length; i++)
            {
                int count = input.Count(c => c.Equals(unique[i]));
                Console.Write($"{unique[i]} : {count} | ");
            }
            Console.WriteLine("\n");
        }
    }
}
