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
            double far = double.Parse(Console.ReadLine());

            var output = Celsium(far);

            Console.WriteLine("{0:F2}", output);
        }
        static double Celsium(double far)
        {
            return (far - 32) * 5 / 9;
        }
    }
}
