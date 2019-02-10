using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            ReturnLastDigit(long.Parse(Console.ReadLine()));
          

        }
        static void ReturnLastDigit(long n)
        {
            long output = n % 10;
            output = Math.Abs(output);

            if (output == 0)
            {
                Console.WriteLine("zero");
            }
            else if (output == 1)
            {
                Console.WriteLine("one");
            }
            else if (output == 2)
            {
                Console.WriteLine("two");
            }
            else if (output == 3)
            {
                Console.WriteLine("three");
            }
            else if (output == 4)
            {
                Console.WriteLine("four");
            }
            else if (output == 5)
            {
                Console.WriteLine("five");
            }
            else if (output == 6)
            {
                Console.WriteLine("six");
            }
            else if (output == 7)
            {
                Console.WriteLine("seven");
            }
            else if (output == 8)
            {
                Console.WriteLine("eight");
            }
            else if (output == 9)
            {
                Console.WriteLine("nine");
            }


        }
    }
}
