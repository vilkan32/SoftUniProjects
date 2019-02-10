using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if (a>= 1 && a <= 7)
            {
                var dateOutput = new DateTime(2018, 10, a);
                Console.WriteLine(dateOutput.DayOfWeek);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
                
                
                


         
        }
    }
}
