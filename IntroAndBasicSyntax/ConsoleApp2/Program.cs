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
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int i = 1;
            int counter = 0;
            while (true)
            {
                Console.WriteLine(i);
                sum += i;
                i += 2;
                counter++;
                if (counter == number)
                {
                    break;
                }
            }

            Console.WriteLine("Sum: {0}",sum);
        }
    }
}
