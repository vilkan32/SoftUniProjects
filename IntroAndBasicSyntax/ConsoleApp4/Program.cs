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
            long a = long.Parse(Console.ReadLine());
            string result = "";
            if (a % 2== 0)
            {
                result = "The number is divisible by 2";
            }
            if (a % 3 == 0)
            {
                result = "The number is divisible by 3";
            }
            if (a % 6 == 0)
            {
                result = "The number is divisible by 6";
            }
            if (a % 7 == 0)
            {
                result = "The number is divisible by 7";
            }
            if (a % 10 == 0)
            {
                result = "The number is divisible by 10";
            }

            if (result == "")
            {
                result = "Not divisible";
            }

            Console.WriteLine(result);
        }
    }
}
