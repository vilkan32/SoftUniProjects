using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wardroble
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> ColorClothCount = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");

                string[] clothes = input[1].Split(',');

                if (!ColorClothCount.ContainsKey(input[0]))
                {
                    ColorClothCount.Add(input[0], new Dictionary<string, int>());
                    foreach (var item in clothes)
                    {
                        if (!ColorClothCount[input[0]].ContainsKey(item))
                        {
                            ColorClothCount[input[0]].Add(item, 1);
                        }
                        else
                        {
                            ColorClothCount[input[0]][item]++;
                        }
                    }
                }
                else
                {
                    foreach (var item in clothes)
                    {
                        if (!ColorClothCount[input[0]].ContainsKey(item))
                        {
                            ColorClothCount[input[0]].Add(item, 1);
                        }
                        else
                        {
                            ColorClothCount[input[0]][item]++;
                        }
                    }
                }
            }

            string[] command = Console.ReadLine().Split(" ");
            foreach (var item in ColorClothCount)
            {
                Console.WriteLine(item.Key + " clothes:");

                foreach (var set in item.Value)
                {
                    if (command[0] == item.Key && command[1] == set.Key)
                    {
                        Console.WriteLine("* {0} - {1} (found!)", set.Key, set.Value);
                    }
                    else
                    {
                        Console.WriteLine("* {0} - {1}", set.Key, set.Value);
                    }
                }
            }

        }
    }
}
