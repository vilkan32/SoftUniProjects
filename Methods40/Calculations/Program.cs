using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {

            ReturnRequiredComandAction(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }

        static void ReturnRequiredComandAction(string input, int a, int b)
        {
            if (input == "add")
            {
                Console.WriteLine(a+b);
            }
            else if (input == "substract")
            {
                Console.WriteLine(a-b);
            }
            else if (input == "multiply")
            {
                Console.WriteLine(a*b);
            }
            else if (input == "divide")
            {
                Console.WriteLine(a/b);
            }

        }

    }
}
