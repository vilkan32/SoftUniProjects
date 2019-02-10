using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<int> FirstList = new List<int>();
            List<int> SecondList = new List<int>(); 
            for (int i = 0; i < n; i++)
            {

                List<int> Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                if (i % 2 != 0)
                {
                    FirstList.Add(Input[1]);
                    SecondList.Add(Input[0]);
                }
                else
                {
                    FirstList.Add(Input[0]);
                    SecondList.Add(Input[1]);
                }
            }

            Console.WriteLine(string.Join(" ", FirstList));
            Console.WriteLine(string.Join(" ", SecondList));

        }
    }
}
