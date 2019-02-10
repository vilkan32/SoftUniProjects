using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MayTheForce
{
    class Program
    {


        static void Main(string[] args)
        {
            Dictionary<string, string> Players = new Dictionary<string, string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Lumpawaroo")
                {

                    break;
                }
                string pattern = @"(.*) \| (.*)"; // {forceSide} | {forceUser}
                string pattern1 = @"(.*) -> (.*)"; // {forceUser} -> {forceSide}

                var FirstChance = Regex.Match(input, pattern); // {forceSide} | {forceUser}
                bool cango = false;
                if (FirstChance.Success == false) // {forceUser} -> {forceSide}
                {
                    FirstChance = Regex.Match(input, pattern1);
                    cango = true;
                }
                if (cango == false)
                {
                    if (!Players.ContainsKey(FirstChance.Groups[2].Value))
                    {
                        Players.Add(FirstChance.Groups[2].Value, FirstChance.Groups[1].Value);
                    }
                }
                else if (cango == true)
                {
                    if (Players.ContainsKey(FirstChance.Groups[1].Value))
                    {
                        Players[FirstChance.Groups[1].Value] = FirstChance.Groups[2].Value;
                        Console.WriteLine($"{FirstChance.Groups[1].Value} joins the {FirstChance.Groups[2].Value} side!");
                    }
                    else
                    {
                        Players.Add(FirstChance.Groups[1].Value, FirstChance.Groups[2].Value);
                        Console.WriteLine($"{FirstChance.Groups[1].Value} joins the {FirstChance.Groups[2].Value} side!");
                    }
                }
            }
            Dictionary<string, List<string>> Output = new Dictionary<string, List<string>>();

            foreach (var item in Players)
            {
                if (Output.ContainsKey(item.Value))
                {
                    Output[item.Value].Add(item.Key);
                }
                else
                {
                    Output.Add(item.Value, new List<string>());
                    Output[item.Value].Add(item.Key);
                }
            }
            foreach (var item in Output.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key))
            {
                Console.WriteLine("Side: {0}, Members: {1}", item.Key, item.Value.Count());
                foreach (var set in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine("! {0}", set);
                }
            }

        }
    }

}
