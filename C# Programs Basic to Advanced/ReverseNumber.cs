using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Programs_Basic_to_Advanced
{
    internal class ReverseNumber
    {
        ///6️ Reverse a Number(e.g., 123 → 321)
        //Requirement:
        //Input a number from the user.
        //Reverse the digits using a loop(extract remainder, build reversed number).
        //Handle negative numbers gracefully(keep the sign).
        //Example Input: 123
        //Example Output: Reversed Number = 321
        ///
        public static void Main(string[] args)
        {
            ReverseNumber obj = new ReverseNumber();
            bool isrepeat = true;
            while(isrepeat)
            {
                int value = obj.checkValid();
                int output = obj.Reverse(value);
                Console.WriteLine($"Original Number : {value}\nReverse Number : {output}");
                isrepeat = obj.isRepeat();
            }
        }

        public int checkValid()
        {
            Console.Write("Enter any number to get the reverse : ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int temp))
                {
                    return temp;
                }
                else
                {
                    Console.Write("Invalid Input! Please try again : ");
                }
            }
        }

        public int Reverse(int n)
        {
            n = Math.Abs(n);
            int reverse = 0;

            while (n != 0) 
            {
                int digit = n % 10; //quotient 123%10
                reverse = reverse * 10 + digit;
                n /= 10;
            }
            return reverse;
        }

        public bool isRepeat()
        {
            Console.Write("Do you want to do operation again? Please input Yes/No : ");
            while (true)
            {
                string? response = Console.ReadLine();
                if(string.Equals(response, "Yes", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else if(string.Equals(response, "No", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Exiting Program!");
                    return false;
                }
                else
                {
                    Console.Write("Invalid Input, Please enter Yes/No : ");
                }
            }
        }
    }
}
