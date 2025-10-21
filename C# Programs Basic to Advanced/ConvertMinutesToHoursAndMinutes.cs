using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Programs_Basic_to_Advanced
{
    internal class ConvertMinutesToHoursAndMinutes
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter total minutes : ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int temp) && temp > 0)
                {
                    int totalMinutes = temp;

                    int hours = totalMinutes / 60;
                    int remainingMinutes = totalMinutes % 60;

                    Console.WriteLine($"{totalMinutes} minutes = {hours} hour(s) and {remainingMinutes} minute(s)");
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
