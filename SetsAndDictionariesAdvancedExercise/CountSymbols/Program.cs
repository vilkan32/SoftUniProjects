using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            SortedDictionary<char, int> symbolTimes = new SortedDictionary<char, int>();


            foreach (var item in input)
            {
                if (!symbolTimes.ContainsKey(item))
                {
                    symbolTimes.Add(item, 1);
                }
                else
                {
                    symbolTimes[item]++;
                }
            }

            foreach (var item in symbolTimes)
            {
                Console.WriteLine("{0}: {1} time/s", item.Key, item.Value);
            }

        }
    }
}
