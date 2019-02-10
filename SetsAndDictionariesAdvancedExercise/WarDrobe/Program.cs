using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarDrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> ColorClothCount = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

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

        }
    }
}
