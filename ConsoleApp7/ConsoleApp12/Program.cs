using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] commands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> Output = new List<int>();
            int numstoget = commands[0];
            int counter = 0;
            for (int i = 0; i < numstoget; i++)
            {
                Output.Add(Input[i]);
            }
            for (int c = 0; c < commands[1]; c++)
            {
                Output.RemoveAt(0);
            }
            foreach (var item in Output)
            {
                if (item == commands[2])
                {
                    counter++;
                }

            }
            if (counter> 0 )
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
