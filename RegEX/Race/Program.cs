using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, int> PeopleDistance = new Dictionary<string, int>();
           
                string[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in input)
                {
                    PeopleDistance.Add(item, 0);
                }
            
            

            while (true)
            {
                string inputio = Console.ReadLine();
                if (inputio == "end of race")
                {
                    break;
                }
                var name = Regex.Matches(inputio, @"([A-Za-z])").Cast<Match>().Select(x=>x.Value).ToArray();
                var distance = Regex.Matches(inputio, @"\d").Cast<Match>().Select(x => int.Parse(x.Value)).ToArray();
                string Name = string.Empty;
                foreach (var item in name)
                {
                    Name += item;
                }
                if (PeopleDistance.ContainsKey(Name))
                {
                    PeopleDistance[Name] += distance.Sum();
                }

            }
            int index = 1;
            foreach (var item in PeopleDistance.OrderByDescending(x => x.Value))
            {
                if (index == 1)
                {
                    Console.WriteLine("1st place: {0}",item.Key);
                }
                else if (index == 2)
                {
                    Console.WriteLine("2nd place: {0}", item.Key);
                }
                else if (index == 3)
                {
                    Console.WriteLine("3rd place: {0}", item.Key);
                }
                index++;

            }
        }
    }
}
