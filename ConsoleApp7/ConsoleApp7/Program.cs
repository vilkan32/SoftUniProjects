using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var outputlist = new List<int>();
            var result = new List<int>();


           
                foreach (var number in list)
                {
                    if (number >= 0)
                    {
                    outputlist.Add(number);
                    }

                }

            outputlist.Reverse();

            if (outputlist.Count != 0)
            {
                Console.WriteLine(string.Join(" ", outputlist));
            }
            else
            {
                Console.WriteLine("empty");
            }
           




        }
    }
}
