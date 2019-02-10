using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace SnowWhite1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> Dwarfs = new Dictionary<string, Dictionary<string, int>>();
            // {dwarfName} <:> {dwarfHatColor} <:> {dwarfPhysics}

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Once upon a time")
                {
                    break;
                }

                var split = Regex.Split(input, Regex.Escape(" <:> "));
                if (Dwarfs.ContainsKey(split[1]))
                {
                    if (!Dwarfs[split[1]].ContainsKey(split[0]))
                    {
                        Dwarfs[split[1]].Add(split[0], int.Parse(split[2]));
                    }
                    else
                    {
                        if (Dwarfs[split[1]][split[0]] < int.Parse(split[2]))
                        {
                            Dwarfs[split[1]][split[0]] = int.Parse(split[2]);
                        }
                    }
                }
                else
                {
                    Dwarfs.Add(split[1], new Dictionary<string, int>());
                    Dwarfs[split[1]].Add(split[0], int.Parse(split[2]));
                }
            }
            
                List<Dwarvish> Dwarr = new List<Dwarvish>();
            foreach (var item in Dwarfs)
            {
                
                foreach (var set in item.Value)
                {
                    Dwarvish local = new Dwarvish();
                    local.Hat = item.Key;
                    local.Power = set.Value;
                    local.Name = set.Key;
                    local.Count = item.Value.Count();
                    Dwarr.Add(local);
                }
            }

            foreach (var item in Dwarr.OrderByDescending(x => x.Power).ThenByDescending(x => x.Count))
            {
                Console.WriteLine("({0}) {1} <-> {2}", item.Hat, item.Name, item.Power);
            }
        }
    }
    class Dwarvish
    {
        public string Name { get; set; }
        public string Hat { get; set; }
        public int Power { get; set; }
        public int Count { get; set; }
    }
    
}
