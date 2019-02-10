using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string date = "2011" + "/" + input + "/" + "2";

            DateTime date1 = DateTime.Parse(date);
            Console.WriteLine(date1.ToString("MMMM",
                   System.Globalization.CultureInfo.InvariantCulture));





        }
    }
}
