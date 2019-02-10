using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {

            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long a = long.Parse(Console.ReadLine());
            
            long index = 0;
            long sum = 0;
            long broipreminavaniq = 0;
            for (long i = 0; i < arr.Length; i++)
            {

                if (arr[i] == a)
                {
                    index = i;
                    broipreminavaniq++;
                }

            }

            for (long c = 0; c < index; c++)
            {
                sum += arr[c];
            }

            if (broipreminavaniq > 0)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
           
        }
    }
}
