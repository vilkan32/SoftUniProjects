using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSameValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> occurances = new Dictionary<double, int>();

            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            
            foreach (var item in input)
            {
                if (!occurances.ContainsKey(item))
                {
                    occurances.Add(item, 1);
                }
                else
                {
                    occurances[item]++;
                }
            }

            foreach (var item in occurances)
            {
                Console.WriteLine(item.Key + " - " + item.Value + " times");
            }
        }
    }
}
