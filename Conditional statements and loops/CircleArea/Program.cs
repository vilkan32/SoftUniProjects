using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {

            double r = double.Parse(Console.ReadLine());

            decimal output = 0;
            for (int i = 0; i < r; i++)
            {
                decimal read = decimal.Parse(Console.ReadLine());
                output += read;

            }

            Console.WriteLine(output);
        }
    }
}
