using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChoreWar
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> Chores = new Dictionary<string, int>
            {
                {"Doing the dishes", 0 },
                {"Cleaning the house", 0 },
                {"Doing the laundry", 0 }
            };

            while (true)
            {

                string input = Console.ReadLine();
                if (input == "wife is happy")
                {
                    break;
                }

                var doingDishes = Regex.Match(input, @"<([a-z0-9]*)>");

                if (doingDishes.Success)
                {
                    var numbers = Regex.Matches(doingDishes.Groups[1].Value, @"[0-9]").Cast<Match>().Select(x => int.Parse(x.Value)).ToArray();

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Chores["Doing the dishes"] += numbers[i];
                    }
                    continue;
                }

                var cleaningHouse = Regex.Match(input, @"\[([A-Z0-9]*)\]");

                if (cleaningHouse.Success)
                {
                    var numbers = Regex.Matches(cleaningHouse.Groups[1].Value, @"[0-9]").Cast<Match>().Select(x => int.Parse(x.Value)).ToArray();

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Chores["Cleaning the house"] += numbers[i];
                    }
                    continue;
                }

                var doingLaundry = Regex.Match(input, @"\{(.*)\}");

                if (doingLaundry.Success)
                {
                    var numbers = Regex.Matches(doingLaundry.Groups[1].Value, @"[0-9]").Cast<Match>().Select(x => int.Parse(x.Value)).ToArray();

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Chores["Doing the laundry"] += numbers[i];
                    }
                    continue;

                }

            }
            var total = 0;
            foreach (var item in Chores)
            {
                Console.WriteLine(item.Key + " - " + item.Value + " min.");
                total += item.Value;
            }
            Console.WriteLine($"Total - {total} min.");
        }
    }
}
