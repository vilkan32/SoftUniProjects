using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {

            double width = double.Parse(Console.ReadLine());

            double height = double.Parse(Console.ReadLine());

            

            double output = Math.Round((width * height)/ 1000000, 1);

            Console.WriteLine("{0}x{1} => {2}MP", width, height, output);




        }
    }
}
