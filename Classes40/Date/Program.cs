using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var date = DateTime.ParseExact(input, "d-M-yyyy", System.Globalization.CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);


        }
    }
}
