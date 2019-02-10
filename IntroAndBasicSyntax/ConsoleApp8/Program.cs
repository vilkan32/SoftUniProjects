using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            try
            {
                DateTime Time = new DateTime(2018, number, 1);
                Console.WriteLine(Time.ToString("MMMM", System.Globalization.CultureInfo.InvariantCulture));
            }

            catch (Exception)
            {
                Console.WriteLine("Error!");
            }



        }
    }
}
