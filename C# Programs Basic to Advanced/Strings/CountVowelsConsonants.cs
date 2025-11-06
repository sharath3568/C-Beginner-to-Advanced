using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Programs_Basic_to_Advanced.Strings
{
    internal class CountVowelsConsonants
    {
        public static void Main(String[] args)
        {
            bool isRepeat = true;
            while (isRepeat)
            {
                Console.Write("Enter the string to get the count of vowels and Consonants : ");
                string? input = CheckValid();
                Count_VowelsConsonants(input);
                isRepeat = CheckRepeat();
            }
        }

        public static string CheckValid()
        {
            string? input;
            while (true)
            {
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.Write("Input cannot be empty! Please try again : ");
                }
                else
                {
                    return input;
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
                    Console.WriteLine("Exiting Program............");
                    return false;
                }
                else
                {
                    Console.Write("Invalid Input! please try again : ");
                }
            }
        }

        public static void Count_VowelsConsonants(string? input)
        {
            int vowels = 0, consonants = 0;
            if (!string.IsNullOrEmpty(input)) {
                input = input.ToLower();
                char[] vowel = { 'a', 'e', 'i', 'o', 'u' };
                char[] charArray = input.ToCharArray();
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsLetter(charArray[i]))
                    {
                        if (vowel.Contains(charArray[i]))
                        {
                            vowels++;
                        }
                        else
                        {
                            consonants++;
                        }
                    }
                }
            }

            Console.WriteLine($"Given String : {input}");
            Console.WriteLine($"Vowel Count : {vowels}");
            Console.WriteLine($"Consonant Count : {consonants}");
        }
    }
}
