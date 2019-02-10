using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Input = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x => x).ToArray();
            int counter = 0;
            for (int i = 0; i < Input.Count(); i++)
            {
                if (counter == 3)
                {
                    break;
                }
                Console.Write(Input[i] + " ");
                counter++;
            }
            Console.WriteLine();
        }
    }
}
