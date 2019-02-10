using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> Judge = new Dictionary<string, Dictionary<string, int>>();
           
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "no more time")
                {
                    break;
                }
                var splitter = Regex.Split(input, Regex.Escape(" -> ")).ToArray();
                string[] split = input.Split(" -> ").ToArray();
                // {username} -> {contest} -> {points}
                if (Judge.ContainsKey(splitter[1]))
                {
                    if (Judge[splitter[1]].ContainsKey(splitter[0]))
                    {
                        if (Judge[splitter[1]][splitter[0]] < int.Parse(splitter[2]))
                        {
                            Judge[splitter[1]][splitter[0]] = int.Parse(splitter[2]);
                        }
                    }
                    else
                    {
                        Judge[splitter[1]].Add(splitter[0], int.Parse(splitter[2]));
                    }
                }
                else
                {
                    Judge.Add(splitter[1], new Dictionary<string, int>());
                    Judge[splitter[1]].Add(splitter[0], int.Parse(splitter[2]));
                }

            }

            Dictionary<string, int> Statistics = new Dictionary<string, int>();

            foreach (var item in Judge.Values)
            {
                foreach (var set in item)
                {
                    if (Statistics.ContainsKey(set.Key))
                    {
                        Statistics[set.Key] += set.Value;
                    }
                    else
                    {
                        Statistics.Add(set.Key, set.Value);
                    }
                }
            }

            foreach (var item in Judge)
            {
                Console.WriteLine("{0}: {1} participants", item.Key, item.Value.Count());
                int counterche = 1;
                foreach (var set in item.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine("{2}. {0} <::> {1}", set.Key, set.Value, counterche);
                    counterche++;
                }
            }
            Console.WriteLine("Individual standings:");
            int counter = 1;
            foreach (var item in Statistics.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0}. {1} -> {2}", counter, item.Key,item.Value);
                counter++;
            }
        }
    }
}
