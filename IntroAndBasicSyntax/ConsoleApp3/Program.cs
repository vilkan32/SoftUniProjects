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

            long a = long.Parse(Console.ReadLine());

            if (a >= 0 && a <= 2)
            {
                Console.WriteLine("baby");
            }
            else if (a >= 3 && a <= 13)
            {
                Console.WriteLine("child");
            }
            else if (a >= 14 && a <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (a >= 20 && a <= 65)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("elder");
            }

        }
    }
}
