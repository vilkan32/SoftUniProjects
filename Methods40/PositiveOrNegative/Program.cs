using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveOrNegative
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(ReturnResult(input));
        }

        static string ReturnResult(int n)
        {
            string result = "";
            if (n == 0)
            {
                result = $"The number {n} is zero.";
            }
            else if (n < 0)
            {
                result = $"The number {n} is negative.";
            } 
            else
            {
                result = $"The number {n} is positive.";
            }

            return result;
        }
    }
}
