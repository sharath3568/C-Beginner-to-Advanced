using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Programs_Basic_to_Advanced
{
    internal class printArray
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the count of the numbers you want to enter : ");
            int count = checkValid();
            int[] number = new int[count];

            Console.WriteLine("Enter the Numbers : ");
            for(int i = 0; i < count; i++)
            {
                number[i] = checkValid();
            }

            Console.WriteLine("Numbers you have entered are : ");
            for(int i = 0; i < count; i++)
            {
                Console.Write($"{number[i]} ");
            }
        }

        public static int checkValid()
        {
            while (true) {
                bool check = int.TryParse(Console.ReadLine(), out int value);
                if (check && value > 0) {
                    return value;
                }
                else
                {
                    Console.Write("Invalid input! Please try again : ");
                }
            }
        }
    }
}
