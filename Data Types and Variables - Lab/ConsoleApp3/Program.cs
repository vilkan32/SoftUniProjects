using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            string nameoftheunit = Console.ReadLine();

            decimal value = decimal.Parse(Console.ReadLine());
            decimal number = 0.0m;

            if (nameoftheunit == "miles")
            {
                number =(value * 1.6m);
                Console.WriteLine("{1} miles = {0:f2} kilometers", number, value);
            }
            else if (nameoftheunit == "inches")
            {
                number = (value) * 2.54m;
                Console.WriteLine("{1} inches = {0:f2} centimeters", number, value);
            }
            else if (nameoftheunit == "feet")
            {
                number = (value) * 30.00m;
                Console.WriteLine("{1} feet = {0:f2} centimeters", number, value);
            }
            else if (nameoftheunit == "yards")
            {
                number = (value) * 0.91m;
                Console.WriteLine("{1} yards = {0:f2} meters", number, value);
            }
            else if (nameoftheunit == "gallons")
            {
                number = value * 3.8m;
                Console.WriteLine("{1} gallons = {0:f2} liters", number, value);
            }

        }
    }
}
