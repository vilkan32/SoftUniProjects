using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> Input = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 != 0)
                {

                }
                else
                {
                    Input.Add(input[i]);
                }
            }

            int average = Input.Sum();
            int countofthenumbers = Input.Count();
            List<int> Output = new List<int>();

            foreach (var item in Input)
            {
                if (item > average / countofthenumbers)
                {
                    Output.Add(item + 1);
                }
                else
                {
                    Output.Add(item - 1);
                }

            }

            Console.WriteLine(string.Join(" ", Output));


        }
    }
}
