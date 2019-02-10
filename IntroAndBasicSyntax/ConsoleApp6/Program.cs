using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> Numbers = new List<long>();

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

          
            while (true)
            {
              
                Numbers.Add(start);
                if (start == end)
                {
                    break;
                }
                start++;
            }
            Console.WriteLine(string.Join(" ", Numbers));
            Console.WriteLine("Sum: {0}", Numbers.Sum());
        }
    }
}
