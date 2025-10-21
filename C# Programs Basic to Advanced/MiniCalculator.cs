using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace C__Programs_Basic_to_Advanced
{
    internal class MiniCalculator
    {
        public static void Main(String[] args)
        {
            MiniCalculator obj = new MiniCalculator();
            Console.WriteLine("Select the operation you want to perform");
            Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.Modulus");

            obj.Operation();

        }

        public T Chk_ValidValue<T>()
        {
            T? value = default;
            bool valid = false;

            while (!valid)
            {
                string? input = Console.ReadLine();

                try
                {
                    if (typeof(T) == typeof(double))
                    {
                        valid = double.TryParse(input, out double temp);
                        value = (T)(object)temp;
                    }

                    if (!valid)
                    {
                        Console.WriteLine("Invalid Value, Please try again");
                    }
                }
                catch
                {
                    valid = false;
                    Console.WriteLine("Invalid Input, Please try again");
                }
            }
            return value;
        }

        public void Operation()
        {
            bool valid;
            double firstNumber, secondNumber;
            valid = true;
            while (valid)
            {
                double operation = Chk_ValidValue<double>();
                if (operation <= 0 || operation > 5)
                {
                    Console.WriteLine("Invalid Input! Please provide a value between 1 and 5.");
                }
                else
                {
                    Console.WriteLine("Provide 2 values to do the operation");
                    Console.Write("Enter the First Number : ");
                    firstNumber = Chk_ValidValue<double>();

                    Console.Write("Enter the Second Number : ");
                    secondNumber = Chk_ValidValue<double>();

                    if (operation == 1)
                    {
                        Console.WriteLine($"Addition = {firstNumber + secondNumber}");
                    }
                    else if (operation == 2)
                    {
                        Console.WriteLine($"Subtraction = {firstNumber - secondNumber}");
                    }
                    else if (operation == 3)
                    {
                        Console.WriteLine($"Multiplication = {firstNumber * secondNumber}");
                    }
                    else if (operation == 4)
                    {
                        if(secondNumber == 0)
                        {
                            Console.WriteLine("Cannot divide by zero. Please enter a non-zero value.");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"Division = {firstNumber / secondNumber}");
                        }
                    }
                    else
                    {
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("Cannot divide by zero. Please enter a non-zero value.");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"Modulus = {firstNumber % secondNumber}");
                        }
                    }

                    Console.WriteLine("Do you want to do the operation again, Please enter Yes/No");
                    string? input = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(input))
                    {
                        if (input.ToLower() == "yes")
                        {
                            Console.WriteLine("Select the operation you want to perform");
                            Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.Modulus");
                        }
                        else if (input.ToLower() == "no")
                        {
                            valid = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input! Please try again");
                        }
                    }
                }
            }
        }
    }
}
