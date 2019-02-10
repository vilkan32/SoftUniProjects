using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            double Money = double.Parse(Console.ReadLine());
            double Numberofstudents = double.Parse(Console.ReadLine());
            double lightsabers = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());

            double variable = Math.Ceiling(Numberofstudents + (Numberofstudents * 10 / 100));
            double nexvariable = Math.Floor(Numberofstudents / 6);

            double result = lightsabers * variable + robes * Numberofstudents + belts * (Numberofstudents - nexvariable);

            if (result <= Money)
            {
                Console.WriteLine("The money is enough - it would cost {0:f2}lv.", result);
            }
            else
            {
                Console.WriteLine("Ivan Cho will need {0:f2}lv more.", result - Money);
            }

        }
    }
}
