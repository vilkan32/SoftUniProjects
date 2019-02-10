using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double output = raisetodouble(number, power);
            Console.WriteLine(output);
        }

        static double raisetodouble(double number, int power)
        {
            return Math.Pow(number, power);

        }
    }
}
