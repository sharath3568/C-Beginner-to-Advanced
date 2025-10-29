using System;

namespace C__Programs_Basic_to_Advanced
{
    internal class MinMaxElement
    {
        public static void Main(String[] args)
        {
            bool isRepeat = true;
            while (isRepeat)
            {
                Console.Write("Enter the size of the array : ");
                int n = CheckValid("size");
                Console.WriteLine("Enter the list of elements");
                int[] number = new int[n];
                for (int i = 0; i < n; i++)
                {
                    number[i] = CheckValid("value");
                }
                int operation = CheckOperation();
                if(operation == 1)
                {
                    int maximum = MaxElement(number);
                    Console.WriteLine($"Maximum element in the array is {maximum}");
                }
                else
                {
                    int minimum = MinElement(number);
                    Console.WriteLine($"Minimum element in the array is {minimum}");
                }
                Console.WriteLine("\n");
                isRepeat = CheckRepeat();
            }
        }

        public static int CheckValid(string inputType)
        {
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out int temp))
                {
                    if(inputType == "size" && temp > 0)
                    {
                        return temp;
                    }
                    else if(inputType == "value")
                    {
                        return temp;
                    }
                    else
                    {
                        Console.Write("Size must be greater than zero : ");
                    }
                }
                else
                {
                    Console.Write("Invalid Input! Please try again : ");
                }
            }
        }

        public static bool CheckRepeat()
        {
            Console.Write("Do you want perform this operation again? Please input Yes/No : ");
            while (true)
            {
                string? response = Console.ReadLine();
                if (string.Equals(response, "Yes", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else if(string.Equals(response, "No", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Exiting Program...........");
                    return false;
                }
                else
                {
                    Console.Write("Invalid Input! Please try again : ");
                }
            }
        }

        public static int CheckOperation()
        {
            Console.WriteLine("Select the operation you want to perform\n \n1.Maximum Element in array \n2.Minimum Element in array\n");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int temp) && (temp >= 1 && temp <= 2))
                {
                    return temp;
                }
                else
                {
                    Console.Write("Invalid Input! Please select either 1 or 2 : ");
                }
            }
        }

        public static int MinElement(params int[] numbers)
        {
            int minElement = numbers[0];
            for(int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < minElement)
                {
                    minElement = numbers[i];
                }
            }
            return minElement;
        }

        public static int MaxElement(params int[] numbers)
        {
            int maxElement = numbers[0];
            for(int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxElement)
                {
                    maxElement = numbers[i];
                }
            }
            return maxElement;
        }
    }
}
