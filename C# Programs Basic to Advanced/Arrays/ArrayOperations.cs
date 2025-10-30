using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace C__Programs_Basic_to_Advanced.Arrays
{
    ///
    //Program contains logic of
    //1.Count of Even & Odd
    //2.Count of Positive & Negative
    //3.Duplicate elements and
    //4.Sorting of the array
    ///
    internal class ArrayOperations
    {
        public static void Main(String[] args)
        {
            bool isRepeat = true;
            while (isRepeat)
            {
                Console.WriteLine("Enter the size of an array");
                int n = Convert.ToInt32(CheckValid("size"));
                float[] numbers = new float[n];
                Console.WriteLine("Enter the list of elements");
                for (int i = 0; i < n; i++)
                {
                    numbers[i] = CheckValid("value");
                }
                int operation = CheckOperation();
                switch (operation)
                {
                    case 1:
                        CountEvenOdd(numbers);
                        break;
                    case 2:
                        PositiveNegative(numbers);
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
                isRepeat = CheckRepeat();
            }
        }

        public static float CheckValid(string input)
        {
            while (true)
            {
                if(float.TryParse(Console.ReadLine(), out float temp))
                {
                    if(input == "size" && temp > 0)
                    {
                        return temp;
                    }
                    else if(input == "value")
                    {
                        return temp;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input! Please try again");
                    }
                }
            }
        }

        public static int CheckOperation()
        {
            Console.WriteLine("Select the operation you want to perform \n1.Count of Odd & Even \n2.Count of Positive & Negative \n3.Duplicate Elements List \n4.Sorting of the array");
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out int value) && (value >=1 && value <=4))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Invalid Input! Please select any of the given options");
                }
            }
        }

        public static bool CheckRepeat()
        {
            Console.WriteLine("Do you want to perform another Operation, Please answer Yes/No");
            while (true)
            {
                string? response = Console.ReadLine();
                if(string.Equals(response, "Yes", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else if(string.Equals(response, "No", StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid Input! Please try again");
                }
            }
        }

        public static void CountEvenOdd(params float[] numbers)
        {
            int evenCount = (Array.FindAll(numbers, n => n % 2 == 0)).Length;
            int oddCount = numbers.Length - evenCount;
            Console.WriteLine($"Count of Even Numbers : {evenCount}");
            Console.WriteLine($"Count of Odd Numbers : {oddCount}");
        }

        public static void PositiveNegative(params float[] numbers)
        {
            int positiveCount = (Array.FindAll(numbers, n => n >= 0)).Length;
            int negativeCount = (Array.FindAll(numbers, n => n < 0)).Length;
            Console.WriteLine($"Count of Positive Numbers : {positiveCount}");
            Console.WriteLine($"Count of Negative Numbers : {negativeCount}");
        }
    }
}