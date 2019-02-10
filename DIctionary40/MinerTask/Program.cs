using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> Treasure = new Dictionary<string, long>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                long number = long.Parse(Console.ReadLine());

                if (Treasure.ContainsKey(input))
                {
                    Treasure[input] += number;
                }
                else
                {
                    Treasure.Add(input, number);
                }
            }

            foreach (var item in Treasure)
            {
                Console.WriteLine(item.Key+ " -> "+ item.Value);
            }
        }
    }
}
