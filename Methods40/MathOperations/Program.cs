using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            char mathoperation = char.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double result = 0;

            if (mathoperation == '/')
            {
                result = a / b;
            }
            else if (mathoperation == '*')
            {
                result = a * b;
            }
            else if (mathoperation == '+')
            {
                result = a + b;
            }
            else if (mathoperation == '-')
            {
                result = a - b;
            }

            Console.WriteLine(result);
        }
       
    }
}
