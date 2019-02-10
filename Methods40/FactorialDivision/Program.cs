using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double firstFactorial = multiplyNumbers(a);
            double secondFactorial = multiplyNumbers(b);

            double result = firstFactorial / secondFactorial;
            Console.WriteLine("{0:f2}", result);
        }
        public static double multiplyNumbers(int n)
        {
            if (n >= 1)
                return n * multiplyNumbers(n - 1);
            else
                return 1;
        }
    }
}
