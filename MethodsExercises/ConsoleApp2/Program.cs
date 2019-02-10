using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            long number = long.Parse(Console.ReadLine());
            

            Console.WriteLine(numbers[ReturnLastDigit(number)]);
             
        }

        static long ReturnLastDigit(long n)
        {
            long output = n % 10;
            return Math.Abs(output);
        }
    }
}
