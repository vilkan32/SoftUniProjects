using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();
            for (int i = 0; i < input[0]; i++)
            {
                int n = int.Parse(Console.ReadLine());
                first.Add(n);
            }

            for (int i = 0; i < input[1]; i++)
            {
                int n = int.Parse(Console.ReadLine());
                second.Add(n);
            }

            HashSet<int> third = new HashSet<int>();
            foreach (var item in first)
            {
                if (second.Contains(item))
                {
                    third.Add(item);
                }
            }
            
            Console.WriteLine(string.Join(" ", third));
        }
    }
}
