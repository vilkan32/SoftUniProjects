using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinentCountryCity
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> ContinentCountryCity = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (!ContinentCountryCity.ContainsKey(input[0]))
                {
                    ContinentCountryCity.Add(input[0], new Dictionary<string, List<string>>());
                    ContinentCountryCity[input[0]].Add(input[1], new List<string>());
                    ContinentCountryCity[input[0]][input[1]].Add(input[2]);
                }
                else
                {
                    if (!ContinentCountryCity[input[0]].ContainsKey(input[1]))
                    {
                        ContinentCountryCity[input[0]].Add(input[1], new List<string>());
                        ContinentCountryCity[input[0]][input[1]].Add(input[2]);
                    }
                    else
                    {
                        ContinentCountryCity[input[0]][input[1]].Add(input[2]);
                    }
                }

            }

            foreach (var item in ContinentCountryCity)
            {
                Console.WriteLine(item.Key + ":");
                List<string> show = new List<string>();
                foreach (var set1 in item.Value)
                {
                    Console.Write("  {0} -> ", set1.Key);
                  
                        Console.Write(string.Join(", ", set1.Value));
                    
                    Console.WriteLine();
                }
            }
        }
    }
}
