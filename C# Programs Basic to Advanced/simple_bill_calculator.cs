using System; //Required for console input/output operations

namespace C__Programs_Basic_to_Advanced
{
    /// <summary>
    ///Class Name follows pascalCase convention for C# classes
    /// </summary>
    internal class SimpleBillCalculator
    {
        //Entry point of the progress
        public static void Main(String[] args)
        {
            //Creating an object of SimpleBillCalculator class to access non static methods
            SimpleBillCalculator obj = new SimpleBillCalculator();

            //Prompt the user to enter the item name
            Console.Write("Enter the Item Name : ");

            //Using a generic method Chk_Valid<T>() to validate input for a string
            string itemName = obj.Chk_Valid<string>();

            //Prompt the user to enter the item cost
            Console.Write("Enter the Item Cost : ");

            //Using generic method to validate input for decimal(money)
            decimal itemCost = obj.Chk_Valid<decimal>();

            //Prompt the user to enter quantity
            Console.Write("Enter the quantity : ");

            //Using generic method to validate input for integer quantity
            int quantity = obj.Chk_Valid<int>();

            //Display the total cost formatted to 2 decimal places
            Console.WriteLine($"Total cost for {quantity} {itemName} = ${(itemCost * quantity):F2}");
        }

        //Generic method to validate user input
        //<T> means this method can work with any data type (int, decimal, string, float, etc..)
        //Generic allos "Reusability" and reduce code duplication
        public T Chk_Valid<T>()
        {
            //Initialize value with default of type T (0 for numeric, null for reference types)
            T? value = default;
            //Boolean flag to control the input loop
            bool valid = false;

            //Loop until user enter the valid input
            while (!valid)
            {
                //Read user input from console
                string? input = Console.ReadLine();

                try
                {
                    //Checks if T is int
                    if (typeof(T) == typeof(int))
                    {
                        //Try to parse input as integer
                        valid = int.TryParse(input, out int temp);

                        //Convert int to generic type T (boxing/unboxing needed)
                        value = (T)(object)temp;
                    }

                    //Check if T is decimal
                    else if(typeof(T) == typeof(decimal))
                    {
                        //Try parsing input as decimal
                        valid = decimal.TryParse(input, out decimal temp);

                        //Convert decimal to generic type T
                        value = (T)(object)temp;
                    }

                    //Check if T is string
                    else if(typeof(T) == typeof(string))
                    {
                        //For string, check that input is not null or whitespace
                        if (!string.IsNullOrWhiteSpace(input))
                        {
                            valid = true;
                            value = (T)(object)input;
                        }
                    }

                    //If input is invalid, display an error message
                    if (!valid)
                    {
                        Console.WriteLine("Invalid Input! Please try again");
                    }
                }
                catch
                {
                    //Catch any unexpected errors during conversion
                    valid = false;
                    Console.WriteLine("Invalid Input, Please try again");
                }
            }

            //Return the validated input of type T
            return value;
        }
    }
}
