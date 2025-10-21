using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Programs_Basic_to_Advanced
{
    internal class CountDigits
    {
        //5️⃣ Count Digits in a Number
        ///Requirement:
            //Input a number from the user(e.g., 12345).
            //Count how many digits it has using a loop(by dividing by 10).
            //Handle edge cases:
            //Negative number → count digits without the minus sign.
            //0 → should count as 1 digit.
            //Example Input: 12345
            //Example Output: Number of digits = 5

        public static void Main(string[] args)
        {
            CountDigits obj = new CountDigits();
            bool isRepeat = true;
            while (isRepeat)
            {
                obj.countDigits(); 
                isRepeat = obj.isRepeat();
            }
        }

        public int checkValidNumber()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int temp) && temp >= 0)
                {
                    return temp;
                }
                else
                {
                    Console.Write("Invalid Input! Please try again : ");
                }
            }
        }

        public void countDigits()
        {
            Console.Write("Enter the positive number to find the number of digits present : ");
            int number = checkValidNumber();

            number = Math.Abs(number);

            if (number == 0)
            {
                Console.WriteLine("Number of Digits : 1");
                return;
            }

            int count = 0;
            while(number != 0)
            {
                number = number / 10;
                count++;
            }
            Console.WriteLine($"Number of Digits : {count}");
        }

        public bool isRepeat()
        {
            Console.Write("Do you want to continue the operation? Please input Yes/No : ");
            while (true)
            {
                string? response = Console.ReadLine();
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
                    Console.Write("Invalid Input! Please input Yes or No : ");
                }
            }
        }
    }
}
