using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> len = new List<int>();
            List<int> prev = new List<int>();
            int MaxLen = 0;
            int LastIndex = -1;

            for (int p = 0; p < Input.Count; p++)
            {
                len.Insert(p, 1);
                prev.Insert(p, -1);
                for (int i = 0; i <= p-1; i++)
                {
                    if (Input[i] < Input[p] && len[i] + 1 > len[p])
                    {
                        len[p] = 1 + len[i];
                        prev[p] = i;
                    }
                    if (len[p] > MaxLen)
                    {
                        MaxLen = len[p];
                        LastIndex = p;
                    }
                }

            }

            List<int> longestsequence = new List<int>();
            while (LastIndex != -1)
            {
                longestsequence.Add(Input[LastIndex]);
                LastIndex = prev[LastIndex];
            }
            if (Input.Count == 1)
            {
                longestsequence.Add(Input[0]);
            }
            longestsequence.Reverse();
            Console.WriteLine(string.Join(" ", longestsequence));


        }
       
    }
}
