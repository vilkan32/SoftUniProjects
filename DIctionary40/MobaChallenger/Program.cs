using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MobaChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            //"{player} -> {position} -> {skill}"
            // "{player} vs {player}"
            Dictionary<string, Dictionary<string, int>> Players = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Season end")
                {
                    break;
                }
                if (input.Contains(" -> "))
                {
                    var splitter = Regex.Split(input, Regex.Escape(" -> ")).ToArray();
                    if (!Players.ContainsKey(splitter[0]))
                    {
                        Players.Add(splitter[0], new Dictionary<string, int>());
                        Players[splitter[0]].Add(splitter[1], int.Parse(splitter[2]));

                    }
                    else
                    {
                        if (Players[splitter[0]].ContainsKey(splitter[1]))
                        {
                            if (Players[splitter[0]][splitter[1]] < int.Parse(splitter[2]))
                            {
                                Players[splitter[0]][splitter[1]] = int.Parse(splitter[2]);
                            }
                        }
                        else
                        {
                            Players[splitter[0]].Add(splitter[1], int.Parse(splitter[2]));
                        }
                    }
                }
                else if (input.Contains(" vs "))
                {
                    var splitter = Regex.Split(input, Regex.Escape(" vs ")).ToArray();

                    if (Players.Keys.Contains(splitter[0]) && Players.Keys.Contains(splitter[1]))
                    {
                        List<int> FirstPlayer = new List<int>();
                        List<int> SecondPlayer = new List<int>();
                        foreach (var item in Players[splitter[0]])
                        {
                            foreach (var set in Players[splitter[1]])
                            {
                                if (item.Key == set.Key)
                                {
                                    FirstPlayer.Add(item.Value);
                                    SecondPlayer.Add(set.Value);
                                }
                            }
                        }
                        if (FirstPlayer.Sum() > SecondPlayer.Sum())
                        {
                            Players.Remove(splitter[1]);
                        }
                        else if (FirstPlayer.Sum() < SecondPlayer.Sum())
                        {
                            Players.Remove(splitter[0]);
                        }
                    }
                }
            }

            foreach (var item in Players.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0}: {1} skill", item.Key, item.Value.Values.Sum());
                foreach (var set in item.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine("- {0} <::> {1}", set.Key, set.Value);
                }
            }
        }
    }
}
