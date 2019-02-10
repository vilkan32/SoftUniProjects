using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> SideUsers = new Dictionary<string, List<string>>();
            List<string> ExistingUsers = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Lumpawaroo")
                {
                    break;
                }
                string pattern = @"(.+) -> (.+)"; // forceUser -> forceSide 
                string Pattern = @"(.+) \| (.+)"; // {forceSide} | {forceUser}
                var match = Regex.Match(input, pattern);
                var Match = Regex.Match(input, Pattern);
                if (Match.Success == true)
                {
                    if (!ExistingUsers.Contains(Match.Groups[2].Value))
                    {
                        ExistingUsers.Add(Match.Groups[2].Value);
                        if (SideUsers.ContainsKey(Match.Groups[1].Value))
                        {
                            SideUsers[Match.Groups[1].Value].Add(Match.Groups[2].Value);
                        }
                        else
                        {
                            SideUsers.Add(Match.Groups[1].Value, new List<string>());
                            SideUsers[Match.Groups[1].Value].Add(Match.Groups[2].Value);
                        }
                    }
                }
                else if (match.Success == true)
                {
                    if (ExistingUsers.Contains(match.Groups[1].Value))
                    {
                        string Key = "";
                        int index = -1;
                        bool canbrek = false;
                        foreach (var item in SideUsers)
                        {
                            for (int i = 0; i < item.Value.Count(); i++)
                            {
                                if (item.Value[i] == match.Groups[1].Value)
                                {
                                    index = i;
                                    Key = item.Key;
                                    canbrek = true;
                                    break;
                                }
                                if (canbrek == true)
                                {
                                    break;
                                }
                            }
                        }
                        SideUsers[Key].RemoveAt(index);
                        if (SideUsers.ContainsKey(match.Groups[2].Value))
                        {
                            SideUsers[match.Groups[2].Value].Add(match.Groups[1].Value);
                            Console.WriteLine($"{match.Groups[1].Value} joins the {match.Groups[2].Value} side!");
                        }
                        else
                        {
                            SideUsers.Add(match.Groups[2].Value, new List<string>());
                            SideUsers[match.Groups[2].Value].Add(match.Groups[1].Value);
                            Console.WriteLine($"{match.Groups[1].Value} joins the {match.Groups[2].Value} side!");
                        }
                    }
                    else
                    {
                        if (SideUsers.ContainsKey(match.Groups[2].Value))
                        {
                            SideUsers[match.Groups[2].Value].Add(match.Groups[1].Value);
                            Console.WriteLine($"{match.Groups[1].Value} joins the {match.Groups[2].Value} side!");
                            ExistingUsers.Add(match.Groups[1].Value);
                        }
                        else
                        {
                            SideUsers.Add(match.Groups[2].Value, new List<string>());
                            SideUsers[match.Groups[2].Value].Add(Match.Groups[1].Value);
                            Console.WriteLine($"{match.Groups[1].Value} joins the {match.Groups[2].Value} side!");
                            ExistingUsers.Add(match.Groups[1].Value);
                        }
                    }
                }

            }


            foreach (var item in SideUsers.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key))
            {
                if (item.Value.Count() == 0)
                {
                    continue;
                }
                Console.WriteLine("Side: {0}, Members: {1}", item.Key, item.Value.Count());


                foreach (var set in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine("! " + set);
                }
            }

            ExistingUsers = new List<string>();
        }
    }
}
