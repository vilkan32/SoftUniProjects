using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(ReturnDayOfTheWeek(n));
        }
        static string ReturnDayOfTheWeek(int input)
        {

            string[] daysoftheweek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", "Invalid Day!" };

            if (input >= 1 && input <= 7)
            {
                return daysoftheweek[input - 1];
            }
            else
            {
                return daysoftheweek[7];
            }
        }
    }
}
