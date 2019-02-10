using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double output = GetArea(width, height);
            Console.WriteLine(output);
        }
        static double GetArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
