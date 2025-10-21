using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__Programs_Basic_to_Advanced
{
    public class Swap_Two_Numbers
    {
        public static void Main(String[] args)
        {
            Swap_Two_Numbers obj = new Swap_Two_Numbers();
            Console.Write("Enter first Number : ");
            double firstNumber = obj.ReadPositiveDouble();
            Console.Write("Enter second number : ");
            double secondNumber = obj.ReadPositiveDouble();

            Console.WriteLine($"Before Swap: a = {firstNumber}, b = {secondNumber}");

            //firstNumber = firstNumber + secondNumber;
            //secondNumber = firstNumber - secondNumber;
            //firstNumber = firstNumber - secondNumber;

            (firstNumber, secondNumber) = (secondNumber, firstNumber); //Using tuple

            Console.WriteLine($"After Swap: a = {firstNumber}, b = {secondNumber}");

        }
        public double ReadPositiveDouble()
        {
            while (true)
            {
                double number;
                if (double.TryParse(Console.ReadLine(), out number))
                {
                    return number;
                }
                Console.WriteLine("Invalid value! Please try again");
                Console.WriteLine("Please enter the valid value");
            }
        }
    }

}
